namespace CryptoExchange.UserControls
{
    partial class UC_CardPanel
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lblNameBank = new System.Windows.Forms.Label();
            this.txbLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbActionCard = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbCVV = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbNumberCard = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lblNameBank
            // 
            this.lblNameBank.AutoSize = true;
            this.lblNameBank.BackColor = System.Drawing.Color.Transparent;
            this.lblNameBank.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNameBank.Location = new System.Drawing.Point(21, 20);
            this.lblNameBank.Name = "lblNameBank";
            this.lblNameBank.Size = new System.Drawing.Size(166, 25);
            this.lblNameBank.TabIndex = 0;
            this.lblNameBank.Text = "Название банка";
            // 
            // txbLastName
            // 
            this.txbLastName.BackColor = System.Drawing.Color.Transparent;
            this.txbLastName.BorderRadius = 10;
            this.txbLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbLastName.DefaultText = "";
            this.txbLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbLastName.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbLastName.Location = new System.Drawing.Point(21, 220);
            this.txbLastName.MaxLength = 32000;
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.PasswordChar = '\0';
            this.txbLastName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbLastName.PlaceholderText = "Ваша фамилия";
            this.txbLastName.SelectedText = "";
            this.txbLastName.Size = new System.Drawing.Size(200, 28);
            this.txbLastName.TabIndex = 1;
            // 
            // txbActionCard
            // 
            this.txbActionCard.BackColor = System.Drawing.Color.Transparent;
            this.txbActionCard.BorderRadius = 10;
            this.txbActionCard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbActionCard.DefaultText = "";
            this.txbActionCard.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbActionCard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbActionCard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbActionCard.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbActionCard.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbActionCard.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbActionCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbActionCard.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbActionCard.Location = new System.Drawing.Point(65, 186);
            this.txbActionCard.MaxLength = 5;
            this.txbActionCard.Name = "txbActionCard";
            this.txbActionCard.PasswordChar = '\0';
            this.txbActionCard.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbActionCard.PlaceholderText = "Срок действия";
            this.txbActionCard.SelectedText = "";
            this.txbActionCard.Size = new System.Drawing.Size(156, 28);
            this.txbActionCard.TabIndex = 1;
            // 
            // txbCVV
            // 
            this.txbCVV.BackColor = System.Drawing.Color.Transparent;
            this.txbCVV.BorderRadius = 10;
            this.txbCVV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbCVV.DefaultText = "";
            this.txbCVV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbCVV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbCVV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCVV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbCVV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCVV.Font = new System.Drawing.Font("JetBrains Mono", 12F);
            this.txbCVV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbCVV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbCVV.Location = new System.Drawing.Point(429, 40);
            this.txbCVV.MaxLength = 3;
            this.txbCVV.Name = "txbCVV";
            this.txbCVV.PasswordChar = '\0';
            this.txbCVV.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbCVV.PlaceholderText = "CVV";
            this.txbCVV.SelectedText = "";
            this.txbCVV.Size = new System.Drawing.Size(59, 28);
            this.txbCVV.TabIndex = 1;
            // 
            // txbNumberCard
            // 
            this.txbNumberCard.BackColor = System.Drawing.Color.Transparent;
            this.txbNumberCard.BorderRadius = 10;
            this.txbNumberCard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNumberCard.DefaultText = "";
            this.txbNumberCard.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbNumberCard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbNumberCard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNumberCard.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNumberCard.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNumberCard.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbNumberCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbNumberCard.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNumberCard.Location = new System.Drawing.Point(145, 120);
            this.txbNumberCard.MaxLength = 16;
            this.txbNumberCard.Name = "txbNumberCard";
            this.txbNumberCard.PasswordChar = '\0';
            this.txbNumberCard.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbNumberCard.PlaceholderText = "Номер карты";
            this.txbNumberCard.SelectedText = "";
            this.txbNumberCard.Size = new System.Drawing.Size(222, 28);
            this.txbNumberCard.TabIndex = 1;
            // 
            // UC_CardPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.txbCVV);
            this.Controls.Add(this.txbActionCard);
            this.Controls.Add(this.txbNumberCard);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.lblNameBank);
            this.Name = "UC_CardPanel";
            this.Size = new System.Drawing.Size(501, 265);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblNameBank;
        private Guna.UI2.WinForms.Guna2TextBox txbLastName;
        private Guna.UI2.WinForms.Guna2TextBox txbCVV;
        private Guna.UI2.WinForms.Guna2TextBox txbActionCard;
        private Guna.UI2.WinForms.Guna2TextBox txbNumberCard;
    }
}
