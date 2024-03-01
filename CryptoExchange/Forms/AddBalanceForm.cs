using CryptoExchange.ConnectDbContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoExchange
{
    public partial class AddBalanceForm : Form
    {
        public int UserId { get; set; }
        public AddBalanceForm(int userId)
        {
            InitializeComponent();
            this.UserId = userId;

        }

        private void AddBalanceForm_Load(object sender, EventArgs e)
        {

        }

        private void imgbtnVTB_CheckedChanged(object sender, EventArgs e)
        {
            if (imgbtnVTB.Checked)
            {                
                pnlCard.FillColor = Color.FromArgb(10, 41, 115);
                lblNameBank.Text = "ВТБ Банк";
                txbNumberCard.FillColor = Color.FromArgb(10, 41, 100);
                txbNameUser.FillColor = Color.FromArgb(10, 41, 100);
                txbActionCard.FillColor = Color.FromArgb(10, 41, 100);
                txbNumberCard.PlaceholderText = "Введите номер карты";
                txbNameUser.PlaceholderText = "Ваша Фамилия и Отчество";
                txbActionCard.PlaceholderText = "Срок действия";
                pnlCard.Visible = true;
            }
            else
            {
                pnlCard.Visible = false;
            }

        }

        private void imagebtnSberbank_CheckedChanged(object sender, EventArgs e)
        {
            if (imagebtnSberbank.Checked)
            {
                pnlCard.FillColor = Color.FromArgb(2, 158, 66);
                lblNameBank.Text = "CберБанк";
                txbNumberCard.FillColor = Color.FromArgb(2, 158, 90);
                txbNameUser.FillColor = Color.FromArgb(2, 158, 90);
                txbActionCard.FillColor = Color.FromArgb(2, 158, 90);
                txbNumberCard.PlaceholderText = "Введите номер карты";
                txbNameUser.PlaceholderText = "Ваша Фамилия и Отчество";
                txbActionCard.PlaceholderText = "Срок действие";
                pnlCard.Visible = true;
            }
            else
            {
                pnlCard.Visible = false;
            }
        }

        private void imagebtnTinkov_CheckedChanged(object sender, EventArgs e)
        {
            if (imagebtnTinkov.Checked)
            {
                pnlCard.FillColor = Color.FromArgb(255, 222, 45);
                lblNameBank.Text = "Тинькоф";
                txbNumberCard.FillColor = Color.FromArgb(255, 222, 70);
                txbNameUser.FillColor = Color.FromArgb(255, 222, 70);
                txbActionCard.FillColor = Color.FromArgb(255, 222, 70);
                txbNumberCard.PlaceholderText = "Введите номер карты";
                txbNameUser.PlaceholderText = "Ваша Фамилия и Отчество";
                txbActionCard.PlaceholderText = "Срок действие";
                pnlCard.Visible = true;
            }
            else
            {
                pnlCard.Visible = false;
            }
        }

        private async void btnTopBalance_Click(object sender, EventArgs e)
        {
            
            btnTopBalance.Visible = false;
            ProggressBar.Visible = true;
            User user = new User();
            user.UpdateBalance(UserId, Convert.ToDecimal(txbTopBalance.Text));    
            for(int i = 0; i < 10; i++)
            {
                ProggressBar.Start();
                await Task.Delay(500);
            }
            ProggressBar.Stop();
            MessageBox.Show("Оплата прошла успешно");
            this.Hide();
        }
    }
}
