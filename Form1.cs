using Consola_Bis_Moderna.classes;
using System.IO;

namespace Consola_Bis_Moderna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Adioos");
        }
    }
}