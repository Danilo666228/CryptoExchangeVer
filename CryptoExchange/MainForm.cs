using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoExchange
{
    public partial class MainForm : Form
    {
        private int UserId { get; set; }
        public MainForm(/*int userId*/)
        {
            InitializeComponent();
            //this.UserId = userId;
            
        }

        

        private void MainForm_Activated(object sender, EventArgs e)
        {
            //MiniProfile.FillProfile(UserId);
        }
    }
}
