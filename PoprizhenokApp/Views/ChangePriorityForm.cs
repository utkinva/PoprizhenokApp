using PoprizhenokApp.Models;
using PoprizhenokApp.Utilities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PoprizhenokApp.Views
{
    public partial class ChangePriorityForm : Form
    {
        public ChangePriorityForm()
        {
            InitializeComponent();
        }

        private void ChangePriorityForm_Load(object sender, EventArgs e)
        {
            priorityNumericUpDown.Maximum = Int32.MaxValue;
            priorityNumericUpDown.Value = GetMaximumPriority();
        }
        /// <summary>
        /// Метод для вычисления максимального значения приоритета среди выбранных карточек агентов
        /// </summary>
        /// <returns></returns>
        private int GetMaximumPriority()
        {
            int maxPriorityValue = 0;

            foreach (var agent in MainForm.selectedAgents)
                maxPriorityValue = int.Parse(agent.priorityValueLbl.Text) > maxPriorityValue ? int.Parse(agent.priorityValueLbl.Text) : maxPriorityValue;

            return maxPriorityValue;
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
                MessageBox.Show("Данные успешно сохранены.", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
