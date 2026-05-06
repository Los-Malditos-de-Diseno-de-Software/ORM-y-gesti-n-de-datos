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
        pubsEntities2 bdpubs = new pubsEntities2();

        public Consultas_basicas()
        {
            InitializeComponent();
        }

        private void btnautores_Click(object sender, EventArgs e)
        {
            // Comsultar los procuctos de la BD Ventas
            var consulta = from A in bdpubs.authors
                           select A;
            dgvconsultas.DataSource = consulta.ToList();
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            // Comsultar los procuctos de la BD Ventas
            var consulta = from E in bdpubs.employee
                           select E;
            dgvconsultas.DataSource = consulta.ToList();
        }

        private void btntiendas_Click(object sender, EventArgs e)
        {
            // Comsultar los procuctos de la BD Ventas
            var consulta = from T in bdpubs.stores
                           select T;
            dgvconsultas.DataSource = consulta.ToList();
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            // Comsultar los procuctos de la BD Ventas
            var consulta = from V in bdpubs.sales
                           select V;
            dgvconsultas.DataSource = consulta.ToList();
        }
    }
}
