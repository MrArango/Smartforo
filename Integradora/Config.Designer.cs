namespace Integradora
{
    partial class Config
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.Btn_Rojo = new System.Windows.Forms.Button();
            this.Btn_Amarillo = new System.Windows.Forms.Button();
            this.Btn_Verde = new System.Windows.Forms.Button();
            this.SERIAL = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // Btn_Rojo
            // 
            this.Btn_Rojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Rojo.Location = new System.Drawing.Point(79, 52);
            this.Btn_Rojo.Name = "Btn_Rojo";
            this.Btn_Rojo.Size = new System.Drawing.Size(101, 46);
            this.Btn_Rojo.TabIndex = 11;
            this.Btn_Rojo.Text = "Velocidad Baja";
            this.Btn_Rojo.UseVisualStyleBackColor = true;
            this.Btn_Rojo.Click += new System.EventHandler(this.Btn_Rojo_Click);
            // 
            // Btn_Amarillo
            // 
            this.Btn_Amarillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Amarillo.Location = new System.Drawing.Point(79, 156);
            this.Btn_Amarillo.Name = "Btn_Amarillo";
            this.Btn_Amarillo.Size = new System.Drawing.Size(101, 46);
            this.Btn_Amarillo.TabIndex = 10;
            this.Btn_Amarillo.Text = "Velocidad Alta";
            this.Btn_Amarillo.UseVisualStyleBackColor = true;
            this.Btn_Amarillo.Click += new System.EventHandler(this.Btn_Amarillo_Click);
            // 
            // Btn_Verde
            // 
            this.Btn_Verde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Verde.Location = new System.Drawing.Point(79, 104);
            this.Btn_Verde.Name = "Btn_Verde";
            this.Btn_Verde.Size = new System.Drawing.Size(101, 46);
            this.Btn_Verde.TabIndex = 9;
            this.Btn_Verde.Text = "Velocidad Media";
            this.Btn_Verde.UseVisualStyleBackColor = true;
            this.Btn_Verde.Click += new System.EventHandler(this.Btn_Verde_Click);
            // 
            // SERIAL
            // 
            this.SERIAL.PortName = "COM3";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 262);
            this.Controls.Add(this.Btn_Rojo);
            this.Controls.Add(this.Btn_Amarillo);
            this.Controls.Add(this.Btn_Verde);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuraciones";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Rojo;
        private System.Windows.Forms.Button Btn_Amarillo;
        private System.Windows.Forms.Button Btn_Verde;
        public System.IO.Ports.SerialPort SERIAL;
    }
}