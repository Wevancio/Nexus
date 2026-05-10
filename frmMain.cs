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

            DataTable dtEstatus = objProyectos.GetEstatus();
            DataGridViewComboBoxColumn cmbEstatus = new DataGridViewComboBoxColumn();
            cmbEstatus.Name = "estatus_id";
            cmbEstatus.HeaderText = "Estatus";
            cmbEstatus.DataSource = dtEstatus;
            cmbEstatus.DisplayMember = "estatus";
            cmbEstatus.ValueMember = "estatus_id";

            int ind = dgvProyectos.Columns["estatus_id"].Index;
            dgvProyectos.Columns.Remove("estatus_id");
            dgvProyectos.Columns.Insert(ind, cmbEstatus);

            DataTable dtPrioridad = objProyectos.GetPrioridad();
            DataGridViewComboBoxColumn cmbPrioridad = new DataGridViewComboBoxColumn();
            cmbPrioridad.Name = "prioridad_id";
            cmbPrioridad.HeaderText = "Prioridad";
            cmbPrioridad.DataSource = dtPrioridad;
            cmbPrioridad.DisplayMember = "prioridad";
            cmbPrioridad.ValueMember = "prioridad_id";

            int indP = dgvProyectos.Columns["prioridad_id"].Index;
            dgvProyectos.Columns.Remove("prioridad_id");
            dgvProyectos.Columns.Insert(indP, cmbPrioridad);
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
            if (e.RowIndex == 3 || e.RowIndex == 4 || e.RowIndex == 6 || e.RowIndex == 7)
            {
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
}
