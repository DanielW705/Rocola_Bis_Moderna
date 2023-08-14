using Consola_Bis_Moderna.classes;
using Windows.Storage;
using Windows.Storage.FileProperties;

namespace Consola_Bis_Moderna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_preuba_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog() { AddExtension = true, Filter = "MP3 File (*.mp3)|*.mp3", Multiselect = false })
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {

                    Cancion cancion = new Cancion(
                        Path.GetFileNameWithoutExtension(openFile.FileName),
                        "Hola mundo",
                        "Hola mundo2",
                        "Hola mundo 3",
                        openFile.SafeFileName,
                        File.ReadAllBytes(openFile.FileName)
                        );
                    StorageFile file = StorageFile.GetFileFromPathAsync(openFile.FileName).GetResults();
                    MusicProperties properties = file.Properties.GetMusicPropertiesAsync().GetResults();
                    MessageBox.Show(properties.Duration.ToString());
                }
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Adioos");
        }
    }
}