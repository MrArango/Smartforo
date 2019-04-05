using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integradora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agregarSemaforoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SEMAFORO_ALTA Semaforo_Alta = new SEMAFORO_ALTA();
            Semaforo_Alta.ShowDialog();
        }

        private void callesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SEMAFORO_MODIFICAR_CALLE Semaforo_Modificar_Calle = new SEMAFORO_MODIFICAR_CALLE();
            Semaforo_Modificar_Calle.ShowDialog();
        }

        private void ubicaciónGeoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SEMAFORO_MODIFICAR_UBICACION Semaforo_Modificar_Ubicacion = new SEMAFORO_MODIFICAR_UBICACION();
            Semaforo_Modificar_Ubicacion.ShowDialog();
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SEMAFORO_MODIFICAR_CONFIGURACION Semaforo_Modificar_Configuracion = new SEMAFORO_MODIFICAR_CONFIGURACION();
            Semaforo_Modificar_Configuracion.ShowDialog();
        }

        private void eliminarSemáforoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SEMAFORO_ELIMINAR Semaforo_Eliminar = new SEMAFORO_ELIMINAR();
            Semaforo_Eliminar.ShowDialog();
        }

        private void semaforosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SEMAFORO_MOSTRAR Semaforo_Mostrar = new SEMAFORO_MOSTRAR();
            Semaforo_Mostrar.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult RES = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(RES==DialogResult.Yes)
                Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Config arduino = new Config();
            arduino.ShowDialog();
        }
    }
}
