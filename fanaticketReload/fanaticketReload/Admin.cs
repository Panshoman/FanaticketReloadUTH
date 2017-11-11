using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libConectaBD;
using libFanaticket;
using System.IO;
using libValidaciones;


namespace fanaticketReload_Desktop
{
    public partial class Admin : Form
    {
        libValidaciones.libValidaciones val = new libValidaciones.libValidaciones();
        string ruta = "";
        imagenes img  =new imagenes();
        UsuarioAdmin u = new UsuarioAdmin();        
        private string datos;
        ICrear User;
        IModificar Modificar;        
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Admin()
        {
            InitializeComponent();
            btnAdd.Visible = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
            AddDrag(pictureBox1);
        }

        private void EliminarRepetidos(DataGridView dgv)
        {
            int m = 0;  // Apunta a la fila actual
            int n = dgv.Rows.Count - 1;  // cantidad de filas en el DataGridView
            int k = 0;
            string estaFila, unaFila;

            while (m <= n)
            {
                k = 1;
                estaFila = String.Empty;

                // Relleno la cadena con los datos de toda la fila
                for (int i = 0; i < dgv.Columns.Count -1; i++)
                    estaFila = String.Concat(estaFila, dgv.Rows[m].Cells[i].Value.ToString());

                while (k <= dgv.Rows.Count - 1)
                {
                    unaFila = String.Empty;  // Fila a comparar

                    for (int i = 0; i < dgv.Columns.Count -1; i++)
                        unaFila = String.Concat(unaFila, dgv.Rows[k].Cells[i].Value.ToString());

                    if (String.Compare(estaFila, unaFila) == 0 && k != m)
                    {
                        dgv.Rows.RemoveAt(k); // Si son iguales remuevo unaFila solamente
                        n--;                            // Tamaño actual del DataGridView, al remover disminuye en uno
                        k--;
                    }
                    k++;
                }
                m++;
            }
        }

        private void Lector(DataGridView dgv, IDataReader lector)
        {
            while (lector.Read())
            {
                    dgvUsuarios.Rows.Add(lector.GetString(1),//nick
                                    lector.GetString(2),//pass
                                    lector.GetString(3),//name
                                    lector.GetString(4),//ApP
                                    lector.GetString(5),//ApM
                                    lector.GetString(6),//Tel
                                    lector.GetString(7),//Ext
                                    lector.GetString(8),//Email
                                    lector.GetString(9),//Depa
                                    lector.GetString(10),//dNivel                                    
                                    lector.GetString(11));//Estatus
                                    //lector.GetString(12));//Imagen               
            }            
        }

        private void DatagridDatos()
        {
            dgvUsuarios.Rows.Clear();
            u.Consulta("*", "usuario");
            Lector(dgvUsuarios, u.Sdt);
            Lector(dgvUsuarios, u.Mdt);
            Lector(dgvUsuarios, u.Pdt);
            EliminarRepetidos(dgvUsuarios);
        }


