using System;

namespace DelegateTest
{


    class Program
    {
        static void Main()
        {
            
           try
            {
                Console.WriteLine("In parent try");
                CatchTest();
            }
            catch(Exception ex)
            {
                Console.WriteLine("In parent catch");
            }

           
        }

        private static void CatchTest()
        {
            try
            {
                Console.WriteLine("In child try");
                throw new Exception("Child Unhandle error");
            }
            catch (Exception ex)
            {
                Console.WriteLine("In Child Catch");
                return;
            }
            finally
            {
                Console.WriteLine("Child Finally");
            }
        }
        
    }

}
