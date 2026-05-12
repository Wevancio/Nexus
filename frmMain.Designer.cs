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
            this.btnModificarDocs = new System.Windows.Forms.Button();
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
            this.tabControl.Location = new System.Drawing.Point(-3, 42);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1341, 706);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1333, 669);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Proyectos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mCalendarTareas
            // 
            this.mCalendarTareas.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCalendarTareas.Location = new System.Drawing.Point(963, 399);
            this.mCalendarTareas.Name = "mCalendarTareas";
            this.mCalendarTareas.TabIndex = 16;
            // 
            // mCalendarProyectos
            // 
            this.mCalendarProyectos.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCalendarProyectos.Location = new System.Drawing.Point(964, 75);
            this.mCalendarProyectos.Name = "mCalendarProyectos";
            this.mCalendarProyectos.TabIndex = 15;
            // 
            // txtTituloProyecto
            // 
            this.txtTituloProyecto.Location = new System.Drawing.Point(237, 21);
            this.txtTituloProyecto.Name = "txtTituloProyecto";
            this.txtTituloProyecto.Size = new System.Drawing.Size(455, 34);
            this.txtTituloProyecto.TabIndex = 14;
            this.txtTituloProyecto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTituloProyecto_KeyDown);
            // 
            // lblNuevoProyecto
            // 
            this.lblNuevoProyecto.AutoSize = true;
            this.lblNuevoProyecto.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevoProyecto.Location = new System.Drawing.Point(16, 20);
            this.lblNuevoProyecto.Name = "lblNuevoProyecto";
            this.lblNuevoProyecto.Size = new System.Drawing.Size(201, 30);
            this.lblNuevoProyecto.TabIndex = 13;
            this.lblNuevoProyecto.Text = "Nuevo Proyecto:";
            // 
            // lblHeaderTareas
            // 
            this.lblHeaderTareas.AutoSize = true;
            this.lblHeaderTareas.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTareas.Location = new System.Drawing.Point(16, 347);
            this.lblHeaderTareas.Name = "lblHeaderTareas";
            this.lblHeaderTareas.Size = new System.Drawing.Size(182, 30);
            this.lblHeaderTareas.TabIndex = 12;
            this.lblHeaderTareas.Text = "Lista de Tareas";
            // 
            // btnEliminarTareaProyecto
            // 
            this.btnEliminarTareaProyecto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTareaProyecto.Location = new System.Drawing.Point(1198, 619);
            this.btnEliminarTareaProyecto.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarTareaProyecto.Name = "btnEliminarTareaProyecto";
            this.btnEliminarTareaProyecto.Size = new System.Drawing.Size(114, 39);
            this.btnEliminarTareaProyecto.TabIndex = 11;
            this.btnEliminarTareaProyecto.Text = "Eliminar";
            this.btnEliminarTareaProyecto.UseVisualStyleBackColor = true;
            this.btnEliminarTareaProyecto.Click += new System.EventHandler(this.btnEliminarTareaProyecto_Click);
            // 
            // btnModificarTareaProyecto
            // 
            this.btnModificarTareaProyecto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTareaProyecto.Location = new System.Drawing.Point(1059, 619);
            this.btnModificarTareaProyecto.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarTareaProyecto.Name = "btnModificarTareaProyecto";
            this.btnModificarTareaProyecto.Size = new System.Drawing.Size(114, 39);
            this.btnModificarTareaProyecto.TabIndex = 10;
            this.btnModificarTareaProyecto.Text = "Modificar";
            this.btnModificarTareaProyecto.UseVisualStyleBackColor = true;
            this.btnModificarTareaProyecto.Click += new System.EventHandler(this.btnModificarTareaProyecto_Click);
            // 
            // btnAgregarTareaProyecto
            // 
            this.btnAgregarTareaProyecto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTareaProyecto.Location = new System.Drawing.Point(920, 619);
            this.btnAgregarTareaProyecto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTareaProyecto.Name = "btnAgregarTareaProyecto";
            this.btnAgregarTareaProyecto.Size = new System.Drawing.Size(114, 39);
            this.btnAgregarTareaProyecto.TabIndex = 9;
            this.btnAgregarTareaProyecto.Text = "Agregar";
            this.btnAgregarTareaProyecto.UseVisualStyleBackColor = true;
            this.btnAgregarTareaProyecto.Click += new System.EventHandler(this.btnAgregarTareaProyecto_Click);
            // 
            // dgvTareas
            // 
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(21, 393);
            this.dgvTareas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.RowTemplate.Height = 24;
            this.dgvTareas.Size = new System.Drawing.Size(872, 265);
            this.dgvTareas.TabIndex = 8;
            this.dgvTareas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareas_CellClick);
            this.dgvTareas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTareas_CellValueChanged);
            this.dgvTareas.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvTareas_CurrentCellDirtyStateChanged);
            // 
            // btnEliminarProyecto
            // 
            this.btnEliminarProyecto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProyecto.Location = new System.Drawing.Point(1198, 295);
            this.btnEliminarProyecto.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarProyecto.Name = "btnEliminarProyecto";
            this.btnEliminarProyecto.Size = new System.Drawing.Size(114, 39);
            this.btnEliminarProyecto.TabIndex = 7;
            this.btnEliminarProyecto.Text = "Eliminar";
            this.btnEliminarProyecto.UseVisualStyleBackColor = true;
            this.btnEliminarProyecto.Click += new System.EventHandler(this.btnEliminarProyecto_Click);
            // 
            // btnModificarProyecto
            // 
            this.btnModificarProyecto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProyecto.Location = new System.Drawing.Point(1059, 295);
            this.btnModificarProyecto.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarProyecto.Name = "btnModificarProyecto";
            this.btnModificarProyecto.Size = new System.Drawing.Size(114, 39);
            this.btnModificarProyecto.TabIndex = 6;
            this.btnModificarProyecto.Text = "Modificar";
            this.btnModificarProyecto.UseVisualStyleBackColor = true;
            this.btnModificarProyecto.Click += new System.EventHandler(this.btnModificarProyecto_Click);
            // 
            // btnAgregarProyecto
            // 
            this.btnAgregarProyecto.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProyecto.Location = new System.Drawing.Point(920, 295);
            this.btnAgregarProyecto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarProyecto.Name = "btnAgregarProyecto";
            this.btnAgregarProyecto.Size = new System.Drawing.Size(114, 39);
            this.btnAgregarProyecto.TabIndex = 5;
            this.btnAgregarProyecto.Text = "Agregar";
            this.btnAgregarProyecto.UseVisualStyleBackColor = true;
            this.btnAgregarProyecto.Click += new System.EventHandler(this.btnAgregarProyecto_Click);
            // 
            // dgvProyectos
            // 
            this.dgvProyectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProyectos.Location = new System.Drawing.Point(20, 69);
            this.dgvProyectos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProyectos.Name = "dgvProyectos";
            this.dgvProyectos.RowHeadersWidth = 51;
            this.dgvProyectos.RowTemplate.Height = 24;
            this.dgvProyectos.Size = new System.Drawing.Size(872, 265);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1333, 669);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tareas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mCalendarTareasInd
            // 
            this.mCalendarTareasInd.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mCalendarTareasInd.Location = new System.Drawing.Point(964, 75);
            this.mCalendarTareasInd.Name = "mCalendarTareasInd";
            this.mCalendarTareasInd.TabIndex = 23;
            // 
            // txtTituloTarea
            // 
            this.txtTituloTarea.Location = new System.Drawing.Point(193, 21);
            this.txtTituloTarea.Name = "txtTituloTarea";
            this.txtTituloTarea.Size = new System.Drawing.Size(455, 34);
            this.txtTituloTarea.TabIndex = 22;
            // 
            // lblHeaderTareasInd
            // 
            this.lblHeaderTareasInd.AutoSize = true;
            this.lblHeaderTareasInd.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTareasInd.Location = new System.Drawing.Point(16, 20);
            this.lblHeaderTareasInd.Name = "lblHeaderTareasInd";
            this.lblHeaderTareasInd.Size = new System.Drawing.Size(162, 30);
            this.lblHeaderTareasInd.TabIndex = 21;
            this.lblHeaderTareasInd.Text = "Nueva Tarea:";
            // 
            // btnEliminarTareaInd
            // 
            this.btnEliminarTareaInd.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTareaInd.Location = new System.Drawing.Point(1198, 295);
            this.btnEliminarTareaInd.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarTareaInd.Name = "btnEliminarTareaInd";
            this.btnEliminarTareaInd.Size = new System.Drawing.Size(114, 39);
            this.btnEliminarTareaInd.TabIndex = 19;
            this.btnEliminarTareaInd.Text = "Eliminar";
            this.btnEliminarTareaInd.UseVisualStyleBackColor = true;
            this.btnEliminarTareaInd.Click += new System.EventHandler(this.btnEliminarTareaInd_Click);
            // 
            // btnModificarTareaInd
            // 
            this.btnModificarTareaInd.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTareaInd.Location = new System.Drawing.Point(1059, 295);
            this.btnModificarTareaInd.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarTareaInd.Name = "btnModificarTareaInd";
            this.btnModificarTareaInd.Size = new System.Drawing.Size(114, 39);
            this.btnModificarTareaInd.TabIndex = 18;
            this.btnModificarTareaInd.Text = "Modificar";
            this.btnModificarTareaInd.UseVisualStyleBackColor = true;
            this.btnModificarTareaInd.Click += new System.EventHandler(this.btnModificarTareaInd_Click);
            // 
            // btnAgregarTareaInd
            // 
            this.btnAgregarTareaInd.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTareaInd.Location = new System.Drawing.Point(920, 295);
            this.btnAgregarTareaInd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTareaInd.Name = "btnAgregarTareaInd";
            this.btnAgregarTareaInd.Size = new System.Drawing.Size(114, 39);
            this.btnAgregarTareaInd.TabIndex = 17;
            this.btnAgregarTareaInd.Text = "Agregar";
            this.btnAgregarTareaInd.UseVisualStyleBackColor = true;
            this.btnAgregarTareaInd.Click += new System.EventHandler(this.btnAgregarTareaInd_Click);
            // 
            // dgvTareasInd
            // 
            this.dgvTareasInd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareasInd.Location = new System.Drawing.Point(20, 69);
            this.dgvTareasInd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTareasInd.Name = "dgvTareasInd";
            this.dgvTareasInd.RowHeadersWidth = 51;
            this.dgvTareasInd.RowTemplate.Height = 24;
            this.dgvTareasInd.Size = new System.Drawing.Size(872, 529);
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
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1333, 669);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bloques de Notas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnEliminarBloc
            // 
            this.btnEliminarBloc.Location = new System.Drawing.Point(882, 87);
            this.btnEliminarBloc.Name = "btnEliminarBloc";
            this.btnEliminarBloc.Size = new System.Drawing.Size(109, 38);
            this.btnEliminarBloc.TabIndex = 11;
            this.btnEliminarBloc.Text = "Eliminar";
            this.btnEliminarBloc.UseVisualStyleBackColor = true;
            this.btnEliminarBloc.Click += new System.EventHandler(this.btnEliminarBloc_Click);
            // 
            // btnModificarBloc
            // 
            this.btnModificarBloc.Location = new System.Drawing.Point(754, 87);
            this.btnModificarBloc.Name = "btnModificarBloc";
            this.btnModificarBloc.Size = new System.Drawing.Size(122, 38);
            this.btnModificarBloc.TabIndex = 10;
            this.btnModificarBloc.Text = "Modificar";
            this.btnModificarBloc.UseVisualStyleBackColor = true;
            this.btnModificarBloc.Click += new System.EventHandler(this.btnModificarBloc_Click);
            // 
            // btnAgregarBloc
            // 
            this.btnAgregarBloc.Location = new System.Drawing.Point(639, 87);
            this.btnAgregarBloc.Name = "btnAgregarBloc";
            this.btnAgregarBloc.Size = new System.Drawing.Size(109, 38);
            this.btnAgregarBloc.TabIndex = 8;
            this.btnAgregarBloc.Text = "Agregar";
            this.btnAgregarBloc.UseVisualStyleBackColor = true;
            this.btnAgregarBloc.Click += new System.EventHandler(this.btnAgregarBloc_Click);
            // 
            // txtTituloBloc
            // 
            this.txtTituloBloc.Location = new System.Drawing.Point(308, 87);
            this.txtTituloBloc.Name = "txtTituloBloc";
            this.txtTituloBloc.Size = new System.Drawing.Size(306, 34);
            this.txtTituloBloc.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nuevo Bloc de Notas";
            // 
            // dgvBlocs
            // 
            this.dgvBlocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlocs.Location = new System.Drawing.Point(77, 138);
            this.dgvBlocs.Name = "dgvBlocs";
            this.dgvBlocs.RowHeadersWidth = 51;
            this.dgvBlocs.RowTemplate.Height = 24;
            this.dgvBlocs.Size = new System.Drawing.Size(914, 494);
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
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1333, 669);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Documentos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvDocumentos
            // 
            this.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentos.Location = new System.Drawing.Point(59, 128);
            this.dgvDocumentos.Name = "dgvDocumentos";
            this.dgvDocumentos.RowHeadersWidth = 51;
            this.dgvDocumentos.RowTemplate.Height = 24;
            this.dgvDocumentos.Size = new System.Drawing.Size(884, 493);
            this.dgvDocumentos.TabIndex = 11;
            this.dgvDocumentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocumentos_CellClick);
            // 
            // btnEliminarDocs
            // 
            this.btnEliminarDocs.Location = new System.Drawing.Point(834, 70);
            this.btnEliminarDocs.Name = "btnEliminarDocs";
            this.btnEliminarDocs.Size = new System.Drawing.Size(109, 38);
            this.btnEliminarDocs.TabIndex = 10;
            this.btnEliminarDocs.Text = "Eliminar";
            this.btnEliminarDocs.UseVisualStyleBackColor = true;
            this.btnEliminarDocs.Click += new System.EventHandler(this.btnEliminarDocs_Click);
            // 
            // btnAgregarDocs
            // 
            this.btnAgregarDocs.Location = new System.Drawing.Point(591, 70);
            this.btnAgregarDocs.Name = "btnAgregarDocs";
            this.btnAgregarDocs.Size = new System.Drawing.Size(109, 38);
            this.btnAgregarDocs.TabIndex = 7;
            this.btnAgregarDocs.Text = "Agregar";
            this.btnAgregarDocs.UseVisualStyleBackColor = true;
            this.btnAgregarDocs.Click += new System.EventHandler(this.btnAgregarDocs_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titulo";
            // 
            // txtTituloDoc
            // 
            this.txtTituloDoc.Location = new System.Drawing.Point(156, 74);
            this.txtTituloDoc.Name = "txtTituloDoc";
            this.txtTituloDoc.Size = new System.Drawing.Size(401, 34);
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
            this.tabPage5.Location = new System.Drawing.Point(4, 33);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1333, 669);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Notas";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // cmbBloques
            // 
            this.cmbBloques.FormattingEnabled = true;
            this.cmbBloques.Location = new System.Drawing.Point(979, 69);
            this.cmbBloques.Name = "cmbBloques";
            this.cmbBloques.Size = new System.Drawing.Size(225, 32);
            this.cmbBloques.TabIndex = 7;
            this.cmbBloques.SelectedIndexChanged += new System.EventHandler(this.cmbBloques_SelectedIndexChanged);
            // 
            // btnEliminarNota
            // 
            this.btnEliminarNota.Location = new System.Drawing.Point(768, 65);
            this.btnEliminarNota.Name = "btnEliminarNota";
            this.btnEliminarNota.Size = new System.Drawing.Size(109, 38);
            this.btnEliminarNota.TabIndex = 6;
            this.btnEliminarNota.Text = "Eliminar";
            this.btnEliminarNota.UseVisualStyleBackColor = true;
            // 
            // btnModificarNota
            // 
            this.btnModificarNota.Location = new System.Drawing.Point(640, 65);
            this.btnModificarNota.Name = "btnModificarNota";
            this.btnModificarNota.Size = new System.Drawing.Size(122, 38);
            this.btnModificarNota.TabIndex = 5;
            this.btnModificarNota.Text = "Modificar";
            this.btnModificarNota.UseVisualStyleBackColor = true;
            this.btnModificarNota.Click += new System.EventHandler(this.btnModificarNota_Click);
            // 
            // btnAgregarNota
            // 
            this.btnAgregarNota.Location = new System.Drawing.Point(525, 65);
            this.btnAgregarNota.Name = "btnAgregarNota";
            this.btnAgregarNota.Size = new System.Drawing.Size(109, 38);
            this.btnAgregarNota.TabIndex = 4;
            this.btnAgregarNota.Text = "Agregar";
            this.btnAgregarNota.UseVisualStyleBackColor = true;
            this.btnAgregarNota.Click += new System.EventHandler(this.btnAgregarNota_Click);
            // 
            // dgvNotas
            // 
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Location = new System.Drawing.Point(72, 433);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.RowHeadersWidth = 51;
            this.dgvNotas.RowTemplate.Height = 24;
            this.dgvNotas.Size = new System.Drawing.Size(1132, 264);
            this.dgvNotas.TabIndex = 3;
            // 
            // rtxtContenido
            // 
            this.rtxtContenido.Location = new System.Drawing.Point(72, 117);
            this.rtxtContenido.Name = "rtxtContenido";
            this.rtxtContenido.Size = new System.Drawing.Size(1132, 282);
            this.rtxtContenido.TabIndex = 2;
            this.rtxtContenido.Text = "";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(257, 69);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(240, 34);
            this.txtTitulo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Titulo de la Nota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nexus";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(1165, 18);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(147, 29);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "userpotro.lvr";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1101, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblAdminControl
            // 
            this.lblAdminControl.AutoSize = true;
            this.lblAdminControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAdminControl.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminControl.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblAdminControl.Location = new System.Drawing.Point(947, 25);
            this.lblAdminControl.Name = "lblAdminControl";
            this.lblAdminControl.Size = new System.Drawing.Size(133, 21);
            this.lblAdminControl.TabIndex = 4;
            this.lblAdminControl.Text = "Admin Control";
            this.lblAdminControl.Click += new System.EventHandler(this.lblAdminControl_Click);
            // 
            // btnModificarDocs
            // 
            this.btnModificarDocs.Location = new System.Drawing.Point(706, 70);
            this.btnModificarDocs.Name = "btnModificarDocs";
            this.btnModificarDocs.Size = new System.Drawing.Size(122, 38);
            this.btnModificarDocs.TabIndex = 9;
            this.btnModificarDocs.Text = "Modificar";
            this.btnModificarDocs.UseVisualStyleBackColor = true;
            this.btnModificarDocs.Click += new System.EventHandler(this.btnModificarDocs_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 750);
            this.Controls.Add(this.lblAdminControl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
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