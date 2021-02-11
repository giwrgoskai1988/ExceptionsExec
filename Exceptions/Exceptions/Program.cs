using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Simple s = new Simple();
            s.Throw();

            try
            {
                throw new CustomException("Custom Exception");
            }
            catch(CustomException cex)
            {
                cex.ShowMessage();
                Console.WriteLine("_____________________________________________________");
            }

            NestedEx neX = new NestedEx();

            try
            {
                neX.F();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("_____________________________________________");
            }

           
            ClassA c = new ClassC();
            
            try
            {
                c.Throw();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            
            }


            ClassC classC = new ClassC();

            int result = 0;
            while(result< 5)
            {
                try
                {
                    result = classC.DoSomething(result);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    result++;
                }
            }

            
           
            

        }




    }
}
