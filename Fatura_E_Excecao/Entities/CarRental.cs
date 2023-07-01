using System;
using Fatura_E_Excecao.Exececoes;


namespace Fatura_E_Excecao.Entities
{
    internal class CarRental
    {

        public DateTime Start { get; set; }
        public DateTime Finsh { get; set; }
        public Car Car { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental (DateTime start, DateTime finish, Car car)
        {           
              
            Start = start; Finsh = finish; Car = car;
            if (Car.Model == "Marea" || Car.Model == "marea")
            {
                throw new DomainExeption("Não rola, marea é muito zuado");
            }
        }

        

    }
}
