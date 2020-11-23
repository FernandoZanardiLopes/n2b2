using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n2b2
{
    class Veiculo : Modelo
    {
        public string Identificacao { get; set; }
        public string Tipo { get; set; }
        public int Velocidade { get; set; }
        public int Capacidade { get; set; }
        public void Acelera() => Velocidade += 1;
        public void DesAcelera()
        {
            if (Velocidade <= 0)
            { 
                Velocidade -= 1; 
            }
            else
            {
                MessageBox.Show("O Veiculo esta parado!");
            }

        }
        public static double CalcPedagio(int eixos) => 8.50 * eixos;
    }
     class Limpador
    {
        public void ligar()
        {
            MessageBox.Show("Limpador Ligado");
        }
        public void Desligar()
        {
            MessageBox.Show("Limpador Desligado");
        }
        public void ligarTodos()
        {
            MessageBox.Show("Os limpadorres estão Ligados");
        }
        public void DesligarTodos()
        {
            MessageBox.Show("Os limpadorres estão Desligados");
        }
    }
    class Moto :Veiculo
    {
        public string Empinar() => "Empinando";
        public double Pedagio = 3.00;
    }
    class Carro: Veiculo
    {
        public int QtdePortas { get; set; }
        public double Pedagio = 7.00;
    }
    class Camminhao : Veiculo
    {
        public int QtdeEixos { get; set; }
        public double Pedagio { get; set; }
        public double PesoCarregado { get; set; }
        public double CargaMaxima { get; set; }
        public void Carregar (double peso) => PesoCarregado += peso;
        public void DesCarregar () => PesoCarregado = 0;
        public void Acelera()
        {
            if (PesoCarregado <= CargaMaxima)
            {
                MessageBox.Show("Não é possivel andar com sobrepeso");
                return;
            }
            Velocidade += 1;
        }
    }
    class Onibus : Veiculo
    {
        public int QtdeEixos { get; set; }
        public double Pedagio { get; set; }
        public bool Leito { get; set; }
    }
    class Aviao : Veiculo
    {
        public void Pousar()
        {
            MessageBox.Show("O avião pousou");
        }
        public void Arremeter()
        {
            MessageBox.Show("O Arremeteu");
        }
        public void Decolar()
        {
            MessageBox.Show("O avião Decolou");
        }
    }
    class AviaoGuerra : Aviao
    {
        public void Atacar()
        {
            MessageBox.Show("Atacando");
        }
        public void Ejetar()
        {
            MessageBox.Show("Ejetando");
        }
    }
    class Trem : Veiculo
    {
        public static int QtdeVagoes { get; set; }
    }
    class Navio : Veiculo
    {
        public void atracar() => MessageBox.Show("Navio atracado!");
    }
    class NavioGuerra : Navio
    {
        public void atacar() => MessageBox.Show("Atacando,'Tem que atacar mesmo, TA OK ?!'");
    }
}
