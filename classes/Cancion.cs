using System.IO;
using WMPLib;

namespace Consola_Bis_Moderna.classes
{
    public class Cancion
    {
        public string nombre;

        public double duracion_cancion;

        public string album;

        public string genero;

        private string nombre_extencion { get; }

        private byte[] archivo;

        public string route;

        public Cancion(string nombre, double duracion_cancion, string album, string genero, string nombre_extencion, byte[] archivo)
        {
            this.nombre = nombre;
            this.duracion_cancion = duracion_cancion;
            this.album = album;
            this.genero = genero;
            this.nombre_extencion = nombre_extencion;
            this.archivo = archivo;
            this.route = Path.Combine(Directory.GetCurrentDirectory(), nombre_extencion);
        }

        public Tuple<bool, Exception?> CrearCancion(ref WindowsMediaPlayer player)
        {
            try
            {
                File.WriteAllBytes(route, archivo);
                player.URL = route;
                return new Tuple<bool, Exception?>(false, null);
            }
            catch (Exception ex)
            {
                return new Tuple<bool, Exception?>(false, ex);
            }
        }

        public bool EliminarCancion()
        {
            try
            {
                File.Delete(route);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
