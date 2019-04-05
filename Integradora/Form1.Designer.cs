namespace Integradora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Strip = new System.Windows.Forms.MenuStrip();
            this.semaforosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarSemaforoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.callesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ubicaciónGeoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarSemáforoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semaforosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Strip
            // 
            this.Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.semaforosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.Strip.Location = new System.Drawing.Point(0, 0);
            this.Strip.Name = "Strip";
            this.Strip.Size = new System.Drawing.Size(584, 24);
            this.Strip.TabIndex = 0;
            this.Strip.Text = "menuStrip1";
            // 
            // semaforosToolStripMenuItem
            // 
            this.semaforosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarSemaforoToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarSemáforoToolStripMenuItem,
            this.semaforosToolStripMenuItem1});
            this.semaforosToolStripMenuItem.Name = "semaforosToolStripMenuItem";
            this.semaforosToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.semaforosToolStripMenuItem.Text = "Semaforos";
            // 
            // agregarSemaforoToolStripMenuItem
            // 
            this.agregarSemaforoToolStripMenuItem.Name = "agregarSemaforoToolStripMenuItem";
            this.agregarSemaforoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.agregarSemaforoToolStripMenuItem.Text = "Agregar Semáforo";
            this.agregarSemaforoToolStripMenuItem.Click += new System.EventHandler(this.agregarSemaforoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.callesToolStripMenuItem,
            this.ubicaciónGeoToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.modificarToolStripMenuItem.Text = "Modificar Semáforo";
            // 
            // callesToolStripMenuItem
            // 
            this.callesToolStripMenuItem.Name = "callesToolStripMenuItem";
            this.callesToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.callesToolStripMenuItem.Text = "Calles";
            this.callesToolStripMenuItem.Click += new System.EventHandler(this.callesToolStripMenuItem_Click);
            // 
            // ubicaciónGeoToolStripMenuItem
            // 
            this.ubicaciónGeoToolStripMenuItem.Name = "ubicaciónGeoToolStripMenuItem";
            this.ubicaciónGeoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ubicaciónGeoToolStripMenuItem.Text = "Ubicación Geo.";
            this.ubicaciónGeoToolStripMenuItem.Click += new System.EventHandler(this.ubicaciónGeoToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            this.configuraciónToolStripMenuItem.Click += new System.EventHandler(this.configuraciónToolStripMenuItem_Click);
            // 
            // eliminarSemáforoToolStripMenuItem
            // 
            this.eliminarSemáforoToolStripMenuItem.Name = "eliminarSemáforoToolStripMenuItem";
            this.eliminarSemáforoToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.eliminarSemáforoToolStripMenuItem.Text = "Eliminar Semáforo";
            this.eliminarSemáforoToolStripMenuItem.Click += new System.EventHandler(this.eliminarSemáforoToolStripMenuItem_Click);
            // 
            // semaforosToolStripMenuItem1
            // 
            this.semaforosToolStripMenuItem1.Name = "semaforosToolStripMenuItem1";
            this.semaforosToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.semaforosToolStripMenuItem1.Text = "Mostrar Semaforos";
            this.semaforosToolStripMenuItem1.Click += new System.EventHandler(this.semaforosToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(106, 20);
            this.toolStripMenuItem1.Text = "Configuraciones";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Integradora.Properties.Resources.LOGO_Sistema;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.Strip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Strip;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smartforo";
            this.Strip.ResumeLayout(false);
            this.Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Strip;
        private System.Windows.Forms.ToolStripMenuItem semaforosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarSemaforoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarSemáforoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem callesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ubicaciónGeoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semaforosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

