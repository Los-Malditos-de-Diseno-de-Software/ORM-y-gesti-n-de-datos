namespace OMR_GESTION_DE_DATOS.Capa_de_presentación
{
    partial class Consultas_Básicas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvconsultas = new System.Windows.Forms.DataGridView();
            this.btnempleados = new System.Windows.Forms.Button();
            this.btnregiones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "listar clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(224, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "listar productos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvconsultas
            // 
            this.dgvconsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsultas.Location = new System.Drawing.Point(74, 157);
            this.dgvconsultas.Name = "dgvconsultas";
            this.dgvconsultas.Size = new System.Drawing.Size(890, 342);
            this.dgvconsultas.TabIndex = 2;
            // 
            // btnempleados
            // 
            this.btnempleados.Location = new System.Drawing.Point(385, 106);
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Size = new System.Drawing.Size(112, 23);
            this.btnempleados.TabIndex = 3;
            this.btnempleados.Text = "listar empleados";
            this.btnempleados.UseVisualStyleBackColor = true;
            this.btnempleados.Click += new System.EventHandler(this.btnempleados_Click);
            // 
            // btnregiones
            // 
            this.btnregiones.Location = new System.Drawing.Point(550, 107);
            this.btnregiones.Name = "btnregiones";
            this.btnregiones.Size = new System.Drawing.Size(120, 23);
            this.btnregiones.TabIndex = 5;
            this.btnregiones.Text = "listar regiones";
            this.btnregiones.UseVisualStyleBackColor = true;
            this.btnregiones.Click += new System.EventHandler(this.btnregiones_Click);
            // 
            // Consultas_Básicas
            // 
            this.ClientSize = new System.Drawing.Size(1007, 527);
            this.Controls.Add(this.btnregiones);
            this.Controls.Add(this.btnempleados);
            this.Controls.Add(this.dgvconsultas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Consultas_Básicas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlistar;
        private System.Windows.Forms.Button btnproductos;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvconsultas;
        private System.Windows.Forms.Button btnempleados;
        private System.Windows.Forms.Button btnregiones;
    }
}