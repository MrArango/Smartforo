namespace Integradora
{
    partial class SEMAFORO_ELIMINAR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SEMAFORO_ELIMINAR));
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.LB_Semaforo = new System.Windows.Forms.Label();
            this.Dgv_Tabla = new System.Windows.Forms.DataGridView();
            this.Lb_ID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Location = new System.Drawing.Point(452, 20);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(90, 50);
            this.Btn_Eliminar.TabIndex = 0;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // LB_Semaforo
            // 
            this.LB_Semaforo.AutoSize = true;
            this.LB_Semaforo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Semaforo.Location = new System.Drawing.Point(12, 32);
            this.LB_Semaforo.Name = "LB_Semaforo";
            this.LB_Semaforo.Size = new System.Drawing.Size(204, 24);
            this.LB_Semaforo.TabIndex = 1;
            this.LB_Semaforo.Text = "Semáforo a Eliminar:";
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
            this.Dgv_Tabla.Location = new System.Drawing.Point(12, 98);
            this.Dgv_Tabla.Name = "Dgv_Tabla";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_Tabla.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Tabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Tabla.Size = new System.Drawing.Size(560, 251);
            this.Dgv_Tabla.TabIndex = 2;
            this.Dgv_Tabla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Llevar_A_Label);
            // 
            // Lb_ID
            // 
            this.Lb_ID.AutoSize = true;
            this.Lb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_ID.Location = new System.Drawing.Point(222, 32);
            this.Lb_ID.Name = "Lb_ID";
            this.Lb_ID.Size = new System.Drawing.Size(171, 24);
            this.Lb_ID.TabIndex = 3;
            this.Lb_ID.Text = "No Seleccionado";
            // 
            // SEMAFORO_ELIMINAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.Lb_ID);
            this.Controls.Add(this.Dgv_Tabla);
            this.Controls.Add(this.LB_Semaforo);
            this.Controls.Add(this.Btn_Eliminar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SEMAFORO_ELIMINAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.SEMAFORO_ELIMINAR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Label LB_Semaforo;
        private System.Windows.Forms.DataGridView Dgv_Tabla;
        private System.Windows.Forms.Label Lb_ID;
    }
}