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
            lbl5.Text = 0.ToString();

        }
        public int velocidade = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            velocidade += 1;
            lblvelocidade.Text = velocidade.ToString();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lblveiculo.Text = Program.Tipo + ": ";
            switch(Program.Tipo)
            {
                case "Carro":
                    
                    foreach (var batatinha in Funcoes.ListaCarros)
                    {
                        if(batatinha.Identificacao == Program.NomeVeiculo)
                        {
                            
                            Pedagio.b.Identificacao = batatinha.Identificacao;
                            Pedagio.b.QtdePortas = batatinha.QtdePortas;
                            Pedagio.b.CodigoM = batatinha.CodigoM;
                            Pedagio.b.Capacidade = batatinha.Capacidade;
                            break;
                        }
                    }
                    lbl11.Text = "Quantidade portas";
                    lbl1.Text = Pedagio.b.QtdePortas.ToString();
                    lbl12.Text = "Capacidade de passageiros" ;
                    lbl2.Text = Pedagio.b.Capacidade.ToString();
                    lbl13.Text = "Identificação";
                    lbl3.Text = Pedagio.b.Identificacao;
                    lbl14.Text = "Codigo do modelo";
                    lbl4.Text = Pedagio.b.CodigoM.ToString();
                    lbl15.Visible = false;
                    lbl16.Visible = false;
                    lbl6.Visible = false;
                    lbl17.Visible = false;
                    lbl7.Visible = false;
                    lblkg.Visible = false;
                    break;

                case "Caminhão":
                    lbl11.Text = "Identificação";
                    lbl12.Text = "Quantidade de eixos";
                    lbl13.Text = "Capacidade máxima";
                    lbl14.Text = "Codigo do modelo";
                    lbl15.Text = "Peso carregado";
                    lbl16.Text = "Capacidade de passagerios";
                    lbl17.Text = "Descrição do Modelo";
                    break;

                case "Onibus":
                    lbl11.Text = "Identificação";
                    lbl12.Text = "Quantidade de eixos";
                    lbl13.Text = "Codigo do modelo";
                    lbl14.Text = "Descrição do modelo";
                    lbl15.Text = "Capacidade de pessaos";
                    lblkg.Visible = false;
                    lbl16.Visible = false;
                    lbl6.Visible = false;
                    lbl17.Text = "Leito";
                    break;

                case "Moto":
                    lbl11.Text = "Identificação";
                    lbl12.Text = "Capacidade de passageiros";
                    lbl13.Text = "Codigo do modelo";
                    lbl14.Text = "Descrição do modelo";
                    lblkg.Visible = false;
                    lbl15.Visible = false;
                    lbl5.Visible = false;
                    lbl16.Visible = false;
                    lbl6.Visible = false;
                    lbl17.Visible = false;
                    lbl7.Visible = false;
                    break;

                case "Avião":
                    lbl11.Text = "Capacidade de passageiros";
                    lbl12.Text = "Identificação";
                    lbl13.Text = "Codigo do modelo";
                    lbl14.Text = "Descrição do modelo";
                    lblkg.Visible = false;
                    lbl15.Visible = false;
                    lbl5.Visible = false;
                    lbl16.Visible = false;
                    lbl6.Visible = false;
                    lbl17.Visible = false;
                    lbl7.Visible = false;
                    break;

                case "Avião de Guerra":
                    lbl11.Text = "Capacidade de passageiros";
                    lbl12.Text = "Identificação";
                    lbl13.Text = "Codigo do modelo";
                    lbl14.Text = "Descrição do modelo";
                    lblkg.Visible = false;
                    lbl15.Visible = false;
                    lbl5.Visible = false;
                    lbl16.Visible = false;
                    lbl6.Visible = false;
                    lbl17.Visible = false;
                    lbl7.Visible = false;
                    break;

                case "Trem":
                    lbl11.Text = "Quantidade de vagões";
                    lbl12.Text = "Capacidade de passageiros";
                    lbl13.Text = "Identificação";
                    lbl14.Text = "Codigo do modelo";
                    lbl15.Text = "Descrição do modelo";
                    lblkg.Visible = false;
                    lbl16.Visible = false;
                    lbl6.Visible = false;
                    lbl17.Visible = false;
                    lbl7.Visible = false;
                    break;

                case "Navio":
                    lbl11.Text = "Capacidade de passageiros";
                    lbl12.Text = "Identificação";
                    lbl13.Text = "Codigo do modelo";
                    lbl14.Text = "Descrição do modelo";
                    lbl15.Visible = false;
                    lblkg.Visible = false;
                    lbl5.Visible = false;
                    lbl16.Visible = false;
                    lbl6.Visible = false;
                    lbl17.Visible = false;
                    lbl7.Visible = false;
                    break;

                case "Navio de Guerra":
                    lbl11.Text = "Capacidade de passageiros";
                    lbl12.Text = "Identificação";
                    lbl13.Text = "Codigo do modelo";
                    lbl14.Text = "Descrição do modelo";
                    lbl15.Visible = false;
                    lbl5.Visible = false;
                    lblkg.Visible = false;
                    lbl16.Visible = false;
                    lbl6.Visible = false;
                    lbl17.Visible = false;
                    lbl7.Visible = false;
                    break;
            }
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

        private void button12_Click(object sender, EventArgs e)
        {
            if(Program.Tipo == "Moto")
            {
                MessageBox.Show("Empinando !!!!");
                Thread.Sleep(2000);
                MessageBox.Show("Bololololololololololo!!!!!!");
            }
            else
            {
                MessageBox.Show("Você não está em uma Moto");
            }
        }

        public static double MudaPeso(double peso, double atual)
        {
            double i = atual + peso;
            if (i < 0)
            {
                return 0;
            }
            else
            {
                return i;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Program.Tipo == "Caminhão")
            {
                lbl5.Text = MudaPeso(double.Parse(txtpeso.Text), double.Parse(lbl5.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Você Não é um veiculo de carga");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Program.Tipo == "Caminhão")
            {
                lbl5.Text = MudaPeso(- double.Parse(txtpeso.Text), double.Parse(lbl5.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Você Não é um veiculo de carga");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Program.Tipo == "Navio de Guerra")
                MessageBox.Show("Atacando o Navio");

            else if (Program.Tipo == "Avião de Guerra")
                MessageBox.Show("Atacando o Avião");

            else
                MessageBox.Show("Você não está em um Veiculo de Guerra");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(Program.Tipo == "Avião")
            {
                MessageBox.Show("Pousando o Avião");
            }
            else if (Program.Tipo == "Avião de Guerra")
            {
                MessageBox.Show("Pousando o Avião");
            }
            else
                MessageBox.Show("Você Não esta em um Avião");

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Program.Tipo == "Avião")
            {
                MessageBox.Show("Decolando o Avião");
            }
            else if (Program.Tipo == "Avião de Guerra")
            {
                MessageBox.Show("Decolando o Avião");
            }
            else
                MessageBox.Show("Você Não esta em um Avião");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Program.Tipo == "Avião")
            {
                MessageBox.Show("Ejetando do Avião");
            }
            else if (Program.Tipo == "Avião de Guerra")
            {
                MessageBox.Show("Ejetando do Avião");
            }
            else
            {
                MessageBox.Show("Você Não esta em um Avião");

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Program.Tipo == "Avião")
            {
                MessageBox.Show("Arremetendo o Voo");
            }
            else if (Program.Tipo == "Avião de Guerra")
            {
                MessageBox.Show("Arremetendo o Voo");
            }
            else
                MessageBox.Show("Você Não esta em um Avião");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            switch (Program.Tipo)
            {
                case "Carro":
                    Pedagio.Pagar(Pedagio.b.Pedagio);
                    MessageBox.Show("Pedagio Pago");
                    break;
                case "Moto":
                    Pedagio.Pagar(Pedagio.b.Pedagio);
                    MessageBox.Show("Pedagio Pago");
                    break;
                case "Caminhão":
                    Pedagio.Pagar(Pedagio.b.Pedagio);
                    MessageBox.Show("Pedagio Pago");
                    break;
                case "Onibus":
                    Pedagio.Pagar(Pedagio.b.Pedagio);
                    MessageBox.Show("Pedagio Pago");
                    break;
            }
                
                
        }
    }
}
