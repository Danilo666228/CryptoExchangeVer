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
            this.pnlHeader = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlCloseForm = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCloseForm = new Guna.UI2.WinForms.Guna2ControlBox();
            this.imagebtnTinkov = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.imagebtnSberbank = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.imgbtnVTB = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.txbTopBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTopBalance = new Guna.UI2.WinForms.Guna2Button();
            this.pnlFooter = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.ProggressBar = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.CardSberbank = new CryptoExchange.UserControls.UC_CardPanel();
            this.CardVTB = new CryptoExchange.UserControls.UC_CardPanel();
            this.CardTinkoff = new CryptoExchange.UserControls.UC_CardPanel();
            this.pnlHeader.SuspendLayout();
            this.pnlCloseForm.SuspendLayout();
            this.pnlFooter.SuspendLayout();
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
            // pnlCloseForm
            // 
            this.pnlCloseForm.Controls.Add(this.btnCloseForm);
            this.pnlCloseForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCloseForm.Location = new System.Drawing.Point(0, 0);
            this.pnlCloseForm.Name = "pnlCloseForm";
            this.pnlCloseForm.Size = new System.Drawing.Size(615, 41);
            this.pnlCloseForm.TabIndex = 2;
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
            // imagebtnTinkov
            // 
            this.imagebtnTinkov.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.imagebtnTinkov.CheckedState.ImageSize = new System.Drawing.Size(110, 71);
            this.imagebtnTinkov.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.imagebtnTinkov.Image = ((System.Drawing.Image)(resources.GetObject("imagebtnTinkov.Image")));
            this.imagebtnTinkov.ImageOffset = new System.Drawing.Point(0, 0);
            this.imagebtnTinkov.ImageRotate = 0F;
            this.imagebtnTinkov.ImageSize = new System.Drawing.Size(100, 61);
            this.imagebtnTinkov.Location = new System.Drawing.Point(467, 47);
            this.imagebtnTinkov.Name = "imagebtnTinkov";
            this.imagebtnTinkov.PressedState.ImageSize = new System.Drawing.Size(81, 51);
            this.imagebtnTinkov.ShadowDecoration.BorderRadius = 10;
            this.imagebtnTinkov.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imagebtnTinkov.Size = new System.Drawing.Size(108, 67);
            this.imagebtnTinkov.TabIndex = 0;
            this.imagebtnTinkov.UseTransparentBackground = true;
            this.imagebtnTinkov.CheckedChanged += new System.EventHandler(this.imagebtnTinkov_CheckedChanged);
            // 
            // imagebtnSberbank
            // 
            this.imagebtnSberbank.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.imagebtnSberbank.CheckedState.ImageSize = new System.Drawing.Size(110, 71);
            this.imagebtnSberbank.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.imagebtnSberbank.Image = ((System.Drawing.Image)(resources.GetObject("imagebtnSberbank.Image")));
            this.imagebtnSberbank.ImageOffset = new System.Drawing.Point(0, 0);
            this.imagebtnSberbank.ImageRotate = 0F;
            this.imagebtnSberbank.ImageSize = new System.Drawing.Size(100, 61);
            this.imagebtnSberbank.Location = new System.Drawing.Point(259, 47);
            this.imagebtnSberbank.Name = "imagebtnSberbank";
            this.imagebtnSberbank.PressedState.ImageSize = new System.Drawing.Size(81, 51);
            this.imagebtnSberbank.ShadowDecoration.BorderRadius = 10;
            this.imagebtnSberbank.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imagebtnSberbank.Size = new System.Drawing.Size(121, 67);
            this.imagebtnSberbank.TabIndex = 0;
            this.imagebtnSberbank.UseTransparentBackground = true;
            this.imagebtnSberbank.CheckedChanged += new System.EventHandler(this.imagebtnSberbank_CheckedChanged);
            // 
            // imgbtnVTB
            // 
            this.imgbtnVTB.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.imgbtnVTB.CheckedState.ImageSize = new System.Drawing.Size(110, 71);
            this.imgbtnVTB.HoverState.ImageSize = new System.Drawing.Size(0, 0);
            this.imgbtnVTB.Image = ((System.Drawing.Image)(resources.GetObject("imgbtnVTB.Image")));
            this.imgbtnVTB.ImageOffset = new System.Drawing.Point(0, 0);
            this.imgbtnVTB.ImageRotate = 0F;
            this.imgbtnVTB.ImageSize = new System.Drawing.Size(100, 61);
            this.imgbtnVTB.Location = new System.Drawing.Point(40, 47);
            this.imgbtnVTB.Name = "imgbtnVTB";
            this.imgbtnVTB.PressedState.ImageSize = new System.Drawing.Size(81, 51);
            this.imgbtnVTB.ShadowDecoration.BorderRadius = 10;
            this.imgbtnVTB.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.imgbtnVTB.Size = new System.Drawing.Size(108, 67);
            this.imgbtnVTB.TabIndex = 0;
            this.imgbtnVTB.UseTransparentBackground = true;
            this.imgbtnVTB.CheckedChanged += new System.EventHandler(this.imgbtnVTB_CheckedChanged);
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
            this.txbTopBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbTopBalance.Visible = false;
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
            this.btnTopBalance.Visible = false;
            this.btnTopBalance.Click += new System.EventHandler(this.btnTopBalance_Click);
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
            // ProggressBar
            // 
            this.ProggressBar.BackColor = System.Drawing.Color.Transparent;
            this.ProggressBar.Location = new System.Drawing.Point(284, 108);
            this.ProggressBar.Name = "ProggressBar";
            this.ProggressBar.Size = new System.Drawing.Size(90, 90);
            this.ProggressBar.TabIndex = 3;
            this.ProggressBar.Visible = false;
            // 
            // CardSberbank
            // 
            this.CardSberbank.ActionCard = "";
            this.CardSberbank.BackColor = System.Drawing.Color.DarkGray;
            this.CardSberbank.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CardSberbank.BackgroundImage")));
            this.CardSberbank.CVV = "";
            this.CardSberbank.Location = new System.Drawing.Point(56, 175);
            this.CardSberbank.Name = "CardSberbank";
            this.CardSberbank.NameBank = "СберБанк";
            this.CardSberbank.NameUserCard = "";
            this.CardSberbank.NumberCard = "";
            this.CardSberbank.Size = new System.Drawing.Size(501, 265);
            this.CardSberbank.TabIndex = 3;
            this.CardSberbank.Visible = false;
            // 
            // CardVTB
            // 
            this.CardVTB.ActionCard = "";
            this.CardVTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(41)))), ((int)(((byte)(115)))));
            this.CardVTB.CVV = "";
            this.CardVTB.Location = new System.Drawing.Point(56, 175);
            this.CardVTB.Name = "CardVTB";
            this.CardVTB.NameBank = "ВТБ";
            this.CardVTB.NameUserCard = "";
            this.CardVTB.NumberCard = "";
            this.CardVTB.Size = new System.Drawing.Size(501, 265);
            this.CardVTB.TabIndex = 4;
            this.CardVTB.Visible = false;
            // 
            // CardTinkoff
            // 
            this.CardTinkoff.ActionCard = "";
            this.CardTinkoff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(45)))));
            this.CardTinkoff.CVV = "";
            this.CardTinkoff.Location = new System.Drawing.Point(56, 175);
            this.CardTinkoff.Name = "CardTinkoff";
            this.CardTinkoff.NameBank = "Тинькофф";
            this.CardTinkoff.NameUserCard = "";
            this.CardTinkoff.NumberCard = "";
            this.CardTinkoff.Size = new System.Drawing.Size(501, 265);
            this.CardTinkoff.TabIndex = 5;
            this.CardTinkoff.Visible = false;
            // 
            // AddBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(615, 712);
            this.Controls.Add(this.CardSberbank);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.CardTinkoff);
            this.Controls.Add(this.CardVTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBalanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBalanceForm";
            this.pnlHeader.ResumeLayout(false);
            this.pnlCloseForm.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlHeader;
        private Guna.UI2.WinForms.Guna2ImageRadioButton imgbtnVTB;
        private Guna.UI2.WinForms.Guna2ImageRadioButton imagebtnTinkov;
        private Guna.UI2.WinForms.Guna2ImageRadioButton imagebtnSberbank;
        private Guna.UI2.WinForms.Guna2Button btnTopBalance;
        private Guna.UI2.WinForms.Guna2TextBox txbTopBalance;
        private Guna.UI2.WinForms.Guna2ControlBox btnCloseForm;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlFooter;
        private Guna.UI2.WinForms.Guna2Panel pnlCloseForm;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator ProggressBar;
        private UserControls.UC_CardPanel CardVTB;
        private UserControls.UC_CardPanel CardSberbank;
        private UserControls.UC_CardPanel CardTinkoff;
    }
}