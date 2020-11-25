using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n2b2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
                
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        
        public void AbrirMenu()
        {
            Form3 m = new Form3();
            m.Show();
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            Program.Tipo = "Carro";
            AbrirMenu();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Program.Tipo = "Moto";
            AbrirMenu();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Program.Tipo = "Caminhão";
            AbrirMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.Tipo = "Onibus";
            AbrirMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Program.Tipo = "Avião";
            AbrirMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Program.Tipo = "Avião de Guerra";
            AbrirMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Program.Tipo = "Navio de Guerra";
            AbrirMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Program.Tipo = "Navio";
            AbrirMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Program.Tipo = "Trem";
            AbrirMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Program.Tipo = "Marca";
            AbrirMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Program.Tipo = "Modelo";
            AbrirMenu();
        }
    }
}
