using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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
            MySqlConnection cnx = new MySqlConnection("server=win2016-01;userid=alumn517;password=Alumno2022;database=repo_517");
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
            MessageBox.Show(pId);
        }
    }
}
