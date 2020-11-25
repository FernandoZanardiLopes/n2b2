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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (velocidade <= 0)
                MessageBox.Show("Veiculo está parado");
            else
                velocidade -= 1;


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
    }
}
