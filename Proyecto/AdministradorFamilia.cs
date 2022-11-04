using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace Proyecto
{
    public partial class FormularioFamilia : Form
    {
        Familia familia1 = new Familia();

        public FormularioFamilia()
        {
            InitializeComponent();
        }

        private void btbCompletar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            dgvFamilia.DataSource = familia1.llenarFamilia();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idfamilia = dgvFamilia.SelectedCells[0].Value.ToString();
            
            familia1.eliminarFamilia(idfamilia);

            dgvFamilia.DataSource = familia1.llenarFamilia();




        }

        private void dgvFamilia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AltaFamilia altaFamilia = new AltaFamilia();
            altaFamilia.ShowDialog();

        }
    }
}
