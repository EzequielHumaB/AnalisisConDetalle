using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalisisDetalle.UI.Registros;

namespace AnalisisDetalle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RegistrarAnalisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnalisisRegistro analisis = new AnalisisRegistro();
            analisis.StartPosition = FormStartPosition.CenterScreen;
            analisis.Show();
        }
    }
}
