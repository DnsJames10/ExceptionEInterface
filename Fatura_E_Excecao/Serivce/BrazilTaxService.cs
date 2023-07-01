using System;


namespace Fatura_E_Excecao.Serivce
{
    internal class BrazilTaxService: IGlobaService
    {
        public double Tax(double amount)
        {
            if(amount <= 100)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }

    }
}
