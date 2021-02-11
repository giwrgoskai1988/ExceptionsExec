using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class NestedEx
    {

        void G()
        {
            throw new CustomException("From G in NestedEx Class");
        }
        
        public void F()
        {
            try
            {
                G();
            }
            catch (CustomException)
            {
                throw new AnotherCustomException("From catch inside F, The 2nd Custom Exception");
            }
            
        }

    }
}
