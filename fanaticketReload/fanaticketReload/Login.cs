using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace fanaticketReload_Desktop
{
    public partial class Login : Form
    {
        private static string id;
        public static string contra;
        public static string idUser;
        public static string contraUser;
        private static bool check;
        private static Login _instance;
        public bool NuevaInstancia;
       

        public Login()
        {
            InitializeComponent();
            txbPass.UseSystemPasswordChar = true;
            //if (comprobar() == true)
            //{
            //    this.Close();
            //}
            
        }

        public Login instance
        {
            get
            {
                if (Login._instance == null)
                {
                    Login._instance = new Login();
                }
                return Login._instance;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            errorProvider1.SetError(txbPass, "");
            if (check)
            {
                txbId.Text = id;
                txbPass.Text = contra;
                checkBox1.Checked = true;
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txbId.Text.Trim() == "" || txbPass.Text.Trim() == "") //verifica que no este vacio
            {
                errorProvider1.SetError(txbPass, "El usuario o contraseña estan en blanco");
                if (txbId.Text.Trim() == "") //vemos cual esta vacio y mandamos el focus al lugar vacio
                {
                    txbId.Focus();
                }
                else
                {
                    txbPass.Focus();
                }
            }
            else
            {

                //if (BD.Login(txbId.Text, txbPass.Text) == true) //verifica estado de acceso para el error
                //{
                //    if (checkBox1.Checked)
                //    {
                //        id = txbId.Text;
                //        contra = txbPass.Text;
                //        check = true;
                //    }
                //    else
                //    {
                //        id = "";
                //        contra = txbPass.Text;
                //        check = false;
                //    }
                //    menu form1 = new menu();
                //    form1.Show();
                //    this.Close();
                //}
                //else
                //{
                //    errorProvider1.SetError(txbPass, "Verifique sus datos, ID o contraseña incorrectas");
                //    txbPass.Clear();//especifica el error
                //    id = "";
                //    contra = "";
                //    check = false;
                //}
                //BD.DesconectarDB();
                menu mn = new menu();
                mn.instance.Show();
                this.Hide();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txbPass.UseSystemPasswordChar = true;
        }

        private void btnShow_MouseDown(object sender, MouseEventArgs e)
        {
            txbPass.UseSystemPasswordChar = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Realmente desea cerrar sesion?",
                             "OJO CHICHARO CON ESTO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login._instance = null;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }

        public static bool getInstance()
        {
            //toma el nombre del proceso actual 
            //que esta corriendo en la aplicacion.

            string currPrsName = Process.GetCurrentProcess().ProcessName;
            
            //toma el nombre de todos los procesos que tienen
            //el mismo nombre a este proceso.      
            Process[] allProcessWithThisName
                         = Process.GetProcessesByName(currPrsName);

            //if more than one process is running return true.
            //si mas de un proceso esta corriendo regresa true.
            //lo que significa que ya existe uns instancia de esta aplicacion            
            if (allProcessWithThisName.Length > 1)
            {
                MessageBox.Show("Solo se puede abrir uno a la vez");
                return true; // ya existe una instancia previa
            }
            else
            {
                return false; //no existe una instancia previa
            }
        }

        private bool comprobar()
        {
            Mutex m = new Mutex(true, "fanaticketReload_Desktop", out NuevaInstancia);

            if (!NuevaInstancia)
            {
                //Ya se esta ejecutando el programa
                MessageBox.Show("Solo una Instancia a la vez.");
                GC.KeepAlive(m);
                return true;
            }
            else
            {
                GC.KeepAlive(m);
                return false;                
            }            
        }
    }
}
