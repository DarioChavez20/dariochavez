using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Menu
    {
        static void Main(string[] args)
        {
            String cp1;
            int cp2;
            Char juegos;
            Console.WriteLine("-------------------");
            Console.WriteLine("LOGIN");
            Console.WriteLine("-------------------");
            Console.WriteLine("Escribe tú usuario o correo");
            cp1 = Console.ReadLine();
            Console.WriteLine("Escribe tú contraseña");
            int.TryParse(Console.ReadLine(), out cp2);
            if ((cp1 == "Gamer") && (cp2 == 0123))
            {
                Console.WriteLine("Inició su login");
                Console.Clear();
                do
                {
                    Console.WriteLine("1 Juegos Xbox");
                    Console.WriteLine("2 Juegos Pc");
                    Console.WriteLine("----Eliga una opcion----");
                    Char.TryParse(Console.ReadLine(), out juegos);
                    switch (juegos)
                    {
                        case '1':
                            {
                                Console.WriteLine("Xbox");
                                Console.WriteLine("1 Halo Infinty");
                                Console.WriteLine("2 Gears of Wars");
                                Console.WriteLine("3 Army of Two");
                                Console.WriteLine("4 FIFA 22");
                                Console.ReadLine();
                            }
                            break;
                        case '2':
                            {
                                Console.WriteLine("Pc");
                                Console.WriteLine("1 League of Legends");
                                Console.WriteLine("2 Valorant");
                                Console.WriteLine("3 GTA V");
                                Console.WriteLine("4 Resident Evil 4");
                                Console.ReadLine();
                            }
                            break;

                    }
                } while (cp2 == 0123);
            }
            else
            {
                Console.WriteLine("No puede acceder a su login");
                Console.ReadLine();
            }

        }
    }
    }

