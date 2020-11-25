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
        public static List<Carro> ListaCarros;
        public static List<Moto> ListaMotos;
        public static List<Camminhao> ListaCaminhoes;
        public static List<Onibus> ListaOnibus;
        public static List<Trem> ListaTrem;
        public static List<Aviao> ListaAviao;
        public static List<AviaoGuerra> ListaAviaoG;
        public static List<Navio> ListaNavio;
        public static List<NavioGuerra> ListaNavioG;
        public static List<Marca> ListaMarca;
        public static List<Modelo> ListaModelo;

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
        public static bool salvarMoto(Moto moto)
        {
            try
            {
                File.AppendAllText("moto.txt", moto.Identificacao + "|" + moto.CodigoM + "|" + moto.DescricaoM + "|" + moto.Capacidade.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool salvarCaminhao(Camminhao b)
        {
            try
            {
                File.AppendAllText("caminhao.txt", b.Identificacao + "|" + b.CodigoM.ToString() + "|" + b.DescricaoM + "|" + b.Capacidade.ToString() + "|" + b.QtdeEixos.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool salvarOnibus(Onibus b)
        {
            try
            {
                File.AppendAllText("onibus.txt", b.Identificacao + "|" + b.CodigoM + "|" + b.DescricaoM + "|" + b.Capacidade.ToString() + "|" + b.QtdeEixos.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool salvarNavio(Navio b)
        {
            try
            {
                File.AppendAllText("navio.txt", b.Identificacao + "|" + b.CodigoM + "|" + b.DescricaoM + "|" + b.Capacidade.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool salvarNaviog(NavioGuerra b)
        {
            try
            {
                File.AppendAllText("navioguerra.txt", b.Identificacao + "|" + b.CodigoM + "|" + b.DescricaoM + "|" + b.Capacidade.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool salvaTrem(Trem b)
        {
            try
            {
                File.AppendAllText("trem.txt", b.Identificacao + "|" + b.CodigoM + "|" + b.DescricaoM + "|" + b.Capacidade.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool salvarAviao(Aviao b)
        {
            try
            {
                File.AppendAllText("aviao.txt", b.Identificacao + "|" + b.CodigoM + "|" + b.DescricaoM + "|" + b.Capacidade.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool salvarAviaoG(AviaoGuerra b)
        {
            try
            {
                File.AppendAllText("aviaoguerra.txt", b.Identificacao + "|" + b.CodigoM + "|" + b.DescricaoM + "|" + b.Capacidade.ToString());
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void CriarListas()
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
        public static bool ExisteTxt(string arquivo)
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
        public static void AdcLista(string tipo)
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
                        ListaCarros.Add(c);
                    }
                    break;
                case "Moto":
                    string[] tempm = File.ReadAllText("moto.txt").Split('|');
                    for (int j = 0; j < tempm.Length;)
                    {
                        Moto c = new Moto();
                        c.Identificacao = tempm[j];
                        j++;
                        c.CodigoM = Convert.ToInt32(tempm[j]);
                        j++;
                        c.DescricaoM = tempm[j];
                        j++;
                        c.Capacidade = Convert.ToInt32(tempm[j]);
                        j++;
                        ListaMotos.Add(c);
                    }
                    break;
                case "Caminhao":
                    string[] tempc = File.ReadAllText("caminhao.txt").Split('|');
                    for (int j = 0; j < tempc.Length;)
                    {
                        Camminhao c = new Camminhao();
                        c.Identificacao = tempc[j];
                        j++;
                        c.CodigoM = Convert.ToInt32(tempc[j]);
                        j++;
                        c.DescricaoM = tempc[j];
                        j++;
                        c.Capacidade = Convert.ToInt32(tempc[j]);
                        j++;
                        c.QtdeEixos = Convert.ToInt32(tempc[j]);
                        j++;
                        ListaCaminhoes.Add(c);
                    }
                    break;
                case "Onibus":
                    string[] tempo = File.ReadAllText("onibus.txt").Split('|');
                    for (int j = 0; j < tempo.Length;)
                    {
                        Onibus c = new Onibus();
                        c.Identificacao = tempo[j];
                        j++;
                        c.CodigoM = Convert.ToInt32(tempo[j]);
                        j++;
                        c.DescricaoM = tempo[j];
                        j++;
                        c.Capacidade = Convert.ToInt32(tempo[j]);
                        j++;
                        c.QtdeEixos = Convert.ToInt32(tempo[j]);
                        j++;
                        ListaOnibus.Add(c);
                    }
                    break;
                case "Navio":
                    string[] tempn = File.ReadAllText("navio.txt").Split('|');
                    for (int j = 0; j < tempn.Length;)
                    {
                        Navio c = new Navio();
                        c.Identificacao = tempn[j];
                        j++;
                        c.CodigoM = Convert.ToInt32(tempn[j]);
                        j++;
                        c.DescricaoM = tempn[j];
                        j++;
                        c.Capacidade = Convert.ToInt32(tempn[j]);
                        j++;
                        ListaNavio.Add(c);
                    }
                    break;
                case "NavioGuerra":
                    string[] tempng = File.ReadAllText("navioguerra.txt").Split('|');
                    for (int j = 0; j < tempng.Length;)
                    {
                        NavioGuerra c = new NavioGuerra();
                        c.Identificacao = tempng[j];
                        j++;
                        c.CodigoM = Convert.ToInt32(tempng[j]);
                        j++;
                        c.DescricaoM = tempng[j];
                        j++;
                        c.Capacidade = Convert.ToInt32(tempng[j]);
                        j++;
                        ListaNavioG.Add(c);
                    }
                    break;
                case"Trem":
                    string[] tempt = File.ReadAllText("trem.txt").Split('|');
                    for (int j = 0; j < tempt.Length;)
                    {
                        Trem c = new Trem();
                        c.Identificacao = tempt[j];
                        j++;
                        c.CodigoM = Convert.ToInt32(tempt[j]);
                        j++;
                        c.DescricaoM = tempt[j];
                        j++;
                        c.Capacidade = Convert.ToInt32(tempt[j]);
                        j++;
                        ListaTrem.Add(c);
                    }
                    break;
                case "Aviao":
                    string[] tempa = File.ReadAllText("aviao.txt").Split('|');
                    for (int j = 0; j < tempa.Length;)
                    {
                        Aviao c = new Aviao();
                        c.Identificacao = tempa[j];
                        j++;
                        c.CodigoM = Convert.ToInt32(tempa[j]);
                        j++;
                        c.DescricaoM = tempa[j];
                        j++;
                        c.Capacidade = Convert.ToInt32(tempa[j]);
                        j++;
                        ListaAviao.Add(c);
                    }
                    break;
                case "AviaoGuerra":
                    string[] tempag = File.ReadAllText("aviaoguerra.txt").Split('|');
                    for (int j = 0; j < tempag.Length;)
                    {
                        AviaoGuerra c = new AviaoGuerra();
                        c.Identificacao = tempag[j];
                        j++;
                        c.CodigoM = Convert.ToInt32(tempag[j]);
                        j++;
                        c.DescricaoM = tempag[j];
                        j++;
                        c.Capacidade = Convert.ToInt32(tempag[j]);
                        j++;
                        ListaAviaoG.Add(c);
                    }
                    break;
            }
            string[] tempmarca = File.ReadAllText("marca.txt").Split('|');
            for (int j = 0; j < tempmarca.Length;)
            {
                Marca c = new Marca();
                c.Codigo = Convert.ToInt32(tempmarca[j]);
                j++;
                c.Descricao = tempmarca[j];
                j++;
                ListaMarca.Add(c);
            }

            string[] tempmod = File.ReadAllText("modelo.txt").Split('|');
            for (int j = 0; j < tempmod.Length;)
            {
                Modelo c = new Modelo();
                c.CodigoM = Convert.ToInt32(tempmod[j]);
                j++;
                c.DescricaoM = tempmod[j];
                j++;
                c.Codigo = Convert.ToInt32(tempmod[j]);
                j++;
                ListaMarca.Add(c);
            }
        }
    }
}
