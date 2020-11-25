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
                    lbl6.Visible = false;
                    txt6.Visible = false;
                    break;

                case "Caminhão":
                    lbl1.Text = "Identificação";
                    lbl2.Text = "Quantidade de eixos";
                    lbl3.Text = "Capacidade máxima";
                    lbl4.Text = "Codigo do modelo";
                    lbl5.Text = "Descrição do Modelo";
                    lbl6.Text = "Capacidade de passagerios";
                    break;

                case "Onibus":
                    lbl1.Text = "Identificação";
                    lbl2.Text = "Quantidade de eixos";
                    lbl3.Text = "Codigo do modelo";
                    lbl4.Text = "Descrição do modelo";
                    lbl5.Text = "Capacidade de pessaos";
                    lbl6.Visible = false;
                    txt6.Visible = false;
                    break;

                case "Moto":
                    lbl1.Text = "Identificação";
                    lbl2.Text = "Capacidade de passageiros";
                    lbl3.Text = "Codigo do modelo";
                    lbl4.Text = "Descrição do modelo";
                    lbl5.Visible = false;
                    txt5.Visible = false;
                    lbl6.Visible = false;
                    txt6.Visible = false;
                    break;

                case "Avião":
                    lbl1.Text = "Capacidade de passageiros";
                    lbl2.Text = "Identificação";
                    lbl3.Text = "Codigo do modelo";
                    lbl4.Text = "Descrição do modelo";
                    lbl5.Visible = false;
                    txt5.Visible = false;
                    lbl6.Visible = false;
                    txt6.Visible = false;
                    break;

                case "Avião de Guerra":
                    lbl1.Text = "Capacidade de passageiros";
                    lbl2.Text = "Identificação";
                    lbl3.Text = "Codigo do modelo";
                    lbl4.Text = "Descrição do modelo";
                    lbl5.Visible = false;
                    txt5.Visible = false;
                    lbl6.Visible = false;
                    txt6.Visible = false;
                    break;

                case "Trem":
                    lbl1.Text = "Quantidade de vagões";
                    lbl2.Text = "Capacidade de passageiros";
                    lbl3.Text = "Identificação";
                    lbl4.Text = "Codigo do modelo";
                    lbl5.Text = "Descrição do modelo";
                    lbl6.Visible = false;
                    txt6.Visible = false;
                    break;

                case "Navio":
                    lbl1.Text = "Capacidade de passageiros";
                    lbl2.Text = "Identificação";
                    lbl3.Text = "Codigo do modelo";
                    lbl4.Text = "Descrição do modelo";
                    lbl5.Visible = false;
                    txt5.Visible = false;
                    lbl6.Visible = false;
                    txt6.Visible = false;
                    break;

                case "Navio de Guerra":
                    lbl1.Text = "Capacidade de passageiros";
                    lbl2.Text = "Identificação";
                    lbl3.Text = "Codigo do modelo";
                    lbl4.Text = "Descrição do modelo";
                    lbl5.Visible = false;
                    txt5.Visible = false;
                    lbl6.Visible = false;
                    txt6.Visible = false;
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
            else if (Program.Tipo == "Caminhão")
            {
                Camminhao ca = new Camminhao();
                ca.Identificacao = txt1.Text.Trim();
                ca.QtdeEixos = Convert.ToInt32(txt2.Text.Trim());
                ca.CargaMaxima = Convert.ToInt32(txt3.Text.Trim());
                ca.CodigoM = Convert.ToInt32(txt4.Text.Trim());
                ca.DescricaoM = txt5.Text.Trim();
                ca.Capacidade = Convert.ToInt32(txt6.Text.Trim());
                
            }
            else if (Program.Tipo == "Onibus")
            {
                Onibus no = new Onibus();
                no.Identificacao = txt1.Text.Trim();
                no.QtdeEixos = Convert.ToInt32(txt2.Text.Trim());
                no.CodigoM = Convert.ToInt32(txt3.Text.Trim());
                no.DescricaoM = txt4.Text.Trim();
            }
            else if (Program.Tipo == "Avião")
            {
                Aviao av = new Aviao();
                av.Capacidade = Convert.ToInt32(txt1.Text.Trim());
                av.Identificacao = txt2.Text.Trim();
                av.CodigoM = Convert.ToInt32(txt3.Text.Trim());
                av.DescricaoM = txt4.Text.Trim();
            }
            else if (Program.Tipo == "Aviçao de Guerra")
            {
                AviaoGuerra avg = new AviaoGuerra();
                avg.Capacidade = Convert.ToInt32(txt1.Text.Trim());
                avg.Identificacao = txt2.Text.Trim();
                avg.CodigoM = Convert.ToInt32(txt3.Text.Trim());
                avg.DescricaoM = txt4.Text.Trim();
            }
            else if (Program.Tipo == "Navio")
            {
                Navio na = new Navio();
                na.Capacidade = Convert.ToInt32(txt1.Text.Trim());
                na.Identificacao = txt2.Text.Trim();
                na.CodigoM = Convert.ToInt32(txt3.Text.Trim());
                na.DescricaoM = txt4.Text.Trim();
            }
            else if (Program.Tipo == "Navio de Guerra")
            {
                NavioGuerra nag = new NavioGuerra();
                nag.Capacidade = Convert.ToInt32(txt1.Text.Trim());
                nag.Identificacao = txt2.Text.Trim();
                nag.CodigoM = Convert.ToInt32(txt3.Text.Trim());
                nag.DescricaoM = txt4.Text.Trim();
            }
            else if (Program.Tipo == "Trem")
            {
                Trem t = new Trem();
                t.Capacidade = Convert.ToInt32(txt1.Text.Trim());
                t.Identificacao = txt2.Text.Trim();
                t.CodigoM = Convert.ToInt32(txt3.Text.Trim());
                t.DescricaoM = txt4.Text.Trim();
            }
            Close();
            Form2 newForm2 = new Form2();
        }
    }
}
