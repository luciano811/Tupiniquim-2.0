using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao robô Tupiniquim\n");
            Console.WriteLine("Você sabe as regras do robô, vamos fazê-lo funcionar!\n\n ");

            int x = 0, y = 0;
            string Z = "N";

            Console.WriteLine("Orientação inicial do Robô (0,0,N)\n\n");

            while (true)
            {
                Console.WriteLine("\nDigite a opção que você para o robô\ne = Vira a esquerda\nd = Vira a direita\nm = Move-se para o respectivo lado\ns = Sair");

                string a;
                
                a = Console.ReadLine();

                if(a == "s")
                {
                    Console.WriteLine("\nFechando o programa...");
                    break;
                }

                // ORIENTAÇÃO - DIREITA

                if (a == "d")
                {
                    if (Z == "N")
                    {                        
                        Console.WriteLine("\n\nO Tupiniquim virou-se para o Leste");
                        Z = "L";
                        Console.Write("\nOrientação atual do Robô {0} {1} {2}\n", x, y, Z);
                    }
                    else if (Z == "L")
                    {                        
                        Console.WriteLine("\n\nO Tupiniquim virou-se para o Sul");
                        Z = "S";
                        Console.Write("\nOrientação atual do Robô {0} {1} {2}\n", x, y, Z);
                    }
                    else if (Z == "S")
                    {
                        Console.WriteLine("\n\nO Tupiniquim virou-se para o Oeste");
                        Z = "O";
                        Console.Write("\nOrientação atual do Robô {0} {1} {2}\n", x, y, Z);
                    }
                    else if (Z == "O")
                    {
                        Console.WriteLine("\n\nO Tupiniquim virou-se para o Norte");
                        Z = "N";
                        Console.Write("\nOrientação atual do Robô {0} {1} {2}\n", x, y, Z);
                    }
                }



                // ORIENTAÇÃO - ESQUERDA



                else if (a == "e")
                {
                    if (Z == "N")
                    {
                        Console.WriteLine("\n\nO Tupiniquim virou-se para o Oeste");
                        Z = "O";
                        Console.Write("\nOrientação atual do Robô {0} {1} {2}\n", x, y, Z);
                    }
                    else if (Z == "O")
                    {
                        Console.WriteLine("\n\nO Tupiniquim virou-se para o Sul");
                        Z = "S";
                        Console.Write("\nOrientação atual do Robô {0} {1} {2}\n", x, y, Z);
                    }
                    else if (Z == "S")
                    {
                        Console.WriteLine("\n\nO Tupiniquim virou-se para o Leste");
                        Z = "L";
                        Console.Write("\nOrientação atual do Robô {0} {1} {2}\n", x, y, Z);
                    }
                    else if (Z == "L")
                    {
                        Console.WriteLine("\n\nO Tupiniquim virou-se para o Norte");
                        Z = "N";
                        Console.Write("\nOrientação atual do Robô {0} {1} {2}\n", x, y, Z);
                    }
                }

                // MOVIMENTOS - M

                else if (Z == "N" && a == "m")

                {
                    y = y + 1;

                    Console.Write("\nOrientação atual do Robô {0} {1} {2}\n", x, y, Z);


                }

                else if (Z == "O" && a == "m")


                {

                    if (x == 0)
                    {
                        Console.WriteLine("\nImpossível, X já é zero");
                    }

                    else
                    {
                        x = x - 1;
                        Console.Write("\nOrientação atual do Robô {0} {1} {2}\n", x, y, Z);

                    }

                }

                else if (Z == "L" && a == "m")


                {

                    
                        x = x + 1;
                        Console.Write("\nOrientação atual do Robô {0} {1} {2}\n", x, y, Z);



                }
                else if (Z == "S" && a == "m")
                {
                    if (y == 0)
                    {
                        Console.WriteLine("\nImpossível, Y já é zero");
                    }

                    else
                    {
                        y = y - 1;
                        Console.Write("\nOrientação atual do Robô {0} {1} {2}\n", x, y, Z);
                    }
                }
            }
        }
    }
}
