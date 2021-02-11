using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class AnotherCustomException:Exception
    {

        public AnotherCustomException(string message):base(message)
        {

        }
    }
}
