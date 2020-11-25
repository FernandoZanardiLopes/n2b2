using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace n2b2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public int velocidade = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            velocidade += 1;
            lblvelocidade.Text = velocidade.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lblveiculo.Text = Program.Tipo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblvelocidade.Text) <= 0)
                MessageBox.Show("Veiculo está parado");
            else
                velocidade -= 1;
            lblvelocidade.Text = velocidade.ToString();
        }
        int i = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            
            if (i == 0)
            {
                MessageBox.Show("Lipador ligado");
                i = 1;
            }
            else
            {
                MessageBox.Show("Limpador Desligado");
                i = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Program.Tipo == "Navio")
                MessageBox.Show("O Navio Foi Atracado");

            else if (Program.Tipo == "Navio de Guerra")
                MessageBox.Show("O Navio Foi Atracado");

            else
                MessageBox.Show("Você não está em um Navio");

        }
    }
}
