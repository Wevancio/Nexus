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

            ModificarColumnas(usuarioRef);
        }

        public void ModificarColumnas(string usuario)
        {
            clsUsuarios objUsuarios = new clsUsuarios();
            objUsuarios.username = usuario;
            objUsuarios.GetUsuario_ID();

            clsProyectos objProyectos = new clsProyectos();
            objProyectos.usuario_id = objUsuarios.usuario_id;

            DataTable dtEstatus = objProyectos.GetEstatus();

            dgvProyectos.AutoGenerateColumns = false;
            dgvProyectos.Columns.Clear();

            //Creación columna titulo
            DataGridViewTextBoxColumn colTitulo = new DataGridViewTextBoxColumn();
            colTitulo.Name = "tituloProyecto";
            colTitulo.HeaderText = "Proyecto";
            colTitulo.DataPropertyName = "tituloProyecto";

            //Creación columna comboEstatus
            DataGridViewComboBoxColumn cmbEstatus = new DataGridViewComboBoxColumn();
            cmbEstatus.Name = "estatus_id";
            cmbEstatus.HeaderText = "Estatus";
            cmbEstatus.DataSource = dtEstatus;
            cmbEstatus.DisplayMember = "estatus";
            cmbEstatus.ValueMember = "estatus_id";
            cmbEstatus.DataPropertyName = "estatus_id";

            //int ind = dgvProyectos.Columns["estatus_id"].Index;
            //dgvProyectos.Columns.Remove("estatus_id");
            //dgvProyectos.Columns.Insert(ind, cmbEstatus);

            //Creación columna comboPrioridad
            DataTable dtPrioridad = objProyectos.GetPrioridad();
            DataGridViewComboBoxColumn cmbPrioridad = new DataGridViewComboBoxColumn();
            cmbPrioridad.Name = "prioridad_id";
            cmbPrioridad.HeaderText = "Prioridad";
            cmbPrioridad.DataSource = dtPrioridad;
            cmbPrioridad.DisplayMember = "prioridad";
            cmbPrioridad.ValueMember = "prioridad_id";
            cmbPrioridad.DataPropertyName = "prioridad_id";

            //int indP = dgvProyectos.Columns["prioridad_id"].Index;
            //dgvProyectos.Columns.Remove("prioridad_id");
            //dgvProyectos.Columns.Insert(indP, cmbPrioridad);

            //Creación columna fechaCreacion
            DataGridViewTextBoxColumn colFechaCreacion = new DataGridViewTextBoxColumn();
            colFechaCreacion.Name = "fechaCreacion";
            colFechaCreacion.HeaderText = "Fecha Creacion";
            colFechaCreacion.DataPropertyName = "fechaCreacion";

            //dgvProyectos.Columns["fechaCreacion"].DefaultCellStyle.Format = "dd/MM/yyyy";

            DataGridViewTextBoxColumn colFechaLimite = new DataGridViewTextBoxColumn();
            colFechaLimite.Name = "fechaLimite";
            colFechaLimite.HeaderText = "Fecha Limite";
            colFechaLimite.DataPropertyName = "fechaLimite";
            //dgvProyectos.Columns["fechaLimite"].DefaultCellStyle.Format = "dd/MM/yyyy";

            DataGridViewTextBoxColumn colFechaFin = new DataGridViewTextBoxColumn();
            colFechaFin.Name = "fechaFin";
            colFechaFin.HeaderText = "Fecha Fin";
            colFechaFin.DataPropertyName = "fechaFin";
            //dgvProyectos.Columns["fechaFin"].DefaultCellStyle.Format = "dd/MM/yyyy";
            // O para fecha y hora:
            // dataGridView1.Columns["NombreColumnaFecha"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";

            dgvProyectos.Columns.Add(colTitulo);
            dgvProyectos.Columns.Add(cmbEstatus);
            dgvProyectos.Columns.Add(cmbPrioridad);
            dgvProyectos.Columns.Add(colFechaCreacion);
            dgvProyectos.Columns.Add(colFechaLimite);
            dgvProyectos.Columns.Add(colFechaFin);

            dgvProyectos.DataSource = objProyectos.GetProyectos();
            dgvProyectos.Columns["fechaCreacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
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
            if (e.ColumnIndex == 5 || e.ColumnIndex == 4)
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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Validamos que haya una fila seleccionada en el DataGridView
            if (dgvProyectos.SelectedRows.Count > 0)
            {
                clsProyectos objProyectos = new clsProyectos();

                // Obtenemos el ID de la fila seleccionada
                objProyectos.proyecto_id = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["proyecto_id"].Value);

                // Asignamos los nuevos valores de los TextBoxes
                objProyectos.tituloProyecto = dgvProyectos.CurrentRow.Cells["tituloProyecto"].Value.ToString();
                objProyectos.estatus_id = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["estatus_id"].Value);
                objProyectos.prioridad_id = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["prioridad_id"].Value);
                objProyectos.fechaLimite = Convert.ToDateTime(dgvProyectos.CurrentRow.Cells["fechaLimite"].Value);
                objProyectos.fechaFin = Convert.ToDateTime(dgvProyectos.CurrentRow.Cells["fechaFin"].Value);
                

                MessageBox.Show("Proyecto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Actualizar la tabla
            }
            else
            {
                MessageBox.Show("Por favor, seleccione toda la fila del usuario que desea modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
