using System;

namespace Exception_Filter
{
    static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //throw new Exception("200 error");
                throw new Exception("500 error");
            }
            catch (Exception ex) when (ex.Message.Contains("200"))
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
            return false;
        }
    }    
}
