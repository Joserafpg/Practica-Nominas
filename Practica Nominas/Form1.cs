using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            Alumno.Sueldo_Bruto = txtsueldo.Text;
            Alumno.ARS = txtars.Text;
            Alumno.AFP = txtafp.Text;
            Alumno.Vivienda = txtvivienda.Text;
            Alumno.Descuento = txtdescuento.Text;
            Alumno.Sueldo_Neto = txtsueldoneto.Text;

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
            txtsueldoneto.Clear();
            txtdescuento.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Calcular ARS//          
            if (double.TryParse(txtsueldo.Text, out double numero))
            {
                double resultado = numero * 0.3 / 100;

                txtars.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("El valor ingresado no es válido.");
            }

            //Calcular AFP//
            if (double.TryParse(txtsueldo.Text, out double numero2))
            {
                double resultado2 = numero2 * 0.4 / 100;

                txtafp.Text = resultado2.ToString();
            }


            //Calcular vivienda//
            if (double.TryParse(txtsueldo.Text, out double numero3))
            {
                double resultado3 = numero3 * 0.8 / 100;

                txtvivienda.Text = resultado3.ToString();
            }

            //Calcular el descuento//
            if (double.TryParse(txtars.Text, out double suma1) &&
               double.TryParse(txtafp.Text, out double suma2) &&
               double.TryParse(txtvivienda.Text, out double suma3))
            {
                double resultado = suma1 + suma2 + suma3 ;

                txtdescuento.Text = resultado.ToString();
            }


            // Obtener los valores de los tres TextBox y convertirlos a double
            if (decimal.TryParse(txtsueldo.Text, out decimal valor4) &&
                decimal.TryParse(txtdescuento.Text, out decimal valor5))
            {
                // Restar los valores de los tres TextBox
                decimal resultado = valor4 - valor5;

                // Mostrar el resultado en otro TextBox
                txtsueldoneto.Text = resultado.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "select Nombre, Cedula, Fecha_Nacimiento, Cargo, Sueldo_Bruto, ARS, AFP, Vivienda, Descuento, Sueldo_Neto from Empleados where ";
            if (btnbuscar.Text != "")
            {
                query = query + "(Nombre Like '%" + txtbuscar.Text + "%' or Cedula Like '%" + txtbuscar.Text + "%')";
            }

            Conexion.opoencon();
            SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtgDatos.DataSource = ds.Tables[0];
            Conexion.cerrarcon();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
