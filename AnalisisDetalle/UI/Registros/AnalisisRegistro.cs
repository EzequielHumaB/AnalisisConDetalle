using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalisisDetalle.DAL;
using AnalisisDetalle.UI.Registros;
using AnalisisDetalle.Entidades;
using AnalisisDetalle.BLL;

namespace AnalisisDetalle.UI.Registros
{
    public partial class AnalisisRegistro : Form
    {
        public List<DetallesAnalisis> detalles { get; set; }
        public AnalisisRegistro()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            IdAnalisisnumericUpDown.Value = 0;
            idTiponumericUpDown.Value = 0;
            ResultadotextBox.Text = string.Empty;
            this.detalles = new List<DetallesAnalisis>();
            CargarGrid();
        }

        private void LlenarCampo(Analisis analisis)
        {
            IdAnalisisnumericUpDown.Value = analisis.AnalisisId;
            idTiponumericUpDown.Value = analisis.TipoId;
            this.detalles = analisis.Detalles;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = detalles;
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if (DetalledataGridView.Rows.Count>0 & DetalledataGridView.CurrentRow!=null)
            {
                detalles.RemoveAt(DetalledataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }
    }
}
