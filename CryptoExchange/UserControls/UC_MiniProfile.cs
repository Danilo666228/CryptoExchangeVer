using CryptoExchange.ConnectDbContext;
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
    public partial class UC_MiniProfile : UserControl
    {
        public UC_MiniProfile()
        {
            InitializeComponent();
        }
        public void FillProfile(int UserId)
        {
            User user = new User();
            lblNameUser.Text = user.GetUserName(UserId);
            lblBalanceUser.Text = user.GetUserBalance(UserId).ToString();
        }

        private void UC_MiniProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
