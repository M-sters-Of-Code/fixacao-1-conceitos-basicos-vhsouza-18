﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoConceitosBasicos1.Model
{
    public class CalculaAumento
    {
        public static double Calcular()
        {
            double salario = 1000;
            double aumento = 0.1;
            double salarioAumentado = salario + (salario * aumento);
            return salarioAumentado;

        }
    }
}
