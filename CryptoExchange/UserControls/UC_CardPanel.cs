using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoExchange.UserControls
{
    public partial class UC_CardPanel : UserControl
    {
        public UC_CardPanel()
        {
            InitializeComponent();
            
        }        
        public string NameBank
        {
            get { return lblNameBank.Text; }
            set { lblNameBank.Text = value; }
        }
        public string CVV
        {
            get { return txbCVV.Text; }
            set { txbCVV.Text = value; }
        }
        public string NumberCard
        {
            get { return txbNumberCard.Text; }
            set { txbNumberCard.Text = value; }
        }
        public string ActionCard
        {
            get { return txbActionCard.Text; }
            set { txbActionCard.Text = value; }
        }
        public string NameUserCard
        {
            get { return txbLastName.Text; }
            set { txbLastName.Text = value; }
        }

        public void BlockTextBox()
        {
            txbCVV.Enabled = false;
            txbNumberCard.Enabled = false;
            txbLastName.Enabled = false;
            txbActionCard.Enabled = false;
        }
    }
}