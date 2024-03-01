using CryptoExchange.ConnectDbContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace CryptoExchange.UserControls
{
    public partial class UC_MiniProfile : UserControl
    {
        public int UserId {  get; set; }
        public UC_MiniProfile()
        {
            InitializeComponent();
        }

        public void FillProfile(int UserId)
        {
            User user = new User();
            lblNameUser.Text = user.GetUserName(UserId);            
            lblBalanceUser.Text = user.GetUserBalance(UserId).ToString() + " $";
        }

        private void UC_MiniProfile_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBalance_Click(object sender, EventArgs e)
        {
            
            AddBalanceForm addbalance = new AddBalanceForm(UserId);
            addbalance.ShowDialog();
        }
    }
}
