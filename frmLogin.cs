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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogRegistro_Click(object sender, EventArgs e)
        {
            clsUsuarios objUsuarios = new clsUsuarios();

            objUsuarios.email = txtEmailRegistro.Text;
            objUsuarios.contrasena = txtContrasenaRegistro.Text;
            objUsuarios.username = txtUsernameRegistro.Text;
            objUsuarios.tipoUsuario_id = 0;

            objUsuarios.InsertarUsuario();

            Form frmMain = new frmMain(txtUsernameRegistro.Text);
            frmMain.ShowDialog();
            this.Hide();
        }
    }
}
