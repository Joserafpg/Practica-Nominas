using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Nominas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datosget Alumno = new Datosget();
            Alumno.Nombre = txtnombre.Text;
            Alumno.Cedula = txtcedula.Text;
            Alumno.Fecha_Nac = txtfecha.Text;
            Alumno.Cargo = txtcargo.Text;
            Alumno.ARS = txtars.Text;
            Alumno.AFP = txtafp.Text;
            Alumno.Vivienda = txtvivienda.Text;
            Alumno.Sueldo_Bruto = txtsueldo.Text;

            int resultado = Datosbasedt.Agregar(Alumno);

            if (resultado > 0)
            {
                MessageBox.Show("Datos Guardados Corerectamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("No se pudieron guardar los datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            txtnombre.Clear();
            txtcedula.Clear();
            txtfecha.Clear();
            txtcargo.ResetText();
            txtars.Clear();
            txtafp.Clear();
            txtvivienda.Clear();
            txtsueldo.Clear();
        }
    }
}
