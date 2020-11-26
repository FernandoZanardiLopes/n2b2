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
    public partial class Form3 : Form
    {
        public Form3()
        {
            Funcoes.AdcLista(Program.Tipo);
            //switch (Program.Tipo)
            //{
            //    case "Carro":
            //        foreach(var i in Funcoes.ListaCarros)
            //        {
            //            checkedListBox1.Items.Add(i);
            //        }
                    //ltbListaveiculos.DataSource = Funcoes.ListaCarros;
                   // break;
                //case "Moto":
                //    ltbListaveiculos.DataSource = Funcoes.ListaMotos;
                //    break;
                //case "Caminhao":
                //    ltbListaveiculos.DataSource = Funcoes.ListaCaminhoes;
                //    break;
                //case "Onibus":
                //    ltbListaveiculos.DataSource = Funcoes.ListaOnibus;
                //    break;
                //case "Navio":
                //    ltbListaveiculos.DataSource = Funcoes.ListaNavio;
                //    break;
                //case "NavioGuerra":
                //    ltbListaveiculos.DataSource = Funcoes.ListaNavioG;
                //    break;
                //case "Trem":
                //    ltbListaveiculos.DataSource = Funcoes.ListaTrem;
                //    break;
                //case "Aviao":
                //    ltbListaveiculos.DataSource = Funcoes.ListaAviao;
                //    break;
                //case "AviaoGuerra":
                //    ltbListaveiculos.DataSource = Funcoes.ListaAviaoG;
                //    break;
           // }
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Program.Tipo == "Modelo")
            {
                Form5 t = new Form5();
                t.Show();
            }
            else if (Program.Tipo == "Marca")
            {
                Form5 t = new Form5();
                t.Show();
            }
            else
            {
                Form2 tela = new Form2();
                tela.Show();
            }

                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.NomeVeiculo = txtdescricao.Text.Trim();
           Form4 tela = new Form4();
            tela.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //if (Program.Tipo == "Modelo")
            //{
            //    button2.Visible = false;
            //    ltbListaveiculos.Visible = false;
            //}
            //else if (Program.Tipo == "Marca")
            //{
            //    button2.Visible = false;
            //    ltbListaveiculos.Visible = false;
            //}
           
        }

        //private void ltbListaveiculos_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Program.NomeVeiculo = ltbListaveiculos.SelectedItem.ToString();
        //}
    }
}
