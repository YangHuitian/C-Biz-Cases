using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_BizCases
{
    class Program
    {
        //BIZ CASES 1        [ turn money num into words ]

        static string tr(string n)//Transfer num into string: 1---One
        {
            switch (n)
            {
                case "0":
                    return "";
                case "1":
                    return "One";
                case "2":
                    return "Two";
                case "3":
                    return "Three";
                case "4":
                    return "Four";
                case "5":
                    return "Five";
                case "6":
                    return "Six";
                case "7":
                    return "Seven";
                case "8":
                    return "Eight";
                case "9":
                    return "Nine";
                case "10":
                    return "Ten";
                case "11":
                    return "Eleven";
                case "12":
                    return "Twelve";
                case "13":
                    return "Thirteen";
                case "14":
                    return "Fourteen";
                case "15":
                    return "Fifteen";
                case "16":
                    return "Sixteen";
                case "17":
                    return "Seventeen";
                case "18":
                    return "Eighteen";
                case "19":
                    return "Nineteen";
                case "20":
                    return "Twenty";
                case "30":
                    return "Thirty";
                case "40":
                    return "Fourty";
                case "50":
                    return "Fifty";
                case "60":
                    return "Sixty";
                case "70":
                    return "Seventy";
                case "80":
                    return "Eighty";
                case "90":
                    return "Ninety";

            }
            return "";
        }
        
        static int Mul(string n)
        {
            int a = Convert.ToInt32((Convert.ToDouble(n))*100);
            return a;
        }

        static void Main(string[] args)
        {
            Console.Write("Pls enter your dollars: ");

            string ss = Console.ReadLine();
            int n = Mul(ss);//912854
            string n1 = Convert.ToString(n);
            //Console.WriteLine(n1);//"912854"//"46325"
            string nn = n1.PadLeft(6, '0');//"046325"
            //Console.WriteLine(nn);//"046325"

            Console.Write("${0} is Dollar ", ss);
            for (int k = 0; k<=nn.Length - 1; k++)
            {
                switch (k)
                {
                    case 0:
                        if (nn[k] != '0')//0XXXXX
                            Console.Write("{0} Thousand ", tr(nn.Substring(k,1)));
                        else//2XXXXX
                            Console.Write("");
                        break;
                    case 1:
                        if (nn[k] != '0')//X3XXXX
                            Console.Write("{0} Hundred ", tr(nn.Substring(k, 1)));
                        else//X0XXXX
                            Console.Write("");
                        break;
                    case 2:
                        if (nn[k] == '0')//XX02XX; XX00XX
                        {
                            if (nn[k + 1] == '0')//XX00XX
                            {
                                Console.Write("");
                                break;
                            }
                            else//XX01XX
                            {
                                Console.Write("and {0} ", tr(nn.Substring(k + 1, 1)));
                                break;
                            } 
                        }
                        else if (nn[k] == '1')//XX1XXX
                        {
                            Console.Write("and {0} ", tr((nn.Substring(k, 2))));
                            break;
                        }
                        else//XX22XX; XX20XX
                        {
                            if (nn[k + 1] == '0')//XX20XX
                            {
                                Console.Write("and {0} ", tr((nn.Substring(k, 1)) + "0"));
                                break;
                            }
                            else//XX22XX
                            {
                                Console.Write("and {0} {1} ", tr((nn.Substring(k, 1)) + "0"), tr(nn.Substring(k + 1, 1)));
                                break;
                            }
                        }
                    case 3:
                        Console.Write("");
                        break;
                    case 4:
                        if (nn[k] == '0')//XXXX02; XXXX00
                        {
                            if (nn[k + 1] == '0')//XXXX00
                            {
                                Console.Write("");
                                break;
                            }
                            else//XXXX02
                            {
                                Console.Write("and Cents {0} ", tr(nn.Substring(k + 1, 1)));
                                break;
                            }
                        }

                        else if (nn[k] == '1')//XXXX1X
                        {
                            Console.Write("and Cents {0} ", tr((nn.Substring(k, 2))));//1X----12: +'0' ***NOT WORK,just sub 2 digi
                            break;
                        }
                        else//XXXX22; XXXX20
                        {
                            if (nn[k + 1] == '0')//XXXX20
                            {
                                Console.Write("and Cents {0} ", tr((nn.Substring(k, 1)) + "0"));
                                break;
                            }
                            else//XXXX22
                            {
                                Console.Write("and Cents {0} {1} ", tr((nn.Substring(k, 1)) + "0"), tr(nn.Substring(k + 1, 1)));
                                break;
                            }
                        }
                        
                    case 5:
                        Console.Write("");
                        break;
                }
            }
            Console.Write("only.");

        }
    }
}
