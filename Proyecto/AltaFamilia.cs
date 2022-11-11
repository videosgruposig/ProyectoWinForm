﻿using Modelo;
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
        public AltaFamilia()
        {
            InitializeComponent();
        }

        private void AltaFamilia_Load(object sender, EventArgs e)
        {

        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            flia.nombre = txtNombre.ToString();
            flia.apellido = txtApellido.ToString();
            flia.parentesco = txtParentesco.ToString();
            flia.ocupacion = txtOcupacion.ToString();

            flia.agregarFamilia(flia);

           

            this.Close();

        }
    }
}
