using System;


namespace exececao2.Entities.Exceptions
{
    class DomainExeception : ApplicationException
    {
       public DomainExeception(string message) : base(message)
        {

        }
    }
    
    
}
