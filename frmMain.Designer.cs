namespace NexusApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mCalendarTareas = new System.Windows.Forms.MonthCalendar();
            this.mCalendarProyectos = new System.Windows.Forms.MonthCalendar();
            this.txtTituloProyecto = new System.Windows.Forms.TextBox();
            this.lblNuevoProyecto = new System.Windows.Forms.Label();
            this.lblHeaderTareas = new System.Windows.Forms.Label();
            this.btnEliminarTareaProyecto = new System.Windows.Forms.Button();
            this.btnModificarTareaProyecto = new System.Windows.Forms.Button();
            this.btnAgregarTareaProyecto = new System.Windows.Forms.Button();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.btnEliminarProyecto = new System.Windows.Forms.Button();
            this.btnModificarProyecto = new System.Windows.Forms.Button();
            this.btnAgregarProyecto = new System.Windows.Forms.Button();
            this.dgvProyectos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mCalendarTareasInd = new System.Windows.Forms.MonthCalendar();
            this.txtTituloTarea = new System.Windows.Forms.TextBox();
            this.lblHeaderTareasInd = new System.Windows.Forms.Label();
            this.btnEliminarTareaInd = new System.Windows.Forms.Button();
            this.btnModificarTareaInd = new System.Windows.Forms.Button();
            this.btnAgregarTareaInd = new System.Windows.Forms.Button();
            this.dgvTareasInd = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnEliminarBloc = new System.Windows.Forms.Button();
            this.btnModificarBloc = new System.Windows.Forms.Button();
            this.btnAgregarBloc = new System.Windows.Forms.Button();
            this.txtTituloBloc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvBlocs = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvDocumentos = new System.Windows.Forms.DataGridView();
            this.btnEliminarDocs = new System.Windows.Forms.Button();
            this.btnModificarDocs = new System.Windows.Forms.Button();
            this.btnAgregarDocs = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTituloDoc = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cmbBloques = new System.Windows.Forms.ComboBox();
            this.btnEliminarNota = new System.Windows.Forms.Button();
            this.btnModificarNota = new System.Windows.Forms.Button();
            this.btnAgregarNota = new System.Windows.Forms.Button();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.rtxtContenido = new System.Windows.Forms.RichTextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAdminControl = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareasInd)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlocs)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(-2, 34);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1006, 574);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mCalendarTareas);
            this.tabPage1.Controls.Add(this.mCalendarProyectos);
            this.tabPage1.Controls.Add(this.txtTituloProyecto);
            this.tabPage1.Controls.Add(this.lblNuevoProyecto);
            this.tabPage1.Controls.Add(this.lblHeaderTareas);
            this.tabPage1.Controls.Add(this.btnEliminarTareaProyecto);
            this.tabPage1.Controls.Add(this.btnModificarTareaProyecto);
            this.tabPage1.Controls.Add(this.btnAgregarTareaProyecto);
            this.tabPage1.Controls.Add(this.dgvTareas);
            this.tabPage1.Controls.Add(this.btnEliminarProyecto);
            this.tabPage1.Controls.Add(this.btnModificarProyecto);
            this.tabPage1.Controls.Add(this.btnAgregarProyecto);
            this.tabPage1.Controls.Add(this.dgvProyectos);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(998, 542);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Proyectos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mCalendarTareas
            // 
            this.mCalendarTareas.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCalendarTareas.Location = new System.Drawing.Point(722, 324);
            this.mCalendarTareas.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.mCalendarTareas.Name = "mCalendarTareas";
            this.mCalendarTareas.TabIndex = 16;
            // 
            // mCalendarProyectos
            // 
            this.mCalendarProyectos.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCalendarProyectos.Location = new System.Drawing.Point(723, 61);
            this.mCalendarProyectos.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.mCalendarProyectos.Name = "mCalendarProyectos";
            this.mCalendarProyectos.TabIndex = 15;
            // 
            // txtTituloProyecto
            // 
            this.txtTituloProyecto.Location = new System.Drawing.Point(178, 17);
            this.txtTituloProyecto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTituloProyecto.Name = "txtTituloProyecto";
            this.txtTituloProyecto.Size = new System.Drawing.Size(342, 29);
            this.txtTituloProyecto.TabIndex = 14;
            this.txtTituloProyecto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTituloProyecto_KeyDown);
            // 
            // lblNuevoProyecto
            // 
            this.lblNuevoProyecto.AutoSize = true;
            this.lblNuevoProyecto.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoProyecto.Location = new System.Drawing.Point(12, 16);
            this.lblNuevoProyecto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNuevoProyecto.Name = "lblNuevoProyecto";
            this.lblNuevoProyecto.Size = new System.Drawing.Size(159, 24);
            this.lblNuevoProyecto.TabIndex = 13;
            this.lblNuevoProyecto.Text = "Nuevo Proyecto:";
            // 
            // lblHeaderTareas
            // 
            this.lblHeaderTareas.AutoSize = true;
            this.lblHeaderTareas.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTareas.Location = new System.Drawing.Point(12, 282);
            this.lblHeaderTareas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeaderTareas.Name = "lblHeaderTareas";
            this.lblHeaderTareas.Size = new System.Drawing.Size(146, 24);
            this.lblHeaderTareas.TabIndex = 12;
            this.lblHeaderTareas.Text = "Lista de Tareas";
            // 
            // btnEliminarTareaProyecto
            // 
            this.btnEliminarTareaProyecto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTareaProyecto.Location = new System.Drawing.Point(898, 503);
            this.btnEliminarTareaProyecto.Name = "btnEliminarTareaProyecto";
            this.btnEliminarTareaProyecto.Size = new System.Drawing.Size(86, 32);
            this.btnEliminarTareaProyecto.TabIndex = 11;
            this.btnEliminarTareaProyecto.Text = "Eliminar";
            this.btnEliminarTareaProyecto.UseVisualStyleBackColor = true;
            this.btnEliminarTareaProyecto.Click += new System.EventHandler(this.btnEliminarTareaProyecto_Click);
            // 
            // btnModificarTareaProyecto
            // 
            this.btnModificarTareaProyecto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTareaProyecto.Location = new System.Drawing.Point(794, 503);
            this.btnModificarTareaProyecto.Name = "btnModificarTareaProyecto";
            this.btnModificarTareaProyecto.Size = new System.Drawing.Size(86, 32);
            this.btnModificarTareaProyecto.TabIndex = 10;
            this.btnModificarTareaProyecto.Text = "Modificar";
            this.btnModificarTareaProyecto.UseVisualStyleBackColor = true;
            this.btnModificarTareaProyecto.Click += new System.EventHandler(this.btnModificarTareaProyecto_Click);
            // 
            // btnAgregarTareaProyecto
            // 
            this.btnAgregarTareaProyecto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTareaProyecto.Location = new System.Drawing.Point(690, 503);
            this.btnAgregarTareaProyecto.Name = "btnAgregarTareaProyecto";
            this.btnAgregarTareaProyecto.Size = new System.Drawing.Size(86, 32);
            this.btnAgregarTareaProyecto.TabIndex = 9;
            this.btnAgregarTareaProyecto.Text = "Agregar";
            this.btnAgregarTareaProyecto.UseVisualStyleBackColor = true;
            this.btnAgregarTareaProyecto.Click += new System.EventHandler(this.btnAgregarTareaProyecto_Click);
            // 
            // dgvTareas
            // 
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(16, 319);
            this.dgvTareas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.RowTemplate.Height = 24;
            this.dgvTareas.Size = new System.Drawing.Size(654, 215);
            this.dgvTareas.TabIndex = 8;
            this.dgvTareas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareas_CellClick);
            this.dgvTareas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareas_CellValueChanged);
            this.dgvTareas.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvTareas_CurrentCellDirtyStateChanged);
            // 
            // btnEliminarProyecto
            // 
            this.btnEliminarProyecto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProyecto.Location = new System.Drawing.Point(898, 240);
            this.btnEliminarProyecto.Name = "btnEliminarProyecto";
            this.btnEliminarProyecto.Size = new System.Drawing.Size(86, 32);
            this.btnEliminarProyecto.TabIndex = 7;
            this.btnEliminarProyecto.Text = "Eliminar";
            this.btnEliminarProyecto.UseVisualStyleBackColor = true;
            this.btnEliminarProyecto.Click += new System.EventHandler(this.btnEliminarProyecto_Click);
            // 
            // btnModificarProyecto
            // 
            this.btnModificarProyecto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProyecto.Location = new System.Drawing.Point(794, 240);
            this.btnModificarProyecto.Name = "btnModificarProyecto";
            this.btnModificarProyecto.Size = new System.Drawing.Size(86, 32);
            this.btnModificarProyecto.TabIndex = 6;
            this.btnModificarProyecto.Text = "Modificar";
            this.btnModificarProyecto.UseVisualStyleBackColor = true;
            this.btnModificarProyecto.Click += new System.EventHandler(this.btnModificarProyecto_Click);
            // 
            // btnAgregarProyecto
            // 
            this.btnAgregarProyecto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProyecto.Location = new System.Drawing.Point(690, 240);
            this.btnAgregarProyecto.Name = "btnAgregarProyecto";
            this.btnAgregarProyecto.Size = new System.Drawing.Size(86, 32);
            this.btnAgregarProyecto.TabIndex = 5;
            this.btnAgregarProyecto.Text = "Agregar";
            this.btnAgregarProyecto.UseVisualStyleBackColor = true;
            this.btnAgregarProyecto.Click += new System.EventHandler(this.btnAgregarProyecto_Click);
            // 
            // dgvProyectos
            // 
            this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyectos.Location = new System.Drawing.Point(15, 56);
            this.dgvProyectos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.RowHeadersWidth = 51;
            this.dgvProyectos.RowTemplate.Height = 24;
            this.dgvProyectos.Size = new System.Drawing.Size(654, 215);
            this.dgvProyectos.TabIndex = 0;
            this.dgvProyectos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProyectos_CellClick);
            this.dgvProyectos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProyectos_CellValueChanged);
            this.dgvProyectos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvProyectos_CurrentCellDirtyStateChanged);
            this.dgvProyectos.SelectionChanged += new System.EventHandler(this.dgvProyectos_SelectionChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mCalendarTareasInd);
            this.tabPage2.Controls.Add(this.txtTituloTarea);
            this.tabPage2.Controls.Add(this.lblHeaderTareasInd);
            this.tabPage2.Controls.Add(this.btnEliminarTareaInd);
            this.tabPage2.Controls.Add(this.btnModificarTareaInd);
            this.tabPage2.Controls.Add(this.btnAgregarTareaInd);
            this.tabPage2.Controls.Add(this.dgvTareasInd);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(998, 542);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tareas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mCalendarTareasInd
            // 
            this.mCalendarTareasInd.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCalendarTareasInd.Location = new System.Drawing.Point(723, 61);
            this.mCalendarTareasInd.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.mCalendarTareasInd.Name = "mCalendarTareasInd";
            this.mCalendarTareasInd.TabIndex = 23;
            // 
            // txtTituloTarea
            // 
            this.txtTituloTarea.Location = new System.Drawing.Point(145, 17);
            this.txtTituloTarea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTituloTarea.Name = "txtTituloTarea";
            this.txtTituloTarea.Size = new System.Drawing.Size(342, 29);
            this.txtTituloTarea.TabIndex = 22;
            // 
            // lblHeaderTareasInd
            // 
            this.lblHeaderTareasInd.AutoSize = true;
            this.lblHeaderTareasInd.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTareasInd.Location = new System.Drawing.Point(12, 16);
            this.lblHeaderTareasInd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeaderTareasInd.Name = "lblHeaderTareasInd";
            this.lblHeaderTareasInd.Size = new System.Drawing.Size(130, 24);
            this.lblHeaderTareasInd.TabIndex = 21;
            this.lblHeaderTareasInd.Text = "Nueva Tarea:";
            // 
            // btnEliminarTareaInd
            // 
            this.btnEliminarTareaInd.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTareaInd.Location = new System.Drawing.Point(898, 240);
            this.btnEliminarTareaInd.Name = "btnEliminarTareaInd";
            this.btnEliminarTareaInd.Size = new System.Drawing.Size(86, 32);
            this.btnEliminarTareaInd.TabIndex = 19;
            this.btnEliminarTareaInd.Text = "Eliminar";
            this.btnEliminarTareaInd.UseVisualStyleBackColor = true;
            this.btnEliminarTareaInd.Click += new System.EventHandler(this.btnEliminarTareaInd_Click);
            // 
            // btnModificarTareaInd
            // 
            this.btnModificarTareaInd.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTareaInd.Location = new System.Drawing.Point(794, 240);
            this.btnModificarTareaInd.Name = "btnModificarTareaInd";
            this.btnModificarTareaInd.Size = new System.Drawing.Size(86, 32);
            this.btnModificarTareaInd.TabIndex = 18;
            this.btnModificarTareaInd.Text = "Modificar";
            this.btnModificarTareaInd.UseVisualStyleBackColor = true;
            this.btnModificarTareaInd.Click += new System.EventHandler(this.btnModificarTareaInd_Click);
            // 
            // btnAgregarTareaInd
            // 
            this.btnAgregarTareaInd.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTareaInd.Location = new System.Drawing.Point(690, 240);
            this.btnAgregarTareaInd.Name = "btnAgregarTareaInd";
            this.btnAgregarTareaInd.Size = new System.Drawing.Size(86, 32);
            this.btnAgregarTareaInd.TabIndex = 17;
            this.btnAgregarTareaInd.Text = "Agregar";
            this.btnAgregarTareaInd.UseVisualStyleBackColor = true;
            this.btnAgregarTareaInd.Click += new System.EventHandler(this.btnAgregarTareaInd_Click);
            // 
            // dgvTareasInd
            // 
            this.dgvTareasInd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareasInd.Location = new System.Drawing.Point(15, 56);
            this.dgvTareasInd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTareasInd.Name = "dgvTareasInd";
            this.dgvTareasInd.RowHeadersWidth = 51;
            this.dgvTareasInd.RowTemplate.Height = 24;
            this.dgvTareasInd.Size = new System.Drawing.Size(654, 430);
            this.dgvTareasInd.TabIndex = 16;
            this.dgvTareasInd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareasInd_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnEliminarBloc);
            this.tabPage3.Controls.Add(this.btnModificarBloc);
            this.tabPage3.Controls.Add(this.btnAgregarBloc);
            this.tabPage3.Controls.Add(this.txtTituloBloc);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dgvBlocs);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage3.Size = new System.Drawing.Size(998, 542);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bloques de Notas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnEliminarBloc
            // 
            this.btnEliminarBloc.Location = new System.Drawing.Point(662, 71);
            this.btnEliminarBloc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarBloc.Name = "btnEliminarBloc";
            this.btnEliminarBloc.Size = new System.Drawing.Size(91, 31);
            this.btnEliminarBloc.TabIndex = 11;
            this.btnEliminarBloc.Text = "Eliminar";
            this.btnEliminarBloc.UseVisualStyleBackColor = true;
            this.btnEliminarBloc.Click += new System.EventHandler(this.btnEliminarBloc_Click);
            // 
            // btnModificarBloc
            // 
            this.btnModificarBloc.Location = new System.Drawing.Point(566, 71);
            this.btnModificarBloc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarBloc.Name = "btnModificarBloc";
            this.btnModificarBloc.Size = new System.Drawing.Size(92, 31);
            this.btnModificarBloc.TabIndex = 10;
            this.btnModificarBloc.Text = "Modificar";
            this.btnModificarBloc.UseVisualStyleBackColor = true;
            this.btnModificarBloc.Click += new System.EventHandler(this.btnModificarBloc_Click);
            // 
            // btnAgregarBloc
            // 
            this.btnAgregarBloc.Location = new System.Drawing.Point(479, 71);
            this.btnAgregarBloc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarBloc.Name = "btnAgregarBloc";
            this.btnAgregarBloc.Size = new System.Drawing.Size(82, 31);
            this.btnAgregarBloc.TabIndex = 8;
            this.btnAgregarBloc.Text = "Agregar";
            this.btnAgregarBloc.UseVisualStyleBackColor = true;
            this.btnAgregarBloc.Click += new System.EventHandler(this.btnAgregarBloc_Click);
            // 
            // txtTituloBloc
            // 
            this.txtTituloBloc.Location = new System.Drawing.Point(231, 71);
            this.txtTituloBloc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTituloBloc.Name = "txtTituloBloc";
            this.txtTituloBloc.Size = new System.Drawing.Size(230, 29);
            this.txtTituloBloc.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nuevo Bloc de Notas";
            // 
            // dgvBlocs
            // 
            this.dgvBlocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlocs.Location = new System.Drawing.Point(58, 112);
            this.dgvBlocs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvBlocs.Name = "dgvBlocs";
            this.dgvBlocs.RowHeadersWidth = 51;
            this.dgvBlocs.RowTemplate.Height = 24;
            this.dgvBlocs.Size = new System.Drawing.Size(686, 401);
            this.dgvBlocs.TabIndex = 0;
            this.dgvBlocs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBlocs_CellClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvDocumentos);
            this.tabPage4.Controls.Add(this.btnEliminarDocs);
            this.tabPage4.Controls.Add(this.btnModificarDocs);
            this.tabPage4.Controls.Add(this.btnAgregarDocs);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.txtTituloDoc);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Size = new System.Drawing.Size(998, 542);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Documentos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvDocumentos
            // 
            this.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentos.Location = new System.Drawing.Point(44, 104);
            this.dgvDocumentos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDocumentos.Name = "dgvDocumentos";
            this.dgvDocumentos.RowHeadersWidth = 51;
            this.dgvDocumentos.RowTemplate.Height = 24;
            this.dgvDocumentos.Size = new System.Drawing.Size(663, 401);
            this.dgvDocumentos.TabIndex = 11;
            this.dgvDocumentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocumentos_CellClick);
            // 
            // btnEliminarDocs
            // 
            this.btnEliminarDocs.Location = new System.Drawing.Point(626, 57);
            this.btnEliminarDocs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarDocs.Name = "btnEliminarDocs";
            this.btnEliminarDocs.Size = new System.Drawing.Size(90, 31);
            this.btnEliminarDocs.TabIndex = 10;
            this.btnEliminarDocs.Text = "Eliminar";
            this.btnEliminarDocs.UseVisualStyleBackColor = true;
            this.btnEliminarDocs.Click += new System.EventHandler(this.btnEliminarDocs_Click);
            // 
            // btnModificarDocs
            // 
            this.btnModificarDocs.Location = new System.Drawing.Point(530, 57);
            this.btnModificarDocs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarDocs.Name = "btnModificarDocs";
            this.btnModificarDocs.Size = new System.Drawing.Size(92, 31);
            this.btnModificarDocs.TabIndex = 9;
            this.btnModificarDocs.Text = "Modificar";
            this.btnModificarDocs.UseVisualStyleBackColor = true;
            this.btnModificarDocs.Click += new System.EventHandler(this.btnModificarDocs_Click);
            // 
            // btnAgregarDocs
            // 
            this.btnAgregarDocs.Location = new System.Drawing.Point(443, 57);
            this.btnAgregarDocs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarDocs.Name = "btnAgregarDocs";
            this.btnAgregarDocs.Size = new System.Drawing.Size(82, 31);
            this.btnAgregarDocs.TabIndex = 7;
            this.btnAgregarDocs.Text = "Agregar";
            this.btnAgregarDocs.UseVisualStyleBackColor = true;
            this.btnAgregarDocs.Click += new System.EventHandler(this.btnAgregarDocs_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titulo";
            // 
            // txtTituloDoc
            // 
            this.txtTituloDoc.Location = new System.Drawing.Point(117, 60);
            this.txtTituloDoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTituloDoc.Name = "txtTituloDoc";
            this.txtTituloDoc.Size = new System.Drawing.Size(302, 29);
            this.txtTituloDoc.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cmbBloques);
            this.tabPage5.Controls.Add(this.btnEliminarNota);
            this.tabPage5.Controls.Add(this.btnModificarNota);
            this.tabPage5.Controls.Add(this.btnAgregarNota);
            this.tabPage5.Controls.Add(this.dgvNotas);
            this.tabPage5.Controls.Add(this.rtxtContenido);
            this.tabPage5.Controls.Add(this.txtTitulo);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage5.Size = new System.Drawing.Size(998, 542);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Notas";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // cmbBloques
            // 
            this.cmbBloques.FormattingEnabled = true;
            this.cmbBloques.Location = new System.Drawing.Point(734, 56);
            this.cmbBloques.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBloques.Name = "cmbBloques";
            this.cmbBloques.Size = new System.Drawing.Size(170, 27);
            this.cmbBloques.TabIndex = 7;
            this.cmbBloques.SelectedIndexChanged += new System.EventHandler(this.cmbBloques_SelectedIndexChanged);
            // 
            // btnEliminarNota
            // 
            this.btnEliminarNota.Location = new System.Drawing.Point(576, 53);
            this.btnEliminarNota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarNota.Name = "btnEliminarNota";
            this.btnEliminarNota.Size = new System.Drawing.Size(85, 31);
            this.btnEliminarNota.TabIndex = 6;
            this.btnEliminarNota.Text = "Eliminar";
            this.btnEliminarNota.UseVisualStyleBackColor = true;
            // 
            // btnModificarNota
            // 
            this.btnModificarNota.Location = new System.Drawing.Point(480, 53);
            this.btnModificarNota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificarNota.Name = "btnModificarNota";
            this.btnModificarNota.Size = new System.Drawing.Size(92, 31);
            this.btnModificarNota.TabIndex = 5;
            this.btnModificarNota.Text = "Modificar";
            this.btnModificarNota.UseVisualStyleBackColor = true;
            this.btnModificarNota.Click += new System.EventHandler(this.btnModificarNota_Click);
            // 
            // btnAgregarNota
            // 
            this.btnAgregarNota.Location = new System.Drawing.Point(394, 53);
            this.btnAgregarNota.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarNota.Name = "btnAgregarNota";
            this.btnAgregarNota.Size = new System.Drawing.Size(82, 31);
            this.btnAgregarNota.TabIndex = 4;
            this.btnAgregarNota.Text = "Agregar";
            this.btnAgregarNota.UseVisualStyleBackColor = true;
            this.btnAgregarNota.Click += new System.EventHandler(this.btnAgregarNota_Click);
            // 
            // dgvNotas
            // 
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Location = new System.Drawing.Point(54, 352);
            this.dgvNotas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.RowHeadersWidth = 51;
            this.dgvNotas.RowTemplate.Height = 24;
            this.dgvNotas.Size = new System.Drawing.Size(849, 214);
            this.dgvNotas.TabIndex = 3;
            // 
            // rtxtContenido
            // 
            this.rtxtContenido.Location = new System.Drawing.Point(54, 95);
            this.rtxtContenido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtxtContenido.Name = "rtxtContenido";
            this.rtxtContenido.Size = new System.Drawing.Size(850, 230);
            this.rtxtContenido.TabIndex = 2;
            this.rtxtContenido.Text = "";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(193, 56);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(181, 29);
            this.txtTitulo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Titulo de la Nota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nexus";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(874, 15);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(114, 24);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "userpotro.lvr";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(826, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 41);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblAdminControl
            // 
            this.lblAdminControl.AutoSize = true;
            this.lblAdminControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdminControl.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminControl.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblAdminControl.Location = new System.Drawing.Point(710, 20);
            this.lblAdminControl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdminControl.Name = "lblAdminControl";
            this.lblAdminControl.Size = new System.Drawing.Size(103, 16);
            this.lblAdminControl.TabIndex = 4;
            this.lblAdminControl.Text = "Admin Control";
            this.lblAdminControl.Click += new System.EventHandler(this.lblAdminControl_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 609);
            this.Controls.Add(this.lblAdminControl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nexus App";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareasInd)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlocs)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvProyectos;
        private System.Windows.Forms.Button btnEliminarProyecto;
        private System.Windows.Forms.Button btnModificarProyecto;
        private System.Windows.Forms.Button btnAgregarProyecto;
        private System.Windows.Forms.Label lblHeaderTareas;
        private System.Windows.Forms.Button btnEliminarTareaProyecto;
        private System.Windows.Forms.Button btnModificarTareaProyecto;
        private System.Windows.Forms.Button btnAgregarTareaProyecto;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.Label lblAdminControl;
        private System.Windows.Forms.TextBox txtTituloProyecto;
        private System.Windows.Forms.Label lblNuevoProyecto;
        private System.Windows.Forms.MonthCalendar mCalendarProyectos;
        private System.Windows.Forms.MonthCalendar mCalendarTareas;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.RichTextBox rtxtContenido;
        private System.Windows.Forms.Button btnEliminarNota;
        private System.Windows.Forms.Button btnModificarNota;
        private System.Windows.Forms.Button btnAgregarNota;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.ComboBox cmbBloques;
        private System.Windows.Forms.TextBox txtTituloDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEliminarDocs;
        private System.Windows.Forms.Button btnAgregarDocs;
        private System.Windows.Forms.DataGridView dgvDocumentos;
        private System.Windows.Forms.DataGridView dgvBlocs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTituloBloc;
        private System.Windows.Forms.Button btnEliminarBloc;
        private System.Windows.Forms.Button btnModificarBloc;
        private System.Windows.Forms.Button btnAgregarBloc;
        private System.Windows.Forms.MonthCalendar mCalendarTareasInd;
        private System.Windows.Forms.TextBox txtTituloTarea;
        private System.Windows.Forms.Label lblHeaderTareasInd;
        private System.Windows.Forms.Button btnEliminarTareaInd;
        private System.Windows.Forms.Button btnModificarTareaInd;
        private System.Windows.Forms.Button btnAgregarTareaInd;
        private System.Windows.Forms.DataGridView dgvTareasInd;
        private System.Windows.Forms.Button btnModificarDocs;
    }
}