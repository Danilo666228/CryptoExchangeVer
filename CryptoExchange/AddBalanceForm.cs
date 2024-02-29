using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoExchange
{
    public partial class AddBalanceForm : Form
    {
        public int UserId {  get; set; }
        public AddBalanceForm(int userId)
        {
            InitializeComponent();
            this.UserId = userId;
        }

        private void AddBalanceForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(UserId.ToString());
        }
    }
}
