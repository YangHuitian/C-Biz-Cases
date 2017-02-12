using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_BizCases
{
    class Biz_Case3
    {
        //Biz Cases3 : Encryption

        static void Encrypt(string s)
        {
            string[] fir = new string[s.Length];//create a new[] for change into next alphabet series
            string ALPH = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string alph = "abcdefghijklmnopqrstuvwxyz";
            string num = "0123456789";

            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (ALPH.Contains(s[i]))
                {
                    for (int j = 0; j <= ALPH.Length - 1; j++)//through out ALPH
                    {
                        if (s[i] == ALPH[j] && ALPH[j] != 'Z')
                        {
                            fir[i] = ALPH.Substring(j + 1, 1);
                        }
                        else if (s[i] == ALPH[j] && ALPH[j] == 'Z')
                        {
                            fir[i] = "A";
                        }
                    }
                }
                else if (alph.Contains(s[i]))
                {
                    for (int p = 0; p <= alph.Length - 1; p++)//through out alph
                    {
                        if (s[i] == alph[p] && alph[p] != 'z')
                        {
                            fir[i] = alph.Substring(p + 1, 1);
                        }
                        else if (s[i] == alph[p] && alph[p] == 'z')
                        {
                            fir[i] = "a";
                        }
                    }
                }
                else//num Contains s[i]
                {
                    for (int n = 0; n <= num.Length - 1; n++)//through out num
                    {
                        if (s[i] == num[n] && n != 9)
                        {
                            fir[i] = num.Substring(n + 1, 1);
                        }
                        else if (s[i] == num[n] && n == 9)
                        {
                            fir[i] = "0";
                        }
                    }
                }
            }
            Console.WriteLine(String.Join("", fir));

            string[] sec = new string[fir.Length];//create a new[] for Mirror Image Change
            for (int u = 0; u <= fir.Length - 1; u++)//123opQ
            {
                sec[u] = fir[5-u];
            }

            Console.WriteLine(String.Join("", sec));
        }   


        public static void Main()
        {
            Console.Write("Pls enter your password: ");
            string password = Console.ReadLine();
            Encrypt(password);
        }
    }
}
