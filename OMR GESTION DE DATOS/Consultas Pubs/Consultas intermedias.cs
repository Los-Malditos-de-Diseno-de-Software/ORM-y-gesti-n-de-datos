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
    public partial class Consultas_intermedias : Form
    {
        private object Pubs;
        pubsEntities2 bdpubs = new pubsEntities2();

        public Consultas_intermedias()
        {
            InitializeComponent();
        }

        private void btncategorias_Click(object sender, EventArgs e)
        {
            string trabajosBusqueda = this.txttrabajos.Text.Trim();
            using (pubsEntities2 trabajos = new pubsEntities2())
            {
                // La consulta busca cualquier apellido que CONTENGA la cadena ingresada
                var consulta = from C in trabajos.jobs
                               where C.job_desc.Contains(trabajosBusqueda)

                               select new
                               {
                                   C.job_id,
                                   C.job_desc,
                                   C.min_lvl,
                                   C.max_lvl
                               }; 

                dgvconsulta.DataSource = consulta.ToList();

            }

        }

        private void Consultas_intermedias_Load(object sender, EventArgs e)
        {

        }

        private void dgvconsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
