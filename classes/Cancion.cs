using System.IO;
namespace Consola_Bis_Moderna.classes
{
    public class Cancion
    {
        public string nombre;

        public double duracion_cancion;

        public string album;

        public string artista;

        public string genero;

        private string nombre_extencion { get; }

        private byte[] archivo;
        public Cancion(string nombre, string album, string artista, string genero, string nombre_extencion, byte[] archivo)
        {
            this.nombre = nombre;
            this.album = album;
            this.artista = artista;
            this.genero = genero;
            this.nombre_extencion = nombre_extencion;
            this.archivo = archivo;

        }

        public Tuple<bool, Exception?> CrearCancion()
        {
            try
            {
                File.WriteAllBytes(Path.Combine(Directory.GetCurrentDirectory(), nombre_extencion), archivo);
                return new Tuple<bool, Exception?>(false, null);
            }
            catch (Exception ex)
            {
                return new Tuple<bool, Exception?>(false, ex);
            }
        }
    }
}
