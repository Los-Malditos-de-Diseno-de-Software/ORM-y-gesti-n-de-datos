namespace OMR_GESTION_DE_DATOS.Consultas_Pubs
{
    partial class Consultas_basicas
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
            this.btnautores = new System.Windows.Forms.Button();
            this.btnempleados = new System.Windows.Forms.Button();
            this.btntiendas = new System.Windows.Forms.Button();
            this.btnventas = new System.Windows.Forms.Button();
            this.dgvconsultas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnautores
            // 
            this.btnautores.Location = new System.Drawing.Point(135, 73);
            this.btnautores.Name = "btnautores";
            this.btnautores.Size = new System.Drawing.Size(75, 23);
            this.btnautores.TabIndex = 0;
            this.btnautores.Text = "listar autores";
            this.btnautores.UseVisualStyleBackColor = true;
            this.btnautores.Click += new System.EventHandler(this.btnautores_Click);
            // 
            // btnempleados
            // 
            this.btnempleados.Location = new System.Drawing.Point(287, 72);
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Size = new System.Drawing.Size(91, 23);
            this.btnempleados.TabIndex = 1;
            this.btnempleados.Text = "listar empleados";
            this.btnempleados.UseVisualStyleBackColor = true;
            // 
            // btntiendas
            // 
            this.btntiendas.Location = new System.Drawing.Point(427, 73);
            this.btntiendas.Name = "btntiendas";
            this.btntiendas.Size = new System.Drawing.Size(75, 23);
            this.btntiendas.TabIndex = 2;
            this.btntiendas.Text = "listar tiendas";
            this.btntiendas.UseVisualStyleBackColor = true;
            // 
            // btnventas
            // 
            this.btnventas.Location = new System.Drawing.Point(575, 71);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(75, 23);
            this.btnventas.TabIndex = 3;
            this.btnventas.Text = "listar ventas";
            this.btnventas.UseVisualStyleBackColor = true;
            // 
            // dgvconsultas
            // 
            this.dgvconsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsultas.Location = new System.Drawing.Point(122, 221);
            this.dgvconsultas.Name = "dgvconsultas";
            this.dgvconsultas.Size = new System.Drawing.Size(625, 150);
            this.dgvconsultas.TabIndex = 4;
            // 
            // Consultas_basicas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvconsultas);
            this.Controls.Add(this.btnventas);
            this.Controls.Add(this.btntiendas);
            this.Controls.Add(this.btnempleados);
            this.Controls.Add(this.btnautores);
            this.Name = "Consultas_basicas";
            this.Text = "Consultas_basicas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnautores;
        private System.Windows.Forms.Button btnempleados;
        private System.Windows.Forms.Button btntiendas;
        private System.Windows.Forms.Button btnventas;
        private System.Windows.Forms.DataGridView dgvconsultas;
    }
}