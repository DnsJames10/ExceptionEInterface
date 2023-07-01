using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatura_E_Excecao.Exececoes
{
    internal class DomainExeption : ApplicationException
    {
        public DomainExeption(string message) : base(message)
        {

        }

    }
}
