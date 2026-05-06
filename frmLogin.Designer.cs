namespace NexusApp
{
    partial class frmLogin
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            this.gBxRegistro = new System.Windows.Forms.GroupBox();
            this.gBxLogin = new System.Windows.Forms.GroupBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseñaLogin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContraseñaRegistro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailRegistro = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsernameRegistro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gBxRegistro.SuspendLayout();
            this.gBxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(21, 281);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(171, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Correo electrónico:";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(94, 458);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(170, 43);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailLogin.Location = new System.Drawing.Point(25, 314);
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(323, 27);
            this.txtEmailLogin.TabIndex = 2;
            // 
            // gBxRegistro
            // 
            this.gBxRegistro.Controls.Add(this.pictureBox2);
            this.gBxRegistro.Controls.Add(this.lblUsername);
            this.gBxRegistro.Controls.Add(this.txtUsernameRegistro);
            this.gBxRegistro.Controls.Add(this.button1);
            this.gBxRegistro.Controls.Add(this.label1);
            this.gBxRegistro.Controls.Add(this.txtContraseñaRegistro);
            this.gBxRegistro.Controls.Add(this.label2);
            this.gBxRegistro.Controls.Add(this.txtEmailRegistro);
            this.gBxRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxRegistro.Location = new System.Drawing.Point(461, 37);
            this.gBxRegistro.Name = "gBxRegistro";
            this.gBxRegistro.Size = new System.Drawing.Size(573, 530);
            this.gBxRegistro.TabIndex = 3;
            this.gBxRegistro.TabStop = false;
            this.gBxRegistro.Text = "Regístrate";
            // 
            // gBxLogin
            // 
            this.gBxLogin.Controls.Add(this.lblContraseña);
            this.gBxLogin.Controls.Add(this.txtContraseñaLogin);
            this.gBxLogin.Controls.Add(this.pictureBox1);
            this.gBxLogin.Controls.Add(this.lblEmail);
            this.gBxLogin.Controls.Add(this.btnLogin);
            this.gBxLogin.Controls.Add(this.txtEmailLogin);
            this.gBxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBxLogin.Location = new System.Drawing.Point(29, 37);
            this.gBxLogin.Name = "gBxLogin";
            this.gBxLogin.Size = new System.Drawing.Size(379, 530);
            this.gBxLogin.TabIndex = 4;
            this.gBxLogin.TabStop = false;
            this.gBxLogin.Text = "Inicia Sesión";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(21, 352);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(111, 20);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // txtContraseñaLogin
            // 
            this.txtContraseñaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaLogin.Location = new System.Drawing.Point(25, 396);
            this.txtContraseñaLogin.Name = "txtContraseñaLogin";
            this.txtContraseñaLogin.Size = new System.Drawing.Size(323, 27);
            this.txtContraseñaLogin.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(94, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contraseña:";
            // 
            // txtContraseñaRegistro
            // 
            this.txtContraseñaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseñaRegistro.Location = new System.Drawing.Point(40, 314);
            this.txtContraseñaRegistro.Name = "txtContraseñaRegistro";
            this.txtContraseñaRegistro.Size = new System.Drawing.Size(323, 27);
            this.txtContraseñaRegistro.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Correo electrónico:";
            // 
            // txtEmailRegistro
            // 
            this.txtEmailRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailRegistro.Location = new System.Drawing.Point(40, 232);
            this.txtEmailRegistro.Name = "txtEmailRegistro";
            this.txtEmailRegistro.Size = new System.Drawing.Size(323, 27);
            this.txtEmailRegistro.TabIndex = 7;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(36, 363);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(174, 20);
            this.lblUsername.TabIndex = 11;
            this.lblUsername.Text = "Nombre de usuario:";
            // 
            // txtUsernameRegistro
            // 
            this.txtUsernameRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameRegistro.Location = new System.Drawing.Point(40, 396);
            this.txtUsernameRegistro.Name = "txtUsernameRegistro";
            this.txtUsernameRegistro.Size = new System.Drawing.Size(323, 27);
            this.txtUsernameRegistro.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(109, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(23, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(530, 123);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 601);
            this.Controls.Add(this.gBxLogin);
            this.Controls.Add(this.gBxRegistro);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.gBxRegistro.ResumeLayout(false);
            this.gBxRegistro.PerformLayout();
            this.gBxLogin.ResumeLayout(false);
            this.gBxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtEmailLogin;
        private System.Windows.Forms.GroupBox gBxRegistro;
        private System.Windows.Forms.GroupBox gBxLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseñaLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContraseñaRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailRegistro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsernameRegistro;
        private System.Windows.Forms.Button button1;
    }
}