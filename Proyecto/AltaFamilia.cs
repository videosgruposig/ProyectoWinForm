using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class AltaFamilia : Form
    {
        Familia flia = new Familia();
        string nombre = "";
        public AltaFamilia(string pOrigen)
        {
            if (pOrigen == "M")
            {
                nombre = "Probando si funciona";
            }

            InitializeComponent();
        }

        private void AltaFamilia_Load(object sender, EventArgs e)
        {
            txtNombre.Text = nombre;

        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            flia.nombre = txtNombre.Text;
            flia.apellido = txtApellido.Text;
            flia.parentesco = txtParentesco.Text;
            flia.ocupacion = txtOcupacion.Text;

            flia.agregarFamilia(flia);

           

            this.Close();

        }
    }
}
