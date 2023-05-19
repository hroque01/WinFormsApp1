using System.Reflection.Metadata.Ecma335;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.AutoSize = false; // Disabilita il ridimensionamento automatico del testo
            label1.Text = HelloWorld();
            label1.TextAlign = ContentAlignment.MiddleCenter; // Allinea il testo al centro
            label1.Dock = DockStyle.Fill; // Ridimensiona il controllo per adattarsi al testo completo

            this.BackColor = Color.Gray; // Cambia il colore del form corrente
        }

        public string HelloWorld()
        {
            return "Bella ZIOOOOOO!!!!"; // Restituisce l'intera frase
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}