namespace CryptoExchange
{
    partial class AddBalanceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBalanceForm));
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pnlCard = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.imagebtnTinkov = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.imagebtnSberbank = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.imgbtnVTB = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.lblNameBank = new System.Windows.Forms.Label();
            this.txbNumberCard = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbTopBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTopBalance = new Guna.UI2.WinForms.Guna2Button();
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnlFooter = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlCloseForm = new Guna.UI2.WinForms.Guna2Panel();
            this.txbNameUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.txbActionCard = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTypeCard = new System.Windows.Forms.Label();
            this.pcbAttachCard = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ProggressBar = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.pnlCard.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlCloseForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttachCard)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimateWindow = true;
            this.BorderlessForm.AnimationInterval = 800;
            this.BorderlessForm.BorderRadius = 20;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlCard.Controls.Add(this.pcbAttachCard);
            this.pnlCard.Controls.Add(this.txbActionCard);
            this.pnlCard.Controls.Add(this.txbNameUser);
            this.pnlCard.Controls.Add(this.txbNumberCard);
            this.pnlCard.Controls.Add(this.lblTypeCard);
            this.pnlCard.Controls.Add(this.lblNameBank);
            this.pnlCard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlCard.ForeColor = System.Drawing.Color.Black;
            this.pnlCard.Location = new System.Drawing.Point(69, 172);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Radius = 10;
            this.pnlCard.ShadowColor = System.Drawing.Color.Black;
            this.pnlCard.Size = new System.Drawing.Size(485, 271);
            this.pnlCard.TabIndex = 0;
            this.pnlCard.Visible = false;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeader.Controls.Add(this.pnlCloseForm);
            this.pnlHeader.Controls.Add(this.imagebtnTinkov);
            this.pnlHeader.Controls.Add(this.imagebtnSberbank);
            this.pnlHeader.Controls.Add(this.imgbtnVTB);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Radius = 5;
            this.pnlHeader.ShadowColor = System.Drawing.Color.Black;
            this.pnlHeader.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
            this.pnlHeader.Size = new System.Drawing.Size(615, 152);
            this.pnlHeader.TabIndex = 1;
            // 
            // imagebtnTinkov
            // 
            this.imagebtnTinkov.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.imagebtnTinkov.CheckedState.ImageSize = new System.Drawing.Size(91, 61);
            this.imagebtnTinkov.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.imagebtnTinkov.Image = ((System.Drawing.Image)(resources.GetObject("imagebtnTinkov.Image")));
            this.imagebtnTinkov.ImageOffset = new System.Drawing.Point(0, 0);
            this.imagebtnTinkov.ImageRotate = 0F;
            this.imagebtnTinkov.ImageSize = new System.Drawing.Size(81, 51);
            this.imagebtnTinkov.Location = new System.Drawing.Point(467, 47);
            this.imagebtnTinkov.Name = "imagebtnTinkov";
            this.imagebtnTinkov.PressedState.ImageSize = new System.Drawing.Size(81, 51);
            this.imagebtnTinkov.ShadowDecoration.BorderRadius = 10;
            this.imagebtnTinkov.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imagebtnTinkov.Size = new System.Drawing.Size(108, 67);
            this.imagebtnTinkov.TabIndex = 0;
            this.imagebtnTinkov.CheckedChanged += new System.EventHandler(this.imagebtnTinkov_CheckedChanged);
            // 
            // imagebtnSberbank
            // 
            this.imagebtnSberbank.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.imagebtnSberbank.CheckedState.ImageSize = new System.Drawing.Size(91, 61);
            this.imagebtnSberbank.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.imagebtnSberbank.Image = ((System.Drawing.Image)(resources.GetObject("imagebtnSberbank.Image")));
            this.imagebtnSberbank.ImageOffset = new System.Drawing.Point(0, 0);
            this.imagebtnSberbank.ImageRotate = 0F;
            this.imagebtnSberbank.ImageSize = new System.Drawing.Size(81, 51);
            this.imagebtnSberbank.Location = new System.Drawing.Point(259, 47);
            this.imagebtnSberbank.Name = "imagebtnSberbank";
            this.imagebtnSberbank.PressedState.ImageSize = new System.Drawing.Size(81, 51);
            this.imagebtnSberbank.ShadowDecoration.BorderRadius = 10;
            this.imagebtnSberbank.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imagebtnSberbank.Size = new System.Drawing.Size(108, 67);
            this.imagebtnSberbank.TabIndex = 0;
            this.imagebtnSberbank.CheckedChanged += new System.EventHandler(this.imagebtnSberbank_CheckedChanged);
            // 
            // imgbtnVTB
            // 
            this.imgbtnVTB.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.imgbtnVTB.CheckedState.ImageSize = new System.Drawing.Size(91, 61);
            this.imgbtnVTB.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.imgbtnVTB.Image = ((System.Drawing.Image)(resources.GetObject("imgbtnVTB.Image")));
            this.imgbtnVTB.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgbtnVTB.ImageRotate = 0F;
            this.imgbtnVTB.ImageSize = new System.Drawing.Size(81, 51);
            this.imgbtnVTB.Location = new System.Drawing.Point(40, 47);
            this.imgbtnVTB.Name = "imgbtnVTB";
            this.imgbtnVTB.PressedState.ImageSize = new System.Drawing.Size(81, 51);
            this.imgbtnVTB.ShadowDecoration.BorderRadius = 10;
            this.imgbtnVTB.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgbtnVTB.Size = new System.Drawing.Size(108, 67);
            this.imgbtnVTB.TabIndex = 0;
            this.imgbtnVTB.CheckedChanged += new System.EventHandler(this.imgbtnVTB_CheckedChanged);
            // 
            // lblNameBank
            // 
            this.lblNameBank.AutoSize = true;
            this.lblNameBank.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameBank.Location = new System.Drawing.Point(35, 32);
            this.lblNameBank.Name = "lblNameBank";
            this.lblNameBank.Size = new System.Drawing.Size(135, 19);
            this.lblNameBank.TabIndex = 0;
            this.lblNameBank.Text = "Название Банка";
            // 
            // txbNumberCard
            // 
            this.txbNumberCard.Animated = true;
            this.txbNumberCard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNumberCard.DefaultText = "";
            this.txbNumberCard.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbNumberCard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbNumberCard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNumberCard.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNumberCard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(41)))), ((int)(((byte)(100)))));
            this.txbNumberCard.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNumberCard.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbNumberCard.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNumberCard.Location = new System.Drawing.Point(100, 99);
            this.txbNumberCard.Name = "txbNumberCard";
            this.txbNumberCard.PasswordChar = '\0';
            this.txbNumberCard.PlaceholderText = "";
            this.txbNumberCard.SelectedText = "";
            this.txbNumberCard.Size = new System.Drawing.Size(311, 40);
            this.txbNumberCard.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txbNumberCard.TabIndex = 1;
            // 
            // txbTopBalance
            // 
            this.txbTopBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbTopBalance.DefaultText = "";
            this.txbTopBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbTopBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbTopBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTopBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbTopBalance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbTopBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTopBalance.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbTopBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbTopBalance.Location = new System.Drawing.Point(176, 32);
            this.txbTopBalance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTopBalance.Name = "txbTopBalance";
            this.txbTopBalance.PasswordChar = '\0';
            this.txbTopBalance.PlaceholderText = "Сумма пополнения";
            this.txbTopBalance.SelectedText = "";
            this.txbTopBalance.Size = new System.Drawing.Size(293, 46);
            this.txbTopBalance.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txbTopBalance.TabIndex = 2;
            // 
            // btnTopBalance
            // 
            this.btnTopBalance.Animated = true;
            this.btnTopBalance.AutoRoundedCorners = true;
            this.btnTopBalance.BorderRadius = 21;
            this.btnTopBalance.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTopBalance.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTopBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTopBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTopBalance.Font = new System.Drawing.Font("JetBrains Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTopBalance.ForeColor = System.Drawing.Color.White;
            this.btnTopBalance.Location = new System.Drawing.Point(266, 120);
            this.btnTopBalance.Name = "btnTopBalance";
            this.btnTopBalance.Size = new System.Drawing.Size(132, 45);
            this.btnTopBalance.TabIndex = 3;
            this.btnTopBalance.Text = "Пополнить";
            this.btnTopBalance.Click += new System.EventHandler(this.btnTopBalance_Click);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseForm.FillColor = System.Drawing.Color.Transparent;
            this.btnCloseForm.IconColor = System.Drawing.Color.White;
            this.btnCloseForm.Location = new System.Drawing.Point(570, 0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(45, 41);
            this.btnCloseForm.TabIndex = 1;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.Transparent;
            this.pnlFooter.Controls.Add(this.btnTopBalance);
            this.pnlFooter.Controls.Add(this.txbTopBalance);
            this.pnlFooter.Controls.Add(this.ProggressBar);
            this.pnlFooter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(70)))));
            this.pnlFooter.Location = new System.Drawing.Point(-7, 468);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Radius = 5;
            this.pnlFooter.ShadowColor = System.Drawing.Color.Black;
            this.pnlFooter.Size = new System.Drawing.Size(629, 248);
            this.pnlFooter.TabIndex = 2;
            // 
            // pnlCloseForm
            // 
            this.pnlCloseForm.Controls.Add(this.btnCloseForm);
            this.pnlCloseForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCloseForm.Location = new System.Drawing.Point(0, 0);
            this.pnlCloseForm.Name = "pnlCloseForm";
            this.pnlCloseForm.Size = new System.Drawing.Size(615, 41);
            this.pnlCloseForm.TabIndex = 2;
            // 
            // txbNameUser
            // 
            this.txbNameUser.Animated = true;
            this.txbNameUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbNameUser.DefaultText = "";
            this.txbNameUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbNameUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbNameUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNameUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbNameUser.FillColor = System.Drawing.Color.DimGray;
            this.txbNameUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNameUser.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbNameUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbNameUser.Location = new System.Drawing.Point(28, 225);
            this.txbNameUser.Name = "txbNameUser";
            this.txbNameUser.PasswordChar = '\0';
            this.txbNameUser.PlaceholderText = "";
            this.txbNameUser.SelectedText = "";
            this.txbNameUser.Size = new System.Drawing.Size(206, 32);
            this.txbNameUser.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txbNameUser.TabIndex = 1;
            // 
            // txbActionCard
            // 
            this.txbActionCard.Animated = true;
            this.txbActionCard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbActionCard.DefaultText = "";
            this.txbActionCard.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txbActionCard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txbActionCard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbActionCard.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txbActionCard.FillColor = System.Drawing.Color.DimGray;
            this.txbActionCard.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbActionCard.Font = new System.Drawing.Font("JetBrains Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txbActionCard.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txbActionCard.Location = new System.Drawing.Point(100, 186);
            this.txbActionCard.Name = "txbActionCard";
            this.txbActionCard.PasswordChar = '\0';
            this.txbActionCard.PlaceholderText = "";
            this.txbActionCard.SelectedText = "";
            this.txbActionCard.Size = new System.Drawing.Size(133, 32);
            this.txbActionCard.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txbActionCard.TabIndex = 1;
            // 
            // lblTypeCard
            // 
            this.lblTypeCard.AutoSize = true;
            this.lblTypeCard.Font = new System.Drawing.Font("JetBrains Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTypeCard.Location = new System.Drawing.Point(374, 215);
            this.lblTypeCard.Name = "lblTypeCard";
            this.lblTypeCard.Size = new System.Drawing.Size(95, 43);
            this.lblTypeCard.TabIndex = 0;
            this.lblTypeCard.Text = "VISA";
            // 
            // pcbAttachCard
            // 
            this.pcbAttachCard.Image = ((System.Drawing.Image)(resources.GetObject("pcbAttachCard.Image")));
            this.pcbAttachCard.ImageRotate = 0F;
            this.pcbAttachCard.Location = new System.Drawing.Point(412, 32);
            this.pcbAttachCard.Name = "pcbAttachCard";
            this.pcbAttachCard.Size = new System.Drawing.Size(57, 50);
            this.pcbAttachCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAttachCard.TabIndex = 2;
            this.pcbAttachCard.TabStop = false;
            // 
            // ProggressBar
            // 
            this.ProggressBar.BackColor = System.Drawing.Color.Transparent;
            this.ProggressBar.Location = new System.Drawing.Point(284, 108);
            this.ProggressBar.Name = "ProggressBar";
            this.ProggressBar.Size = new System.Drawing.Size(90, 90);
            this.ProggressBar.TabIndex = 3;
            this.ProggressBar.Visible = false;
            // 
            // AddBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(615, 712);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBalanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBalanceForm";
            this.Load += new System.EventHandler(this.AddBalanceForm_Load);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlCloseForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbAttachCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlHeader;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlCard;
        private Guna.UI2.WinForms.Guna2ImageRadioButton imgbtnVTB;
        private Guna.UI2.WinForms.Guna2ImageRadioButton imagebtnTinkov;
        private Guna.UI2.WinForms.Guna2ImageRadioButton imagebtnSberbank;
        private System.Windows.Forms.Label lblNameBank;
        private Guna.UI2.WinForms.Guna2Button btnTopBalance;
        private Guna.UI2.WinForms.Guna2TextBox txbTopBalance;
        private Guna.UI2.WinForms.Guna2TextBox txbNumberCard;
        private Guna.UI2.WinForms.Guna2ControlBox btnCloseForm;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlFooter;
        private Guna.UI2.WinForms.Guna2Panel pnlCloseForm;
        private Guna.UI2.WinForms.Guna2TextBox txbActionCard;
        private Guna.UI2.WinForms.Guna2TextBox txbNameUser;
        private System.Windows.Forms.Label lblTypeCard;
        private Guna.UI2.WinForms.Guna2PictureBox pcbAttachCard;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator ProggressBar;
    }
}