using System;
using System.Collections.Generic;
using System.Text;

namespace FixacaoExcecao.Entities.Exception
{
    internal class DomainException : ApplicationException
    {

        public DomainException(string message) : base(message) { }

    }
}
