namespace OMR_GESTION_DE_DATOS.Consultas_Pubs
{
    partial class Consultas_intermedias
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
            this.btntiendas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btntrabajos = new System.Windows.Forms.Button();
            this.txttiendas = new System.Windows.Forms.TextBox();
            this.txtempleados = new System.Windows.Forms.TextBox();
            this.txttrabajos = new System.Windows.Forms.TextBox();
            this.dgvconsulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // btntiendas
            // 
            this.btntiendas.Location = new System.Drawing.Point(215, 116);
            this.btntiendas.Name = "btntiendas";
            this.btntiendas.Size = new System.Drawing.Size(133, 23);
            this.btntiendas.TabIndex = 13;
            this.btntiendas.Text = "buscar tiendas";
            this.btntiendas.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "buscar empleados";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btntrabajos
            // 
            this.btntrabajos.Location = new System.Drawing.Point(215, 6);
            this.btntrabajos.Name = "btntrabajos";
            this.btntrabajos.Size = new System.Drawing.Size(133, 23);
            this.btntrabajos.TabIndex = 11;
            this.btntrabajos.Text = "buscar trabajos";
            this.btntrabajos.UseVisualStyleBackColor = true;
            this.btntrabajos.Click += new System.EventHandler(this.btncategorias_Click);
            // 
            // txttiendas
            // 
            this.txttiendas.Location = new System.Drawing.Point(29, 116);
            this.txttiendas.Name = "txttiendas";
            this.txttiendas.Size = new System.Drawing.Size(100, 20);
            this.txttiendas.TabIndex = 10;
            // 
            // txtempleados
            // 
            this.txtempleados.Location = new System.Drawing.Point(29, 58);
            this.txtempleados.Name = "txtempleados";
            this.txtempleados.Size = new System.Drawing.Size(100, 20);
            this.txtempleados.TabIndex = 9;
            // 
            // txttrabajos
            // 
            this.txttrabajos.Location = new System.Drawing.Point(29, 10);
            this.txttrabajos.Name = "txttrabajos";
            this.txttrabajos.Size = new System.Drawing.Size(100, 20);
            this.txttrabajos.TabIndex = 8;
            // 
            // dgvconsulta
            // 
            this.dgvconsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvconsulta.Location = new System.Drawing.Point(29, 230);
            this.dgvconsulta.Name = "dgvconsulta";
            this.dgvconsulta.Size = new System.Drawing.Size(743, 215);
            this.dgvconsulta.TabIndex = 7;
            this.dgvconsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvconsulta_CellContentClick);
            // 
            // Consultas_intermedias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntiendas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btntrabajos);
            this.Controls.Add(this.txttiendas);
            this.Controls.Add(this.txtempleados);
            this.Controls.Add(this.txttrabajos);
            this.Controls.Add(this.dgvconsulta);
            this.Name = "Consultas_intermedias";
            this.Text = "Consultas Intermedias-Pubs";
            this.Load += new System.EventHandler(this.Consultas_intermedias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvconsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntiendas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btntrabajos;
        private System.Windows.Forms.TextBox txttiendas;
        private System.Windows.Forms.TextBox txtempleados;
        private System.Windows.Forms.TextBox txttrabajos;
        private System.Windows.Forms.DataGridView dgvconsulta;
    }
}