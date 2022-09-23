using PoprizhenokApp.Models;
using PoprizhenokApp.Utilities;
using PoprizhenokApp.Views;
using PoprizhenokApp.Views.PartialView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoprizhenokApp
{
    public partial class MainForm : Form
    {
        List<Agent> agents = new List<Agent>();
        public static List<AgentCard> selectedAgents = new List<AgentCard>();

        public MainForm()
        {
            InitializeComponent();

            agents = DBContext.Context.Agent.ToList();

            GenerateAgentCardList(agents);

            List<AgentType> agentTypes = new List<AgentType>();
            agentTypes = DBContext.Context.AgentType.ToList();
            agentTypes.Insert(0, new AgentType { Title = "Все типы" });
            filterComboBox.DataSource = agentTypes;

            sortComboBox.SelectedIndex = 0;
            filterComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Generating agent cards list
        /// </summary>
        /// <param name="agents"></param>
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

        private void Card_DoubleClick(object sender, EventArgs e)
        {
            AgentCard card = sender as AgentCard;

            AddEditAgentForm edit = new AddEditAgentForm(DBContext.Context.Agent.First(x => x.ID.ToString() == card.agentIdLbl.Text));
            DialogResult dr = edit.ShowDialog();
            if (dr == DialogResult.OK || dr == DialogResult.Cancel)
            {
                ApplyFilters();
                selectedAgents.Clear();
                card.BackColor = Color.White;
            }
            

        }

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

            if (selectedAgents.Count > 1)
                addAgentBtn.Visible = false;
            else
                addAgentBtn.Visible = true;

            if (selectedAgents.Count >= 2)
                changePriorityBtn.Visible = true;
            else
                changePriorityBtn.Visible = false;
        }

        #region Sort, filter n search logic
        private void ApplyFilters()
        {
            var updatedList = DBContext.Context.Agent.ToList();

            if (searchTxtBox.Text != "Введите для поиска"
                && !String.IsNullOrWhiteSpace(searchTxtBox.Text))
                updatedList = updatedList
                    .Where(x => x.Title.ToLower().Contains(searchTxtBox.Text.ToLower())
                    || x.Email.ToLower().Contains(searchTxtBox.Text.ToLower())
                    || x.Phone.Contains(searchTxtBox.Text))
                    .ToList();

            if(sortComboBox.SelectedIndex > 0)
                switch (sortComboBox.SelectedIndex)
                {
                    case 1:
                        if (!ascDescCheck.Checked)
                            updatedList = updatedList.OrderBy(x => x.Title).ToList();
                        else
                            updatedList = updatedList.OrderByDescending(x => x.Title).ToList();
                        break;
                    case 2:
                        if (!ascDescCheck.Checked)
                            updatedList = updatedList.OrderBy(x => x.Discount).ToList();
                        else
                            updatedList = updatedList.OrderByDescending(x => x.Discount).ToList();
                        break;
                    case 3:
                        if (!ascDescCheck.Checked)
                            updatedList = updatedList.OrderBy(x => x.Priority).ToList();
                        else
                            updatedList = updatedList.OrderByDescending(x => x.Priority).ToList();
                        break;
                }

            if (filterComboBox.SelectedIndex > 0)
                updatedList = updatedList
                    .Where(x => x.AgentType.ID == filterComboBox.SelectedIndex)
                    .ToList();

            agentsLayoutPanel.Controls.Clear();
            GenerateAgentCardList(updatedList);
        }

        private void searchTxtBox_Leave(object sender, EventArgs e)
        {
            if (searchTxtBox.Text != "Введите для поиска"
                && String.IsNullOrWhiteSpace(searchTxtBox.Text))
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

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            if(searchTxtBox.Text != "Введите для поиска"
                && !String.IsNullOrWhiteSpace(searchTxtBox.Text))
                ApplyFilters();

        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void ascDescCheck_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        #endregion

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
    }
}
