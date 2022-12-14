namespace PoprizhenokApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.agentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ascDescCheck = new System.Windows.Forms.CheckBox();
            this.searchTxtBox = new System.Windows.Forms.TextBox();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pagesCountLbl = new System.Windows.Forms.Label();
            this.pageNumLbl = new System.Windows.Forms.Label();
            this.prevPageLbl = new System.Windows.Forms.Label();
            this.changePriorityBtn = new System.Windows.Forms.Button();
            this.addAgentBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.agentsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.titleLbl);
            this.panel1.Controls.Add(this.logoPictureBox);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 150);
            this.panel1.TabIndex = 0;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLbl.Location = new System.Drawing.Point(145, 5);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(445, 90);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "Попрыженок";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::PoprizhenokApp.Properties.Resources.Попрыженок;
            this.logoPictureBox.Location = new System.Drawing.Point(-1, 5);
            this.logoPictureBox.MaximumSize = new System.Drawing.Size(140, 140);
            this.logoPictureBox.MinimumSize = new System.Drawing.Size(140, 140);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(140, 140);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.filterComboBox);
            this.panel4.Controls.Add(this.ascDescCheck);
            this.panel4.Controls.Add(this.searchTxtBox);
            this.panel4.Controls.Add(this.sortComboBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(145, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1073, 148);
            this.panel4.TabIndex = 4;
            // 
            // filterComboBox
            // 
            this.filterComboBox.BackColor = System.Drawing.Color.White;
            this.filterComboBox.DataSource = this.agentTypeBindingSource;
            this.filterComboBox.DisplayMember = "Title";
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(797, 106);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(258, 37);
            this.filterComboBox.TabIndex = 2;
            this.filterComboBox.ValueMember = "ID";
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.TriggerFilters);
            // 
            // agentTypeBindingSource
            // 
            this.agentTypeBindingSource.DataSource = typeof(PoprizhenokApp.Models.AgentType);
            // 
            // ascDescCheck
            // 
            this.ascDescCheck.AutoSize = true;
            this.ascDescCheck.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ascDescCheck.Location = new System.Drawing.Point(617, 112);
            this.ascDescCheck.Name = "ascDescCheck";
            this.ascDescCheck.Size = new System.Drawing.Size(174, 33);
            this.ascDescCheck.TabIndex = 1;
            this.ascDescCheck.Text = "По убыванию";
            this.ascDescCheck.UseVisualStyleBackColor = true;
            this.ascDescCheck.CheckedChanged += new System.EventHandler(this.TriggerFilters);
            // 
            // searchTxtBox
            // 
            this.searchTxtBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTxtBox.Location = new System.Drawing.Point(8, 107);
            this.searchTxtBox.Name = "searchTxtBox";
            this.searchTxtBox.Size = new System.Drawing.Size(350, 37);
            this.searchTxtBox.TabIndex = 3;
            this.searchTxtBox.Text = "Введите для поиска";
            this.searchTxtBox.TextChanged += new System.EventHandler(this.TriggerFilters);
            this.searchTxtBox.Enter += new System.EventHandler(this.searchTxtBox_Enter);
            this.searchTxtBox.Leave += new System.EventHandler(this.searchTxtBox_Leave);
            // 
            // sortComboBox
            // 
            this.sortComboBox.BackColor = System.Drawing.Color.White;
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Без сортировки",
            "Наименование",
            "Размер скидки",
            "Приоритет"});
            this.sortComboBox.Location = new System.Drawing.Point(364, 106);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(247, 37);
            this.sortComboBox.TabIndex = 0;
            this.sortComboBox.SelectedIndexChanged += new System.EventHandler(this.TriggerFilters);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(150)))), ((int)(((byte)(158)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.changePriorityBtn);
            this.panel2.Controls.Add(this.addAgentBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 750);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 56);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.pagesCountLbl);
            this.panel5.Controls.Add(this.pageNumLbl);
            this.panel5.Controls.Add(this.prevPageLbl);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(900, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(318, 54);
            this.panel5.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(286, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = ">";
            this.label1.Click += new System.EventHandler(this.nextPageBtn_Click);
            // 
            // pagesCountLbl
            // 
            this.pagesCountLbl.AutoSize = true;
            this.pagesCountLbl.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pagesCountLbl.Location = new System.Drawing.Point(7, 13);
            this.pagesCountLbl.Name = "pagesCountLbl";
            this.pagesCountLbl.Size = new System.Drawing.Size(119, 29);
            this.pagesCountLbl.TabIndex = 3;
            this.pagesCountLbl.Text = "## из ##";
            // 
            // pageNumLbl
            // 
            this.pageNumLbl.AutoSize = true;
            this.pageNumLbl.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageNumLbl.Location = new System.Drawing.Point(201, 13);
            this.pageNumLbl.Name = "pageNumLbl";
            this.pageNumLbl.Size = new System.Drawing.Size(79, 29);
            this.pageNumLbl.TabIndex = 3;
            this.pageNumLbl.Text = "1 2 3 4";
            // 
            // prevPageLbl
            // 
            this.prevPageLbl.AutoSize = true;
            this.prevPageLbl.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prevPageLbl.Location = new System.Drawing.Point(174, 13);
            this.prevPageLbl.Name = "prevPageLbl";
            this.prevPageLbl.Size = new System.Drawing.Size(21, 29);
            this.prevPageLbl.TabIndex = 3;
            this.prevPageLbl.Text = "<";
            this.prevPageLbl.Click += new System.EventHandler(this.prevPageBtn_Click);
            // 
            // changePriorityBtn
            // 
            this.changePriorityBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.changePriorityBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePriorityBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePriorityBtn.ForeColor = System.Drawing.Color.Black;
            this.changePriorityBtn.Location = new System.Drawing.Point(315, 8);
            this.changePriorityBtn.Name = "changePriorityBtn";
            this.changePriorityBtn.Size = new System.Drawing.Size(300, 39);
            this.changePriorityBtn.TabIndex = 5;
            this.changePriorityBtn.Text = "Изменить приоритет на...";
            this.changePriorityBtn.UseVisualStyleBackColor = false;
            this.changePriorityBtn.Click += new System.EventHandler(this.changePriorityBtn_Click);
            // 
            // addAgentBtn
            // 
            this.addAgentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(220)))), ((int)(((byte)(254)))));
            this.addAgentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAgentBtn.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAgentBtn.ForeColor = System.Drawing.Color.Black;
            this.addAgentBtn.Location = new System.Drawing.Point(9, 8);
            this.addAgentBtn.Name = "addAgentBtn";
            this.addAgentBtn.Size = new System.Drawing.Size(300, 39);
            this.addAgentBtn.TabIndex = 4;
            this.addAgentBtn.Text = "Добавить агента";
            this.addAgentBtn.UseVisualStyleBackColor = false;
            this.addAgentBtn.Click += new System.EventHandler(this.addAgentBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.agentsLayoutPanel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1220, 600);
            this.panel3.TabIndex = 2;
            // 
            // agentsLayoutPanel
            // 
            this.agentsLayoutPanel.AutoScroll = true;
            this.agentsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agentsLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.agentsLayoutPanel.Name = "agentsLayoutPanel";
            this.agentsLayoutPanel.Size = new System.Drawing.Size(1220, 600);
            this.agentsLayoutPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1220, 806);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Попрыженок";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentTypeBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel agentsLayoutPanel;
        private System.Windows.Forms.TextBox searchTxtBox;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.CheckBox ascDescCheck;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.BindingSource agentTypeBindingSource;
        private System.Windows.Forms.Button addAgentBtn;
        private System.Windows.Forms.Button changePriorityBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pageNumLbl;
        private System.Windows.Forms.Label prevPageLbl;
        private System.Windows.Forms.Label pagesCountLbl;
    }
}

