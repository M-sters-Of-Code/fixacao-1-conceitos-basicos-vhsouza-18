﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    class CalculaDesconto
    {
        public static double Calcular()
        {
            double valor = 100;
            double desconto = 0.1;
            double valorComDesconto = valor - (valor * desconto);
            return valorComDesconto;
        }
    }
