using OMR_GESTION_DE_DATOS.Capa_de_presentación;
using OMR_GESTION_DE_DATOS.Consultas_Pubs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        // Evento para abrir Consultas Básicas (Pubs)
        private void cONSULTASBASICASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciamos el formulario de Consultas Básicas
            Consultas_Básicas frmBasicas = new Consultas_Básicas();

            // Lo mostramos (Show permite navegar en ambos formularios a la vez)
            frmBasicas.Show();
        }

        // Evento para abrir Consultas Avanzadas (Northwind/Mixtas)
        private void cONSULTASNORWINTHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cONSULTASAVANZADASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciamos el formulario de Consultas Avanzadas
            Consultas_Avanzadas frmAvanzadas = new Consultas_Avanzadas();

            // Lo mostramos
            frmAvanzadas.Show();
        }

        private void cONSULTASINTERMEDIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciamos el formulario de Consultas Avanzadas
            Consultas_Intermedias frmIntermedio = new Consultas_Intermedias();

            // Lo mostramos
            frmIntermedio.Show();
        }

        private void cONSULTASBASICASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Instanciamos el formulario de Consultas Avanzadas
            Consultas_basicas frmBasicas = new Consultas_basicas();

            // Lo mostramos
            frmBasicas.Show();
        }

        private void cONSULTASINTERMEDIASToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Instanciamos el formulario de Consultas Avanzadas
            Consultas_intermedias frmIntermedias = new Consultas_intermedias();

            // Lo mostramos
            frmIntermedias.Show();
        }
    }
}