namespace Integradora
{
    partial class SEMAFORO_ALTA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SEMAFORO_ALTA));
            this.LB_CalleVertical = new System.Windows.Forms.Label();
            this.Txt_CalleVertical = new System.Windows.Forms.TextBox();
            this.Txt_CalleHorizontal = new System.Windows.Forms.TextBox();
            this.LB_CalleHorizontal = new System.Windows.Forms.Label();
            this.Txt_Latitud = new System.Windows.Forms.TextBox();
            this.LB_Latitud = new System.Windows.Forms.Label();
            this.Txt_Longitud = new System.Windows.Forms.TextBox();
            this.LB_Longitud = new System.Windows.Forms.Label();
            this.Gmap_Mapa = new GMap.NET.WindowsForms.GMapControl();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Lb_Config = new System.Windows.Forms.Label();
            this.Combo_Config = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LB_CalleVertical
            // 
            this.LB_CalleVertical.AutoSize = true;
            this.LB_CalleVertical.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CalleVertical.Location = new System.Drawing.Point(79, 35);
            this.LB_CalleVertical.Name = "LB_CalleVertical";
            this.LB_CalleVertical.Size = new System.Drawing.Size(97, 18);
            this.LB_CalleVertical.TabIndex = 0;
            this.LB_CalleVertical.Text = "Calle Vertical:";
            // 
            // Txt_CalleVertical
            // 
            this.Txt_CalleVertical.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CalleVertical.Location = new System.Drawing.Point(12, 56);
            this.Txt_CalleVertical.Name = "Txt_CalleVertical";
            this.Txt_CalleVertical.Size = new System.Drawing.Size(231, 24);
            this.Txt_CalleVertical.TabIndex = 1;
            this.Txt_CalleVertical.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_CalleHorizontal
            // 
            this.Txt_CalleHorizontal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CalleHorizontal.Location = new System.Drawing.Point(12, 128);
            this.Txt_CalleHorizontal.Name = "Txt_CalleHorizontal";
            this.Txt_CalleHorizontal.Size = new System.Drawing.Size(231, 24);
            this.Txt_CalleHorizontal.TabIndex = 3;
            this.Txt_CalleHorizontal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LB_CalleHorizontal
            // 
            this.LB_CalleHorizontal.AutoSize = true;
            this.LB_CalleHorizontal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CalleHorizontal.Location = new System.Drawing.Point(73, 107);
            this.LB_CalleHorizontal.Name = "LB_CalleHorizontal";
            this.LB_CalleHorizontal.Size = new System.Drawing.Size(117, 18);
            this.LB_CalleHorizontal.TabIndex = 2;
            this.LB_CalleHorizontal.Text = "Calle Horizontal:";
            // 
            // Txt_Latitud
            // 
            this.Txt_Latitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Latitud.Location = new System.Drawing.Point(12, 205);
            this.Txt_Latitud.Name = "Txt_Latitud";
            this.Txt_Latitud.ReadOnly = true;
            this.Txt_Latitud.Size = new System.Drawing.Size(231, 24);
            this.Txt_Latitud.TabIndex = 5;
            this.Txt_Latitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LB_Latitud
            // 
            this.LB_Latitud.AutoSize = true;
            this.LB_Latitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Latitud.Location = new System.Drawing.Point(97, 184);
            this.LB_Latitud.Name = "LB_Latitud";
            this.LB_Latitud.Size = new System.Drawing.Size(55, 18);
            this.LB_Latitud.TabIndex = 4;
            this.LB_Latitud.Text = "Latitud:";
            // 
            // Txt_Longitud
            // 
            this.Txt_Longitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Longitud.Location = new System.Drawing.Point(9, 288);
            this.Txt_Longitud.Name = "Txt_Longitud";
            this.Txt_Longitud.ReadOnly = true;
            this.Txt_Longitud.Size = new System.Drawing.Size(234, 24);
            this.Txt_Longitud.TabIndex = 7;
            this.Txt_Longitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LB_Longitud
            // 
            this.LB_Longitud.AutoSize = true;
            this.LB_Longitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Longitud.Location = new System.Drawing.Point(90, 267);
            this.LB_Longitud.Name = "LB_Longitud";
            this.LB_Longitud.Size = new System.Drawing.Size(68, 18);
            this.LB_Longitud.TabIndex = 6;
            this.LB_Longitud.Text = "Longitud:";
            // 
            // Gmap_Mapa
            // 
            this.Gmap_Mapa.Bearing = 0F;
            this.Gmap_Mapa.CanDragMap = true;
            this.Gmap_Mapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.Gmap_Mapa.GrayScaleMode = false;
            this.Gmap_Mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Gmap_Mapa.LevelsKeepInMemmory = 5;
            this.Gmap_Mapa.Location = new System.Drawing.Point(260, 12);
            this.Gmap_Mapa.MarkersEnabled = true;
            this.Gmap_Mapa.MaxZoom = 2;
            this.Gmap_Mapa.MinZoom = 2;
            this.Gmap_Mapa.MouseWheelZoomEnabled = true;
            this.Gmap_Mapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.Gmap_Mapa.Name = "Gmap_Mapa";
            this.Gmap_Mapa.NegativeMode = false;
            this.Gmap_Mapa.PolygonsEnabled = true;
            this.Gmap_Mapa.RetryLoadTile = 0;
            this.Gmap_Mapa.RoutesEnabled = true;
            this.Gmap_Mapa.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.Gmap_Mapa.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Gmap_Mapa.ShowTileGridLines = false;
            this.Gmap_Mapa.Size = new System.Drawing.Size(512, 537);
            this.Gmap_Mapa.TabIndex = 8;
            this.Gmap_Mapa.Zoom = 0D;
            this.Gmap_Mapa.Load += new System.EventHandler(this.Cargar_Mapa);
            this.Gmap_Mapa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SeleccionarPunto);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Location = new System.Drawing.Point(129, 499);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(90, 50);
            this.Btn_Salir.TabIndex = 9;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(33, 499);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(90, 50);
            this.Btn_Agregar.TabIndex = 10;
            this.Btn_Agregar.Text = "Agregar";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // Lb_Config
            // 
            this.Lb_Config.AutoSize = true;
            this.Lb_Config.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Config.Location = new System.Drawing.Point(72, 358);
            this.Lb_Config.Name = "Lb_Config";
            this.Lb_Config.Size = new System.Drawing.Size(100, 18);
            this.Lb_Config.TabIndex = 11;
            this.Lb_Config.Text = "Configuración";
            // 
            // Combo_Config
            // 
            this.Combo_Config.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_Config.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Config.FormattingEnabled = true;
            this.Combo_Config.Items.AddRange(new object[] {
            "Lenta",
            "Mediana",
            "Velóz"});
            this.Combo_Config.Location = new System.Drawing.Point(9, 390);
            this.Combo_Config.Name = "Combo_Config";
            this.Combo_Config.Size = new System.Drawing.Size(234, 28);
            this.Combo_Config.TabIndex = 12;
            // 
            // SEMAFORO_ALTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Combo_Config);
            this.Controls.Add(this.Lb_Config);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Gmap_Mapa);
            this.Controls.Add(this.Txt_Longitud);
            this.Controls.Add(this.LB_Longitud);
            this.Controls.Add(this.Txt_Latitud);
            this.Controls.Add(this.LB_Latitud);
            this.Controls.Add(this.Txt_CalleHorizontal);
            this.Controls.Add(this.LB_CalleHorizontal);
            this.Controls.Add(this.Txt_CalleVertical);
            this.Controls.Add(this.LB_CalleVertical);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SEMAFORO_ALTA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_CalleVertical;
        private System.Windows.Forms.TextBox Txt_CalleVertical;
        private System.Windows.Forms.TextBox Txt_CalleHorizontal;
        private System.Windows.Forms.Label LB_CalleHorizontal;
        private System.Windows.Forms.TextBox Txt_Latitud;
        private System.Windows.Forms.Label LB_Latitud;
        private System.Windows.Forms.TextBox Txt_Longitud;
        private System.Windows.Forms.Label LB_Longitud;
        private GMap.NET.WindowsForms.GMapControl Gmap_Mapa;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Label Lb_Config;
        private System.Windows.Forms.ComboBox Combo_Config;
    }
}