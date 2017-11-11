using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using libconectaBD;
using libConectaBD;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;
using System.Net;
using System.Data.SqlClient;

namespace libFanaticket
{
    public class Usuarios
    {
        ConectaBD BD = new ConectaBD();
        private DataTable dataSQL;
        public DataTable DataSQL { get => dataSQL; set => dataSQL = value; }
        private MySqlDataReader mdt;
        public MySqlDataReader Mdt { get => mdt; set => mdt = value; }        
        private SqlDataReader sdt;
        public SqlDataReader Sdt { get => sdt; set => sdt = value; }
        private string id;
        private string nick;
        private string pass;
        private string name;
        private string apP;
        private string apM;
        private string tel;
        private string ext;
        private string email;
        private string depa;
        private string nivel;
        private string estatus;
        private string imagen;
        
        private string campos = "nickUsuario, pass, user_name, ap_paterno, ap_materno, telefono, tel_ext, email, nom_depa, nivel, estatus, imagen";
        private string loginNick;
        private string loginNombre;
        private string loginapellidoP;
        private string loginapellifoM;
        private string loginPic;
        private int loginValue;


        public string Id { get => id; set => id = value; }
        public string Nick { get => nick; set => nick = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Name { get => name; set => name = value; }
        public string ApP { get => apP; set => apP = value; }
        public string ApM { get => apM; set => apM = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Ext { get => ext; set => ext = value; }
        public string Email { get => email; set => email = value; }
        public string Depa { get => depa; set => depa = value; }
        public string Nivel { get => nivel; set => nivel = value; }
        public string Estatus { get => estatus; set => estatus = value; }
        public string Imagen { get => imagen; set => imagen = value; }
       
        public string LoginNick { get => loginNick; set => loginNick = value; }
        public string LoginNombre { get => loginNombre; set => loginNombre = value; }
        public string LoginapellidoP { get => loginapellidoP; set => loginapellidoP = value; }
        public string LoginapellifoM { get => loginapellifoM; set => loginapellifoM = value; }
        public string LoginPic { get => loginPic; set => loginPic = value; }
        public int LoginValue { get => loginValue; set => loginValue = value; }
       

        public bool Load()
        {
            BD.Consulta("*", "usuario");
            Mdt = ConectaBD.LectorMYSQL;
            Sdt = ConectaBD.LectorSQL;
            //Data = ConectaBD.Mslq;
            //BD.Datagrid(Mdt, Sdt);
            bool res = true;
            return res;
        }

        public bool LoadDepa()
        {
            BD.Consulta("nom_depa", "departamento");
            //Mdt = ConectaBD.LectorMYSQL;
            //Sdt = ConectaBD.LectorSQL;
           
            bool res = true;
            return res;
        }

        //public bool CrearUsuario()
        //{
        //    string Values = "'" + Nick + "' , '" + Pass + "' , '" + Name + "' , '" + ApP + "' , '" + ApM + "' , '" + Tel + "' , '" + Ext +  "' , '" + Email + "' , '"
        //        + Depa + "', '" + Nivel + "', '" + Estatus + "', '" + imagen + "'";
        //    BD.Crear("usuario", campos, Values);
        //    bool res = true;
        //    return res;
        //}

        //public bool ActualizarUsuario()
        //{
        //   string Values = "nickUsuario = '" + Nick + "' , pass = '" + Pass + "' , user_name = '" + Name + "' , ap_paterno ='" + ApP + "' , ap_materno ='" + ApM + "' , telefono = '" + Tel + "' , tel_ext = '" + Ext + "' , email ='" + Email + "' , nom_depa ='"
        //        + Depa + "', nivel = '" + Nivel + "', estatus = '" + Estatus + "', imagen = '" + imagen + "'"; ;
        //   BD.Update("usuario", Values, "WHERE id_usuario = " + Id);
        //    bool res = true;
        //    return res;
        //}

        //public bool BorrarUsuario()
        //{
        //    return BD.Delete("usuario", "id_usuario = " + Id);
        //}
        //public bool Entrar()
        //{
        //    LoginNick = ConectaBD.nick;
        //    LoginNombre = ConectaBD.nombre;
        //    LoginapellidoP = ConectaBD.ApellidoP;
        //    LoginapellifoM = ConectaBD.ApellidoM;
        //    LoginPic = ConectaBD.pic;
        //    LoginValue = ConectaBD.valor;
        //    bool res = true;
        //    return res;


        //}

        public bool UsuariosActivos()
        {
            BD.Consulta("*", "usuario WHERE estatus = 'ACTIVO'");
            //Mdt = ConectaBD.LectorMYSQL;
            //Sdt = ConectaBD.LectorSQL;
            bool res = true;
            return res;
        }

    }
}
