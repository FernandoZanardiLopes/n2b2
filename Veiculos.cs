using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n2b2
{
    class Veiculos : Modelo
    {
        public static string Identificacao { get; set; }
        public static int Velocidade { get; set; }
        public static void Acelera(int v) => v += 1;
        public static void DesAcelera(int v) => v -= 1;
    }
}
