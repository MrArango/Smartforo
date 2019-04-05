using System;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Integradora
{
    public partial class SEMAFORO_ALTA : Form
    {
        GMarkerGoogle marcador;
        GMapOverlay capa;
        Conexion Semaforo = new Conexion();

        public SEMAFORO_ALTA()
        {
            InitializeComponent();
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
            //Remueve el marcador anterior
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
           
            //Agregar al mapa
            capa.Markers.Add(marcador);
            
            //Agregar texto al marcador
            marcador.ToolTipMode = MarkerTooltipMode.Always;
            marcador.ToolTipText = string.Format("Latitud:{0} \n  Longitud:{1}", lat, lng);

            //agregar marcardor al mapa
            Gmap_Mapa.Overlays.Add(capa);            
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if (Txt_CalleHorizontal.Text != "" && Txt_CalleVertical.Text != "" && Txt_Latitud.Text != "" && Txt_Longitud.Text != "" && Combo_Config.Text != "")
            {
                string CalleH = Txt_CalleHorizontal.Text;
                string CalleV = Txt_CalleVertical.Text;
                string Lng = Txt_Longitud.Text;
                string Lat = Txt_Latitud.Text;
                string Config = Combo_Config.Text;

                try
                {
                    Semaforo.Conexion_Abrir();
                    Semaforo.Semaforo_Agregar(CalleH, CalleV, Lat, Lng, Config);
                    MessageBox.Show("¡Semaforo Agregado!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    Semaforo.Conexion_Cerrar();
                    Vaciar();
                }
            }
            else
            {
                MessageBox.Show("Rellena Todos Los Campos");
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Vaciar()
        {
            Txt_CalleHorizontal.Text = "";
            Txt_CalleVertical.Text = "";
            Txt_Latitud.Text = "";
            Txt_Longitud.Text = "";
            Combo_Config.Text = "";
            Gmap_Mapa.Overlays.Remove(capa);
        }
    }
}
