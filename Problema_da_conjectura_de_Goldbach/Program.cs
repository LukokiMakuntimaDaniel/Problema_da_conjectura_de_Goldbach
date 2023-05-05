using System;
using System.Diagnostics;

namespace Problema_da_conjectura_de_Goldbach
{
    class Program
    {
        public static bool primo(int n)
        {
            int qtdDiv = 0;
            if(n%2==0 && n != 2)
            {
                return false;
            }
            for(int cont = 1; cont <= n; cont++)
            {
                if (n % cont == 0)
                {
                    qtdDiv++;
                }
                if (qtdDiv > 2)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            bool encontrei = false;
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                for(int cont=3; cont<n; cont++)
                {
                    if(cont%2!=0 && primo(cont))
                    {
                        for(int cont1=3;cont1<n; cont1++)
                        {
                            if (cont1 % 2 != 0 && primo(cont1) && (cont+cont1)==n)
                            {
                                encontrei = true;
                                Console.WriteLine("" + cont);
                                Console.WriteLine("" + cont1);
                                break;
                            }
                        }
                    }
                    if (encontrei)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("o Tempo foi "+ stopwatch.ElapsedMilliseconds/1000);
        }
    }
}
