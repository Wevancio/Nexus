namespace NexusApp.Forms
{
    partial class frmAdmin
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pblHeader = new System.Windows.Forms.Panel();
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 67);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(228, 408);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // pblHeader
            // 
            this.pblHeader.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pblHeader.Location = new System.Drawing.Point(0, 0);
            this.pblHeader.Name = "pblHeader";
            this.pblHeader.Size = new System.Drawing.Size(900, 67);
            this.pblHeader.TabIndex = 1;
            this.pblHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pblHeader_Paint);
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.pnlMenu);
            this.pnlContenedor.Controls.Add(this.pblHeader);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(900, 475);
            this.pnlContenedor.TabIndex = 2;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 475);
            this.Controls.Add(this.pnlContenedor);
            this.Name = "frmAdmin";
            this.Text = "Admin Control";
            this.pnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pblHeader;
        private System.Windows.Forms.Panel pnlContenedor;
    }
}