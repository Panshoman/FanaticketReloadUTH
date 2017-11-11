using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace fanaticketReload_Desktop
{
    public partial class Saludo : Form
    {
        public bool NuevaInstancia;
        public Saludo()
        {
            InitializeComponent();
            timer1.Start();
            //if (comprobar() == true)
            //{
            //    this.Close();
            //}
        }

        private void Saludo_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.instance.Show();
            this.Hide();
            timer1.Stop();
        }

        //private bool comprobar()
        //{
        //    Mutex m = new Mutex(true, "fanaticketReload_Desktop", out NuevaInstancia);

        //    if (!NuevaInstancia)
        //    {
        //        //Ya se esta ejecutando el programa
        //        MessageBox.Show("Solo una Instancia a la vez.");
        //        GC.KeepAlive(m);
        //        return true;
        //    }
        //    else
        //    {
        //        GC.KeepAlive(m);
        //        return false;
        //    }
        //}
    }
}
