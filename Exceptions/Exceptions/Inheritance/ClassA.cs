using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class ClassA
    {

        public virtual void Throw()
        {
            throw new ExceptionA("Exception A from Class A");
        }
    }
}
