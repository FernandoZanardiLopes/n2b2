using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace n2b2
{
    class Funcoes
    {
        public List<Carro> ListaCarros;
        public List<Moto> ListaMotos;
        public List<Camminhao> ListaCaminhoes;
        public List<Onibus> ListaOnibus;
        public List<Trem> ListaTrem;
        public List<Aviao> ListaAviao;
        public List<AviaoGuerra> ListaAviaoG;
        public List<Navio> ListaNavio;
        public List<NavioGuerra> ListaNavioG;

        public static void SalvarMarca(Marca m)
        {
            File.AppendAllText("marcas.txt", m.Codigo.ToString() + "|" + m.Descricao);
        }
        public static bool SalvarModelo(Modelo m)
        {
            try
            {
                File.AppendAllText("modelos.txt", m.CodigoM.ToString() + "|" + m.DescricaoM + "|" + m.Codigo.ToString() + "|" + m.Descricao);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool salvarCarro(Carro carro)
        {
            try
            {
                File.AppendAllText("carros.txt",carro.Identificacao + "|" + carro.QtdePortas.ToString() +"|" + carro.CodigoM + "|" + carro.DescricaoM + "|" + carro.Capacidade.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void CriarListas()
        {

            string[] veiculos= File.ReadAllText("veiculos.txt").Split('|');
            foreach(var i in veiculos)
            {
                if (ExisteTxt(i))
                {
                    AdcLista(i);
                }
            }

        }
        public bool ExisteTxt(string arquivo)
        {
            if (File.Exists($"{arquivo.Trim()}.txt"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void AdcLista(string tipo)
        {
            switch (tipo.Trim())
            {
                case "Carro":
                    string[] temp = File.ReadAllText("carro.txt").Split('|');
                    for (int j = 0; j < temp.Length;)
                    {
                        Carro c = new Carro();
                        c.Identificacao = temp[j];
                        j++;
                        c.QtdePortas = Convert.ToInt32(temp[j]);
                        j++;
                        c.CodigoM = Convert.ToInt32(temp[j]);
                        j++;
                        c.DescricaoM = temp[j];
                        j++;
                        c.Capacidade = Convert.ToInt32(temp[j]);
                        
                        j++;
                    }
                    break;
                case "Moto":
                    break;
                case "Caminhao":
                    break;
            }
        }
    }
}