        private void Admin_Load(object sender, EventArgs e)
        {
            DatagridDatos();
            for (int i = 101; i < 136; i++)
            {
                cbExt.Items.Add(i);
            }
            timer1.Start();
            txbNick.Enabled = false; txbName.Enabled = false; txbTel.Enabled = false; txbApP.Enabled = false;
            txbCorreo.Enabled = false; cbDepa.Enabled = false; 
            cbExt.Enabled = false; cbStatus.Enabled = false; cbNivel.Enabled = false; pbUser.Enabled = false;
            stsName.Text = "Usuario : " + Environment.UserName;
            stsArea.Text = "Ubicación: " + Environment.MachineName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User = new UsuarioAdmin();
            ActualizarDatos();
            datos = u.LlenadoDatos();
            User.Crear(datos);
            img.Registrar_foto(pbUser, txbNick.Text);
            DatagridDatos();
            MessageBox.Show("Usuario creado correctamente.",
                    "AGREGADO", MessageBoxButtons.OK, MessageBoxIcon.Information);//ventana de error con diseño
            txbNick.Clear(); txbName.Clear(); txbTel.Clear(); txbApP.Clear(); txbCorreo.Clear(); TxbPass.Clear();txbApM.Clear();
            cbDepa.Text = null; cbExt.Text = null; cbStatus.Text = null; cbNivel.Text = null;
            pbUser.Image = BackgroundImage;          
            txbNick.Enabled = false; txbName.Enabled = false; txbTel.Enabled = false; txbApP.Enabled = false;
            txbCorreo.Enabled = false; cbDepa.Enabled = false;
            cbExt.Enabled = false; cbStatus.Enabled = false; cbNivel.Enabled = false; dgvUsuarios.Enabled = true;
            pbUser.Enabled = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User = new UsuarioAdmin();            
            u.Nick = txbNick.Text;
            DialogResult dialogResult = MessageBox.Show("Realmente desea borrar a '" + u.Nick + "'?",
                             "CERRARA LA VENTANA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                User.Delete(u.Nick);
                DatagridDatos();
            }
            txbNick.Clear(); txbName.Clear(); txbTel.Clear(); txbApP.Clear(); txbCorreo.Clear(); TxbPass.Clear(); txbApM.Clear();
            cbDepa.Text = null; cbExt.Text = null; cbStatus.Text = null; cbNivel.Text = null; 
            pbUser.Image = BackgroundImage;            
            txbNick.Enabled = false; txbName.Enabled = false; txbTel.Enabled = false; txbApP.Enabled = false;
            txbCorreo.Enabled = false; cbDepa.Enabled = false; 
            cbExt.Enabled = false; cbStatus.Enabled = false; cbNivel.Enabled = false;
            dgvUsuarios.Enabled = true; pbUser.Enabled = false;
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pbUser.Image = BackgroundImage;
            if (e.RowIndex < 0)
            {
                e.RowIndex.Equals(0);
            }
            else
            {
                u.Nick = txbNick.Text = dgvUsuarios[0, e.RowIndex].Value.ToString();
                u.Pass = TxbPass.Text = dgvUsuarios[1, e.RowIndex].Value.ToString();
                u.Name = txbName.Text = dgvUsuarios[2, e.RowIndex].Value.ToString();
                u.ApP = txbApP.Text = dgvUsuarios[3, e.RowIndex].Value.ToString();
                u.ApM = txbApM.Text = dgvUsuarios[4, e.RowIndex].Value.ToString();
                u.Tel = txbTel.Text = dgvUsuarios[5, e.RowIndex].Value.ToString();
                u.Ext = cbExt.Text = dgvUsuarios[6, e.RowIndex].Value.ToString();
                u.Email = txbCorreo.Text = dgvUsuarios[7, e.RowIndex].Value.ToString();
                u.Depa = cbDepa.Text = dgvUsuarios[8, e.RowIndex].Value.ToString();
                u.Nivel = cbNivel.Text = dgvUsuarios[9, e.RowIndex].Value.ToString();
                u.Estatus = cbStatus.Text = dgvUsuarios[10, e.RowIndex].Value.ToString();
                try
                {
                    img.Recuperar_foto(pbUser, u.Nick);
                }
                catch (Exception)
                {
                    pbUser.Image = BackgroundImage;
                    MessageBox.Show("No cuenta con fotografia almacenada.",
                    "AGREGADO", MessageBoxButtons.OK, MessageBoxIcon.Information);//ventana de error con diseño 
                }
                datos = u.LlenadoDatos();
            }
        }

        private void ActualizarDatos()
        {
            u.Nick = txbNick.Text;
            u.Pass = TxbPass.Text;
            u.Name = txbName.Text;
            u.ApP = txbApP.Text;
            u.ApM = txbApM.Text;
            u.Tel = txbTel.Text;
            u.Ext = cbExt.Text;
            u.Email = txbCorreo.Text;
            u.Depa = cbDepa.Text;
            u.Nivel = cbNivel.Text;
            u.Estatus = cbStatus.Text; 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Modificar = new UsuarioSoporte();
            ActualizarDatos();
            datos = u.UpdateDatos();
            Modificar.Update(datos, u.Nick);
            try{img.Registrar_foto(pbUser, txbNick.Text);}
            catch (Exception){ MessageBox.Show("No se pudo Agregar la foto"); }            
            MessageBox.Show("Usuario creado correctamente.",
                    "AGREGADO", MessageBoxButtons.OK, MessageBoxIcon.Information);//ventana de error con diseño    
            DatagridDatos();
            txbNick.Clear(); txbName.Clear(); txbTel.Clear(); txbApP.Clear(); txbCorreo.Clear();
            cbDepa.Text = null; cbExt.Text = null; cbStatus.Text = null; cbNivel.Text = null;                        
            txbNick.Enabled = false; txbName.Enabled = false; txbTel.Enabled = false; txbApP.Enabled = false;
            txbCorreo.Enabled = false; cbDepa.Enabled = false; 
            cbExt.Enabled = false; cbStatus.Enabled = false; cbNivel.Enabled = false;
            dgvUsuarios.Enabled = true; pbUser.Enabled = false;
        }

