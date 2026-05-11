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
        int rowCant = 0;

        public frmMain(string usuario)
        {
            InitializeComponent();
            usuarioRef = usuario;
            lblUsername.Text = usuario;

            ModificarColumnasVistaProyectos(usuarioRef);
            ModificarColumnasVistaTareas(usuarioRef, rowCant);
        }

        public void ModificarColumnasVistaProyectos(string usuario)
        {
            clsUsuarios objUsuarios = new clsUsuarios();
            objUsuarios.username = usuario;
            objUsuarios.GetUsuario_ID();

            clsProyectos objProyectos = new clsProyectos();
            objProyectos.usuario_id = objUsuarios.usuario_id;

            DataTable dtEstatus = objProyectos.GetEstatus();

            dgvProyectos.AutoGenerateColumns = false;
            dgvProyectos.Columns.Clear();

            //Creación columna proyecto_id
            DataGridViewTextBoxColumn colProid = new DataGridViewTextBoxColumn();
            colProid.Name = "proyecto_id";
            colProid.HeaderText = "Proyecto ID";
            colProid.DataPropertyName = "proyecto_id";

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

            dgvProyectos.Columns.Add(colProid);
            dgvProyectos.Columns["proyecto_id"].Visible = false;
            dgvProyectos.Columns.Add(colTitulo);
            dgvProyectos.Columns.Add(cmbEstatus);
            dgvProyectos.Columns.Add(cmbPrioridad);
            dgvProyectos.Columns.Add(colFechaCreacion);
            dgvProyectos.Columns.Add(colFechaLimite);
            dgvProyectos.Columns.Add(colFechaFin);

            dgvProyectos.DataSource = objProyectos.GetProyectos();
            dgvProyectos.Columns["fechaCreacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            rowCant = dgvProyectos.RowCount;
        }

        public void ModificarColumnasVistaTareas(string usuario, int cantRows)
        {
            //Creacino de objUsuario para definir par+ametro usuario
            clsUsuarios objUsuarios = new clsUsuarios();
            objUsuarios.username = usuario;
            objUsuarios.GetUsuario_ID();

            //Igualacion en parametro usuario_id
            clsTareas objTareas = new clsTareas();
            objTareas.usuario_id = objUsuarios.usuario_id;

            clsProyectos objProyectos1 = new clsProyectos();


            DataTable dtEstatus = objProyectos1.GetEstatus();

            dgvTareas.AutoGenerateColumns = false;
            dgvTareas.Columns.Clear();

            //Creación columna proyecto_id
            DataGridViewTextBoxColumn colTareaid = new DataGridViewTextBoxColumn();
            colTareaid.Name = "tarea_id";
            colTareaid.HeaderText = "Tarea ID";
            colTareaid.DataPropertyName = "tarea_id";

            //Creación columna titulo
            DataGridViewTextBoxColumn colTitulo = new DataGridViewTextBoxColumn();
            colTitulo.Name = "tituloTarea";
            colTitulo.HeaderText = "Tarea";
            colTitulo.DataPropertyName = "tituloTarea";

            //Creación columna comboEstatus
            DataGridViewComboBoxColumn cmbEstatus = new DataGridViewComboBoxColumn();
            cmbEstatus.Name = "estatus_id";
            cmbEstatus.HeaderText = "Estatus";
            cmbEstatus.DataSource = dtEstatus;
            cmbEstatus.DisplayMember = "estatus";
            cmbEstatus.ValueMember = "estatus_id";
            cmbEstatus.DataPropertyName = "estatus_id";

            DataTable dtPrioridad = objProyectos1.GetPrioridad();
            DataGridViewComboBoxColumn cmbPrioridad = new DataGridViewComboBoxColumn();
            cmbPrioridad.Name = "prioridad_id";
            cmbPrioridad.HeaderText = "Prioridad";
            cmbPrioridad.DataSource = dtPrioridad;
            cmbPrioridad.DisplayMember = "prioridad";
            cmbPrioridad.ValueMember = "prioridad_id";
            cmbPrioridad.DataPropertyName = "prioridad_id";

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

            dgvTareas.Columns.Add(colTareaid);
            dgvTareas.Columns["tarea_id"].Visible = false;
            dgvTareas.Columns.Add(colTitulo);
            dgvTareas.Columns.Add(cmbEstatus);
            dgvTareas.Columns.Add(cmbPrioridad);
            dgvTareas.Columns.Add(colFechaCreacion);
            dgvTareas.Columns.Add(colFechaLimite);
            dgvTareas.Columns.Add(colFechaFin);

            if (cantRows > 0)
            {
                objTareas.proyecto_id = Convert.ToInt32(dgvProyectos.Rows[0].Cells[0].Value);
                dgvTareas.DataSource = objTareas.GetTareasDependientes();
            }
            dgvTareas.Columns["fechaCreacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        public void NuevoProyecto(int tipoReg)
        {
            clsProyectos objProyectos = new clsProyectos();
            clsUsuarios objUsuarios = new clsUsuarios();
            objUsuarios.username = usuarioRef;
            objUsuarios.GetUsuario_ID();

            objProyectos.tituloProyecto = txtTituloProyecto.Text;
            objProyectos.usuario_id = objUsuarios.usuario_id;
            switch (tipoReg)
            {
                case 0:
                    objProyectos.InsertarProyectoRegParcial();
                    break;
                case 1:
                    try
                    {
                        objProyectos.tituloProyecto = dgvProyectos.CurrentRow.Cells["tituloProyecto"].Value.ToString();
                        objProyectos.estatus_id = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["estatus_id"].Value);
                        objProyectos.prioridad_id = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["prioridad_id"].Value);
                        objProyectos.fechaLimite = Convert.ToDateTime(dgvProyectos.CurrentRow.Cells["fechaLimite"].Value);
                        objProyectos.InsertarProyectoRegTotal();
                    }
                    catch (InvalidCastException)
                    {
                        MessageBox.Show("Asegúrese de llenar todos los campos correctamente para poder crear un nuevo proyecto", "¡ESPERA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;
            }
            dgvProyectos.DataSource = objProyectos.GetProyectos();
        }

        private void lblAdminControl_Click(object sender, EventArgs e)
        {

        }

        private void txtTituloProyecto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtTituloProyecto.Text))
            {
                NuevoProyecto(0);
            }
        }

        private void btnAgregarProyecto_Click(object sender, EventArgs e)
        {
            NuevoProyecto(1);
        }

        private void dgvProyectos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
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

        private void btnModificarProyecto_Click(object sender, EventArgs e)
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
                objProyectos.ActualizarProyecto();

                MessageBox.Show("Proyecto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvProyectos.DataSource = objProyectos.GetProyectos();// Actualizar la tabla
            }
            else
            {
                MessageBox.Show("Por favor, seleccione toda la fila del proyecto que desea modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregarTareaProyecto_Click(object sender, EventArgs e)
        {
            //Creaci[on de objUsuario para definir parámetro usuario
            clsUsuarios objUsuarios = new clsUsuarios();
            objUsuarios.username = usuarioRef;
            objUsuarios.GetUsuario_ID();

            //Igualación en parámetro usuario_id
            clsTareas objTareas = new clsTareas();
            objTareas.usuario_id = objUsuarios.usuario_id;
            try
            {
                objTareas.proyecto_id = Convert.ToInt32(dgvProyectos.Rows[0].Cells[0].Value);
                objTareas.tituloTarea = dgvTareas.CurrentRow.Cells["tituloTarea"].Value.ToString();
                objTareas.estatus_id = Convert.ToInt32(dgvTareas.CurrentRow.Cells["estatus_id"].Value);
                objTareas.prioridad_id = Convert.ToInt32(dgvTareas.CurrentRow.Cells["prioridad_id"].Value);
                objTareas.fechaLimite = Convert.ToDateTime(dgvTareas.CurrentRow.Cells["fechaLimite"].Value);
                objTareas.InsertarTareaDependiente();
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Asegúrese de llenar todos los campos correctamente para poder crear una nueva tarea", "¡ESPERA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            dgvTareas.DataSource = objTareas.GetTareasDependientes();
        }

        private void dgvTareas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                try
                {
                    DateTime fecha = mCalendarTareas.SelectionStart;
                    dgvTareas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = fecha;
                }
                catch (ArgumentOutOfRangeException)
                {

                }
            }
        }

        private void btnModificarTareaProyecto_Click(object sender, EventArgs e)
        {
            // Validamos que haya una fila seleccionada en el DataGridView
            if (dgvTareas.SelectedRows.Count > 0)
            {
                clsTareas objTareas = new clsTareas();

                // Obtenemos el ID de la fila seleccionada
                objTareas.tarea_id = Convert.ToInt32(dgvTareas.CurrentRow.Cells["tarea_id"].Value);

                // Asignamos los nuevos valores de los TextBoxes
                objTareas.tituloTarea = dgvTareas.CurrentRow.Cells["tituloTarea"].Value.ToString();
                objTareas.estatus_id = Convert.ToInt32(dgvTareas.CurrentRow.Cells["estatus_id"].Value);
                objTareas.prioridad_id = Convert.ToInt32(dgvTareas.CurrentRow.Cells["prioridad_id"].Value);
                objTareas.fechaLimite = Convert.ToDateTime(dgvTareas.CurrentRow.Cells["fechaLimite"].Value);
                objTareas.ActualizarTareaDependiente();

                MessageBox.Show("Tarea actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTareas.DataSource = objTareas.GetTareasDependientes();// Actualizar la tabla
            }
            else
            {
                MessageBox.Show("Por favor, seleccione toda la fila de la tarea que desea modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarTareaProyecto_Click(object sender, EventArgs e)
        {
            // Validamos que haya una fila seleccionada en el DataGridView
            if (dgvTareas.SelectedRows.Count > 0)
            {
                clsTareas objTareas = new clsTareas();

                // Obtenemos el ID de la fila seleccionada
                objTareas.tarea_id = Convert.ToInt32(dgvTareas.CurrentRow.Cells["tarea_id"].Value);

                // Asignamos los nuevos valores de los TextBoxes
                objTareas.EliminarTarea();

                MessageBox.Show("Tarea eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTareas.DataSource = objTareas.GetTareasDependientes();// Actualizar la tabla
            }
            else
            {
                MessageBox.Show("Por favor, seleccione toda la fila de la tarea que desea eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarProyecto_Click(object sender, EventArgs e)
        {
            // Validamos que haya una fila seleccionada en el DataGridView
            if (dgvProyectos.SelectedRows.Count > 0)
            {
                clsProyectos objProyectos = new clsProyectos();

                // Obtenemos el ID de la fila seleccionada
                objProyectos.proyecto_id = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["proyecto_id"].Value);

                // Asignamos los nuevos valores de los TextBoxes
                objProyectos.EliminarProyecto();

                MessageBox.Show("Proyecto eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvTareas.DataSource = objProyectos.GetProyectos();// Actualizar la tabla
            }
            else
            {
                MessageBox.Show("Por favor, seleccione toda la fila del proyecto que desea eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
