using System;
using System.Windows.Forms;

namespace Integradora
{
    public partial class SEMAFORO_MODIFICAR_CALLE : Form
    {
        Conexion Semaforo = new Conexion();

        public SEMAFORO_MODIFICAR_CALLE()
        {
            InitializeComponent();
        }

        private void SEMAFORO_MODIFICAR_CALLE_Load(object sender, EventArgs e)
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

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Lb_ID.Text != "No Seleccionado")
            {
                if(Txt_CalleHorizontal.Text != "" && Txt_CalleVertical.Text != "")
                {
                    try
                    {
                        string ID = Lb_ID.Text;
                        string Vertical = Txt_CalleVertical.Text;
                        string Horizontal = Txt_CalleHorizontal.Text;

                        Semaforo.Conexion_Abrir();
                        //Modificar el registro seleccionado
                        Semaforo.Semaforo_Modificar_Calles(ID, Vertical, Horizontal);

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
                        Txt_CalleHorizontal.Text = "";
                        Txt_CalleVertical.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Rellene Los Campos");
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
                Dgv_Tabla.DataSource = Semaforo.Semaforo_Modificar_Calles_Tabla();
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
            Txt_CalleVertical.Text = Dgv_Tabla.CurrentRow.Cells[1].Value.ToString();
            Txt_CalleHorizontal.Text = Dgv_Tabla.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
