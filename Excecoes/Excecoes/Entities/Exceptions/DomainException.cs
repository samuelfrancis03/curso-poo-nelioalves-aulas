using System;
using System.Collections.Generic;
using System.Text;

namespace Excecoes.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {

        //EXCEÇÃO PERSONALIZADA
        public DomainException(string message) : base(message) 
        { }

    }
}
