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

namespace PoprizhenokApp
{
    public partial class MainForm : Form
    {
        List<Agent> agents = DBContext.Context.Agent.ToList();
        List<AgentType> agentTypes = DBContext.Context.AgentType.ToList();
        public static List<AgentCard> selectedAgents = new List<AgentCard>();

        public MainForm()
        {
            InitializeComponent();

            GenerateAgentCardList(agents);

            agentTypes.Insert(0, new AgentType { Title = "Все типы" });
            filterComboBox.DataSource = agentTypes;

            sortComboBox.SelectedIndex = 0;
            filterComboBox.SelectedIndex = 0;
        }
        /// <summary>
        /// Генерация списка карточек агентов
        /// </summary>
        /// <param name="agents">Список агентов из таблицы</param>
        private void GenerateAgentCardList(List<Agent> agents)
        {
            foreach (var agent in agents)
            {
                AgentCard card = new AgentCard();

                card.GenerateAgentData(agent);
                agentsLayoutPanel.Controls.Add(card);

                card.Click += Card_Click;
                card.DoubleClick += Card_DoubleClick;
            }
        }

        #region События нажатий на карточку агента
        private void Card_DoubleClick(object sender, EventArgs e)
        {
            AgentCard card = sender as AgentCard;

            AddEditAgentForm edit = new AddEditAgentForm(DBContext.Context.Agent.First(x => x.ID.ToString() == card.agentIdLbl.Text));
            DialogResult dr = edit.ShowDialog();
            if (dr == DialogResult.OK
                || dr == DialogResult.Cancel)
            {
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

            changePriorityBtn.Visible = selectedAgents.Count >= 1 ? true : false;
        }
        #endregion

        #region События нажатий кнопок на форме
        private void addAgentBtn_Click(object sender, EventArgs e)
        {
            AddEditAgentForm add = new AddEditAgentForm(null);
            DialogResult dr = add.ShowDialog();
            if (dr == DialogResult.OK)
            {
                ApplyFilters();
                selectedAgents.Clear();
            }

        }
        private void changePriorityBtn_Click(object sender, EventArgs e)
        {
            ChangePriorityForm changePriority = new ChangePriorityForm();
            DialogResult dr = changePriority.ShowDialog();
            if (dr == DialogResult.OK)
            {
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
            GenerateAgentCardList(updatedList);
        }
        /// <summary>
        /// Метод для вызова метода поискаб сортировки и фильтрации
        /// </summary>
        private void TriggerFilters(object sender, EventArgs e) => ApplyFilters();
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
                searchTxtBox.Text = String.Empty;
                searchTxtBox.ForeColor = Color.Black;
            }
        }
    }
}
