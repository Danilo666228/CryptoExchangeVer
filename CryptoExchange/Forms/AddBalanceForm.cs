using CryptoExchange.ConnectDbContext;
using CryptoExchange.ValidateUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoExchange
{
    public partial class AddBalanceForm : Form
    {
        Regex TopBalance = new Regex(@"[0-9]");
        public int UserId { get; set; }
        public AddBalanceForm(int userId)
        {
            InitializeComponent();
            this.UserId = userId;

        }
        private void BlockTypeCard()
        {
            imagebtnSberbank.Enabled = false;
            imagebtnTinkov.Enabled = false;
            imgbtnVTB.Enabled = false;
        }
        private void imgbtnVTB_CheckedChanged(object sender, EventArgs e)
        {
            CardVTB.BringToFront();
            CardVTB.Visible = true;
            CardSberbank.Visible = false;
            CardTinkoff.Visible = false;
            txbTopBalance.Visible = true;
            btnTopBalance.Visible = true;

        }

        private void imagebtnSberbank_CheckedChanged(object sender, EventArgs e)
        {
            CardSberbank.BringToFront();
            CardSberbank.Visible = true;
            CardTinkoff.Visible = false;
            CardVTB.Visible = false;
            txbTopBalance.Visible = true;
            btnTopBalance.Visible = true;
        }

        private void imagebtnTinkov_CheckedChanged(object sender, EventArgs e)
        {
            CardTinkoff.BringToFront();
            CardTinkoff.Visible = true;
            CardVTB.Visible = false;
            CardSberbank.Visible = false;
            txbTopBalance.Visible = true;
            btnTopBalance.Visible = true;
        }

        private async void btnTopBalance_Click(object sender, EventArgs e)
        {

            Validate validate = new Validate();
            if(validate.ValidateCard(CardVTB.CVV,CardVTB.NumberCard,CardVTB.NameUserCard,CardVTB.ActionCard,CardVTB) == false)
            {
                return;
            }
            if(validate.ValidateCard(CardSberbank.CVV, CardSberbank.NumberCard, CardSberbank.NameUserCard, CardSberbank.ActionCard, CardSberbank) == false)
            {
                return;
            }
            if(validate.ValidateCard(CardTinkoff.CVV, CardTinkoff.NumberCard, CardTinkoff.NameUserCard, CardTinkoff.ActionCard, CardTinkoff) == false)
            {
                return;
            }
            if(!TopBalance.IsMatch(txbTopBalance.Text))
            {
                MessageBox.Show("Введите корректные данные");
                return;
            }
            else
            {
                BlockTypeCard();
                CardVTB.BlockTextBox();
                CardSberbank.BlockTextBox();
                CardTinkoff.BlockTextBox();
                CardVTB.BlockTextBox();
                btnTopBalance.Visible = false;
                ProggressBar.Visible = true;
                User user = new User();
                for (int i = 0; i < 7; i++)
                {
                    ProggressBar.Start();
                    await Task.Delay(500);
                }
                user.UpdateBalance(UserId, Convert.ToDecimal(txbTopBalance.Text));
                ProggressBar.Stop();
                this.Hide();
                MessageBox.Show("Оплата прошла успешно");
            }
        }
    }
}
