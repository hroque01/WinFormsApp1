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
            
            //Prova cambio colore form
            Form1 form = new Form1();
            form.BackColor = Color.Gray; //PS. NON FUNZIONA
            
        }

        public string HelloWorld()
        {
            return "BELLA ZIOOOOOO!!!!";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}