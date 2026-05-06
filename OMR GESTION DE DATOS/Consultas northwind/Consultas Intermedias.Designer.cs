namespace OMR_GESTION_DE_DATOS.Capa_de_presentación
{
    partial class Consultas_Intermedias
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
            this.dgvconsulta = new System.Windows.Forms.DataGridView();
            this.txtcategorias = new System.Windows.Forms.TextBox();
            this.txtempleados = new System.Windows.Forms.TextBox();
            this.txtproductos = new System.Windows.Forms.TextBox();
            this.btncategorias = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnproductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvconsulta
            // 
            this.dgvconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsulta.Location = new System.Drawing.Point(184, 292);
            this.dgvconsulta.Name = "dgvconsulta";
            this.dgvconsulta.Size = new System.Drawing.Size(743, 215);
            this.dgvconsulta.TabIndex = 0;
            // 
            // txtcategorias
            // 
            this.txtcategorias.Location = new System.Drawing.Point(184, 72);
            this.txtcategorias.Name = "txtcategorias";
            this.txtcategorias.Size = new System.Drawing.Size(100, 20);
            this.txtcategorias.TabIndex = 1;
            // 
            // txtempleados
            // 
            this.txtempleados.Location = new System.Drawing.Point(184, 120);
            this.txtempleados.Name = "txtempleados";
            this.txtempleados.Size = new System.Drawing.Size(100, 20);
            this.txtempleados.TabIndex = 2;
            // 
            // txtproductos
            // 
            this.txtproductos.Location = new System.Drawing.Point(184, 178);
            this.txtproductos.Name = "txtproductos";
            this.txtproductos.Size = new System.Drawing.Size(100, 20);
            this.txtproductos.TabIndex = 3;
            // 
            // btncategorias
            // 
            this.btncategorias.Location = new System.Drawing.Point(370, 68);
            this.btncategorias.Name = "btncategorias";
            this.btncategorias.Size = new System.Drawing.Size(133, 23);
            this.btncategorias.TabIndex = 4;
            this.btncategorias.Text = "buscar categorias";
            this.btncategorias.UseVisualStyleBackColor = true;
            this.btncategorias.Click += new System.EventHandler(this.btncategorias_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "buscar empleados";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnproductos
            // 
            this.btnproductos.Location = new System.Drawing.Point(370, 178);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(133, 23);
            this.btnproductos.TabIndex = 6;
            this.btnproductos.Text = "buscar productos";
            this.btnproductos.UseVisualStyleBackColor = true;
            this.btnproductos.Click += new System.EventHandler(this.button3_Click);
            // 
            // Consultas_Intermedias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 593);
            this.Controls.Add(this.btnproductos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btncategorias);
            this.Controls.Add(this.txtproductos);
            this.Controls.Add(this.txtempleados);
            this.Controls.Add(this.txtcategorias);
            this.Controls.Add(this.dgvconsulta);
            this.Name = "Consultas_Intermedias";
            this.Text = "Consultas Intermedias-NorhtWind";
            this.Load += new System.EventHandler(this.Consultas_Intermedias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvconsulta;
        private System.Windows.Forms.TextBox txtcategorias;
        private System.Windows.Forms.TextBox txtempleados;
        private System.Windows.Forms.TextBox txtproductos;
        private System.Windows.Forms.Button btncategorias;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnproductos;
    }
}