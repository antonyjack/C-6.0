using System;

namespace Exception_Filter
{
    static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //throw new Exception("400 error");
                throw new Exception("500 error");
            }
            catch (Exception ex) when (ex.Message.Contains("400"))
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) when (ex.Message.Contains("300"))
            {
                //Do some code here
            }
            catch(Exception ex) when (ex.LogException())
            {
                //Never code reach here                
            }
        }

        public static bool LogException(this Exception ex)
        {
            Console.WriteLine($"{ex.Message}");
            return false; //return true it will move to exception block or exit from catch block.
        }
    }    
}
