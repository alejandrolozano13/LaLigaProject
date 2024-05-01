using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Enumeradores
{
    public enum PosicaoEnum
    {
        [Description("Goleiro")]
        Goleiro = 0,

        [Description("Lateral Direito")]
        LateralDireito = 1,

        [Description("Zagueiro")]
        Zagueiro = 2,

        [Description("Lateral Esquerdo")]
        LateralEsquerdo = 3,

        [Description("Volante")]
        Volante = 4,

        [Description("Meio Campista")]
        MeioCampista = 5,

        [Description("Meia Direita")]
        MeiaDireita = 6,

        [Description("Meia Esquerda")]
        MeiaEsquerda = 7,

        [Description("Meia Atacante")]
        MeiaAtacante = 8,

        [Description("Segundo Atacante")]
        SegundoAtacante = 9,

        [Description("Ponta Direita")]
        PontaDireita = 10,

        [Description("Ponta Esquerda")]
        PontaEsquerda = 11,

        [Description("Centroavante")]
        Centroavante = 12
    }
}
