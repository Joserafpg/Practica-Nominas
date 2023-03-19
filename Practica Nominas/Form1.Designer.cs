namespace Practica_Nominas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.txtsueldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtars = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtafp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtvivienda = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.MaskedTextBox();
            this.dtgDatos = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtcargo = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsueldoneto = new System.Windows.Forms.TextBox();
            this.txtdescuento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(147, 106);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(200, 20);
            this.txtnombre.TabIndex = 0;
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(147, 137);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(200, 20);
            this.txtcedula.TabIndex = 1;
            // 
            // txtsueldo
            // 
            this.txtsueldo.Location = new System.Drawing.Point(147, 230);
            this.txtsueldo.Name = "txtsueldo";
            this.txtsueldo.Size = new System.Drawing.Size(200, 20);
            this.txtsueldo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Fecha Nacimiento";
            // 
            // txtars
            // 
            this.txtars.Location = new System.Drawing.Point(78, 272);
            this.txtars.Name = "txtars";
            this.txtars.Size = new System.Drawing.Size(57, 20);
            this.txtars.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cargo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Sueldo bruto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "ARS";
            // 
            // txtafp
            // 
            this.txtafp.Location = new System.Drawing.Point(203, 272);
            this.txtafp.Name = "txtafp";
            this.txtafp.Size = new System.Drawing.Size(57, 20);
            this.txtafp.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(170, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "AFP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Vivienda";
            // 
            // txtvivienda
            // 
            this.txtvivienda.Location = new System.Drawing.Point(343, 272);
            this.txtvivienda.Name = "txtvivienda";
            this.txtvivienda.Size = new System.Drawing.Size(57, 20);
            this.txtvivienda.TabIndex = 7;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(147, 168);
            this.txtfecha.Mask = "00/00/0000";
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(200, 20);
            this.txtfecha.TabIndex = 2;
            this.txtfecha.ValidatingType = typeof(System.DateTime);
            // 
            // dtgDatos
            // 
            this.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatos.Location = new System.Drawing.Point(466, 106);
            this.dtgDatos.Name = "dtgDatos";
            this.dtgDatos.Size = new System.Drawing.Size(435, 186);
            this.dtgDatos.TabIndex = 14;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(466, 70);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(185, 20);
            this.txtbuscar.TabIndex = 12;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(679, 67);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(93, 23);
            this.btnbuscar.TabIndex = 13;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(570, 368);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 45);
            this.button3.TabIndex = 11;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtcargo
            // 
            this.txtcargo.FormattingEnabled = true;
            this.txtcargo.Items.AddRange(new object[] {
            "Cajero",
            "Conserjer"});
            this.txtcargo.Location = new System.Drawing.Point(147, 199);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(200, 21);
            this.txtcargo.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(406, 368);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 45);
            this.button4.TabIndex = 10;
            this.button4.Text = "Calcular";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Sueldo NETO";
            // 
            // txtsueldoneto
            // 
            this.txtsueldoneto.Location = new System.Drawing.Point(147, 342);
            this.txtsueldoneto.Name = "txtsueldoneto";
            this.txtsueldoneto.Size = new System.Drawing.Size(200, 20);
            this.txtsueldoneto.TabIndex = 17;
            // 
            // txtdescuento
            // 
            this.txtdescuento.Location = new System.Drawing.Point(147, 308);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.Size = new System.Drawing.Size(200, 20);
            this.txtdescuento.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Descontado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.txtdescuento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtsueldoneto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dtgDatos);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtvivienda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtafp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtars);
            this.Controls.Add(this.txtsueldo);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.txtnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.TextBox txtsueldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtars;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtafp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtvivienda;
        private System.Windows.Forms.MaskedTextBox txtfecha;
        private System.Windows.Forms.DataGridView dtgDatos;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox txtcargo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsueldoneto;
        private System.Windows.Forms.TextBox txtdescuento;
        private System.Windows.Forms.Label label10;
    }
}

