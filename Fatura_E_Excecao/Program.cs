using System;
using System.Globalization;
using Fatura_E_Excecao.Entities;
using Fatura_E_Excecao.Serivce;
using Fatura_E_Excecao.Exececoes;



namespace Fatura_E_Exececao
{

    class program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Insira os dados do aluguel");
                Console.Write("Car model: ");
                string modeloCarro = Console.ReadLine();
                Console.Write("Pickup: (MM/dd/yyyy HH:mm): ");
                DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);
                Console.Write("Return: (MM/dd/yyyy HH:mm): ");
                DateTime retorno = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);
                CarRental carRental = new CarRental(inicio, retorno, new Car(modeloCarro));
                Console.WriteLine();
                Console.Write("Enter Price per hour: ");
                double hour = double.Parse(Console.ReadLine());
                Console.Write("Enter Price per day: ");
                double day = double.Parse(Console.ReadLine());
                ProcessInvoice fatura = new ProcessInvoice(hour, day, new BrazilTaxService());
                fatura.ProcessaFatura(carRental);
                Console.WriteLine(carRental.Invoice);
            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(DomainExeption e)
            {
                Console.WriteLine(e.Message);
            }



        }
    }


}