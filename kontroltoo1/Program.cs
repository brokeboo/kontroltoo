using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontroltoo1
{
    class Program
    {
        
        static int Saali_suurus()
        {
            Console.WriteLine("Vali saali suurus: 1, 2, 3");
            int suurus = int.Parse(Console.ReadLine);
            return suurus;
        }
        static int[,] saal = new int[,] { };
        static int kohad, read;
        static void Saali_taitmine()
        {
            for (int rida = 0; rida < 20; rida++)
            {
                Random rnd = new Random();
                if (suurus==1)
                {
                    kohad = 29;
                    read = 19;
                }
                else if (suurus==2)
                {
                    kohad = 20;
                    read = 20;
                }
                else
                {
                    kohad = 20;
                    read = 30;
                }
            }
                static void Saal_ekranile()
                {
                    for (int rida=0; rida < read; rida++)
                    {
                        for(int koht=0;koht<kohad;koht++)
                        {
                            Console.WriteLine(saal[rida, koht]);
                        }
                        Console.WriteLine();
                    }

                }
                static void Muuk()
                {
                    Console.WriteLine("Rida: ");
                    int pileti_rida = int.Parse(Console.ReadLine());
                    Console.WriteLine("Koht: ");
                    int pileti_koht=int.Parse(Console.ReadLine());
                    if (saal[pileti_koht=1, pileti_rida=1]==0)
                    {
                        saal[pileti_koht = 1, pileti_rida = 1] = 1;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                static void Main(string[] args)
                {
                    int[,] saal = new int[20, 30];
                    Random rnd = new Random();
                    for (int rida = 0; rida < 20; rida++)
                    {
                        for (int koht = 0; koht < 30; koht++)
                        {
                            saal[rida, koht] = rnd.Next(0, 2);
                        }
                        {
                            for (int rida = 0; rida < 20; rida++)
                            {
                                for (int koht = 0; koht < 30; koht++)
                                {
                                    Console.Write(saal[rida, koht]);
                                }
                                Console.WriteLine();
                            }
                        }
                        Console.ReadLine();
                    }
                }

            }
        }