﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPOO.Dominio
{
    public class Credito
    {
        Pagamento Pagamento { get; set; }
        int Parcelas { get; set; }
        float Juros { get; set; }
    }
}
