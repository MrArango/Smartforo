using System;
using System.Windows.Forms;

namespace Integradora
{
    public partial class SEMAFORO_MOSTRAR : Form
    {
        Conexion Semaforo = new Conexion();

        public SEMAFORO_MOSTRAR()
        {
            InitializeComponent();
        }

        private void SEMAFORO_MOSTRAR_Load(object sender, EventArgs e)
        {
            //LLENAR DATOS
            try
            {
                Semaforo.Conexion_Abrir();
                Dgv_Tabla.DataSource = Semaforo.Semaforo_Mostrar();
                Dgv_Tabla.Rows[0].Cells[0].Selected = false;
                Dgv_Tabla.ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("No Hay Semáforos Registrados");
            }
            finally
            {
                Semaforo.Conexion_Cerrar();
            }

        }
    }
}
