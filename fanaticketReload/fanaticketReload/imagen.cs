using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace fanaticketReload_Desktop
{
    class imagenes
    {
        #region Registrar Foto
        public void Registrar_foto(PictureBox pb, string id)
        {
            //SqlConnection conectar = new SqlConnection(@"Data Source=PANSHOMAN\SQLEXPRESS;Initial Catalog=fanaticket;User ID=sa;Password=leon");//casa
            //SqlConnection conectar = new SqlConnection("Data Source=172.16.0.52;Initial Catalog=fanaticket;User ID=sa;Password=T4e52017");//Oficina
            SqlConnection conectar = new SqlConnection(@"Data Source=BOLLOS-TEAM\SQLEXPRESS;Initial Catalog=fanaticket;User ID=sa;Password=leon");  //Casa  

            SqlCommand comandos = new SqlCommand
            ("update usuario SET imagen = @Pic where nickUsuario = @Nick", conectar);
            MemoryStream stream = new MemoryStream();
            pb.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] pic = stream.ToArray();
            comandos.Parameters.AddWithValue("@Pic", pic);
            comandos.Parameters.AddWithValue("@Nick", id);
            try
            {
                conectar.Open();
                comandos.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR :" + ex.Message);
            }
            finally
            {
                conectar.Close();
            }
            //MySqlConnection conecta = new MySqlConnection("Server = 127.0.0.1;Database=fanaticket;Uid=root;Pwd=leon");
            //MySqlCommand comando = new MySqlCommand
            //("update usuario SET imagen = @Picc where nickUsuario = @Nicks", conecta);
            //MemoryStream strea = new MemoryStream();
            //pb.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            //byte[] picc = stream.ToArray();
            //comando.Parameters.AddWithValue("@Picc", picc);
            //comando.Parameters.AddWithValue("@Nicks", id);
            //try
            //{
            //    conectar.Open();
            //    comandos.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("ERROR :" + ex.Message);
            //}
            //finally
            //{
            //    conectar.Close();
            //}
        }
            #endregion

            #region Mostrar Foto
            public void Recuperar_foto(PictureBox pb, string Nick)
            {
                //SqlConnection conectar = new SqlConnection(@"Data Source=PANSHOMAN\SQLEXPRESS;Initial Catalog=fanaticket;User ID=sa;Password=leon");//casa
                //SqlConnection conectar = new SqlConnection("Data Source=172.16.0.52;Initial Catalog=fanaticket;User ID=sa;Password=T4e52017");//Oficina/
                SqlConnection conectar = new SqlConnection(@"Data Source=BOLLOS-TEAM\SQLEXPRESS;Initial Catalog=fanaticket;User ID=sa;Password=leon");  //Casa  
                SqlCommand commando = new SqlCommand("select imagen from usuario where nickUsuario = @Nicks", conectar);
                commando.Parameters.AddWithValue("@Nicks", Nick);
                SqlDataAdapter dp = new SqlDataAdapter(commando);
                DataSet ds = new DataSet("Imagenes");
                byte[] Data = new byte[0];
                dp.Fill(ds, "Imagenes");
                DataRow Row;
                Row = ds.Tables["Imagenes"].Rows[0];
                Data = (byte[])Row["imagen"];
                MemoryStream stream = new MemoryStream(Data);
                pb.Image = Image.FromStream(stream);

                //MySqlConnection conecta = new MySqlConnection("Server = 127.0.0.1;Database=fanaticket;Uid=root;Pwd=leon");
                //MySqlCommand command = new MySqlCommand("select imagen from usuario where nickUsuario = @Nick", conecta);
                //command.Parameters.AddWithValue("@Nick", Nick);
                //MySqlDataAdapter dps = new MySqlDataAdapter(command);
                //DataSet dss = new DataSet("Imagenes");
                //byte[] Datas = new byte[0];
                //dps.Fill(dss, "Imagenes");
                //DataRow Rows;
                //Rows = dss.Tables["Imagenes"].Rows[0];
                //Datas = (byte[])Rows["imagen"];
                //MemoryStream strea = new MemoryStream(Datas);
                //pb.Image = Image.FromStream(strea);
            }        
        #endregion
    }
}
