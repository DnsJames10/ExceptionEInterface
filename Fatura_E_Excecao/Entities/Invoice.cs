using System;
using System.Globalization;


namespace Fatura_E_Excecao.Entities
{
    internal class Invoice
    {

        public double BasicPayment { get; set; }
        public double Tax { get; set; }


        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment; Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
                        
        }


        public override string ToString()
        {
            return "Pagamento basico: " + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)+"\nTaxa: "+Tax.ToString("f2")+
                "\nPagamento Total: R$"+TotalPayment.ToString("f2",CultureInfo.InvariantCulture);

        }


    }
}
