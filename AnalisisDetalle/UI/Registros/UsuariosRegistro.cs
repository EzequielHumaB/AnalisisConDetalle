using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalisisDetalle.BLL;
using AnalisisDetalle.DAL;
using AnalisisDetalle.Entidades;

namespace AnalisisDetalle.UI.Registros
{
    public partial class UsuariosRegistro : Form
    {
        public UsuariosRegistro()
        {
            InitializeComponent();
        }

        public void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            CedulatextBox.Text = string.Empty;
            FechaIngresodateTimePicker.Value = DateTime.Now;
            myerrorProvider.Clear();
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Usuarios LlenaClase()
        {
            Usuarios usuario = new Usuarios();
            usuario.UsuarioId = Convert.ToInt32(IdnumericUpDown.Value);
            usuario.nombre = NombretextBox.Text;
            usuario.email = EmailtextBox.Text;
            usuario.cedula = CedulatextBox.Text;
            usuario.fechaIngreso = FechaIngresodateTimePicker.Value;
            return usuario;
        }

        private void LlenaCampo(Usuarios usuario)
        {
            IdnumericUpDown.Value = usuario.UsuarioId;
            NombretextBox.Text = usuario.nombre;
            CedulatextBox.Text = usuario.cedula;
            EmailtextBox.Text = usuario.email;
            FechaIngresodateTimePicker.Value = usuario.fechaIngreso;
        }

        private bool Validar()
        {
            bool paso = true;
            myerrorProvider.Clear();

            if (NombretextBox.Text == string.Empty)
            {
                myerrorProvider.SetError(NombretextBox, "El campo Nombre no puede estar vacio");
                NombretextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                myerrorProvider.SetError(EmailtextBox, "El campo Direccion no puede estar vacio");
                EmailtextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CedulatextBox.Text.Replace("-", "")))
            {
                myerrorProvider.SetError(CedulatextBox, "El campo Cedula no puede estar vacio");
                CedulatextBox.Focus();
                paso = false;
            }

           
            return paso;
        }

       
        private void GuardarButton_Click_1(object sender, EventArgs e)
        {
            Usuarios usuarios;
            bool paso = false;

            if (!Validar())
                return;

            usuarios = LlenaClase();
            Limpiar();

            //Determinar si es guardar o modificar
            if (IdnumericUpDown.Value == 0)
                paso = UsuariosBLL.Guardar(usuarios);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = UsuariosBLL.Modificar(usuarios);
            }

            //Informar el resultado
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Usuarios usuarios = UsuariosBLL.Buscar((int)IdnumericUpDown.Value);

            return (usuarios != null);

        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            myerrorProvider.Clear();
            int id;
            int.TryParse(IdnumericUpDown.Text, out id);
            Limpiar();
            if (UsuariosBLL.Eliminar(id))
                MessageBox.Show("Eliminado");
            else
                myerrorProvider.SetError(IdnumericUpDown, "No se puede eliminar una persona que no existe");

        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            int id;
            Usuarios usuarios = new Usuarios();
            id = (int)IdnumericUpDown.Value;
            
            Limpiar();

            usuarios = UsuariosBLL.Buscar(id);

            if (usuarios != null)
            {
                MessageBox.Show("Persona Encontrada");
                LlenaCampo(usuarios);
            }
            else
            {
                MessageBox.Show("Persona no Encontada");
            }

        }
        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

    }
}
