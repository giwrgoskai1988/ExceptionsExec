using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class ClassB:ClassA
    {
        public override void Throw()
        {
            throw new ExceptionB("Exception B from Class B");
        }
    }
}
