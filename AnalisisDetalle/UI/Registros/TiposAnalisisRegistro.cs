using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalisisDetalle.Entidades;
using AnalisisDetalle.BLL;

namespace AnalisisDetalle.UI.Registros
{
    public partial class TiposAnalisisRegistro : Form
    {
        public TiposAnalisisRegistro()
        {
            InitializeComponent();
        }
        public void Limpiar()
        {
            idTiponumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            MyerrorProvider.Clear();
        }


        private TiposAnalisis LlenaClase()
        {
            TiposAnalisis tipoanalisis = new TiposAnalisis();
            tipoanalisis.TipoId = (int)idTiponumericUpDown.Value;
            tipoanalisis.Descripcion = DescripciontextBox.Text;
            return tipoanalisis;
        }

        private void LlenaCampo(TiposAnalisis tipoanalisis)
        {
            idTiponumericUpDown.Value = tipoanalisis.TipoId;
            DescripciontextBox.Text = tipoanalisis.Descripcion;
        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                MyerrorProvider.SetError(DescripciontextBox, "El campo Descripcion no puede estar vacio");
                DescripciontextBox.Focus();
                paso = false;
            }

            return paso;
        }


        private bool ExisteEnLaBaseDeDatos()
        {
            TiposAnalisis tipoanalisis = TiposAnalisisBLL.Buscar((int)idTiponumericUpDown.Value);

            return (tipoanalisis != null);

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            TiposAnalisis tipoanalisis;
            bool paso = false;

            if (!Validar())
                return;

            tipoanalisis = LlenaClase();
            Limpiar();

            //Determinar si es guardar o modificar
            if (idTiponumericUpDown.Value == 0)
                paso = TiposAnalisisBLL.Guardar(tipoanalisis);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = TiposAnalisisBLL.Modificar(tipoanalisis);
            }

            //Informar el resultado
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            id = (int)idTiponumericUpDown.Value;
            Limpiar();
            try
            {
                if (TiposAnalisisBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado correctamente");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar");
            }
            
        }

     

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            TiposAnalisis tipoanalisis = new TiposAnalisis();
            id = (int)idTiponumericUpDown.Value;

            Limpiar();

            tipoanalisis = TiposAnalisisBLL.Buscar(id);

            if (tipoanalisis != null)
            {
                MessageBox.Show("Persona Encontrada");
                LlenaCampo(tipoanalisis);
            }
            else
            {
                MessageBox.Show("Persona no Encontada");
            }

        }
    }
}
