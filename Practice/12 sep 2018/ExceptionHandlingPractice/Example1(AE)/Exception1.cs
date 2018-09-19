using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPractice
{
    class Exception1 :Interface2
    {
        public void Message1()
        {
            try
            {
               
                int a = 100;
                int b = 0;
                int result = a/b;
                Console.WriteLine(" error in dispalying result");


            }
            catch (Exception e1)
            {
                
              
                Console.WriteLine("Handling the Exception in ");
                Exception ex = new Exception ("Msg",e1);
                Console.WriteLine(ex.Message);
                throw ex;
                


            }
            finally
            {
                Console.WriteLine("Clen up memory and close the connection");
            }
        }

        public void Message2()
        {
            try
            {
                Message1();
                Console.WriteLine("Error message to be displayed");
            }
            catch (Exception e2)
            {
                Console.WriteLine(e2.Message);
                Console.WriteLine("error message from exception e2");
            }
            finally
            {
                Console.WriteLine("Clen up memory and close the connection22222");
            }
        }



    }
}
