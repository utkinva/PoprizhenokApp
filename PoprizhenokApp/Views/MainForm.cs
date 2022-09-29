using PoprizhenokApp.Models;
using PoprizhenokApp.Utilities;
using PoprizhenokApp.Views;
using PoprizhenokApp.Views.PartialView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PoprizhenokApp
{
    public partial class MainForm : Form
    {
        List<Agent> agents = DBContext.Context.Agent.ToList();
        List<AgentType> agentTypes = DBContext.Context.AgentType.ToList();
        public static List<AgentCard> selectedAgents = new List<AgentCard>();
        int nPage = 0;
        int nPageMax = 0;
        public MainForm()
        {
            InitializeComponent();

            ApplyFilters();

            agentTypes.Insert(0, new AgentType { Title = "Все типы" });
            filterComboBox.DataSource = agentTypes;

            sortComboBox.SelectedIndex = 0;
            filterComboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// Генерация списка карточек агентов
        /// </summary>
        /// <param name="agents">Список агентов из таблицы</param>
        /// <param name="page">Номер текущей страницы</param>
        /// <param name="pageSize">Количество элементов на одной странице</param>
        private void GenerateAgentCardList(List<Agent> agents, int page, int pageSize)
        {
            nPageMax = ((int)agents.Count / 10) < 1 ? 1 : ((int)agents.Count / 10);
            agents = agents.Skip(page * pageSize).Take(pageSize).ToList();
            pagesCountLbl.Text = $"{nPage + 1} из {nPageMax}";

            agentsLayoutPanel.Controls.Clear();
            foreach (var agent in agents)
            {
                AgentCard card = new AgentCard();

                card.GenerateAgentData(agent);
                agentsLayoutPanel.Controls.Add(card);

                card.Click += Card_Click;
                card.DoubleClick += Card_DoubleClick;
            }
        }
        #region События кнопок перемещения между страницами списка агентов

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            if (nPage + 1 < nPageMax)
            {
                nPage++;
                ApplyFilters();
            }
        }

        private void prevPageBtn_Click(object sender, EventArgs e)
        {
            if (nPage > 0)
            {
                nPage--;
                ApplyFilters();
            }
        }
        #endregion

        #region События нажатий на карточку агента
        private void Card_DoubleClick(object sender, EventArgs e)
        {
            AgentCard card = sender as AgentCard;

            AddEditAgentForm edit = new AddEditAgentForm(DBContext.Context.Agent.First(x => x.ID.ToString() == card.agentIdLbl.Text));
            DialogResult dr = edit.ShowDialog();
            if (dr == DialogResult.OK || dr == DialogResult.Cancel)
            {
                nPage = 0;
                ApplyFilters();
                selectedAgents.Clear();
                card.BackColor = Color.White;
            }
        }

        private void Card_Click(object sender, EventArgs e)
        {
            AgentCard card = sender as AgentCard;

            if (card.BackColor == Color.White)
            {
                card.BackColor = Color.FromArgb(249, 150, 158);
                selectedAgents.Add(card);
            }
            else
            {
                card.BackColor = Color.White;
                selectedAgents.Remove(card);
            }

        }
        #endregion

        #region События нажатий кнопок на форме
        private void addAgentBtn_Click(object sender, EventArgs e)
        {
            AddEditAgentForm add = new AddEditAgentForm(null);
            DialogResult dr = add.ShowDialog();
            if (dr == DialogResult.OK)
            {
                nPage = 0;
                ApplyFilters();
                selectedAgents.Clear();
            }
        }
        private void changePriorityBtn_Click(object sender, EventArgs e)
        {
            if (selectedAgents.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы одного агента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            ChangePriorityForm changePriority = new ChangePriorityForm();
            DialogResult dr = changePriority.ShowDialog();
            if (dr == DialogResult.OK)
            {
                nPage = 0;
                selectedAgents.Clear();
                ApplyFilters();
            }
        }
        #endregion

        #region Метод поиска, сортировки и фильтрации
        private void ApplyFilters()
        {
            List<Agent> updatedList = DBContext.Context.Agent.ToList();
            #region Поиск
            if (searchTxtBox.Text != "Введите для поиска"
                && !String.IsNullOrWhiteSpace(searchTxtBox.Text))
                updatedList = updatedList
                    .Where(x => x.Title.ToLower().Contains(searchTxtBox.Text.ToLower())
                    || x.Email.ToLower().Contains(searchTxtBox.Text.ToLower())
                    || x.Phone.Contains(searchTxtBox.Text))
                    .ToList();
            #endregion
            #region Сортировка
            if (sortComboBox.SelectedIndex > 0)
                switch (sortComboBox.SelectedIndex)
                {
                    case 1:
                        if (!ascDescCheck.Checked)
                            updatedList = updatedList
                                .OrderBy(x => x.Title)
                                .ToList();
                        else
                            updatedList = updatedList
                                .OrderByDescending(x => x.Title)
                                .ToList();
                        break;
                    case 2:
                        if (!ascDescCheck.Checked)
                            updatedList = updatedList
                                .OrderBy(x => x.Discount)
                                .ToList();
                        else
                            updatedList = updatedList
                                .OrderByDescending(x => x.Discount)
                                .ToList();
                        break;
                    case 3:
                        if (!ascDescCheck.Checked)
                            updatedList = updatedList
                                .OrderBy(x => x.Priority)
                                .ToList();
                        else
                            updatedList = updatedList
                                .OrderByDescending(x => x.Priority)
                                .ToList();
                        break;
                }
            #endregion
            #region Фильтрация
            if (filterComboBox.SelectedIndex > 0)
                updatedList = updatedList
                    .Where(x => x.AgentType.ID == (filterComboBox.SelectedItem as AgentType).ID)
                    .ToList();
            #endregion
            agentsLayoutPanel.Controls.Clear();
            GenerateAgentCardList(updatedList, nPage, 10);
        }
        /// <summary>
        /// Метод для вызова метода поискаб сортировки и фильтрации
        /// </summary>
        private void TriggerFilters(object sender, EventArgs e)
        {
            nPage = 0;
            ApplyFilters();
        }

        #endregion

        private void searchTxtBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(searchTxtBox.Text))
            {
                searchTxtBox.Text = "Введите для поиска";
                searchTxtBox.ForeColor = Color.Gray;
            }
        }
        private void searchTxtBox_Enter(object sender, EventArgs e)
        {
            if (searchTxtBox.Text == "Введите для поиска")
            {
                searchTxtBox.Text = null;
                searchTxtBox.ForeColor = Color.Black;
            }
        }
    }
}
