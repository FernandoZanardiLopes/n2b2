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
        public static string Identificacao { get; set; }
        public static string Tipo { get; set; }
        public static int Velocidade { get; set; }
        public static int Capacidade { get; set; }
        public static void Acelera() => Velocidade += 1;
        public static void DesAcelera() => Velocidade -= 1;
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
        public static int QtdeEixos { get; set; }
        public double Pedagio = 8.50 * double.Parse(QtdeEixos.ToString());
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
        public static int QtdeEixos { get; set; }
        public int CapacidadePassageiros{ get; set; }
        public double Pedagio = 8.50 * double.Parse(QtdeEixos.ToString());
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
