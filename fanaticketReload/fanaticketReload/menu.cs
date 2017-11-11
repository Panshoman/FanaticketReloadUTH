using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fanaticketReload_Desktop
{
    public partial class menu : Form
    {
        private static menu _instance;
        public menu()
        {
            InitializeComponent();
        }

        public menu instance
        {
            get
            {
                if (menu._instance == null)
                {
                    menu._instance = new menu();
                }
                return menu._instance;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.instance.Show();
            this.Hide();
        }

        private void menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu._instance = null;
        }

        private void btnSoporte_Click(object sender, EventArgs e)
        {

        }
    }
}
