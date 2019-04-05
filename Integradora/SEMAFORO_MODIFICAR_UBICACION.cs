using System;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Integradora
{
    public partial class SEMAFORO_MODIFICAR_UBICACION : Form
    {
        GMarkerGoogle marcador;
        GMapOverlay capa;
        Conexion Semaforo = new Conexion();

        public SEMAFORO_MODIFICAR_UBICACION()
        {
            InitializeComponent();
        }

        private void SEMAFORO_MODIFICAR_UBICACION_Load(object sender, EventArgs e)
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
            //Si ID != "No seleccionado", que modificar
            if (Lb_ID.Text != "No Seleccionado")
            {
                try
                {
                    string ID = Lb_ID.Text;
                    string Lat = Txt_Latitud.Text;
                    string Lng = Txt_Longitud.Text;

                    Semaforo.Conexion_Abrir();
                    //Modificar el registro seleccionado
                    Semaforo.Semaforo_Modificar_Ubicacion(ID,Lat,Lng);

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
                }
            }
            else
            {
                MessageBox.Show("Seleccione Un Registro");
            }
        }

        private void Cargar_Mapa(object sender, EventArgs e)
        {
            //inicializar el mapa
            //Se puede mover?
            Gmap_Mapa.CanDragMap = true;
            //boton para mover el mapa
            Gmap_Mapa.DragButton = MouseButtons.Left;
            //Quien te provee el mapa?
            Gmap_Mapa.MapProvider = GMapProviders.GoogleMap;
            //Posicion del mapa
            Gmap_Mapa.Position = new PointLatLng(25.674623, -100.461660);
            //Zoom
            Gmap_Mapa.MinZoom = 0;
            Gmap_Mapa.MaxZoom = 24;
            Gmap_Mapa.Zoom = 10;

            Gmap_Mapa.AutoScroll = true;
        }

        private void SeleccionarPunto(object sender, MouseEventArgs e)
        {
            Gmap_Mapa.Overlays.Remove(capa);

            //Obtener los puntos X y Y en una variable
            double lat = Gmap_Mapa.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = Gmap_Mapa.FromLocalToLatLng(e.X, e.Y).Lng;

            //Pasar los puntos a los Txt
            Txt_Latitud.Text = lat.ToString();
            Txt_Longitud.Text = lng.ToString();

            //Marcador
            capa = new GMapOverlay("Marcador");
            marcador = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.red_dot);

            //agregar marcardor al mapa
            Gmap_Mapa.Overlays.Add(capa);

            //Agregar al mapa
            capa.Markers.Add(marcador);

            //Agregar texto al marcador
            marcador.ToolTipMode = MarkerTooltipMode.Always;
            marcador.ToolTipText = string.Format("Nueva Ubicación \n Latitud:{0} \n  Longitud:{1}", lat, lng);
        }

        public void Cargar_Tabla()
        {
            try
            {
                Semaforo.Conexion_Abrir();
                Dgv_Tabla.DataSource = Semaforo.Semaforo_Modificar_Ubicacion_Tabla();
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

        private void Llevar_Datos(object sender, DataGridViewCellMouseEventArgs e)
        {
            Lb_ID.Text = Dgv_Tabla.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
