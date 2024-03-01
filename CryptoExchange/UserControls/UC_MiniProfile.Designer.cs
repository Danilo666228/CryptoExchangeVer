namespace CryptoExchange.UserControls
{
    partial class UC_MiniProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MiniProfile));
            this.lblNameUser = new System.Windows.Forms.Label();
            this.lblBalanceUser = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAddBalance = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameUser.Location = new System.Drawing.Point(111, 28);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(45, 25);
            this.lblNameUser.TabIndex = 0;
            this.lblNameUser.Text = "Имя";
            // 
            // lblBalanceUser
            // 
            this.lblBalanceUser.AutoSize = true;
            this.lblBalanceUser.Font = new System.Drawing.Font("JetBrains Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBalanceUser.Location = new System.Drawing.Point(111, 64);
            this.lblBalanceUser.Name = "lblBalanceUser";
            this.lblBalanceUser.Size = new System.Drawing.Size(78, 25);
            this.lblBalanceUser.TabIndex = 0;
            this.lblBalanceUser.Text = "Баланс";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(10, 17);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(80, 81);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // btnAddBalance
            // 
            this.btnAddBalance.Animated = true;
            this.btnAddBalance.BorderRadius = 10;
            this.btnAddBalance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBalance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddBalance.FillColor = System.Drawing.Color.Transparent;
            this.btnAddBalance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddBalance.ForeColor = System.Drawing.Color.White;
            this.btnAddBalance.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBalance.Image")));
            this.btnAddBalance.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAddBalance.Location = new System.Drawing.Point(243, 0);
            this.btnAddBalance.Name = "btnAddBalance";
            this.btnAddBalance.Size = new System.Drawing.Size(40, 36);
            this.btnAddBalance.TabIndex = 3;
            this.btnAddBalance.Click += new System.EventHandler(this.btnAddBalance_Click);
            // 
            // UC_MiniProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.btnAddBalance);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.lblBalanceUser);
            this.Controls.Add(this.lblNameUser);
            this.Name = "UC_MiniProfile";
            this.Size = new System.Drawing.Size(283, 118);
            this.Load += new System.EventHandler(this.UC_MiniProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.Label lblBalanceUser;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnAddBalance;
    }
}
