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
    public partial class AddNewSaleForm : Form
    {
        Agent agent { get; set; } = null;
        public AddNewSaleForm(Agent current)
        {
            InitializeComponent();
            agent = current;

            productCountNumericUpDown.Maximum = Int32.MaxValue;
        }

        private void AddNewSaleForm_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = DBContext.Context.Product.ToList();
            productSaleBindingSource.AddNew();

            saleDateDateTimePicker.Value = DateTime.Now;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (productCountNumericUpDown.Value <= 0)
                errors.AppendLine("Количество не должно быть меньше или равным нулю");
            if (saleDateDateTimePicker.Value > DateTime.Now)
                errors.AppendLine($"Дата продажи может быть не позднее {DateTime.Now}");
            if (productIDComboBox.SelectedItem == null)
                errors.AppendLine($"Выберите продукт");

            if (errors.Length > 0)
            {
                MessageBox.Show($"{errors}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product product = (Product)productBindingSource.Current;

            ProductSale sale = new ProductSale()
            {
                ProductID = product.ID,
                AgentID = agent.ID,
                SaleDate = DateTime.Parse(saleDateDateTimePicker.Value.ToShortDateString()),
                ProductCount = Convert.ToInt32(productCountNumericUpDown.Value),
            };


            try
            {
                DBContext.Context.ProductSale.Add(sale);
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
    }
}
