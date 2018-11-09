using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labsheet
{
    class Program4
    {
        static void Main(string[] args)
        {
            char c;
            int m, n, i, j, k;
            do
            {
            enter_a:
                Console.Write("Enter the Order of Matrix :- \n Enter the value of M:- ");
                m = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n Enter the value of N:- ");
                n = Convert.ToInt32(Console.ReadLine());
                if (m == n)
                {
                    int[,] a = new int[m, n];
                    int[,] b = new int[m, n];
                
                    for (i = 0; i < m; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("\nEnter the Value of a[" + i + "][" + j + "]:-");
                            a[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                
                    for (i = 0; i < m; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("\nEnter the Value of b[" + i + "][" + j + "]:- ");
                            b[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                def:
                    Console.Write("\n1.)Addition \n2.)Subtraction\n3.)Multiply\n4.)Transpose of Matrix a\n5.)Transpose of matrix B\n6.)Sum of Diagonal of a\n7.)Sum of Diagonal of b\nEnter Your choice:- ");
                    c = Console.ReadKey().KeyChar;
                    switch (c)
                    {
                        case '1':
                            int[,] sum = new int[m, n];
                            for (i = 0; i < m; i++)
                            {
                                for (j = 0; j < n; j++)
                                {
                                    sum[i, j] = a[i, j] + b[i, j];
                                }
                            }
                            Console.WriteLine("\nAfter A + B");
                            for (i = 0; i < m; i++)
                            {
                                for (j = 0; j < n; j++)
                                {
                                    Console.Write("{0}\t", sum[i, j]);
                                }
                                Console.WriteLine();
                            }
                            break;
                        case '2':
                            int[,] sub = new int[m, n];
                            for (i = 0; i < m; i++)
                            {
                                for (j = 0; j < n; j++)
                                {
                                    sub[i, j] = a[i, j] - b[i, j];
                                }
                            }
                            Console.WriteLine("\nAfter A - B");
                            for (i = 0; i < m; i++)
                            {
                                for (j = 0; j < n; j++)
                                {
                                    Console.Write("{0}\t", sub[i, j]);
                                }
                                Console.WriteLine();
                            }
                            break;
                        case '3':
                            int[,] mul = new int[m, n];
                            for (i = 0; i < m; i++)
                            {
                                for (j = 0; j < n; j++)
                                {
                                    mul[i, j] = 0;
                                }
                            }
                            for (i = 0; i < m; i++)
                            {
                                for (j = 0; j < n; j++)
                                {
                                    for (k = 0; k < n; k++)
                                        mul[i, j] += a[i, k] * b[k, j];
                                }

                            }
                            Console.WriteLine("\nAfter A * B");
                            for (i = 0; i < m; i++)
                            {
                                for (j = 0; j < n; j++)
                                {
                                    Console.Write("{0}\t", mul[i, j]);
                                }
                                Console.WriteLine();
                            }
                            break;
                        case '4':
                            for (i = 0; i < m; i++)
                            {
                                for (j = 0; j < n; j++)
                                    Console.Write("{0}\t", a[j, i]);
                                Console.WriteLine();
                            }
                            break;
                        case '5':
                            for (i = 0; i < m; i++)
                            {
                                for (j = 0; j < n; j++)
                                    Console.Write("{0}\t", b[j, i]);
                                Console.WriteLine();
                            }
                            break;
                        case '6':
                            k = 0;
                       
                                for (i = 0; i < m; i++)
                                {
                                    for (j = 0; j < n; j++)
                                        if (i == j || i + j == m - 1)
                                            k += a[i, j];

                                }
                    
                            break;
                        case '7':
                            k = 0;
                                for (i = 0; i < m; i++)
                                {
                                    for (j = 0; j < n; j++)
                                        if (i == j || i + j == m - 1)
                                            k += b[i, j];

                                }
                            
                            break;
                        default: Console.WriteLine("Invalid choice\n Kindly Choose Correct Option \n"); goto def;
                    }
                }
                else
                {
                    Console.WriteLine("Entered order is not created square matrix\n your matrix must be a square matrix");
                    Console.WriteLine("\nKindly enter same order of martix");
                    goto enter_a;
                }
                Console.WriteLine("Do you want to Continue [Y/N]:- ");
                    c = Console.ReadKey().KeyChar;
                } while (c == 'y' || c == 'Y') ;

          
        }
    
    }
}
