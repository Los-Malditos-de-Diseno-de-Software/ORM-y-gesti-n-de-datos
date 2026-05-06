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
    public partial class Consultas_Avanzadas : Form
    {
        public Consultas_Avanzadas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                // Uso de JOIN y Agrupamiento complejo
                var consulta = from emp in db.Employees
                               join ped in db.Orders on emp.EmployeeID equals ped.EmployeeID
                               group ped by new { emp.EmployeeID, emp.FirstName, emp.LastName } into grupo
                               orderby grupo.Count() descending
                               select new
                               {
                                   ID_Empleado = grupo.Key.EmployeeID,
                                   Nombre_Completo = grupo.Key.FirstName + " " + grupo.Key.LastName,
                                   Total_Pedidos_Atendidos = grupo.Count()
                               };
                dataGridView1.DataSource = consulta.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                    var consulta = from p in db.Products
                               where p.UnitPrice != null
                               orderby p.UnitPrice descending
                               select new
                               {
                                   p.ProductID,
                                   p.ProductName,
                                   Precio = p.UnitPrice,
                                   // Lógica condicional compleja en LINQ
                                   Categoria_Precio = (p.UnitPrice < 20) ? "Económico" :
                                                      (p.UnitPrice <= 50) ? "Normal" : "Caro",
                                   Stock = p.UnitsInStock
                               };
                dataGridView1.DataSource = consulta.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (NorthwindEntities1 db = new NorthwindEntities1())
            {
                // Uso de 'let' como subconsulta para filtrar
                var consulta = from c in db.Customers
                               let totalPedidos = c.Orders.Count() // Subconsulta para contar
                               where totalPedidos > 15
                               orderby totalPedidos descending
                               select new
                               {
                                   c.CustomerID,
                                   Empresa = c.CompanyName,
                                   Ciudad = c.City,
                                   Total_Compras = totalPedidos,
                                   Nivel = "Cliente VIP"
                               };
                dataGridView1.DataSource = consulta.ToList();
            }
        }
    }
}