        private void pbUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileImaPic = new OpenFileDialog(); 
            ruta = ruta.Replace(@"\", @"\\");
            openFileImaPic.Title = "Seleccione la imagen del Usuario"; //titulo del cuadro de dialogo
            openFileImaPic.FileName = ""; //nombre de archivo default
            openFileImaPic.Filter = "Imagenes (*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif"; //extenciones soportadas
            openFileImaPic.ShowDialog(); //lanza cuadro de dialogo abrir
            ruta = openFileImaPic.FileName; //obtiene la ruta
            if (File.Exists(ruta)) //verificar si existe la imagen
            {
                pbUser.Image = Image.FromFile(ruta); //ruta de imagen cargada
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            menu mn = new menu();
            mn.instance.Show();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Buttons(false);
            dgvUsuarios.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stsTime.Text = System.DateTime.Now.ToString();
        }
        private void AddDrag(Control Control) { Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown); }
        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                // Checks if Y = 0, if so maximize the form
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }

        private void Botones(Control ctrl, bool dgv, bool estado, bool estado2)
        {
            //botones ejecutar accion
            btnAdd1.Visible = estado; btnUpdate1.Visible = estado; btnDelete1.Visible = estado; btnCancel.Visible = estado2;

            txbNick.Clear(); txbName.Clear(); txbTel.Clear(); txbApP.Clear(); txbCorreo.Clear(); TxbPass.Clear(); txbApM.Clear();
            cbDepa.Text = null; cbExt.Text = null; cbStatus.Text = null; cbNivel.SelectedIndex = 2;

            txbNick.Enabled = estado2; txbName.Enabled = estado2; txbTel.Enabled = estado2; txbApP.Enabled = estado2;
            txbCorreo.Enabled = estado2; cbDepa.Enabled = estado2; cbExt.Enabled = estado2; 
            cbStatus.Enabled = estado2; cbNivel.Enabled = estado2; dgvUsuarios.Enabled = estado2; pbUser.Enabled = estado2;
            
            ctrl.Visible = true;
            dgvUsuarios.Enabled = dgv;
        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            Botones(btnAdd, false, false, true);
            pbUser.Image = BackgroundImage;
            txbNick.Focus();
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            Botones(btnUpdate, true, false, true);
            pbUser.Image = BackgroundImage;
            txbNick.Focus();
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            Botones(btnDelete, true, false, false);
            btnCancel.Visible = true;
            pbUser.Image = BackgroundImage;
        }

        private void Buttons(bool estado)
        {
            btnAdd.Visible = estado;
            btnUpdate.Visible = estado;
            btnDelete.Visible = estado;            
            btnAdd1.Visible = true;
            btnUpdate1.Visible = true;
            btnDelete1.Visible = true;
            btnCancel.Visible = false;
        }
        
        private void txbNick_Leave(object sender, EventArgs e)
        {
            if (libValidaciones.libValidaciones.NombrePersonal(txbNick.Text))
            {                
                txbNick.CharacterCasing = CharacterCasing.Upper;
                errorProvider1.SetError(txbNick, "");
            }
            else
            {
                txbNick.Focus();
                txbNick.SelectAll();
                errorProvider1.SetError(txbNick, "La primera letra debe ser mayuscula.");                
            }
        }

        private void txbName_Leave(object sender, EventArgs e)
        {
            if (libValidaciones.libValidaciones.NombrePersonal(txbName.Text))
            {                
                errorProvider1.SetError(txbName, "");
            }
            else
            {
                txbName.Focus();
                txbName.SelectAll();
                errorProvider1.SetError(txbName, "La primera letra debe ser mayuscula.");
            }
        }

        private void txbApP_Leave(object sender, EventArgs e)
        {
            if (libValidaciones.libValidaciones.NombrePersonal(txbApP.Text))
            {
                errorProvider1.SetError(txbApP, "");
            }
            else
            {
                txbApP.Focus();
                txbApP.SelectAll();
                errorProvider1.SetError(txbApP, "La primera letra debe ser mayuscula.");
            }
        }

        private void txbApM_Leave(object sender, EventArgs e)
        {
            if (libValidaciones.libValidaciones.NombrePersonal(txbApM.Text))
            {
                errorProvider1.SetError(txbApM, "");
            }
            else
            {
                txbApM.Focus();
                txbApM.SelectAll();
                errorProvider1.SetError(txbApM, "La primera letra debe ser mayuscula.");
            }
        }

        private void txbTel_Leave(object sender, EventArgs e)
        {

            if (libValidaciones.libValidaciones.Telefono(txbTel.Text))
            {
                errorProvider1.SetError(txbTel, "");
            }
            else
            {
                txbTel.Focus();
                txbTel.SelectAll();
                errorProvider1.SetError(txbTel, "NO es un numero valido");
            }
        }

        private void txbCorreo_Leave(object sender, EventArgs e)
        {
            if (libValidaciones.libValidaciones.Email(txbCorreo.Text))
            {
                errorProvider1.SetError(txbCorreo, "");
            }
            else
            {
                txbCorreo.Focus();
                txbCorreo.SelectAll();
                errorProvider1.SetError(txbCorreo, "NO cuenta con el Formato correcto usuario@dominio.com");
            }
        }
    }
}
