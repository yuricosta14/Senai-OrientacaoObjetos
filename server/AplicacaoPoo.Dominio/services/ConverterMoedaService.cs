namespace AplicacaoPoo.Dominio.services
{
    //static c#
    //partial c#
    //abstract c# 
    //exemplos usando classes instansiadas

    public class ConverterMoedaService
    {
        decimal CotacaoDolar = 5.25m;
        decimal CotacaoLibra = 6.15m;
        decimal CotacaoEuro = 6.00m;

        public decimal ConverterDolarEmReal(decimal valor)
        {
            return valor * CotacaoDolar;
        }

        public decimal ConverterLibrasEmReal(decimal valor)
        {
            return valor * CotacaoLibra;
        }

        public decimal ConverterEuroEmReal(decimal valor)
        {
            return valor * CotacaoEuro;
        }
    } 
}
