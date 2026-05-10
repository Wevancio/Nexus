using NexusApp.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexusApp
{
    public partial class frmMain : Form
    {
        string usuarioRef;

        public frmMain(string usuario)
        {
            InitializeComponent();
            usuarioRef = usuario;
            lblUsername.Text = usuario;
            clsUsuarios objUsuarios = new clsUsuarios();
            objUsuarios.username = usuarioRef;
            objUsuarios.GetUsuario_ID();
            clsProyectos objProyectos = new clsProyectos();
            objProyectos.usuario_id = objUsuarios.usuario_id;
            dgvProyectos.DataSource = objProyectos.GetProyectos();

        }

        public void NuevoProyecto()
        {
            clsProyectos objProyectos = new clsProyectos();
            clsUsuarios objUsuarios = new clsUsuarios();
            objUsuarios.username = usuarioRef;
            objUsuarios.GetUsuario_ID();

            objProyectos.tituloProyecto = txtTituloProyecto.Text;
            objProyectos.usuario_id = objUsuarios.usuario_id;
            objProyectos.InsertarProyecto();
            dgvProyectos.DataSource = objProyectos.GetProyectos();
        }

        private void lblAdminControl_Click(object sender, EventArgs e)
        {

        }

        private void txtTituloProyecto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtTituloProyecto.Text))
            {
                NuevoProyecto();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoProyecto();
        }

        private void dgvProyectos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex == 0) Agregar filtro para poder modificar únicamente columnas DateTime
            try
            {
                DateTime fecha = mCalendarProyectos.SelectionStart;
                dgvProyectos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = fecha;
            }
            catch (ArgumentOutOfRangeException)
            {

            }

        }
    }
}
