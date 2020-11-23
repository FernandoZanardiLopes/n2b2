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
    public partial class Informaçoes : Form
    {
        public Informaçoes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Informaçoes_Load(object sender, EventArgs e)
        {
            switch(Program.Tipo)
            {
                case "Carro":
                    lb3.Visible = false;
                    textBox3.Visible = false;
                    lb4.Visible = false;
                    textBox4.Visible = false;
                    lb5.Visible = false;
                    textBox5.Visible = false;
                    lb6.Visible = false;
                    textBox6.Visible = false;
                    lb7.Visible = false;
                    checkBox1.Visible = false;
                    break;

                case "Caminhão":
                    lbveiculo.Text = "Caminhão";
                    lb1.Text = "Quantidade de eixos";
                    lb3.Text = "Capacidade máxima";
                    lb4.Visible = false;
                    textBox4.Visible = false;
                    lb5.Visible = false;
                    textBox5.Visible = false;
                    lb6.Visible = false;
                    textBox6.Visible = false;
                    lb7.Visible = false;
                    checkBox1.Visible = false;
                    break;

                case "Onibus":
                    lbveiculo.Text = "Onibus";
                    lb1.Text = "Quantidade de eixos";
                    lb3.Visible = false;
                    textBox3.Visible = false;
                    lb4.Visible = false;
                    textBox4.Visible = false;
                    lb5.Visible = false;
                    textBox5.Visible = false;
                    lb6.Visible = false;
                    textBox6.Visible = false;
                    break;

                case "Moto":
                    lbveiculo.Text = "Moto";
                    lb1.Text = "Capacidade de passageiros";
                    lb2.Visible = false;
                    textBox2.Visible = false;
                    lb3.Visible = false;
                    textBox3.Visible = false;
                    lb4.Visible = false;
                    textBox4.Visible = false;
                    lb5.Visible = false;
                    textBox5.Visible = false;
                    lb6.Visible = false;
                    textBox6.Visible = false;
                    lb7.Visible = false;
                    checkBox1.Visible = false;
                    break;

                case "Avião":
                    lbveiculo.Text = "Avião";
                    lb1.Text = "Capacidade de passageiros";
                    lb2.Visible = false;
                    textBox2.Visible = false;
                    lb3.Visible = false;
                    textBox3.Visible = false;
                    lb4.Visible = false;
                    textBox4.Visible = false;
                    lb5.Visible = false;
                    textBox5.Visible = false;
                    lb6.Visible = false;
                    textBox6.Visible = false;
                    lb7.Visible = false;
                    checkBox1.Visible = false;
                    break;

                case "Avião de Guerra":
                    lbveiculo.Text = "Avião de Guerra";
                    lb1.Text = "Capacidade de passageiros";
                    lb2.Visible = false;
                    textBox2.Visible = false;
                    lb3.Visible = false;
                    textBox3.Visible = false;
                    lb4.Visible = false;
                    textBox4.Visible = false;
                    lb5.Visible = false;
                    textBox5.Visible = false;
                    lb6.Visible = false;
                    textBox6.Visible = false;
                    lb7.Visible = false;
                    checkBox1.Visible = false;
                    break;

                case "Trem":
                    lbveiculo.Text = "Trem";
                    lb1.Text = "Quantidade de vagões";
                    lb2.Text = "Capacidade de passageiros";
                    lb3.Visible = false;
                    textBox3.Visible = false;
                    lb4.Visible = false;
                    textBox4.Visible = false;
                    lb5.Visible = false;
                    textBox5.Visible = false;
                    lb6.Visible = false;
                    textBox6.Visible = false;
                    lb7.Visible = false;
                    checkBox1.Visible = false;
                    break;

                case "Navio":
                    lbveiculo.Text = "Navio";
                    lb1.Text = "Capacidade de passageiros";
                    lb2.Visible = false;
                    textBox2.Visible = false;
                    lb3.Visible = false;
                    textBox3.Visible = false;
                    lb4.Visible = false;
                    textBox4.Visible = false;
                    lb5.Visible = false;
                    textBox5.Visible = false;
                    lb6.Visible = false;
                    textBox6.Visible = false;
                    lb7.Visible = false;
                    checkBox1.Visible = false;
                    break;

                case "Navio de Guerra":
                    lbveiculo.Text = "Navio de Guerra";
                    lb1.Text = "Capacidade de passageiros";
                    lb2.Visible = false;
                    textBox2.Visible = false;
                    lb3.Visible = false;
                    textBox3.Visible = false;
                    lb4.Visible = false;
                    textBox4.Visible = false;
                    lb5.Visible = false;
                    textBox5.Visible = false;
                    lb6.Visible = false;
                    textBox6.Visible = false;
                    lb7.Visible = false;
                    checkBox1.Visible = false;
                    break;

            }
        }

        private void lb6_Click(object sender, EventArgs e)
        {

        }
    }
}
