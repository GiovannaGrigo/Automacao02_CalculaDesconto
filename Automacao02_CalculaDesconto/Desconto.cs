using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automacao02_CalculaDesconto
{
    public class Desconto
    {
        // Define de vai ou não ter desconto (valores >= 350 têm desconto
        public bool recebeDesconto(float valor)
        {
            return (valor >= 350);
        }

        /* Calculo o % de desconto a ser aplicado (se houver)
         * Valores maiores ou iguais a R$ 5.000,00 --> 3,0% desconto
         * Valores maiores ou iguais a R$ 3.000,00 --> 2,0% desconto
         * Valores maiores ou iguais a R$ 1.000,00 --> 1,0% desconto
         * Valores maiores ou iguais a R$   350,00 --> 0,5% desconto */
        public float percentualDesconto(float valor)
        {
            if (valor >= 5000) return 0.03f;
            if (valor >= 3000) return 0.02f;
            if (valor >= 1000) return 0.01f;
            if (valor >= 350)  return 0.005f;
            return 0f;
        }

        /* Calcular o valor do desconto (se houver) */
        public float valorDesconto(float valor)
        {
            return valor * percentualDesconto(valor);
        }

        /* Calcular valor final (considerando desconto, se houver) */
        public float totalCompra(float valor)
        {
            return valor - valorDesconto(valor);
        }
    }
}
