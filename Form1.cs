using Consola_Bis_Moderna.classes;
using System.Data;
using System.IO;
using System.Windows.Documents;

namespace Consola_Bis_Moderna
{
    public partial class Form1 : Form
    {
        public List<Cancion> Canciones = new List<Cancion>();

        public byte[] CancionBytes;

        public string NombreExtension;

        public void limpiar()
        {
            CancionBytes = new byte[0];
            NombreExtension = String.Empty;
            txtbxNombreCancion.Text = String.Empty;
            txtbxDuracion.Text = String.Empty;
            txtbxAlbum.Text = String.Empty;
            txtboxGenero.Text = String.Empty;
            DataGridViewVistaCanciones.DataSource = null;
        }
        public void CrearTabla()
        {
            DataTable dataTable = new DataTable();
            DataColumn[] columns = new DataColumn[] {
            new DataColumn("Cancion"),
            new DataColumn("Album"),
            new DataColumn("Genero"),
            };
            dataTable.Columns.AddRange(columns);
            foreach (Cancion cancion in Canciones)
            {
                dataTable.Rows.Add(cancion.nombre, cancion.album, cancion.genero);
            }
            DataGridViewVistaCanciones.DataSource = dataTable;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn() { HeaderText = "Buton prueba", Text = "Play", Name = "btnPlay" };
            DataGridViewVistaCanciones.Columns.Add(btn);

        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void txtbxDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnSubirArchivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog() { AddExtension = true, Filter = "MP3 File (*.mp3)|*.mp3", Multiselect = false })
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    CancionBytes = File.ReadAllBytes(openFile.FileName);
                }
            }
        }

        private void btnAgregarActualizar_Click(object sender, EventArgs e)
        {
            if (txtbxNombreCancion.Text != String.Empty && txtbxDuracion.Text != String.Empty && txtbxAlbum.Text != String.Empty && txtboxGenero.Text != string.Empty && CancionBytes.Length > 0)
            {
                Canciones.Add(
                    new Cancion(
                    txtbxNombreCancion.Text,
                    Double.Parse(txtbxDuracion.Text),
                    txtbxAlbum.Text,
                    txtboxGenero.Text,
                    NombreExtension,
                    CancionBytes)
                    );
                limpiar();
                CrearTabla();
            }
            else
                MessageBox.Show("Hace falta escribir algunos datos o falta subir un archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}