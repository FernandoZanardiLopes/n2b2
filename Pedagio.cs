using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n2b2
{
    class Pedagio
    {
        public static double Pago { get; set; }
        public static void Pagar(double dinheiro) =>Pago += dinheiro;
        public static void PagarPorEixo(double dinheiro, int eixo) =>Pagar(dinheiro * eixo);
    }
}
