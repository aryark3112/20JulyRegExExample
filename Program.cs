using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _20JulyRegExExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>()
            {
                "Aman","Amit","Vijay","Anam","Manoj"
            };
            string pattern = @"\b[M]\m+";
            Regex regex = new Regex(pattern);
            string mobPattern = "[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]";
            string[] mobiles = new string[] { "+91-876543210", "9876540981", "+91-876543290", "+91-876543240", "98765432" };
            foreach (string mobile in mobiles )
            {
                if(regex.IsMatch(mobile))
                { Console.WriteLine("{0} is valid mobile number", mobile); }
                else { Console.WriteLine("{0} is not a valid mobile number ",mobile); }
            }
            Console.ReadKey();
            {
                
            }
        }
    }
}
