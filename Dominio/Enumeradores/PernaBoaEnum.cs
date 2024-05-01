using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Enumeradores
{
    public enum PernaBoaEnum
    {
        [Description("Direita")]
        Direita = 0,
        [Description("Esquerda")]
        Esquerda = 1
    }
}
