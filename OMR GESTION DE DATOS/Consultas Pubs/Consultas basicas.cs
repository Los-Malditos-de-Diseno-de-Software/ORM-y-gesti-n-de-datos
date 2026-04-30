using OMR_GESTION_DE_DATOS.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMR_GESTION_DE_DATOS.Consultas_Pubs
{
    
    public partial class Consultas_basicas : Form
    {
        private object Pubs;
        pubsentities1 bdpubs = new pubsentities1();

        public Consultas_basicas()
        {
            InitializeComponent();
        }

        private void btnautores_Click(object sender, EventArgs e)
        {
            // Comsultar los procuctos de la BD Ventas
            var consulta = from A in bdpubs.
                           select A;
            dgvconsultas.DataSource = consulta.ToList();
        }
    }
}
