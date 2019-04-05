using System;
using System.Windows.Forms;

namespace Integradora
{
    public partial class SEMAFORO_MODIFICAR_CONFIGURACION : Form
    {
        Conexion Semaforo = new Conexion();

        public SEMAFORO_MODIFICAR_CONFIGURACION()
        {
            InitializeComponent();
        }

        private void SEMAFORO_MODIFICAR_CONFIGURACION_Load(object sender, EventArgs e)
        {
            Cargar_Tabla();
            if (Dgv_Tabla.Rows.Count != 0)
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

        private void Btn_Mod_Click(object sender, EventArgs e)
        {
            if (Lb_ID.Text != "No Seleccionado")
            {
                if (Combo_Config.Text != "")
                {
                    try
                    {
                        string ID = Lb_ID.Text;
                        string Config = Combo_Config.Text;

                        Semaforo.Conexion_Abrir();
                        //Modificar el registro seleccionado
                        Semaforo.Semaforo_Modificar_Configuracion(ID, Config);

                        MessageBox.Show("¡Semaforo Modificado!");
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
                        Dgv_Tabla.SelectedRows[0].Selected = false;
                        //resetear Lb_ID
                        Lb_ID.Text = "No Seleccionado";
                        Combo_Config.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione Una Configuración");
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
                Dgv_Tabla.DataSource = Semaforo.Semaforo_Modificar_Configuracion_Tabla();
            }
            catch (Exception ex)
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
