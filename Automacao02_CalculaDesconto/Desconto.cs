namespace Automacao02_CalculaDesconto
{
    public class Desconto
    {
        // Define se vai ter ou não desconto (valores >= 350 têm desconto)
        public bool recebeDesconto(float valor)
        {
            return (valor >= 350);
        }

        /* Calcula o % de desconto a ser aplicado (se houver)
         * Valores maiores ou iguais a R$ 5.000,00 --> 3,0% de desconto
         * Valores maiores ou iguais a R$ 3.000,00 --> 2,0% de desconto
         * Valores maiores ou iguais a R$ 1.000,00 --> 1,0% de desconto
         * Valores maiores ou iguais a R$   350,00 --> 0,5% de desconto
         */ 
        public float percentualDesconto(float valor)
        {
            if (valor >= 5000)
                return 0.03f;
            if (valor >= 3000)
                return 0.02f;
            if (valor >= 1000)
                return 0.01f;
            if (valor >= 350)
                return 0.005f;
            return 0f;
        }

        // Calcular o valor do desconto (se houver)
        public float valorDesconto(float valor)
        {
            return valor * percentualDesconto(valor);
        }

        // Calcular o valor final (considerando desconto, se houver)
        public float totalCompra(float valor)
        {
            return valor - valorDesconto(valor);
        }
    }
}
