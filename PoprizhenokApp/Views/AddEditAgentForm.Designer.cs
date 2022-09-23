namespace PoprizhenokApp.Views
{
    partial class AddEditAgentForm
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
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label agentTypeIDLabel;
            System.Windows.Forms.Label directorNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label iNNLabel;
            System.Windows.Forms.Label kPPLabel;
            System.Windows.Forms.Label logoLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label titleLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditAgentForm));
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.agentTypeIDComboBox = new System.Windows.Forms.ComboBox();
            this.agentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directorNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.iNNTextBox = new System.Windows.Forms.TextBox();
            this.kPPTextBox = new System.Windows.Forms.TextBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.priorityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.changeLogoBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.salesHistoryDGV = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saleDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteSaleBtn = new System.Windows.Forms.Button();
            this.addSaleBtn = new System.Windows.Forms.Button();
            addressLabel = new System.Windows.Forms.Label();
            agentTypeIDLabel = new System.Windows.Forms.Label();
            directorNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            iNNLabel = new System.Windows.Forms.Label();
            kPPLabel = new System.Windows.Forms.Label();
            logoLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesHistoryDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            addressLabel.Location = new System.Drawing.Point(12, 81);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(80, 29);
            addressLabel.TabIndex = 1;
            addressLabel.Text = "Адрес:";
            // 
            // agentTypeIDLabel
            // 
            agentTypeIDLabel.AutoSize = true;
            agentTypeIDLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            agentTypeIDLabel.Location = new System.Drawing.Point(12, 153);
            agentTypeIDLabel.Name = "agentTypeIDLabel";
            agentTypeIDLabel.Size = new System.Drawing.Size(131, 29);
            agentTypeIDLabel.TabIndex = 3;
            agentTypeIDLabel.Text = "Тип агента:";
            // 
            // directorNameLabel
            // 
            directorNameLabel.AutoSize = true;
            directorNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            directorNameLabel.Location = new System.Drawing.Point(12, 225);
            directorNameLabel.Name = "directorNameLabel";
            directorNameLabel.Size = new System.Drawing.Size(176, 29);
            directorNameLabel.TabIndex = 5;
            directorNameLabel.Text = "ФИО Директора:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            emailLabel.Location = new System.Drawing.Point(12, 297);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(71, 29);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "Email:";
            // 
            // iNNLabel
            // 
            iNNLabel.AutoSize = true;
            iNNLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iNNLabel.Location = new System.Drawing.Point(260, 49);
            iNNLabel.Name = "iNNLabel";
            iNNLabel.Size = new System.Drawing.Size(67, 29);
            iNNLabel.TabIndex = 9;
            iNNLabel.Text = "ИНН:";
            // 
            // kPPLabel
            // 
            kPPLabel.AutoSize = true;
            kPPLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            kPPLabel.Location = new System.Drawing.Point(260, 121);
            kPPLabel.Name = "kPPLabel";
            kPPLabel.Size = new System.Drawing.Size(70, 29);
            kPPLabel.TabIndex = 11;
            kPPLabel.Text = "КПП:";
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            logoLabel.Location = new System.Drawing.Point(531, 34);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new System.Drawing.Size(106, 29);
            logoLabel.TabIndex = 13;
            logoLabel.Text = "Логотип:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            phoneLabel.Location = new System.Drawing.Point(260, 193);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(188, 29);
            phoneLabel.TabIndex = 15;
            phoneLabel.Text = "Номер телефона:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            priorityLabel.Location = new System.Drawing.Point(260, 265);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(129, 29);
            priorityLabel.TabIndex = 17;
            priorityLabel.Text = "Приоритет:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            titleLabel.Location = new System.Drawing.Point(12, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(167, 29);
            titleLabel.TabIndex = 19;
            titleLabel.Text = "Наименование:";
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataSource = typeof(PoprizhenokApp.Models.Agent);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Address", true));
            this.addressTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTextBox.Location = new System.Drawing.Point(17, 113);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(242, 37);
            this.addressTextBox.TabIndex = 2;
            // 
            // agentTypeIDComboBox
            // 
            this.agentTypeIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agentBindingSource, "AgentTypeID", true));
            this.agentTypeIDComboBox.DataSource = this.agentTypeBindingSource;
            this.agentTypeIDComboBox.DisplayMember = "Title";
            this.agentTypeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.agentTypeIDComboBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentTypeIDComboBox.FormattingEnabled = true;
            this.agentTypeIDComboBox.Location = new System.Drawing.Point(17, 185);
            this.agentTypeIDComboBox.Name = "agentTypeIDComboBox";
            this.agentTypeIDComboBox.Size = new System.Drawing.Size(242, 37);
            this.agentTypeIDComboBox.TabIndex = 4;
            this.agentTypeIDComboBox.TabStop = false;
            this.agentTypeIDComboBox.ValueMember = "ID";
            // 
            // agentTypeBindingSource
            // 
            this.agentTypeBindingSource.DataSource = typeof(PoprizhenokApp.Models.AgentType);
            // 
            // directorNameTextBox
            // 
            this.directorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "DirectorName", true));
            this.directorNameTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directorNameTextBox.Location = new System.Drawing.Point(17, 257);
            this.directorNameTextBox.Name = "directorNameTextBox";
            this.directorNameTextBox.Size = new System.Drawing.Size(242, 37);
            this.directorNameTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(17, 329);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(242, 37);
            this.emailTextBox.TabIndex = 7;
            // 
            // iNNTextBox
            // 
            this.iNNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "INN", true));
            this.iNNTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iNNTextBox.Location = new System.Drawing.Point(265, 81);
            this.iNNTextBox.Name = "iNNTextBox";
            this.iNNTextBox.Size = new System.Drawing.Size(242, 37);
            this.iNNTextBox.TabIndex = 1;
            // 
            // kPPTextBox
            // 
            this.kPPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "KPP", true));
            this.kPPTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kPPTextBox.Location = new System.Drawing.Point(265, 153);
            this.kPPTextBox.Name = "kPPTextBox";
            this.kPPTextBox.Size = new System.Drawing.Size(242, 37);
            this.kPPTextBox.TabIndex = 3;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.agentBindingSource, "Logo", true));
            this.logoPictureBox.Image = global::PoprizhenokApp.Properties.Resources.picture;
            this.logoPictureBox.Location = new System.Drawing.Point(536, 66);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(300, 300);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 14;
            this.logoPictureBox.TabStop = false;
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Phone", true));
            this.phoneMaskedTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(265, 225);
            this.phoneMaskedTextBox.Mask = "+7 000 000 00 00";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(242, 37);
            this.phoneMaskedTextBox.TabIndex = 4;
            // 
            // priorityNumericUpDown
            // 
            this.priorityNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.agentBindingSource, "Priority", true));
            this.priorityNumericUpDown.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityNumericUpDown.Location = new System.Drawing.Point(265, 297);
            this.priorityNumericUpDown.Name = "priorityNumericUpDown";
            this.priorityNumericUpDown.Size = new System.Drawing.Size(242, 37);
            this.priorityNumericUpDown.TabIndex = 6;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "Title", true));
            this.titleTextBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTextBox.Location = new System.Drawing.Point(17, 41);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(242, 37);
            this.titleTextBox.TabIndex = 0;
            // 
            // changeLogoBtn
            // 
            this.changeLogoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.changeLogoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeLogoBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeLogoBtn.ForeColor = System.Drawing.Color.Black;
            this.changeLogoBtn.Location = new System.Drawing.Point(536, 372);
            this.changeLogoBtn.Name = "changeLogoBtn";
            this.changeLogoBtn.Size = new System.Drawing.Size(300, 39);
            this.changeLogoBtn.TabIndex = 8;
            this.changeLogoBtn.Text = "Выбрать фото";
            this.changeLogoBtn.UseVisualStyleBackColor = false;
            this.changeLogoBtn.Click += new System.EventHandler(this.changeLogoBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.Location = new System.Drawing.Point(12, 519);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(198, 39);
            this.saveBtn.TabIndex = 9;
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
            this.cancelBtn.Location = new System.Drawing.Point(628, 519);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(208, 39);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Отменить";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.Location = new System.Drawing.Point(414, 519);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(208, 39);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // salesHistoryDGV
            // 
            this.salesHistoryDGV.AllowUserToAddRows = false;
            this.salesHistoryDGV.AllowUserToDeleteRows = false;
            this.salesHistoryDGV.AutoGenerateColumns = false;
            this.salesHistoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesHistoryDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.saleDateDataGridViewTextBoxColumn,
            this.productCountDataGridViewTextBoxColumn});
            this.salesHistoryDGV.DataSource = this.productSaleBindingSource;
            this.salesHistoryDGV.Location = new System.Drawing.Point(842, 12);
            this.salesHistoryDGV.MultiSelect = false;
            this.salesHistoryDGV.Name = "salesHistoryDGV";
            this.salesHistoryDGV.ReadOnly = true;
            this.salesHistoryDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.salesHistoryDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesHistoryDGV.Size = new System.Drawing.Size(442, 399);
            this.salesHistoryDGV.TabIndex = 20;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.DataSource = this.productBindingSource;
            this.productIDDataGridViewTextBoxColumn.DisplayMember = "Title";
            this.productIDDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Продукт";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 120;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.productIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.productIDDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(PoprizhenokApp.Models.Product);
            // 
            // saleDateDataGridViewTextBoxColumn
            // 
            this.saleDateDataGridViewTextBoxColumn.DataPropertyName = "SaleDate";
            this.saleDateDataGridViewTextBoxColumn.HeaderText = "Дата продажи";
            this.saleDateDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.saleDateDataGridViewTextBoxColumn.Name = "saleDateDataGridViewTextBoxColumn";
            this.saleDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productCountDataGridViewTextBoxColumn
            // 
            this.productCountDataGridViewTextBoxColumn.DataPropertyName = "ProductCount";
            this.productCountDataGridViewTextBoxColumn.HeaderText = "Кол-во";
            this.productCountDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.productCountDataGridViewTextBoxColumn.Name = "productCountDataGridViewTextBoxColumn";
            this.productCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.productCountDataGridViewTextBoxColumn.Width = 70;
            // 
            // productSaleBindingSource
            // 
            this.productSaleBindingSource.DataSource = typeof(PoprizhenokApp.Models.ProductSale);
            // 
            // deleteSaleBtn
            // 
            this.deleteSaleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.deleteSaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSaleBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteSaleBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteSaleBtn.Location = new System.Drawing.Point(1076, 417);
            this.deleteSaleBtn.Name = "deleteSaleBtn";
            this.deleteSaleBtn.Size = new System.Drawing.Size(208, 39);
            this.deleteSaleBtn.TabIndex = 10;
            this.deleteSaleBtn.Text = "-";
            this.deleteSaleBtn.UseVisualStyleBackColor = false;
            this.deleteSaleBtn.Click += new System.EventHandler(this.deleteSaleBtn_Click);
            // 
            // addSaleBtn
            // 
            this.addSaleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.addSaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addSaleBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSaleBtn.ForeColor = System.Drawing.Color.Black;
            this.addSaleBtn.Location = new System.Drawing.Point(842, 417);
            this.addSaleBtn.Name = "addSaleBtn";
            this.addSaleBtn.Size = new System.Drawing.Size(208, 39);
            this.addSaleBtn.TabIndex = 10;
            this.addSaleBtn.Text = "+";
            this.addSaleBtn.UseVisualStyleBackColor = false;
            this.addSaleBtn.Click += new System.EventHandler(this.addSaleBtn_Click);
            // 
            // AddEditAgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1296, 593);
            this.ControlBox = false;
            this.Controls.Add(this.salesHistoryDGV);
            this.Controls.Add(this.addSaleBtn);
            this.Controls.Add(this.deleteSaleBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.changeLogoBtn);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(agentTypeIDLabel);
            this.Controls.Add(this.agentTypeIDComboBox);
            this.Controls.Add(directorNameLabel);
            this.Controls.Add(this.directorNameTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(iNNLabel);
            this.Controls.Add(this.iNNTextBox);
            this.Controls.Add(kPPLabel);
            this.Controls.Add(this.kPPTextBox);
            this.Controls.Add(logoLabel);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(priorityLabel);
            this.Controls.Add(this.priorityNumericUpDown);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(864, 609);
            this.Name = "AddEditAgentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Попрыженок";
            this.Load += new System.EventHandler(this.AddEditAgentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesHistoryDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSaleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource agentBindingSource;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.ComboBox agentTypeIDComboBox;
        private System.Windows.Forms.TextBox directorNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox iNNTextBox;
        private System.Windows.Forms.TextBox kPPTextBox;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.NumericUpDown priorityNumericUpDown;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button changeLogoBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.BindingSource agentTypeBindingSource;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView salesHistoryDGV;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productSaleBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteSaleBtn;
        private System.Windows.Forms.Button addSaleBtn;
    }
}