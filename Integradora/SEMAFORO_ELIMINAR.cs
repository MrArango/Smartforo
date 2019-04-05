using System;
using System.Windows.Forms;

namespace Integradora
{
    public partial class SEMAFORO_ELIMINAR : Form
    {
        Conexion Semaforo = new Conexion();

        public SEMAFORO_ELIMINAR()
        {
            InitializeComponent();
        }

        private void SEMAFORO_ELIMINAR_Load(object sender, EventArgs e)
        {
            //Cargar tabla
            Cargar_Tabla();
            if(Dgv_Tabla.Rows.Count != 0)
            { 
                Dgv_Tabla.SelectedRows[0].Selected = false;
            }
            else
            {
                MessageBox.Show("No Hay Semáforos Registrados");
                this.Close();
            }
            Dgv_Tabla.ReadOnly = true;
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            //Si ID != "No seleccionado", que elimine
            if (Lb_ID.Text != "No Seleccionado")
            {
                try
                {
                    string ID = Lb_ID.Text;
                    Semaforo.Conexion_Abrir();
                    //Eliminar el registro seleccionado
                    Semaforo.Semaforo_Eliminar(ID);

                    MessageBox.Show("¡Semaforo Eliminado!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    Semaforo.Conexion_Cerrar();
                    //Recargar la tabla
                    Cargar_Tabla();
                    //deseleccionar la tabla 
                    if (Dgv_Tabla.Rows.Count != 0)
                    {
                        Dgv_Tabla.SelectedRows[0].Selected = false;
                    }        
                    //resetear Lb_ID
                    Lb_ID.Text = "No Seleccionado";
                }
            }
            else
            {
                MessageBox.Show("Seleccione Un Registro");
            }
           
        }

        public void Cargar_Tabla()
        {
            try
            {
                Semaforo.Conexion_Abrir();
                Dgv_Tabla.DataSource = Semaforo.Semaforo_Eliminar_Tabla();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Semaforo.Conexion_Cerrar();
            }
        }

        private void Llevar_A_Label(object sender, DataGridViewCellEventArgs e)
        {
            Lb_ID.Text = Dgv_Tabla.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
