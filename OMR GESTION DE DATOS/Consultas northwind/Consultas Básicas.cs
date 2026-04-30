using OMR_GESTION_DE_DATOS.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMR_GESTION_DE_DATOS.Capa_de_presentación
{
    public partial class Consultas_Básicas : Form
    {
        private object northwind;
        NorthwindEntities1 database = new NorthwindEntities1();

        public Consultas_Básicas()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Comsultar los procuctos de la BD Ventas
            var consulta = from C in database.Customers
                           select C;
            dgvconsultas.DataSource = consulta.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Comsultar los procuctos de la BD Ventas
            var consulta = from P in database.Products
                           select P;
            dgvconsultas.DataSource = consulta.ToList();
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            // Comsultar los procuctos de la BD Ventas
            var consulta = from E in database.Employees
                           select E;
            dgvconsultas.DataSource = consulta.ToList();
        }

        private void btnregiones_Click(object sender, EventArgs e)
        {
            // Comsultar los procuctos de la BD Ventas
            var consulta = from R in database.Region
                           select R;
            dgvconsultas.DataSource = consulta.ToList();
        }
    }
}
