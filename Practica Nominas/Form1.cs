﻿using System;
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Calcular ARS//

            // Obtener el valor del primer TextBox y convertirlo a double
            if (double.TryParse(txtsueldo.Text, out double numero))
            {
                // Multiplicar el número por 0.3
                double resultado = numero * 0.3 / 100;

                // Mostrar el resultado en el segundo TextBox
                txtars.Text = resultado.ToString();
            }
            else
            {
                // El valor del primer TextBox no se puede convertir a un número double
                MessageBox.Show("El valor ingresado no es válido.");
            }

            //Calcular AFP//

            // Obtener el valor del primer TextBox y convertirlo a double
            if (double.TryParse(txtsueldo.Text, out double numero2))
            {
                // Multiplicar el número por 0.4
                double resultado2 = numero2 * 0.4 / 100;

                // Mostrar el resultado en el segundo TextBox
                txtafp.Text = resultado2.ToString();
            }


            //Calcular vivienda//

            // Obtener el valor del primer TextBox y convertirlo a double
            if (double.TryParse(txtsueldo.Text, out double numero3))
            {
                // Multiplicar el número por 0.8
                double resultado3 = numero3 * 0.8 / 100;

                // Mostrar el resultado en el segundo TextBox
                txtvivienda.Text = resultado3.ToString();
            }


            // Obtener los valores de los tres TextBox y convertirlos a double
            if (double.TryParse(txtars.Text, out double valor1) &&
                double.TryParse(txtafp.Text, out double valor2) &&
                double.TryParse(txtvivienda.Text, out double valor3)&&
                double.TryParse(txtsueldo.Text, out double valor4))
            {
                // Restar los valores de los tres TextBox
                double resultado = valor4 - valor1 - valor2 - valor3;

                // Mostrar el resultado en otro TextBox
                txtsueldoneto.Text = resultado.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "select Nombre, Cedula, Fecha_Nacimiento, Cargo, Sueldo_Bruto, ARS, AFP, Vivienda, Sueldo_Neto from Empleados where ";
            if (btnbuscar.Text != "")
            {
                query = query + "  ( Cedula like '%" + txtbuscar.Text + "%')";
            }



            Conexion.opoencon();
            SqlCommand cmd = new SqlCommand(query, Conexion.ObtenerConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtgDatos.DataSource = ds.Tables[0];
            Conexion.cerrarcon();
        }
    }
}
