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
            label1.Text = HelloWorld();

            // Prova cambio colore form
            this.BackColor = Color.Gray; // Cambia il colore del form corrente
        }


        public string HelloWorld()
        {
            return "BELLA ZIOOOOOO!!!!"; //SPACCATO
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}