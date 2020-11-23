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
        public void AbrirMenu()
        {
            Menu m = new Menu();
            m.Show();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        private void button8_Click(object sender, EventArgs e)
        {
            Program.Tipo = "Avião de Guerra";
            AbrirMenu();
        }

        private void btncarro_Click(object sender, EventArgs e)
        {
            Program.Tipo = "Carro";
            AbrirMenu();
        }

        private void btnmoto_Click(object sender, EventArgs e)
        {
            Program.Tipo = "Moto";
            AbrirMenu();
        }

        private void btnnavio_Click(object sender, EventArgs e)
        {
            Program.Tipo = "Navio";
            AbrirMenu();
        }

        private void btnnaviog_Click(object sender, EventArgs e)
        {
            Program.Tipo = "Navio de Guerra";
            AbrirMenu();
        }

        private void btncaminhao_Click(object sender, EventArgs e)
        {
            Program.Tipo = "Caminhão";
            AbrirMenu();
        }

        private void btnonibus_Click(object sender, EventArgs e)
        {
            Program.Tipo = "Onibus";
            AbrirMenu();
        }

        private void btnaviao_Click(object sender, EventArgs e)
        {
            Program.Tipo = "Avião";
            AbrirMenu();
        }

        private void btntrem_Click(object sender, EventArgs e)
        {
            Program.Tipo = "Trem";
            AbrirMenu();
        }
    }
}
