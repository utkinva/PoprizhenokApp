namespace PoprizhenokApp.Views.PartialView
{
    partial class AgentCard
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleTypeLbl = new System.Windows.Forms.Label();
            this.salesPerYearLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.priorityLbl = new System.Windows.Forms.Label();
            this.percentLbl = new System.Windows.Forms.Label();
            this.agentIdLbl = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.priorityValueLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleTypeLbl
            // 
            this.titleTypeLbl.AutoSize = true;
            this.titleTypeLbl.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTypeLbl.Location = new System.Drawing.Point(251, 16);
            this.titleTypeLbl.Name = "titleTypeLbl";
            this.titleTypeLbl.Size = new System.Drawing.Size(300, 38);
            this.titleTypeLbl.TabIndex = 1;
            this.titleTypeLbl.Text = "Тип | Наименование";
            // 
            // salesPerYearLbl
            // 
            this.salesPerYearLbl.AutoSize = true;
            this.salesPerYearLbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salesPerYearLbl.Location = new System.Drawing.Point(251, 63);
            this.salesPerYearLbl.Name = "salesPerYearLbl";
            this.salesPerYearLbl.Size = new System.Drawing.Size(209, 33);
            this.salesPerYearLbl.TabIndex = 1;
            this.salesPerYearLbl.Text = "10 продаж за год";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneLbl.Location = new System.Drawing.Point(251, 96);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(169, 33);
            this.phoneLbl.TabIndex = 1;
            this.phoneLbl.Text = "+7 111 11 11 11";
            // 
            // priorityLbl
            // 
            this.priorityLbl.AutoSize = true;
            this.priorityLbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityLbl.Location = new System.Drawing.Point(251, 129);
            this.priorityLbl.Name = "priorityLbl";
            this.priorityLbl.Size = new System.Drawing.Size(218, 33);
            this.priorityLbl.TabIndex = 1;
            this.priorityLbl.Text = "Приоритетность: ";
            // 
            // percentLbl
            // 
            this.percentLbl.AutoSize = true;
            this.percentLbl.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percentLbl.Location = new System.Drawing.Point(1094, 14);
            this.percentLbl.Name = "percentLbl";
            this.percentLbl.Size = new System.Drawing.Size(77, 40);
            this.percentLbl.TabIndex = 1;
            this.percentLbl.Text = "10%";
            // 
            // agentIdLbl
            // 
            this.agentIdLbl.AutoSize = true;
            this.agentIdLbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.agentIdLbl.Location = new System.Drawing.Point(560, 117);
            this.agentIdLbl.Name = "agentIdLbl";
            this.agentIdLbl.Size = new System.Drawing.Size(0, 33);
            this.agentIdLbl.TabIndex = 1;
            this.agentIdLbl.Visible = false;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::PoprizhenokApp.Properties.Resources.picture;
            this.logoPictureBox.Location = new System.Drawing.Point(18, 16);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(227, 146);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // priorityValueLbl
            // 
            this.priorityValueLbl.AutoSize = true;
            this.priorityValueLbl.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityValueLbl.Location = new System.Drawing.Point(451, 129);
            this.priorityValueLbl.Name = "priorityValueLbl";
            this.priorityValueLbl.Size = new System.Drawing.Size(41, 33);
            this.priorityValueLbl.TabIndex = 1;
            this.priorityValueLbl.Text = "10";
            // 
            // AgentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.agentIdLbl);
            this.Controls.Add(this.priorityValueLbl);
            this.Controls.Add(this.priorityLbl);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.salesPerYearLbl);
            this.Controls.Add(this.percentLbl);
            this.Controls.Add(this.titleTypeLbl);
            this.Controls.Add(this.logoPictureBox);
            this.Name = "AgentCard";
            this.Size = new System.Drawing.Size(1195, 189);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label titleTypeLbl;
        private System.Windows.Forms.Label salesPerYearLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label priorityLbl;
        public System.Windows.Forms.Label agentIdLbl;
        private System.Windows.Forms.Label percentLbl;
        public System.Windows.Forms.Label priorityValueLbl;
    }
}
