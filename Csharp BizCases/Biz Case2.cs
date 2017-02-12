using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_BizCases
{
    class Biz_Case2
    {
        //Biz Cases 2: Data migration: Postal Code
        //assunming that the old addresss is "Tower 52 Blk 729 West Coast, Singapore 1254"

        static string d3ToNumber(string s)
        {
            switch (s)
            {
                case "A":
                    return "1";
                case "B":
                    return "2";
                case "C":
                    return "3";
                case "D":
                    return "4";
                case "E":
                    return "5";
                case "F":
                    return "6";
                case "G":
                    return "7";
                case "H":
                    return "8";
            }
            return "";
        }   

        public static void Main()
        {
            Console.Write("Your address is: ");
            string w = Console.ReadLine().ToUpper();
            string[] s = w.Split(' ');

            string bln = "";
            string enn = "";
            for (int i = 0; i <= s.Length -1; i++)
            {
                if (s[i] == "BLK" || s[i] == "BlOCK")
                {
                    bln = s[i + 1];//"729B"
                }
                else if (s[i] == "SINGAPORE")
                {
                    enn = s[i + 1];//1254
                }
            }

            string d3 = "";
            if (bln.Length == 4)//exist B
            {
                d3 = d3ToNumber(bln.Substring(3, 1));
            }
            else//(bln.Length == 3)//not exist B
            {
                d3 = "0";
            }

            string new12 = enn.Substring(2, 2);
            string new456 = bln.Substring(0, 3);
            string newcode = new12 + d3 + new456;
            Console.WriteLine("Your New Postal Code is: {0}", newcode);
        }
    }
}
