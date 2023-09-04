using Consola_Bis_Moderna.classes;
using System.Data;
using System.IO;
using System.Windows.Documents;
using WMPLib;

namespace Consola_Bis_Moderna
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public List<Cancion> Canciones = new List<Cancion>();

        public byte[] CancionBytes;

        public string NombreExtension;

        int song_index = 0;

        public void nextSong(int i)
        {

            Cancion cancion_seleccionada = Canciones[i];
            cancion_seleccionada.CrearCancion(ref player);
            pBMusicProgress.Maximum = (int)cancion_seleccionada.duracion_cancion;
            player.controls.play();
        }

        public Form1()
        {
            InitializeComponent();
            player.PlayStateChange += Player_PlayStateChange;
        }

        int before = 0;
        private void Player_PlayStateChange(int NewState)
        {
            if (WMPPlayState.wmppsPlaying == (WMPPlayState)NewState)
                ProgressTimer.Start();
            //else if (WMPPlayState.wmppsMediaEnded == (WMPPlayState)NewState)
            //    before = NewState;
            //else if (WMPPlayState.wmppsMediaEnded == (WMPPlayState)before && WMPPlayState.wmppsTransitioning == (WMPPlayState)NewState)
            //{
            //    ProgressTimer.Stop();
            //    pBMusicProgress.Value = 0;
            //    i = nextSong(i);
            //}
            else if (WMPPlayState.wmppsPaused == (WMPPlayState)NewState)
            {
                ProgressTimer.Stop();
            }
            else if (WMPPlayState.wmppsStopped == (WMPPlayState)NewState)
            {
                ProgressTimer.Stop();
                pBMusicProgress.Value = 0;
            }
        }

        public void limpiar()
        {
            CancionBytes = new byte[0];
            NombreExtension = String.Empty;
            txtbxNombreCancion.Text = String.Empty;
            txtbxDuracion.Text = String.Empty;
            txtbxAlbum.Text = String.Empty;
            txtboxGenero.Text = String.Empty;
            DataGridViewVistaCanciones.DataSource = null;
            DataGridViewVistaCanciones.Columns.Clear();
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
            DataGridViewVistaCanciones.DataSource = dataTable;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn() { HeaderText = " ", Text = "Play", Name = "btnPlay", UseColumnTextForButtonValue = true };
            DataGridViewVistaCanciones.Columns.Add(btn);
            foreach (Cancion cancion in Canciones)
            {
                dataTable.Rows.Add(cancion.nombre, cancion.album, cancion.genero);
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Cancion cancion in Canciones)
            {
                cancion.EliminarCancion();
            }
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
                    txtbxDuracion.Text = player.newMedia(openFile.FileName).duration.ToString();
                    NombreExtension = openFile.SafeFileName;
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
        private void DataGridViewVistaCanciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                song_index = e.RowIndex;
                nextSong(e.RowIndex);
            }
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            //if (pBMusicProgress.Value < pBMusicProgress.Maximum)
            pBMusicProgress.Value = (int)player.controls.currentPosition;
        }

        private void after_button_Click(object sender, EventArgs e)
        {
            if (song_index < Canciones.Count - 1)
            {
                player.controls.stop();
                song_index++;
                nextSong(song_index);
            }
            else
            {
                player.controls.stop();
                song_index = 0;
                nextSong(song_index);
            }
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPPlayState.wmppsPaused)
                player.controls.play();
        }

        private void pause_button_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
                player.controls.pause();
        }

        private void before_button_Click(object sender, EventArgs e)
        {
            if (song_index > 0)
            {
                player.controls.stop();
                song_index--;
                nextSong(song_index);
            }
            else
            {
                player.controls.stop();
                song_index = Canciones.Count - 1;
                nextSong(song_index);
            }
        }
    }
}