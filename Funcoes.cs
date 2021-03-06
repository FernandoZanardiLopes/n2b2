﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace n2b2
{
    class Funcoes
    {
        public static List<Carro> ListaCarros = new List<Carro>();
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
                File.AppendAllText("modelos.txt", m.CodigoM.ToString() + "|" + m.DescricaoM + "|" + m.Marca.Codigo.ToString());
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
                File.AppendAllText("carro.txt", carro.Identificacao + "|" + carro.QtdePortas.ToString() + "|" + carro.CodigoM + "|" + carro.DescricaoM + "|" + carro.Capacidade.ToString() + "|");
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
                File.AppendAllText("moto.txt", moto.Identificacao + "|" + moto.CodigoM + "|" + moto.DescricaoM + "|" + moto.Capacidade.ToString() + "|");
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
                File.AppendAllText("caminhao.txt", b.Identificacao + "|" + b.CodigoM.ToString() + "|" + b.DescricaoM + "|" + b.Capacidade.ToString() + "|" + b.QtdeEixos.ToString() + "|");
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
                File.AppendAllText("onibus.txt", b.Identificacao + "|" + b.CodigoM + "|" + b.DescricaoM + "|" + b.Capacidade.ToString() + "|" + b.QtdeEixos.ToString() + "|");
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
                File.AppendAllText("navio.txt", b.Identificacao + "|" + b.CodigoM + "|" + b.DescricaoM + "|" + b.Capacidade.ToString() + "|");
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
                File.AppendAllText("navioguerra.txt", b.Identificacao + "|" + b.CodigoM + "|" + b.DescricaoM + "|" + b.Capacidade.ToString() + "|");
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
                File.AppendAllText("trem.txt", b.Identificacao + "|" + b.CodigoM + "|" + b.DescricaoM + "|" + b.Capacidade.ToString() + "|");
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
                File.AppendAllText("aviao.txt", b.Identificacao + "|" + b.CodigoM + "|" + b.DescricaoM + "|" + b.Capacidade.ToString() + "|");
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
                File.AppendAllText("aviaoguerra.txt", b.Identificacao + "|" + b.CodigoM + "|" + b.DescricaoM + "|" + b.Capacidade.ToString() + "|");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void CriarListas()
        {

            string[] veiculos = File.ReadAllText("veiculos.txt").Split('|');
            foreach (var i in veiculos)
            {
                if (ExisteTxt(i))
                {

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
        public static void ListarCarro()
        {
            string[] temp = File.ReadAllText("carro.txt").Split('|');
            Marca mindinho = new Marca();
            mindinho.Codigo = 1;
            mindinho.Descricao = "";
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
                c.Velocidade = 0;
                c.Marca = mindinho;
                ListaCarros.Add(c);
                if (j == temp.Length - 1)
                    break;
            }
        }
        public static void ListarMoto()
        {
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
        }
        public static void ListarCaminhao()
        {
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
        }
        public static void ListarOnibus()
        {
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
        }
        public static void ListarNavio()
        {
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
        }
        public static void ListarNavioGuerra()
        {
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

        }
        public static void ListarAviao()
        {
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
        }
        public static void ListarAviaoGuerra()
        {
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
        }
        public static void ListarTrem()
        {
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
        }
        public static void ListarMarcas()
        {
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
        }
        public static void ListarModelos()
        {
            string[] tempmod = File.ReadAllText("modelo.txt").Split('|');
            for (int j = 0; j < tempmod.Length;)
            {
                Modelo c = new Modelo();
                c.CodigoM = Convert.ToInt32(tempmod[j]);
                j++;
                c.DescricaoM = tempmod[j];
                j++;
                c.Marca.Codigo = Convert.ToInt32(tempmod[j]);
                j++;
                ListaModelo.Add(c);
            }
        }
        public static void AdcLista(string tipo)
        {
            switch (tipo.Trim())
            {
                case "Carro":
                    ListarCarro();
                    break;
                case "Moto":
                    ListarMoto();
                    break;
                case "Caminhao":
                    ListarCaminhao();
                    break;
                case "Onibus":
                    ListarOnibus();
                    break;
                case "Navio":
                    ListarNavio();
                    break;
                case "NavioGuerra":
                    ListarNavioGuerra();
                    break;
                case "Trem":
                    ListarTrem();
                    break;
                case "Aviao":
                    ListarAviao();
                    break;
                case "AviaoGuerra":
                    ListarAviaoGuerra();
                    break;
            }
        }
    }
}
