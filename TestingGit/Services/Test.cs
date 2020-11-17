using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingGit.Services
{
    public class Test
    {
        public int a { get; set; }
        public int b { get; set; }

        public void Complex()
        {
            var rand = new Random();
            a = rand.Next(1, 10);
            b = rand.Next(1, 10);
            //b= a-2
            if(a==1 && b==2)
            {
                a = rand.Next(1, 10);
                b = rand.Next(1, 10);
                if (a == 1 && b == 2)
                {
                    a = rand.Next(1, 10);
                    b = rand.Next(1, 10);
                    if (a == 1 && b == 2)
                    {
                        a = rand.Next(1, 10);
                        b = rand.Next(1, 10);
                        if (a == 1 && b == 2)
                        {
                            a = rand.Next(1, 10);
                            b = rand.Next(1, 10);
                            if (a == 1 && b == 2)
                            {
                                a = rand.Next(1, 10);
                                b = rand.Next(1, 10);
                                if (a == 1 && b == 2)
                                {
                                    a = rand.Next(1, 10);
                                    b = rand.Next(1, 10);
                                    if (a == 1 && b == 2)
                                    {
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        public void Complex2()
        {
            var rand = new Random();
            b = rand.Next(1, 10);
            a = rand.Next(1, 10);
            //b= a-2
            if (a == 1 && b == 2)
            {
                a = rand.Next(1, 10);
                b = rand.Next(1, 10);
                if (a == 1 && b == 2)
                {
                    a = rand.Next(1, 10);
                    b = rand.Next(1, 10);
                    if (a == 1 && b == 2)
                    {
                        a = rand.Next(1, 10);
                        b = rand.Next(1, 10);
                        if (a == 1 && b == 2)
                        {
                            a = rand.Next(1, 10);
                            b = rand.Next(1, 10);
                            if (a == 1 && b == 2)
                            {
                                a = rand.Next(1, 10);
                                b = rand.Next(1, 10);
                                if (a == 1 && b == 2)
                                {
                                    a = rand.Next(1, 10);
                                    b = rand.Next(1, 10);
                                    if (a == 1 && b == 2)
                                    {
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
