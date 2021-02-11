using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class ClassC:ClassB
    {

        public override void Throw()
        {
            throw new ExceptionC("Exception C from Class C");
        }


        public int DoSomething(int result)
        {
            if (result < 3)
                Throw();

            return ++result;
        }
    }
}
