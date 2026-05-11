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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAdminControl = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProyectos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
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
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(1333, 669);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tareas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(1333, 669);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bloques de Notas";
            this.tabPage3.UseVisualStyleBackColor = true;
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
    }
}