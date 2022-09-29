using PoprizhenokApp.Models;
using PoprizhenokApp.Properties;
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

            agent = current ?? null;

            if (current == null)
            {
                agent = new Agent()
                {
                    Logo = @"..\..\Resources\picture.png"
                };
                addSaleBtn.Enabled = false;
                deleteSaleBtn.Enabled = false;
            }

            priorityNumericUpDown.Maximum = Int32.MaxValue;
            agentTypeBindingSource.DataSource = DBContext.Context.AgentType.ToList();
        }

        private void AddEditAgentForm_Load(object sender, EventArgs e)
        {
            if (agent != null)
            {
                if (agent.Logo != String.Empty)
                    logoPictureBox.ImageLocation = agent.Logo;
                else
                    logoPictureBox.ImageLocation = @"..\..\Resources\picture.png";

                agentBindingSource.Add(agent);

                productBindingSource.DataSource = DBContext.Context.Product.ToList();
                productSaleBindingSource.DataSource = GetSalesHistory();
            }
            else
                agentBindingSource.AddNew();
        }

        private List<ProductSale> GetSalesHistory()
        {
            var sales = DBContext.Context.ProductSale.ToList();

            sales = sales
                .Where(x => x.AgentID == agent.ID)
                .ToList();

            return sales;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (String.IsNullOrWhiteSpace(titleTextBox.Text))
                errors.AppendLine("Наименование");
            if (iNNMaskedTextBox.Text.Length != 10)
                errors.AppendLine("ИНН");
            if (kPPMaskedTextBox.Text.Length != 9)
                errors.AppendLine("КПП");
            if (String.IsNullOrWhiteSpace(emailTextBox.Text)
                || (!emailTextBox.Text.Contains("@") && !emailTextBox.Text.Contains(".")))
                errors.AppendLine("Email");
            if (phoneMaskedTextBox.Text.Length != 16)
                errors.AppendLine("Номер телефона");
            if (String.IsNullOrWhiteSpace(directorNameTextBox.Text))
                errors.AppendLine("ФИО Директора");
            if (priorityNumericUpDown.Value <= 0)
                errors.AppendLine("Приоритет не должен быть равен нулю");
            if (agentTypeIDComboBox.SelectedItem == null)
                errors.AppendLine("Тип агента");

            if (errors.Length > 0)
            {
                MessageBox.Show($"Необходимо заполнить следующие поля корректными данными:\n{errors}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (agent.ID == 0)
            {
                agent.Logo = agent.Logo == @"..\..\Resources\picture.png" ? null : agent.Logo;
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
        /// Метод вызова диалогового окна для выбора изображения логотипа агента
        /// </summary>
        private void changeLogoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = $@"{Environment.CurrentDirectory}\agents\";

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
                MessageBox.Show("Агент не может быть удален, потому что у него имеется история продаж","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("Удалить текущего агента?","Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
                try
                {
                    DBContext.Context.Agent.Remove(agent);
                    DBContext.Context.SaveChanges();
                    MessageBox.Show("Агент удален.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DialogResult dr = MessageBox.Show("Удалить выбранную запись?","Удаление",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
                try
                {
                    DBContext.Context.ProductSale.Remove(itemToDelete);
                    DBContext.Context.SaveChanges();

                    MessageBox.Show("Запись удалена.","Успешно",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    productSaleBindingSource.DataSource = GetSalesHistory();
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
                productSaleBindingSource.DataSource = GetSalesHistory();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
