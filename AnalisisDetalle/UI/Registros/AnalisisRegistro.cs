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
            this.detalles = new List<DetallesAnalisis>();
            LlenarComboBox();
            LlenarTipoCombox();
        }

        private void limpiar()
        {
            IdAnalisisnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            this.detalles = new List<DetallesAnalisis>();
            CargarGrid();
        }

        private Analisis LlenarClase()
        {
            Analisis analisis = new Analisis();
            analisis.AnalisisId = (int)IdAnalisisnumericUpDown.Value;
            analisis.Fecha = FechadateTimePicker.Value;
            return analisis;
        }

        private void LlenarCampo(Analisis analisis)
        {
            TiposAnalisis tiposAnalisis = new TiposAnalisis();
            IdAnalisisnumericUpDown.Value = analisis.AnalisisId;
            FechadateTimePicker.Value = analisis.Fecha;
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

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(UsuariocomboBox.Text))
            {
                MyerrorProvider.SetError(UsuariocomboBox, "El campo Usuario no puede estar vacio");
                UsuariocomboBox.Focus();
                paso = false;
            }

          
            if (string.IsNullOrWhiteSpace(ResultadotextBox.Text))
            {
                MyerrorProvider.SetError(ResultadotextBox, "El campo Resultado no puede estar vacio");
                ResultadotextBox.Focus();
                paso = false;
            }

            return paso;
        }


        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if (DetalledataGridView.Rows.Count>0 & DetalledataGridView.CurrentRow!=null)
            {
                detalles.RemoveAt(DetalledataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }

        private void AgregarUsuariobutton_Click(object sender, EventArgs e)
        {
            UsuariosRegistro usuariosRegistro = new UsuariosRegistro();
            usuariosRegistro.StartPosition = FormStartPosition.CenterScreen;
            usuariosRegistro.ShowDialog();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
           Analisis analisis;
            bool paso = false;

            if (!Validar())
                return;

            analisis = LlenarClase();

            if (IdAnalisisnumericUpDown.Value == 0)
            {
                paso = AnalisisBLL.Guardar(analisis);
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(IdAnalisisnumericUpDown.Value);
                analisis = AnalisisBLL.Buscar(id);

                if (analisis != null)
                {
                    paso = AnalisisBLL.Modificar(LlenarClase());
                    MessageBox.Show("Modificado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Id no existe", "Falló", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (paso)
            {
                limpiar();
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id;
            id = (int)IdAnalisisnumericUpDown.Value;
            limpiar();
            try
            {
                if (AnalisisBLL.Eliminar(id))
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

            int id = 0;
            id = (int)IdAnalisisnumericUpDown.Value;
            try
            {
                Analisis analisis = AnalisisBLL.Buscar(id);
                if (analisis != null)
                {
                    MessageBox.Show("Producto encontrado");
                    LlenarCampo(analisis);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No existe el producto");
            }
        }

        private void LlenarComboBox()
        {
            var listado = new List<Usuarios>();
            listado = UsuariosBLL.GetList(p => true);
            UsuariocomboBox.DataSource = listado;
            UsuariocomboBox.DisplayMember = "Nombre";
            UsuariocomboBox.ValueMember = "UsuarioId";
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (DetalledataGridView.DataSource != null)
                this.detalles = (List<DetallesAnalisis>)DetalledataGridView.DataSource;

          
            this.detalles.Add(
                new DetallesAnalisis(
                    id: 0,
                    idtipo: (int)TipocomboBox.SelectedValue,
                    descripcion: TipocomboBox.SelectedText,
                    Res: ResultadotextBox.Text
                    )
               ) ; 
            CargarGrid();
        }

     

        private void LlenarTipoCombox()
        {
            var listado = new List<TiposAnalisis>();
            listado = TiposAnalisisBLL.GetList(p => true);
            TipocomboBox.DataSource = listado;
            //TipocomboBox.DisplayMember = "Resultado";
            TipocomboBox.DisplayMember = "Descripcion";
            TipocomboBox.ValueMember = "TipoId";
        }

        private void Tipobutton_Click(object sender, EventArgs e)
        {
            TiposAnalisisRegistro tiposAnalisisRegistro = new TiposAnalisisRegistro();
            tiposAnalisisRegistro.StartPosition = FormStartPosition.CenterScreen;
            tiposAnalisisRegistro.ShowDialog();
        }


    }
}
