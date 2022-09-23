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
    public partial class AddEditAgentForm : Form
    {
        Agent agent { get; set; } = null;

        public AddEditAgentForm(Agent current)
        {
            InitializeComponent();

            if (current != null)
            {
                agent = current;
            }
            else
            {
                agent = new Agent()
                {
                    Logo = @"..\..\Resources\picture.png"
                };
            }

            priorityNumericUpDown.Maximum = Int32.MaxValue;

            agentTypeBindingSource.DataSource = DBContext.Context.AgentType.ToList();
        }

        private void AddEditAgentForm_Load(object sender, EventArgs e)
        {

            if (agent != null)
            {
                if (agent.Logo == null)
                {
                    logoPictureBox.ImageLocation = @"..\..\Resources\picture.png";
                }
                else
                {
                    logoPictureBox.ImageLocation = agent.Logo;
                }
                agentBindingSource.Add(agent);
                productBindingSource.DataSource = DBContext.Context.Product.ToList();

                GetSalesHistory();
            }
            else
            {
                agentBindingSource.AddNew();
            }




        }

        private void GetSalesHistory()
        {
            var sales = DBContext.Context.ProductSale.ToList();

            sales = sales
                .Where(x => x.AgentID == agent.ID)
                .ToList();

            productSaleBindingSource.DataSource = sales;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (String.IsNullOrWhiteSpace(titleTextBox.Text))
                errors.AppendLine("Наименование");
            if (String.IsNullOrWhiteSpace(iNNTextBox.Text))
                errors.AppendLine("ИНН");
            if (String.IsNullOrWhiteSpace(kPPTextBox.Text))
                errors.AppendLine("КПП");
            if (String.IsNullOrWhiteSpace(emailTextBox.Text)
                || !emailTextBox.Text.Contains("@"))
                errors.AppendLine("Email");
            if (phoneMaskedTextBox.Text.Length != 16)
                errors.AppendLine("Номер телефона");
            if (String.IsNullOrWhiteSpace(directorNameTextBox.Text))
                errors.AppendLine("ФИО Директора");
            if (priorityNumericUpDown.Value <= 0)
                errors.AppendLine("Приоритет не должен быть меньше или равным нулю");
            if (agentTypeIDComboBox.SelectedItem == null)
                errors.AppendLine("Тип агента");



            if (errors.Length > 0)
            {
                MessageBox.Show($"Необходимо заполнить следующие поля корректными данными:\n{errors}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (agent.ID == 0)
            {
                DBContext.Context.Agent.Add(agent);
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

        /// <summary>
        /// Change agent logo image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changeLogoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "";
            dialog.InitialDirectory = Environment.CurrentDirectory;
            dialog.InitialDirectory += @"\agents\";

            DialogResult dr = dialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string file = dialog.FileName;
                int num = file.IndexOf("agents");
                file = file.Substring(num);

                logoPictureBox.Image = Image.FromFile(file);
                ((Agent)agentBindingSource.Current).Logo = file;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (salesHistoryDGV.RowCount != 0)
            {
                MessageBox.Show("Агент не может быть удален, потому что у него имеется история продаж",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("Удалить текущего агента?", 
                "Удаление", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);

            if(dr == DialogResult.Yes)
                try
                {
                    DBContext.Context.Agent.Remove(agent);
                    DBContext.Context.SaveChanges();

                    MessageBox.Show("Агент удален.", 
                        "Успешно", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка\n" + ex.Message);
                    return;
                }
        }

        private void deleteSaleBtn_Click(object sender, EventArgs e)
        {
            ProductSale itemToDelete = (ProductSale)productSaleBindingSource.Current;

            DialogResult dr = MessageBox.Show("Удалить выбранную запись?",
                                            "Удаление",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
                try
                {
                    DBContext.Context.ProductSale.Remove(itemToDelete);
                    DBContext.Context.SaveChanges();

                    MessageBox.Show("Запись удалена.",
                                    "Успешно",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    GetSalesHistory();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка\n" + ex.Message);
                    return;
                }
        }

        private void addSaleBtn_Click(object sender, EventArgs e)
        {
            AddNewSaleForm newSale = new AddNewSaleForm(agent);
            DialogResult dr = newSale.ShowDialog();
            if (dr == DialogResult.OK)
                GetSalesHistory();
        }
    }
}
