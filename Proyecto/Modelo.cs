using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using Org.BouncyCastle.Utilities.Collections;

namespace Modelo
{
    class Familia
    {
        public int idfamilia { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string parentesco { get; set; }
        public string ocupacion { get; set; }


        public DataTable llenarFamilia()
        {
            MySqlConnection cnx = new MySqlConnection("server=10.120.2.123;userid=alumn517;password=Alumno2022;database=repo_517"); //ServerName: win2016-01
            MySqlCommand instuccion = new MySqlCommand();
            instuccion.Connection = cnx;


            //Tabla
            cnx.Open();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            instuccion.CommandText = "select * from familia";
            Adapter.SelectCommand = instuccion;
            DataSet SetDatos = new DataSet();
            Adapter.Fill(SetDatos);
            DataTable Tabla = new DataTable();
            Tabla = SetDatos.Tables[0];
            cnx.Close();


            return Tabla;
        }

        public void eliminarFamilia(string pId)
        {
            MySqlConnection cnx = new MySqlConnection("server=10.120.2.123;userid=alumn517;password=Alumno2022;database=repo_517");
            MySqlCommand instruccion = new MySqlCommand();
            instruccion.Connection = cnx;
            cnx.Open();
            
            instruccion.CommandText = "delete from familia  where idfamilia = '" + pId + "'";
            instruccion.ExecuteNonQuery();
            cnx.Close();

            //MessageBox.Show(pId);
        }

        public void agregarFamilia(Familia pFlia)
        {
          //  MessageBox.Show(pFlia.nombre);
            
            
            string textoRecibido = pFlia.nombre + " " + pFlia.apellido + " " + pFlia.ocupacion + " " + pFlia.parentesco;


            MySqlConnection cnx = new MySqlConnection("server=10.120.2.123;userid=alumn517;password=Alumno2022;database=repo_517");
            MySqlCommand instruccion = new MySqlCommand();
            instruccion.Connection = cnx;
            cnx.Open();

            instruccion.CommandText = "insert into familia(nombre, apellido, parentesco, ocupacion) values('" + pFlia.nombre + "', '" + pFlia.apellido + "', '" + pFlia.parentesco + "', '" + pFlia.ocupacion + "')";


           // "delete from familia  where idfamilia = '" + pId + "'";

            
            instruccion.ExecuteNonQuery();
            cnx.Close();

            
            

            /*
             hacer todo para insertar en la BD
             */
            
        }

        public Familia obtenerFamilia(string pIdFamilia)
        {

            MySqlConnection cnx = new MySqlConnection("server=10.120.2.123;userid=alumn517;password=Alumno2022;database=repo_517"); //ServerName: win2016-01
            MySqlCommand instuccion = new MySqlCommand();
            instuccion.Connection = cnx;


            //Tabla
            cnx.Open();
            MySqlDataAdapter Adapter = new MySqlDataAdapter();
            instuccion.CommandText = "select * from familia where idfamilia = '" + pIdFamilia + "'";
            Adapter.SelectCommand = instuccion;
            DataSet SetDatos = new DataSet();
            Adapter.Fill(SetDatos);
            DataTable Tabla = new DataTable();
            Tabla = SetDatos.Tables[0];
            cnx.Close();

            

           // MessageBox.Show(Tabla.Rows[0][4].ToString());
            this.nombre = Tabla.Rows[0][1].ToString();
            this.apellido = Tabla.Rows[0][2].ToString();
            // this.idfamilia = Convert.ToInt32(pIdFamilia);
            this.ocupacion = Tabla.Rows[0][4].ToString();
            this.parentesco = Tabla.Rows[0][3].ToString();

            return this;
        }

        public void actualizarFamilia(Familia pFlia, string IdFamilia)
        {


            MySqlConnection cnx = new MySqlConnection("server=10.120.2.123;userid=alumn517;password=Alumno2022;database=repo_517");
            MySqlCommand instruccion = new MySqlCommand();
            instruccion.Connection = cnx;
            cnx.Open();

            instruccion.CommandText = "update familia set nombre = '"+ pFlia.nombre +"', apellido = '"+ pFlia.apellido +"', parentesco = '"+ pFlia.parentesco +"', ocupacion = '"+ pFlia.ocupacion +"' where idfamilia = '"+ IdFamilia +"'";


            instruccion.ExecuteNonQuery();
            cnx.Close();

        }
    }
}
