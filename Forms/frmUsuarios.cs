using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NexusApp.Clases;

namespace NexusApp.Forms
{
    public partial class frmUsuarios : Form 
    {

        public frmUsuarios()
        {
            InitializeComponent();
        }


        private void CargarDatos()
        {
            clsUsuarios objUsuario = new clsUsuarios();
            dgvTablaUsuarios.DataSource = objUsuario.ObtenerUsuarios();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsUsuarios objUsuario = new clsUsuarios();
            objUsuario.email = txtEmail.Text;
            objUsuario.contrasena = txtContraseña.Text;
            objUsuario.username = txtUsuario.Text;
            objUsuario.tipoUsuario_id = Convert.ToInt32(cmbTipoUsuario.SelectedValue); 

            objUsuario.InsertarUsuario();

            MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            CargarDatos();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Validamos que haya una fila seleccionada en el DataGridView
            if (dgvTablaUsuarios.SelectedRows.Count > 0)
            {
                clsUsuarios objUsuario = new clsUsuarios();

                // Obtenemos el ID de la fila seleccionada
                objUsuario.usuario_id = Convert.ToInt32(dgvTablaUsuarios.CurrentRow.Cells["usuario_id"].Value);

                // Asignamos los nuevos valores de los TextBoxes
                objUsuario.email = txtEmail.Text;
                objUsuario.contrasena = txtContraseña.Text;
                objUsuario.username = txtUsuario.Text;
                objUsuario.tipoUsuario_id = Convert.ToInt32(cmbTipoUsuario.SelectedValue); // Asegúrate de que cmbTipoUsuario contenga un valor válido

                objUsuario.ActualizarUsuario();

                MessageBox.Show("Usuario modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos(); // Actualizar la tabla
            }
            else
            {
                MessageBox.Show("Por favor, seleccione toda la fila del usuario que desea modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTablaUsuarios.SelectedRows.Count > 0)
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    clsUsuarios objUsuario = new clsUsuarios();

                    objUsuario.usuario_id = Convert.ToInt32(dgvTablaUsuarios.CurrentRow.Cells["usuario_id"].Value);

                    objUsuario.EliminarUsuario();

                    MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos(); 
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione toda la fila del usuario que desea eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dgvTablaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validamos que el clic no haya sido en el encabezado de las columnas (RowIndex -1)
            if (e.RowIndex >= 0)
            {
                // Obtenemos la fila a la que se le hizo clic
                DataGridViewRow fila = dgvTablaUsuarios.Rows[e.RowIndex];
                txtUsuarioID.Text = fila.Cells["usuario_id"].Value.ToString();
                txtEmail.Text = fila.Cells["email"].Value.ToString();
                txtContraseña.Text = fila.Cells["contrasena"].Value.ToString();
                txtUsuario.Text = fila.Cells["username"].Value.ToString();
                cmbTipoUsuario.SelectedValue = Convert.ToInt32(fila.Cells["tipoUsuario_id"].Value); 

                // Opcional: Si tienes una variable global o un TextBox oculto para el ID, puedes guardarlo aquí
                // txtId.Text = fila.Cells["usuario_id"].Value.ToString();
            }
        }
    }
}
