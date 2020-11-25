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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbltitulo.Text = Program.Tipo;
            switch (Program.Tipo)
            {
                case "Carro":
                    lbl1.Text = "Quantidade portas";
                    lbl2.Text = "Capacidade de passageiros";
                    lbl3.Text = "Identificação";
                    lbl4.Text = "Codigo do modelo";
                    lbl5.Text = "Descrição do modelo";
                    break;

                case "Caminhão":
                    lbl1.Text = "Identificação";
                    lbl2.Text = "Quantidade de eixos";
                    lbl3.Text = "Capacidade máxima";
                    lbl4.Text = "Codigo do modelo";
                    lbl5.Visible = false;
                    txt5.Visible = false;
                    break;

                case "Onibus":
                    lbl1.Text = "Quantidade de eixos";
                    lbl2.Visible = false;
                    txt2.Visible = false;
                    lbl3.Visible = false;
                    txt3.Visible = false;
                    lbl4.Visible = false;
                    txt4.Visible = false;
                    lbl5.Visible = false;
                    txt5.Visible = false;
                    break;

                case "Moto":
                    lbl1.Text = "Capacidade de passageiros";
                    lbl2.Text = "Identificação";
                    lbl3.Text = "Codigo do modelo";
                    lbl4.Text = "Descrição do modelo";
                    lbl5.Visible = false;
                    txt5.Visible = false;
                    break;

                case "Avião":
                    lbl1.Text = "Capacidade de passageiros";
                    lbl2.Visible = false;
                    txt2.Visible = false;
                    lbl3.Visible = false;
                    txt3.Visible = false;
                    lbl4.Visible = false;
                    txt4.Visible = false;
                    lbl5.Visible = false;
                    txt5.Visible = false;
                    break;

                case "Avião de Guerra":
                    lbl1.Text = "Capacidade de passageiros";
                    lbl2.Visible = false;
                    txt2.Visible = false;
                    lbl3.Visible = false;
                    txt3.Visible = false;
                    lbl4.Visible = false;
                    txt4.Visible = false;
                    lbl5.Visible = false;
                    txt5.Visible = false;
                    break;

                case "Trem":
                    lbl1.Text = "Quantidade de vagões";
                    lbl2.Text = "Capacidade de passageiros";
                    lbl3.Visible = false;
                    txt3.Visible = false;
                    lbl4.Visible = false;
                    txt4.Visible = false;
                    lbl5.Visible = false;
                    txt5.Visible = false;
                    break;

                case "Navio":
                    lbl1.Text = "Capacidade de passageiros";
                    lbl2.Visible = false;
                    txt2.Visible = false;
                    lbl3.Visible = false;
                    txt3.Visible = false;
                    lbl4.Visible = false;
                    txt4.Visible = false;
                    lbl5.Visible = false;
                    txt5.Visible = false;
                    break;

                case "Navio de Guerra":
                    lbl1.Text = "Capacidade de passageiros";
                    lbl2.Visible = false;
                    txt2.Visible = false;
                    lbl3.Visible = false;
                    txt3.Visible = false;
                    lbl4.Visible = false;
                    txt4.Visible = false;
                    lbl5.Visible = false;
                    txt5.Visible = false;
                    break;
            }
        }

        private void lbltitulo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.Tipo == "Carro")
            {
                Carro c = new Carro();
                c.Identificacao = txt3.Text.Trim();
                c.CodigoM = Convert.ToInt32(txt4.Text.Trim());
                c.QtdePortas = Convert.ToInt32(txt1.Text.Trim());
                c.Capacidade = Convert.ToInt32(txt2.Text.Trim());
                c.DescricaoM = txt5.Text.Trim();

                Funcoes.salvarCarro(c);
            }
            else if (Program.Tipo == "Moto")
            {
                Moto m = new Moto();
                m.Capacidade = Convert.ToInt32(txt1.Text.Trim());
                m.Identificacao = txt2.Text.Trim();
                m.CodigoM = Convert.ToInt32(txt3.Text.Trim());
                m.DescricaoM = txt4.Text.Trim();

                Funcoes.salvarMoto(m);

            }

        }
    }
}
