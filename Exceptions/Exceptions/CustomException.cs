using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class CustomException:Exception
    {
         string _customMessage;


        public CustomException(string message) : base(message)
        {
            _customMessage = message;
        }

        public void ShowMessage()
        {
            Console.WriteLine(_customMessage);
        }



        

    }
}
