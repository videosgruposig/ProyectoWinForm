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
        public FormularioFamilia()
        {
            InitializeComponent();
        }

        private void btbCompletar_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Familia familia1 = new Familia();

            dgvFamilia.DataSource = familia1.llenarFamilia();

        }
    }
}
