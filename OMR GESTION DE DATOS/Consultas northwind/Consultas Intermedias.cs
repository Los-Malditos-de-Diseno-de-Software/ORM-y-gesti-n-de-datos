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
    public partial class Consultas_Intermedias : Form
    {
        private object northwind;
        NorthwindEntities1 database = new NorthwindEntities1();

        public Consultas_Intermedias()
        {
            InitializeComponent();
        }

        private void Consultas_Intermedias_Load(object sender, EventArgs e)
        {

        }

        private void btncategorias_Click(object sender, EventArgs e)
        {
            string categoriasBusqueda = this.txtcategorias.Text.Trim();
            using (NorthwindEntities1 categorias = new NorthwindEntities1())
            {
                // La consulta busca cualquier apellido que CONTENGA la cadena ingresada
                var consulta = from C in categorias.Categories
                               where C.CategoryName.Contains(categoriasBusqueda)
                              
                               select new
                               {
                                   C.CategoryID,
                                   C.CategoryName,
                                   C.Description
                               };

                dgvconsulta.DataSource = consulta.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string empleadosBusqueda = this.txtempleados.Text.Trim();
            using (NorthwindEntities1 empleados = new NorthwindEntities1())
            {
                // La consulta busca cualquier apellido que CONTENGA la cadena ingresada
                var consulta = from C in empleados.Employees
                               where C.LastName.Contains(empleadosBusqueda)

                               select new
                               {
                                   C.EmployeeID,
                                   C.FirstName,
                                   C.LastName
                               };

                dgvconsulta.DataSource = consulta.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string productosBusqueda = this.txtproductos.Text.Trim();
            using (NorthwindEntities1 productos = new NorthwindEntities1())
            {
                // La consulta busca cualquier apellido que CONTENGA la cadena ingresada
                var consulta = from C in productos.Products
                               where C.ProductName.Contains(productosBusqueda)

                               select new
                               {
                                   C.ProductID,
                                   C.ProductName,
                                   C.UnitPrice
                               };

                dgvconsulta.DataSource = consulta.ToList();
            }
        }
    }
}
