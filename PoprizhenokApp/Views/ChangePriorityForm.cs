using PoprizhenokApp.Models;
using PoprizhenokApp.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoprizhenokApp.Views
{
    public partial class ChangePriorityForm : Form
    {
        public ChangePriorityForm()
        {
            InitializeComponent();

            priorityNumericUpDown.Maximum = Int32.MaxValue;
        }

        private void ChangePriorityForm_Load(object sender, EventArgs e)
        {
            int maxPriorityValue = 0;

            foreach (var agent in MainForm.selectedAgents)
            {
                if (int.Parse(agent.priorityValueLbl.Text) > maxPriorityValue)
                {
                    maxPriorityValue = int.Parse(agent.priorityValueLbl.Text);
                }
            }
            priorityNumericUpDown.Value = maxPriorityValue;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            foreach (var card in MainForm.selectedAgents)
            {
                Agent agent = (DBContext.Context.Agent
                    .First(x => x.ID.ToString() == card.agentIdLbl.Text)) as Agent;

                agent.Priority = int.Parse(priorityNumericUpDown.Value.ToString());
            }

            try
            {
                DBContext.Context.SaveChanges();
                MessageBox.Show("Данные успешно сохранены.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка\n" + ex.Message);
                return;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
