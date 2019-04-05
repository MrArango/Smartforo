namespace Integradora
{
    partial class SEMAFORO_MODIFICAR_UBICACION
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SEMAFORO_MODIFICAR_UBICACION));
            this.Gmap_Mapa = new GMap.NET.WindowsForms.GMapControl();
            this.Lb_ID = new System.Windows.Forms.Label();
            this.LB_Semaforo = new System.Windows.Forms.Label();
            this.Btn_Mod = new System.Windows.Forms.Button();
            this.Dgv_Tabla = new System.Windows.Forms.DataGridView();
            this.Txt_Latitud = new System.Windows.Forms.TextBox();
            this.LB_Latitud = new System.Windows.Forms.Label();
            this.Txt_Longitud = new System.Windows.Forms.TextBox();
            this.LB_Longitud = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // Gmap_Mapa
            // 
            this.Gmap_Mapa.Bearing = 0F;
            this.Gmap_Mapa.CanDragMap = true;
            this.Gmap_Mapa.EmptyTileColor = System.Drawing.Color.Navy;
            this.Gmap_Mapa.GrayScaleMode = false;
            this.Gmap_Mapa.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.Gmap_Mapa.LevelsKeepInMemmory = 5;
            this.Gmap_Mapa.Location = new System.Drawing.Point(388, 200);
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
            this.Gmap_Mapa.Size = new System.Drawing.Size(384, 349);
            this.Gmap_Mapa.TabIndex = 9;
            this.Gmap_Mapa.Zoom = 0D;
            this.Gmap_Mapa.Load += new System.EventHandler(this.Cargar_Mapa);
            this.Gmap_Mapa.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SeleccionarPunto);
            // 
            // Lb_ID
            // 
            this.Lb_ID.AutoSize = true;
            this.Lb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ID.Location = new System.Drawing.Point(382, 40);
            this.Lb_ID.Name = "Lb_ID";
            this.Lb_ID.Size = new System.Drawing.Size(171, 24);
            this.Lb_ID.TabIndex = 11;
            this.Lb_ID.Text = "No Seleccionado";
            // 
            // LB_Semaforo
            // 
            this.LB_Semaforo.AutoSize = true;
            this.LB_Semaforo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Semaforo.Location = new System.Drawing.Point(172, 40);
            this.LB_Semaforo.Name = "LB_Semaforo";
            this.LB_Semaforo.Size = new System.Drawing.Size(213, 24);
            this.LB_Semaforo.TabIndex = 10;
            this.LB_Semaforo.Text = "Semáforo a Modificar:";
            // 
            // Btn_Mod
            // 
            this.Btn_Mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Mod.Location = new System.Drawing.Point(574, 28);
            this.Btn_Mod.Name = "Btn_Mod";
            this.Btn_Mod.Size = new System.Drawing.Size(90, 50);
            this.Btn_Mod.TabIndex = 12;
            this.Btn_Mod.Text = "Modificar";
            this.Btn_Mod.UseVisualStyleBackColor = true;
            this.Btn_Mod.Click += new System.EventHandler(this.Btn_Mod_Click);
            // 
            // Dgv_Tabla
            // 
            this.Dgv_Tabla.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_Tabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Tabla.Location = new System.Drawing.Point(12, 200);
            this.Dgv_Tabla.Name = "Dgv_Tabla";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_Tabla.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Tabla.Size = new System.Drawing.Size(370, 349);
            this.Dgv_Tabla.TabIndex = 13;
            this.Dgv_Tabla.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Llevar_Datos);
            // 
            // Txt_Latitud
            // 
            this.Txt_Latitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Latitud.Location = new System.Drawing.Point(84, 125);
            this.Txt_Latitud.Name = "Txt_Latitud";
            this.Txt_Latitud.ReadOnly = true;
            this.Txt_Latitud.Size = new System.Drawing.Size(231, 24);
            this.Txt_Latitud.TabIndex = 15;
            this.Txt_Latitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LB_Latitud
            // 
            this.LB_Latitud.AutoSize = true;
            this.LB_Latitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Latitud.Location = new System.Drawing.Point(169, 104);
            this.LB_Latitud.Name = "LB_Latitud";
            this.LB_Latitud.Size = new System.Drawing.Size(55, 18);
            this.LB_Latitud.TabIndex = 14;
            this.LB_Latitud.Text = "Latitud:";
            // 
            // Txt_Longitud
            // 
            this.Txt_Longitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Longitud.Location = new System.Drawing.Point(490, 125);
            this.Txt_Longitud.Name = "Txt_Longitud";
            this.Txt_Longitud.ReadOnly = true;
            this.Txt_Longitud.Size = new System.Drawing.Size(234, 24);
            this.Txt_Longitud.TabIndex = 17;
            this.Txt_Longitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LB_Longitud
            // 
            this.LB_Longitud.AutoSize = true;
            this.LB_Longitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Longitud.Location = new System.Drawing.Point(571, 104);
            this.LB_Longitud.Name = "LB_Longitud";
            this.LB_Longitud.Size = new System.Drawing.Size(68, 18);
            this.LB_Longitud.TabIndex = 16;
            this.LB_Longitud.Text = "Longitud:";
            // 
            // SEMAFORO_MODIFICAR_UBICACION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.Txt_Longitud);
            this.Controls.Add(this.LB_Longitud);
            this.Controls.Add(this.Txt_Latitud);
            this.Controls.Add(this.LB_Latitud);
            this.Controls.Add(this.Dgv_Tabla);
            this.Controls.Add(this.Btn_Mod);
            this.Controls.Add(this.Lb_ID);
            this.Controls.Add(this.LB_Semaforo);
            this.Controls.Add(this.Gmap_Mapa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SEMAFORO_MODIFICAR_UBICACION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.SEMAFORO_MODIFICAR_UBICACION_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl Gmap_Mapa;
        private System.Windows.Forms.Label Lb_ID;
        private System.Windows.Forms.Label LB_Semaforo;
        private System.Windows.Forms.Button Btn_Mod;
        private System.Windows.Forms.DataGridView Dgv_Tabla;
        private System.Windows.Forms.TextBox Txt_Latitud;
        private System.Windows.Forms.Label LB_Latitud;
        private System.Windows.Forms.TextBox Txt_Longitud;
        private System.Windows.Forms.Label LB_Longitud;
    }
}