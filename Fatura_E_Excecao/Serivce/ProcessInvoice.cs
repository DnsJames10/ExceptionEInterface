using Fatura_E_Excecao.Entities;

namespace Fatura_E_Excecao.Serivce
{
    internal class ProcessInvoice
    {

        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        private IGlobaService _globalService;

        public ProcessInvoice (double pricePerHour, double pricePerDay, IGlobaService globalService)
        {
            PricePerHour = pricePerDay; PricePerDay = pricePerDay; _globalService = globalService;
            
        }


        public void ProcessaFatura(CarRental carRental)
        {
            TimeSpan duration = carRental.Finsh.Subtract(carRental.Start);

            double valorBase = 0.0;
            
            

            if(duration.TotalHours <= 12)
            {
                valorBase = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                valorBase = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _globalService.Tax(valorBase);

            carRental.Invoice = new Invoice(valorBase, tax);

        }



    }
}
