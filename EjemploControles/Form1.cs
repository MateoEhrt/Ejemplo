using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploControles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem);

        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboDisponibilidad.Items.Add("Medio tiempo");
            cboDisponibilidad.Items.Add("Tiempo completo");
            cboDisponibilidad.Items.Add("A convenir");      
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            string familiares = ckbFamilia.Checked == true ? " Tiene familiares en la empresa." : " No tiene familiares en la empresa.";
            string estadoCivil;
            if (rbtSoltero.Checked)
                estadoCivil = "Soltero";
            else if (rbtCasado.Checked)
                estadoCivil = "Casado";
            else
                estadoCivil = "Divorciado";
            string disponibilidadHoraria = cboDisponibilidad.SelectedItem.ToString();
            string personasCargo = numPersonas.Value.ToString();

            string mensaje = nombre + " nacio el " + fecha + ". " + familiares + " Esta " + estadoCivil + ". " + "Tiene disponibilidad " + disponibilidadHoraria + ". " + "Y tiene " + personasCargo + " personas a cargo.";
            MessageBox.Show(mensaje);
        }


    }
}
