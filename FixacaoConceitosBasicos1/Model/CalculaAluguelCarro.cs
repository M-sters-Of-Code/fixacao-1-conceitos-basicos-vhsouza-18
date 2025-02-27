using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    class CalculaAluguelCarro
    {
        public void CalculoAluguelCarro()
        {
            decimal valorDiaria = 95;
            int quilometragemInicial = 100;
            int quilometragemFinal = 300;
            decimal valorQuilometro = 0.35m;
            int dias = 5;
            decimal valorTotal = (valorDiaria * dias) + ((quilometragemFinal - quilometragemInicial) * valorQuilometro);
        }
    }
}
