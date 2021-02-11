using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Simple
    {

        public void Throw()
        {
            try
            {
                throw new Exception("Exception Base Class");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.Data);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Everything is completed"); 
                Console.WriteLine("---------------------------------------------------------------------------"); 
            }
        }
    }
}
