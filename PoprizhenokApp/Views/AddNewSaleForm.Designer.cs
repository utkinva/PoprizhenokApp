namespace PoprizhenokApp.Views
{
    partial class AddNewSaleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label productCountLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label saleDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewSaleForm));
            this.productSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.productIDComboBox = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            productCountLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            saleDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // productCountLabel
            // 
            productCountLabel.AutoSize = true;
            productCountLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productCountLabel.Location = new System.Drawing.Point(12, 9);
            productCountLabel.Name = "productCountLabel";
            productCountLabel.Size = new System.Drawing.Size(137, 29);
            productCountLabel.TabIndex = 1;
            productCountLabel.Text = "Количество:";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            productIDLabel.Location = new System.Drawing.Point(12, 78);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(104, 29);
            productIDLabel.TabIndex = 3;
            productIDLabel.Text = "Продукт:";
            // 
            // saleDateLabel
            // 
            saleDateLabel.AutoSize = true;
            saleDateLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            saleDateLabel.Location = new System.Drawing.Point(12, 147);
            saleDateLabel.Name = "saleDateLabel";
            saleDateLabel.Size = new System.Drawing.Size(160, 29);
            saleDateLabel.TabIndex = 5;
            saleDateLabel.Text = "Дата продажи:";
            // 
            // productSaleBindingSource
            // 
            this.productSaleBindingSource.DataSource = typeof(PoprizhenokApp.Models.ProductSale);
            // 
            // productCountNumericUpDown
            // 
            this.productCountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productSaleBindingSource, "ProductCount", true));
            this.productCountNumericUpDown.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCountNumericUpDown.Location = new System.Drawing.Point(17, 41);
            this.productCountNumericUpDown.Name = "productCountNumericUpDown";
            this.productCountNumericUpDown.Size = new System.Drawing.Size(470, 34);
            this.productCountNumericUpDown.TabIndex = 2;
            // 
            // productIDComboBox
            // 
            this.productIDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.productIDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.productIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productSaleBindingSource, "ProductID", true));
            this.productIDComboBox.DataSource = this.productBindingSource;
            this.productIDComboBox.DisplayMember = "Title";
            this.productIDComboBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productIDComboBox.FormattingEnabled = true;
            this.productIDComboBox.Location = new System.Drawing.Point(17, 110);
            this.productIDComboBox.MaxDropDownItems = 10;
            this.productIDComboBox.Name = "productIDComboBox";
            this.productIDComboBox.Size = new System.Drawing.Size(470, 34);
            this.productIDComboBox.TabIndex = 4;
            this.productIDComboBox.ValueMember = "ID";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(PoprizhenokApp.Models.Product);
            // 
            // saleDateDateTimePicker
            // 
            this.saleDateDateTimePicker.CalendarFont = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saleDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productSaleBindingSource, "SaleDate", true));
            this.saleDateDateTimePicker.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saleDateDateTimePicker.Location = new System.Drawing.Point(17, 179);
            this.saleDateDateTimePicker.Name = "saleDateDateTimePicker";
            this.saleDateDateTimePicker.Size = new System.Drawing.Size(470, 34);
            this.saleDateDateTimePicker.TabIndex = 6;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.Location = new System.Drawing.Point(17, 249);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(138, 39);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(349, 249);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(138, 39);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Отменить";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddNewSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 308);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(productCountLabel);
            this.Controls.Add(this.productCountNumericUpDown);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDComboBox);
            this.Controls.Add(saleDateLabel);
            this.Controls.Add(this.saleDateDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewSaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Попрыженок";
            this.Load += new System.EventHandler(this.AddNewSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productSaleBindingSource;
        private System.Windows.Forms.NumericUpDown productCountNumericUpDown;
        private System.Windows.Forms.ComboBox productIDComboBox;
        private System.Windows.Forms.DateTimePicker saleDateDateTimePicker;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}