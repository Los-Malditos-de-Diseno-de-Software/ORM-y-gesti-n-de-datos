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

namespace OMR_GESTION_DE_DATOS.Consultas_Pubs
{
    public partial class Consultas_avanzadas : Form
    {
        public Consultas_avanzadas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (pubsEntities2 db = new pubsEntities2())
            {
                // JOIN, Agrupamiento y función Sum()
                var consulta = from t in db.stores
                               join v in db.sales on t.stor_id equals v.stor_id
                               group v by new { t.stor_id, t.stor_name } into grupo
                               orderby grupo.Sum(x => x.qty) descending
                               select new
                               {
                                   ID_Tienda = grupo.Key.stor_id,
                                   Nombre_Tienda = grupo.Key.stor_name,
                                   Total_Libros_Vendidos = grupo.Sum(x => x.qty)
                               };
                dataGridView1.DataSource = consulta.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (pubsEntities2 db = new pubsEntities2())
            {
                // Filtrado, uso de 'let' para variables temporales y cálculos
                var consulta = from a in db.authors
                               where a.state == "CA"
                               let nombreCompleto = a.au_fname + " " + a.au_lname
                               orderby a.au_lname ascending
                               select new
                               {
                                   ID_Autor = a.au_id,
                                   Autor = nombreCompleto,
                                   Telefono = a.phone,
                                   Estado = a.state,
                                   Tiene_Contrato = (a.contract == true) ? "Sí" : "No"
                               };
                dataGridView1.DataSource = consulta.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (pubsEntities2 db = new pubsEntities2())
            {
                var consulta = from lib in db.titles
                               where lib.ytd_sales != null
                               orderby lib.ytd_sales descending
                               select new
                               {
                                   lib.title_id,
                                   Titulo = lib.title, // "title1" es como EF suele mapear la columna title
                                   Ventas_Anuales = lib.ytd_sales,
                                   // Lógica condicional para proyectar un nuevo estado
                                   Estado_Comercial = (lib.ytd_sales > 10000) ? "¡Bestseller!" :
                                                      (lib.ytd_sales > 4000) ? "Ventas Regulares" : "Bajas Ventas"
                               };
                dataGridView1.DataSource = consulta.ToList();
            }
        }
    }
}
