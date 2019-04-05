namespace Integradora
{
    partial class SEMAFORO_MODIFICAR_CALLE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SEMAFORO_MODIFICAR_CALLE));
            this.Lb_ID = new System.Windows.Forms.Label();
            this.LB_Semaforo = new System.Windows.Forms.Label();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Dgv_Tabla = new System.Windows.Forms.DataGridView();
            this.LB_CalleVertical = new System.Windows.Forms.Label();
            this.LB_CalleHorizontal = new System.Windows.Forms.Label();
            this.Txt_CalleVertical = new System.Windows.Forms.TextBox();
            this.Txt_CalleHorizontal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // Lb_ID
            // 
            this.Lb_ID.AutoSize = true;
            this.Lb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ID.Location = new System.Drawing.Point(237, 32);
            this.Lb_ID.Name = "Lb_ID";
            this.Lb_ID.Size = new System.Drawing.Size(171, 24);
            this.Lb_ID.TabIndex = 6;
            this.Lb_ID.Text = "No Seleccionado";
            // 
            // LB_Semaforo
            // 
            this.LB_Semaforo.AutoSize = true;
            this.LB_Semaforo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Semaforo.Location = new System.Drawing.Point(27, 32);
            this.LB_Semaforo.Name = "LB_Semaforo";
            this.LB_Semaforo.Size = new System.Drawing.Size(213, 24);
            this.LB_Semaforo.TabIndex = 5;
            this.LB_Semaforo.Text = "Semáforo a Modificar:";
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.Location = new System.Drawing.Point(482, 20);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(90, 50);
            this.Btn_Modificar.TabIndex = 4;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
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
            this.Dgv_Tabla.Location = new System.Drawing.Point(12, 179);
            this.Dgv_Tabla.Name = "Dgv_Tabla";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_Tabla.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Tabla.Size = new System.Drawing.Size(560, 270);
            this.Dgv_Tabla.TabIndex = 7;
            this.Dgv_Tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Llevar_A_Label);
            // 
            // LB_CalleVertical
            // 
            this.LB_CalleVertical.AutoSize = true;
            this.LB_CalleVertical.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CalleVertical.Location = new System.Drawing.Point(138, 88);
            this.LB_CalleVertical.Name = "LB_CalleVertical";
            this.LB_CalleVertical.Size = new System.Drawing.Size(97, 18);
            this.LB_CalleVertical.TabIndex = 8;
            this.LB_CalleVertical.Text = "Calle Vertical:";
            // 
            // LB_CalleHorizontal
            // 
            this.LB_CalleHorizontal.AutoSize = true;
            this.LB_CalleHorizontal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CalleHorizontal.Location = new System.Drawing.Point(118, 133);
            this.LB_CalleHorizontal.Name = "LB_CalleHorizontal";
            this.LB_CalleHorizontal.Size = new System.Drawing.Size(117, 18);
            this.LB_CalleHorizontal.TabIndex = 9;
            this.LB_CalleHorizontal.Text = "Calle Horizontal:";
            // 
            // Txt_CalleVertical
            // 
            this.Txt_CalleVertical.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CalleVertical.Location = new System.Drawing.Point(241, 85);
            this.Txt_CalleVertical.Name = "Txt_CalleVertical";
            this.Txt_CalleVertical.Size = new System.Drawing.Size(231, 24);
            this.Txt_CalleVertical.TabIndex = 10;
            this.Txt_CalleVertical.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_CalleHorizontal
            // 
            this.Txt_CalleHorizontal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_CalleHorizontal.Location = new System.Drawing.Point(241, 130);
            this.Txt_CalleHorizontal.Name = "Txt_CalleHorizontal";
            this.Txt_CalleHorizontal.Size = new System.Drawing.Size(231, 24);
            this.Txt_CalleHorizontal.TabIndex = 11;
            this.Txt_CalleHorizontal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SEMAFORO_MODIFICAR_CALLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.Txt_CalleHorizontal);
            this.Controls.Add(this.Txt_CalleVertical);
            this.Controls.Add(this.LB_CalleHorizontal);
            this.Controls.Add(this.LB_CalleVertical);
            this.Controls.Add(this.Dgv_Tabla);
            this.Controls.Add(this.Lb_ID);
            this.Controls.Add(this.LB_Semaforo);
            this.Controls.Add(this.Btn_Modificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SEMAFORO_MODIFICAR_CALLE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.SEMAFORO_MODIFICAR_CALLE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lb_ID;
        private System.Windows.Forms.Label LB_Semaforo;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.DataGridView Dgv_Tabla;
        private System.Windows.Forms.Label LB_CalleVertical;
        private System.Windows.Forms.Label LB_CalleHorizontal;
        private System.Windows.Forms.TextBox Txt_CalleVertical;
        private System.Windows.Forms.TextBox Txt_CalleHorizontal;
    }
}