using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Integradora
{
    class Conexion
    {
        SqlConnection Con = new SqlConnection(Properties.Settings.Default.Cadena_SQL);
        
        public void Conexion_Abrir()
        {
            Con.Open();
        }

        public void Conexion_Cerrar()
        {
            Con.Close();
        }

        public void Semaforo_Agregar(string CalleH_, string CalleV_, string Lat_, string Lng_, string Config_)
        {
            SqlCommand Semaforo_Agregar = new SqlCommand("Semaforo_Agregar", Con);
            Semaforo_Agregar.CommandType = CommandType.StoredProcedure;

            Semaforo_Agregar.Parameters.AddWithValue("@Calle_Horizontal", CalleH_);
            Semaforo_Agregar.Parameters.AddWithValue("@Calle_Vertical", CalleV_);
            Semaforo_Agregar.Parameters.AddWithValue("@Latitud", Lat_);
            Semaforo_Agregar.Parameters.AddWithValue("@Longitud", Lng_);
            Semaforo_Agregar.Parameters.AddWithValue("@Configuracion", Config_);

            Semaforo_Agregar.ExecuteNonQuery();
        }

        public void Semaforo_Modificar_Calles(string ID,string Vertical,string Horizontal)
        {
            SqlCommand Semaforo_Modificar_Calles = new SqlCommand("Semaforo_Modificar_Calles", Con);
            Semaforo_Modificar_Calles.CommandType = CommandType.StoredProcedure;

            Semaforo_Modificar_Calles.Parameters.AddWithValue("@ID_Semaforo", ID);
            Semaforo_Modificar_Calles.Parameters.AddWithValue("@Calle_Vertical", Vertical);
            Semaforo_Modificar_Calles.Parameters.AddWithValue("@Calle_Horizontal", Horizontal);

            Semaforo_Modificar_Calles.ExecuteNonQuery();
        }

        public DataTable Semaforo_Modificar_Calles_Tabla()
        {
            SqlCommand Semaforo_Modificar_Calles_Tabla = new SqlCommand("Semaforo_Modificar_Calles_Tabla", Con);
            Semaforo_Modificar_Calles_Tabla.CommandType = CommandType.StoredProcedure;

            DataTable Tabla = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(Semaforo_Modificar_Calles_Tabla);
            adapter.Fill(Tabla);

            return Tabla;
        }

        public void Semaforo_Modificar_Ubicacion(string ID,string Lat, string Lng)
        {
            SqlCommand Semaforo_Modificar_Ubicacion = new SqlCommand("Semaforo_Modificar_Ubicacion", Con);
            Semaforo_Modificar_Ubicacion.CommandType = CommandType.StoredProcedure;

            Semaforo_Modificar_Ubicacion.Parameters.AddWithValue("@ID_Semaforo", ID);
            Semaforo_Modificar_Ubicacion.Parameters.AddWithValue("@LNG", Lng);
            Semaforo_Modificar_Ubicacion.Parameters.AddWithValue("@LAT", Lat);

            Semaforo_Modificar_Ubicacion.ExecuteNonQuery();
        }

        public DataTable Semaforo_Modificar_Ubicacion_Tabla()
        {
            SqlCommand Semaforo_Modificar_Ubicacion_Tabla = new SqlCommand("Semaforo_Modificar_Ubicacion_Tabla", Con);
            Semaforo_Modificar_Ubicacion_Tabla.CommandType = CommandType.StoredProcedure;

            DataTable Tabla = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(Semaforo_Modificar_Ubicacion_Tabla);
            adapter.Fill(Tabla);

            return Tabla;
        }

        public void Semaforo_Modificar_Configuracion(string ID, string Config)
        {
            SqlCommand Semaforo_Modificar_Config = new SqlCommand("Semaforo_Modificar_Config", Con);
            Semaforo_Modificar_Config.CommandType = CommandType.StoredProcedure;

            Semaforo_Modificar_Config.Parameters.AddWithValue("@ID_Semaforo", ID);
            Semaforo_Modificar_Config.Parameters.AddWithValue("@Config", Config);

            Semaforo_Modificar_Config.ExecuteNonQuery();
        }

        public DataTable Semaforo_Modificar_Configuracion_Tabla()
        {
            SqlCommand Semaforo_Modificar_Tabla = new SqlCommand("Semaforo_Modificar_Config_Tabla", Con);
            Semaforo_Modificar_Tabla.CommandType = CommandType.StoredProcedure;

            DataTable Tabla = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(Semaforo_Modificar_Tabla);
            adapter.Fill(Tabla);

            return Tabla;
        }

        public void Semaforo_Eliminar(string ID_Semaforo)
        {
            SqlCommand Semaforo_Eliminar = new SqlCommand("Semaforo_Eliminar", Con);
            Semaforo_Eliminar.CommandType = CommandType.StoredProcedure;

            Semaforo_Eliminar.Parameters.AddWithValue("@ID_Semaforo",ID_Semaforo);

            Semaforo_Eliminar.ExecuteNonQuery();
        }

        public DataTable Semaforo_Eliminar_Tabla()
        {
            SqlCommand Semaforo_Eliminar_Tabla = new SqlCommand("Semaforo_Eliminar_Tabla", Con);
            Semaforo_Eliminar_Tabla.CommandType = CommandType.StoredProcedure;

            DataTable Tabla = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(Semaforo_Eliminar_Tabla);
            adapter.Fill(Tabla);

            return Tabla;
        }

        public DataTable Semaforo_Mostrar()
        {
            SqlCommand Semaforo_Mostrar = new SqlCommand("Semaforo_Datos", Con);
            Semaforo_Mostrar.CommandType = CommandType.StoredProcedure;

            DataTable Tabla = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(Semaforo_Mostrar);
            adapter.Fill(Tabla);

            return Tabla;
        }
    }
}
