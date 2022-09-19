using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Extensions_Exceptions_Units.Extensions
{
    
    public static class MyExtension
    {
        // --- 1 ----
        public static void DivideSingleNumber(this int number)
        {
            try
            {
                int dividerNumber = number / 0;                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The method has ended...");
            }                        
        }
        
        //--- 2 ---
        
        public static void DivideTwoNumbers(int dividend, int divider)
        {
            try
            {
                double dividerNumber = dividend / divider;
                Console.WriteLine($"The resulting value by dividing {dividend} and {divider} is {dividerNumber}");
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine($"Critical error!!!, Only Chuck Norris divides by zero!");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                Console.WriteLine("Execution finished.");
                Console.WriteLine(Environment.NewLine);
            }
        }
        
    }
}
