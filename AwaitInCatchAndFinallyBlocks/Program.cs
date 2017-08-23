using System;
using System.Threading;
using System.Threading.Tasks;

namespace AwaitInCatchAndFinallyBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();            
        }

        public static async Task<string> Test()
        {
            await AsyncMethodStartLog();
            try
            {                
                throw new Exception("200 error");
            }
            catch (Exception ex) when (ex.Message.Contains("200"))
            {
                await LogError("Custom error",ex);
                return "Success";            
            }
            finally
            {
                await AsyncMethodEndLog();
            }
        }

        public static async Task AsyncMethodStartLog()
        {
            Console.WriteLine("Method start..");
        }

        public static async Task AsyncMethodEndLog()
        {
            Console.WriteLine("Method end..");
        }

        public static async Task LogError(string message, Exception ex)
        {
            Console.WriteLine($"{message}, {ex.Message}");
        }
    }    
}
