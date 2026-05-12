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
            ModificarColumnasVistaTareas(usuarioRef, rowCant, dgvTareas, 0);
            ModificarColumnasVistaTareas(usuarioRef, rowCant, dgvTareasInd, 1);

            ModificarColumnasVistaBlocs(usuarioRef);
            ModificarColumnasVistaDocumentos(usuarioRef);
            LlenarComboBlocs();
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
        public void ModificarColumnasVistaBlocs(string usuario)
        {
            clsUsuarios objUsuarios = new clsUsuarios { username = usuario };
            objUsuarios.GetUsuario_ID();

            clsBlocNotas objBloc = new clsBlocNotas();
            objBloc.usuario_id = objUsuarios.usuario_id;

            dgvBlocs.AutoGenerateColumns = false;
            dgvBlocs.Columns.Clear();

            // ID oculto para poder modificar/eliminar después
            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "bloc_id";
            colId.DataPropertyName = "bloc_id";
            colId.Visible = false;

            DataGridViewTextBoxColumn colTitulo = new DataGridViewTextBoxColumn();
            colTitulo.Name = "tituloBloc";
            colTitulo.HeaderText = "Nombre del Bloc";
            colTitulo.DataPropertyName = "tituloBloc";
            colTitulo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvBlocs.Columns.Add(colId);
            dgvBlocs.Columns.Add(colTitulo);

            dgvBlocs.DataSource = objBloc.GetTodosLosBlocs(objUsuarios.usuario_id);
        }
        public void ModificarColumnasVistaDocumentos(string usuario)
        {
            clsUsuarios objUsuarios = new clsUsuarios();
            objUsuarios.username = usuario;
            objUsuarios.GetUsuario_ID();

            clsDocumentos objDocumentos = new clsDocumentos();
            objDocumentos.usuario_id = objUsuarios.usuario_id;

            dgvDocumentos.AutoGenerateColumns = false;
            dgvDocumentos.Columns.Clear();

            dgvDocumentos.Columns.Add(new DataGridViewTextBoxColumn { Name = "documento_id", DataPropertyName = "documento_id", Visible = false });
            dgvDocumentos.Columns.Add(new DataGridViewTextBoxColumn { Name = "tituloDocumento", HeaderText = "Documento", DataPropertyName = "tituloDocumento", Width = 150 });
            dgvDocumentos.Columns.Add(new DataGridViewTextBoxColumn { Name = "urlDoc", HeaderText = "Enlace / Ruta", DataPropertyName = "urlDoc", Width = 250 });
            dgvDocumentos.Columns.Add(new DataGridViewTextBoxColumn { Name = "fechaSubida", HeaderText = "Fecha", DataPropertyName = "fechaSubida" });

            dgvDocumentos.DataSource = objDocumentos.GetDocumentos();
            dgvDocumentos.Columns["fechaSubida"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        public void ModificarColumnasVistaTareas(string usuario, int cantRows, DataGridView dgv, int tipo)
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

            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();

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

            dgv.Columns.Add(colTareaid);
            dgv.Columns["tarea_id"].Visible = false;
            dgv.Columns.Add(colTitulo);
            dgv.Columns.Add(cmbEstatus);
            dgv.Columns.Add(cmbPrioridad);
            dgv.Columns.Add(colFechaCreacion);
            dgv.Columns.Add(colFechaLimite);
            dgv.Columns.Add(colFechaFin);

            if (cantRows > 0 && tipo == 0)
            {
                objTareas.proyecto_id = Convert.ToInt32(dgvProyectos.Rows[0].Cells[0].Value);
                dgv.DataSource = objTareas.GetTareasDependientes();
            }
            else
            {
                dgv.DataSource = objTareas.GetTareasIndependientes();
            }
            dgv.Columns["fechaCreacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
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
                //objProyectos.fechaFin = Convert.ToDateTime(dgvProyectos.CurrentRow.Cells["fechaFin"].Value);
                objProyectos.ActualizarProyecto();

                MessageBox.Show("Proyecto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsUsuarios objUsuarios = new clsUsuarios();
                objUsuarios.username = usuarioRef;
                objUsuarios.GetUsuario_ID();

                objProyectos.usuario_id = objUsuarios.usuario_id;
                dgvProyectos.DataSource = objProyectos.GetProyectos();// Actualizar la tabla
            }
            else
            {
                MessageBox.Show("Por favor, seleccione toda la fila del proyecto que desea modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void InsertarTarea(DataGridView dgv, int tipoDep)
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
                if (tipoDep == 0)
                {
                    objTareas.proyecto_id = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["proyecto_id"].Value);
                }
                objTareas.tituloTarea = dgv.CurrentRow.Cells["tituloTarea"].Value.ToString();
                objTareas.estatus_id = Convert.ToInt32(dgv.CurrentRow.Cells["estatus_id"].Value);
                objTareas.prioridad_id = Convert.ToInt32(dgv.CurrentRow.Cells["prioridad_id"].Value);
                objTareas.fechaLimite = Convert.ToDateTime(dgv.CurrentRow.Cells["fechaLimite"].Value);
                
                switch (tipoDep)
                {
                    case 0:
                        objTareas.InsertarTareaDependiente();
                        dgv.DataSource = objTareas.GetTareasDependientes();
                        break;
                    case 1:
                        objTareas.InsertarTareaIndependiente();
                        dgv.DataSource = objTareas.GetTareasIndependientes();
                        break;
                }
            }
            catch (InvalidCastException)
            {
                MessageBox.Show("Asegúrese de llenar todos los campos correctamente para poder crear una nueva tarea", "¡ESPERA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnAgregarTareaProyecto_Click(object sender, EventArgs e)
        {
            ////Creaci[on de objUsuario para definir parámetro usuario
            //clsUsuarios objUsuarios = new clsUsuarios();
            //objUsuarios.username = usuarioRef;
            //objUsuarios.GetUsuario_ID();

            ////Igualación en parámetro usuario_id
            //clsTareas objTareas = new clsTareas();
            //objTareas.usuario_id = objUsuarios.usuario_id;
            //try
            //{
            //    objTareas.proyecto_id = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["proyecto_id"].Value);
            //    objTareas.tituloTarea = dgvTareas.CurrentRow.Cells["tituloTarea"].Value.ToString();
            //    objTareas.estatus_id = Convert.ToInt32(dgvTareas.CurrentRow.Cells["estatus_id"].Value);
            //    objTareas.prioridad_id = Convert.ToInt32(dgvTareas.CurrentRow.Cells["prioridad_id"].Value);
            //    objTareas.fechaLimite = Convert.ToDateTime(dgvTareas.CurrentRow.Cells["fechaLimite"].Value);
            //    objTareas.InsertarTareaDependiente();
            //}
            //catch (InvalidCastException)
            //{
            //    MessageBox.Show("Asegúrese de llenar todos los campos correctamente para poder crear una nueva tarea", "¡ESPERA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //dgvTareas.DataSource = objTareas.GetTareasDependientes();
            InsertarTarea(dgvTareas, 0);
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

        public void ActualizarTarea(int tipoDep, DataGridView dgv)
        {
            // Validamos que haya una fila seleccionada en el DataGridView
            if (dgv.SelectedRows.Count > 0)
            {
                clsTareas objTareas = new clsTareas();

                // Obtenemos el ID de la fila seleccionada
                objTareas.tarea_id = Convert.ToInt32(dgv.CurrentRow.Cells["tarea_id"].Value);

                // Asignamos los nuevos valores de los TextBoxes
                if (tipoDep == 0)
                {
                    objTareas.proyecto_id = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["proyecto_id"].Value);
                }
                objTareas.tituloTarea = dgv.CurrentRow.Cells["tituloTarea"].Value.ToString();
                objTareas.estatus_id = Convert.ToInt32(dgv.CurrentRow.Cells["estatus_id"].Value);
                objTareas.prioridad_id = Convert.ToInt32(dgv.CurrentRow.Cells["prioridad_id"].Value);
                objTareas.fechaLimite = Convert.ToDateTime(dgv.CurrentRow.Cells["fechaLimite"].Value);

                clsUsuarios objUsuarios = new clsUsuarios();
                objUsuarios.username = usuarioRef;
                objUsuarios.GetUsuario_ID();
                objTareas.usuario_id = objUsuarios.usuario_id;
                switch (tipoDep)
                {
                    case 0:
                        objTareas.ActualizarTareaDependiente();
                        dgv.DataSource = objTareas.GetTareasDependientes();// Actualizar la tabla
                        break;
                    case 1:
                        objTareas.ActualizarTareaDependiente();
                        dgv.DataSource = objTareas.GetTareasIndependientes();// Actualizar la tabla
                        break;
                }

                MessageBox.Show("Tarea actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione toda la fila de la tarea que desea modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificarTareaProyecto_Click(object sender, EventArgs e)
        {
            //// Validamos que haya una fila seleccionada en el DataGridView
            //if (dgvTareas.SelectedRows.Count > 0)
            //{
            //    clsTareas objTareas = new clsTareas();

            //    // Obtenemos el ID de la fila seleccionada
            //    objTareas.tarea_id = Convert.ToInt32(dgvTareas.CurrentRow.Cells["tarea_id"].Value);

            //    // Asignamos los nuevos valores de los TextBoxes
            //    objTareas.proyecto_id = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["proyecto_id"].Value);
            //    objTareas.tituloTarea = dgvTareas.CurrentRow.Cells["tituloTarea"].Value.ToString();
            //    objTareas.estatus_id = Convert.ToInt32(dgvTareas.CurrentRow.Cells["estatus_id"].Value);
            //    objTareas.prioridad_id = Convert.ToInt32(dgvTareas.CurrentRow.Cells["prioridad_id"].Value);
            //    objTareas.fechaLimite = Convert.ToDateTime(dgvTareas.CurrentRow.Cells["fechaLimite"].Value);
            //    objTareas.ActualizarTareaDependiente();

            //    MessageBox.Show("Tarea actualizada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    clsUsuarios objUsuarios = new clsUsuarios();
            //    objUsuarios.username = usuarioRef;
            //    objUsuarios.GetUsuario_ID();

            //    objTareas.usuario_id = objUsuarios.usuario_id;
            //    dgvTareas.DataSource = objTareas.GetTareasDependientes();// Actualizar la tabla
            //}
            //else
            //{
            //    MessageBox.Show("Por favor, seleccione toda la fila de la tarea que desea modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            ActualizarTarea(0, dgvTareas);
        }

        public void EliminarTarea(DataGridView dgv, int tipoDep)
        {
            // Validamos que haya una fila seleccionada en el DataGridView
            if (dgv.SelectedRows.Count > 0)
            {
                clsTareas objTareas = new clsTareas();

                // Obtenemos el ID de la fila seleccionada
                if (tipoDep == 0)
                {
                    objTareas.proyecto_id = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["proyecto_id"].Value);
                }
                objTareas.tarea_id = Convert.ToInt32(dgv.CurrentRow.Cells["tarea_id"].Value);

                // Asignamos los nuevos valores de los TextBoxes
                objTareas.EliminarTarea();

                MessageBox.Show("Tarea eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsUsuarios objUsuarios = new clsUsuarios();
                objUsuarios.username = usuarioRef;
                objUsuarios.GetUsuario_ID();

                objTareas.usuario_id = objUsuarios.usuario_id;
                switch (tipoDep)
                {
                    case 0:
                        dgv.DataSource = objTareas.GetTareasDependientes();// Actualizar la tabla
                        break;
                    case 1:
                        dgv.DataSource = objTareas.GetTareasIndependientes();// Actualizar la tabla
                        break;
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione toda la fila de la tarea que desea eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarTareaProyecto_Click(object sender, EventArgs e)
        {
            //// Validamos que haya una fila seleccionada en el DataGridView
            //if (dgvTareas.SelectedRows.Count > 0)
            //{
            //    clsTareas objTareas = new clsTareas();

            //    // Obtenemos el ID de la fila seleccionada
            //    objTareas.tarea_id = Convert.ToInt32(dgvTareas.CurrentRow.Cells["tarea_id"].Value);

            //    // Asignamos los nuevos valores de los TextBoxes
            //    objTareas.EliminarTarea();

            //    MessageBox.Show("Tarea eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    clsUsuarios objUsuarios = new clsUsuarios();
            //    objUsuarios.username = usuarioRef;
            //    objUsuarios.GetUsuario_ID();

            //    objTareas.usuario_id = objUsuarios.usuario_id;
            //    dgvTareas.DataSource = objTareas.GetTareasDependientes();// Actualizar la tabla
            //}
            //else
            //{
            //    MessageBox.Show("Por favor, seleccione toda la fila de la tarea que desea eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            EliminarTarea(dgvTareas, 0);
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
                clsUsuarios objUsuarios = new clsUsuarios();
                objUsuarios.username = usuarioRef;
                objUsuarios.GetUsuario_ID();

                objProyectos.usuario_id = objUsuarios.usuario_id;
                dgvProyectos.DataSource = objProyectos.GetProyectos();// Actualizar la tabla
            }
            else
            {
                MessageBox.Show("Por favor, seleccione toda la fila del proyecto que desea eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvProyectos_SelectionChanged(object sender, EventArgs e)
        {
            int cantRows = rowCant;
            clsUsuarios objUsuarios = new clsUsuarios();
            objUsuarios.username = usuarioRef;
            objUsuarios.GetUsuario_ID();

            clsProyectos objProyectos = new clsProyectos();
            objProyectos.usuario_id = objUsuarios.usuario_id;
            clsTareas objTareas = new clsTareas();
            objTareas.usuario_id = objUsuarios.usuario_id;

            if (cantRows > 0)
            {
                try
                {
                    objTareas.proyecto_id = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["proyecto_id"].Value);
                    dgvTareas.DataSource = objTareas.GetTareasDependientes();
                }
                catch (InvalidCastException)
                {

                }
            }
            //dgvTareas.Columns["fechaCreacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btnAgregarNota_Click(object sender, EventArgs e)
        {
            clsNotas nueva = new clsNotas();
            nueva.bloc_id = int.Parse(cmbBloques.SelectedValue.ToString());
            nueva.tituloNota = txtTitulo.Text;
            nueva.contenido = rtxtContenido.Text;

            clsNotas db = new clsNotas();
            db.Guardar(nueva);

            MessageBox.Show("¡Nota guardada con éxito!");
            nueva.bloc_id = Convert.ToInt32(cmbBloques.SelectedValue);
        }
        public void LlenarComboBlocs()
        {
            clsUsuarios objU = new clsUsuarios { username = usuarioRef };
            objU.GetUsuario_ID();

            clsBlocNotas objBloc = new clsBlocNotas();
            // Este método debe estar en tu clase DAL y devolver un DataTable
            DataTable dt = objBloc.GetTodosLosBlocs(objU.usuario_id);

            cmbBloques.DataSource = dt;
            cmbBloques.DisplayMember = "tituloBloc"; // El nombre que verá el usuario
            cmbBloques.ValueMember = "bloc_id";      // El ID real para la base de datos 
        }
        private void btnModificarNota_Click(object sender, EventArgs e)
        {
            if (dgvNotas.SelectedRows.Count > 0)
            {
                clsNotas nota = new clsNotas();

                // 2. Llenamos los datos (asegúrate que los nombres de los TXT sean correctos)
                nota.nota_id = Convert.ToInt32(dgvNotas.CurrentRow.Cells["nota_id"].Value);
                nota.tituloNota = txtTitulo.Text;
                nota.contenido = rtxtContenido.Text;

                nota.Editar(nota);

                MessageBox.Show("Nota actualizada correctamente.", "Nexus", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. Refrescar la lista (usando el combo de blocs)
                int idBlocActual = Convert.ToInt32(cmbBloques.SelectedValue);
                dgvNotas.DataSource = nota.Listar(idBlocActual);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una nota de la lista.");
            }
        }
    
    public void ModificarColumnasVistasDocumentos(string usuario)
        {
            clsUsuarios objUsuarios = new clsUsuarios();
            objUsuarios.username = usuario;
            objUsuarios.GetUsuario_ID();

            clsDocumentos objDocumentos = new clsDocumentos();
            objDocumentos.usuario_id = objUsuarios.usuario_id;

            dgvDocumentos.AutoGenerateColumns = false;
            dgvDocumentos.Columns.Clear();

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.Name = "documento_id";
            colId.DataPropertyName = "documento_id";
            colId.Visible = false;

            DataGridViewTextBoxColumn colTitulo = new DataGridViewTextBoxColumn();
            colTitulo.Name = "tituloDocumento";
            colTitulo.HeaderText = "Nombre del Archivo";
            colTitulo.DataPropertyName = "tituloDocumento";
            colTitulo.Width = 200;

            DataGridViewTextBoxColumn colUrl = new DataGridViewTextBoxColumn();
            colUrl.Name = "urlDoc";
            colUrl.HeaderText = "Enlace / Ruta";
            colUrl.DataPropertyName = "urlDoc";
            colUrl.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvDocumentos.Columns.Add(colId);
            dgvDocumentos.Columns.Add(colTitulo);
            dgvDocumentos.Columns.Add(colUrl);

            dgvDocumentos.DataSource = objDocumentos.GetDocumentos();
        }

        private void btnAgregarDocs_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTituloDoc.Text) && !string.IsNullOrWhiteSpace(txtUrlDoc.Text))
            {
                clsUsuarios objU = new clsUsuarios { username = usuarioRef };
                objU.GetUsuario_ID();

                clsDocumentos nuevoDoc = new clsDocumentos();
                nuevoDoc.usuario_id = objU.usuario_id;
                nuevoDoc.tituloDocumento = txtTituloDoc.Text;
                nuevoDoc.urlDoc = txtUrlDoc.Text;

                nuevoDoc.Insertar(); // Método que debes crear en tu clase DAL

                ModificarColumnasVistaDocumentos(usuarioRef); // Refrescar tabla
                txtTituloDoc.Clear();
                txtUrlDoc.Clear();
            }
        }

        private void btnEliminarDocs_Click(object sender, EventArgs e)
        {
            if (dgvDocumentos.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvDocumentos.CurrentRow.Cells["documento_id"].Value);
                clsDocumentos obj = new clsDocumentos();
                obj.Eliminar(id);

                ModificarColumnasVistaDocumentos(usuarioRef);
            }
        }

        private void btnModificarDocs_Click(object sender, EventArgs e)
        {
            if (dgvDocumentos.SelectedRows.Count > 0)
            {
                clsDocumentos doc = new clsDocumentos();

                doc.documento_id = Convert.ToInt32(dgvDocumentos.CurrentRow.Cells["documento_id"].Value);

                doc.tituloDocumento = txtTituloDoc.Text;
                doc.urlDoc = txtUrlDoc.Text;

                doc.Editar(doc);

                MessageBox.Show("Documento actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ModificarColumnasVistaDocumentos(usuarioRef);

                txtTituloDoc.Clear();
                txtUrlDoc.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona el documento que deseas modificar de la lista.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDocumentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTituloDoc.Text = dgvDocumentos.CurrentRow.Cells["tituloDocumento"].Value.ToString();
                txtUrlDoc.Text = dgvDocumentos.CurrentRow.Cells["urlDoc"].Value.ToString();
            }
        }

        private void btnAgregarBloc_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTituloBloc.Text))
            {
                clsBlocNotas obj = new clsBlocNotas();

                // Obtenemos el ID del usuario actual
                clsUsuarios objU = new clsUsuarios { username = usuarioRef };
                objU.GetUsuario_ID();

                obj.usuario_id = objU.usuario_id;
                obj.tituloBloc = txtTituloBloc.Text;

                obj.Insertar(obj); // Usamos el método que ya tienes en la clase

                txtTituloBloc.Clear();
                ModificarColumnasVistaBlocs(usuarioRef); // Refrescamos el Grid
                LlenarComboBlocs(); // ¡Importante! Actualizamos el combo de la pestaña Notas
            }
        }

        private void btnModificarBloc_Click(object sender, EventArgs e)
        {
            if (dgvBlocs.SelectedRows.Count > 0)
            {
                clsBlocNotas obj = new clsBlocNotas();
                obj.bloc_id = Convert.ToInt32(dgvBlocs.CurrentRow.Cells["bloc_id"].Value);
                obj.tituloBloc = txtTituloBloc.Text;

                obj.Editar(obj);

                ModificarColumnasVistaBlocs(usuarioRef);
                LlenarComboBlocs();
                txtTituloBloc.Clear();
            }
        }

        private void dgvBlocs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTituloBloc.Text = dgvBlocs.CurrentRow.Cells["tituloBloc"].Value.ToString();
            }
        }

        private void btnEliminarBloc_Click(object sender, EventArgs e)
        {
            // Verificamos que haya una fila seleccionada
            if (dgvBlocs.SelectedRows.Count > 0)
            {
                // Cuadro de confirmación
                DialogResult resultado = MessageBox.Show("¿Estás seguro de eliminar este Bloc? Se perderán todas las notas guardadas en él.", "Confirmar Eliminación",
                MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    int idABorrar = Convert.ToInt32(dgvBlocs.CurrentRow.Cells["bloc_id"].Value);
                    clsBlocNotas obj = new clsBlocNotas();

                    obj.Eliminar(idABorrar);

                    ModificarColumnasVistaBlocs(usuarioRef);
                    LlenarComboBlocs();
                    txtTituloBloc.Clear();

                    MessageBox.Show("Bloc eliminado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un Bloc de la lista.");
            }
        }

        private void dgvProyectos_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvProyectos.IsCurrentCellDirty)
            {
                dgvProyectos.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvProyectos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            clsProyectos objProyectos = new clsProyectos();
            if (e.RowIndex >= 0 && dgvProyectos.Columns[e.ColumnIndex].Name == "estatus_id")
            {
                int estadoID = Convert.ToInt32(dgvProyectos.Rows[e.RowIndex].Cells["estatus_id"].Value);

                if (estadoID == 3)
                {
                    objProyectos.proyecto_id = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["proyecto_id"].Value);
                    objProyectos.estatus_id = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["estatus_id"].Value);
                    objProyectos.ActualizarFechaFinProyecto();

                    clsUsuarios objUsuarios = new clsUsuarios();
                    objUsuarios.username = usuarioRef;
                    objUsuarios.GetUsuario_ID();

                    objProyectos.usuario_id = objUsuarios.usuario_id;
                    dgvProyectos.DataSource = objProyectos.GetProyectos();// Actualizar la tabla
                }
                else if (estadoID != 3 && dgvProyectos.CurrentRow.Cells["fechaFin"].Value.ToString() != "")
                {
                    objProyectos.proyecto_id = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["proyecto_id"].Value);
                    objProyectos.estatus_id = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["estatus_id"].Value);
                    objProyectos.LimpiarFechaFinProyecto();

                    clsUsuarios objUsuarios = new clsUsuarios();
                    objUsuarios.username = usuarioRef;
                    objUsuarios.GetUsuario_ID();

                    objProyectos.usuario_id = objUsuarios.usuario_id;
                    dgvProyectos.DataSource = objProyectos.GetProyectos();// Actualizar la tabla
                }
            }
        }

        private void dgvTareas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvTareas.IsCurrentCellDirty)
            {
                dgvTareas.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvTareas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                clsTareas objTareas = new clsTareas();
                if (e.RowIndex >= 0 && dgvTareas.Columns[e.ColumnIndex].Name == "estatus_id")
                {
                    int estadoID = Convert.ToInt32(dgvTareas.Rows[e.RowIndex].Cells["estatus_id"].Value);

                    if (estadoID == 3)
                    {
                        objTareas.proyecto_id = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["proyecto_id"].Value);
                        objTareas.tarea_id = Convert.ToInt32(dgvTareas.CurrentRow.Cells["tarea_id"].Value);
                        objTareas.estatus_id = Convert.ToInt32(dgvTareas.CurrentRow.Cells["estatus_id"].Value);
                        objTareas.ActualizarFechaFinTarea();

                        clsUsuarios objUsuarios = new clsUsuarios();
                        objUsuarios.username = usuarioRef;
                        objUsuarios.GetUsuario_ID();

                        objTareas.usuario_id = objUsuarios.usuario_id;
                        dgvTareas.DataSource = objTareas.GetTareasDependientes();// Actualizar la tabla
                    }
                    else if (estadoID != 3 && Convert.ToDateTime(dgvTareas.CurrentRow.Cells["fechaFin"].Value) != null)
                    {
                        objTareas.proyecto_id = Convert.ToInt32(dgvProyectos.CurrentRow.Cells["proyecto_id"].Value);
                        objTareas.tarea_id = Convert.ToInt32(dgvTareas.CurrentRow.Cells["tarea_id"].Value);
                        objTareas.estatus_id = Convert.ToInt32(dgvTareas.CurrentRow.Cells["estatus_id"].Value);
                        objTareas.LimpiarFechaFinTarea();

                        clsUsuarios objUsuarios = new clsUsuarios();
                        objUsuarios.username = usuarioRef;
                        objUsuarios.GetUsuario_ID();

                        objTareas.usuario_id = objUsuarios.usuario_id;
                        dgvTareas.DataSource = objTareas.GetTareasDependientes();// Actualizar la tabla
                    }
                }
            }
            catch (InvalidCastException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error... " + ex.ToString());
            }
        }

        private void btnAgregarTareaInd_Click(object sender, EventArgs e)
        {
            ////Creaci[on de objUsuario para definir parámetro usuario
            //clsUsuarios objUsuarios = new clsUsuarios();
            //objUsuarios.username = usuarioRef;
            //objUsuarios.GetUsuario_ID();

            ////Igualación en parámetro usuario_id
            //clsTareas objTareas = new clsTareas();
            //objTareas.usuario_id = objUsuarios.usuario_id;
            //try
            //{
            //    objTareas.tituloTarea = dgvTareasInd.CurrentRow.Cells["tituloTarea"].Value.ToString();
            //    objTareas.estatus_id = Convert.ToInt32(dgvTareasInd.CurrentRow.Cells["estatus_id"].Value);
            //    objTareas.prioridad_id = Convert.ToInt32(dgvTareasInd.CurrentRow.Cells["prioridad_id"].Value);
            //    objTareas.fechaLimite = Convert.ToDateTime(dgvTareasInd.CurrentRow.Cells["fechaLimite"].Value);
            //    objTareas.InsertarTareaIndependiente();
            //}
            //catch (InvalidCastException)
            //{
            //    MessageBox.Show("Asegúrese de llenar todos los campos correctamente para poder crear una nueva tarea", "¡ESPERA!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            //dgvTareas.DataSource = objTareas.GetTareasIndependientes();
            InsertarTarea(dgvTareasInd, 1);
        }

        private void btnModificarTareaInd_Click(object sender, EventArgs e)
        {
            ActualizarTarea(1, dgvTareasInd);
        }

        private void btnEliminarTareaInd_Click(object sender, EventArgs e)
        {
            EliminarTarea(dgvTareasInd, 1);
        }

        private void dgvTareasInd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                try
                {
                    DateTime fecha = mCalendarTareasInd.SelectionStart;
                    dgvTareasInd.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = fecha;
                }
                catch (ArgumentOutOfRangeException)
                {

                }
            }
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
    }
}
