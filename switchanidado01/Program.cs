// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Programa
{
    static void Main(string[] args)
    {
        int opcion1 = 0;
        string opcion2;

        while (opcion1 != 3)  // Continuar hasta que el usuario elija la opción 3 para salir
        {
            Console.WriteLine("\n-----------Elija una de los siguientes programas: \n-------------");
            Console.WriteLine("\n-----------1-Captura de nombre--------------\n");
            Console.WriteLine("\n-----------2-Calculadora--------------------\n");
            Console.WriteLine("\n-----------3-Salir del sistema--------------\n");
            opcion1 = int.Parse(Console.ReadLine());

            switch (opcion1)
            {
                case 1:
                    Console.WriteLine("Digite su nombre: \n");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("\n Su nombre es: " + nombre);
                    break;

                case 2:
                    do  // Un bucle do-while para mantener al usuario en la calculadora hasta que elija regresar
                    {
                        Console.WriteLine("\n Bienvenido a la calculadora\n");
                        Console.WriteLine("\n--------a Suma\n");
                        Console.WriteLine("\n--------b Resta\n");
                        Console.WriteLine("\n--------c Retornar al menú anterior\n");

                        opcion2 = (Console.ReadLine());

                        switch (opcion2)
                        {
                            case "a":
                                Console.WriteLine("Digite el primer numero: \n");
                                int n = int.Parse(Console.ReadLine());

                                Console.WriteLine("Digite el segundo numero: \n");
                                int j = int.Parse(Console.ReadLine());

                                int total = n + j;

                                Console.WriteLine(" El resultado de la suma: " + total);
                                break;

                            case "b":
                                Console.WriteLine("Digite el primer numero: \n");
                                int r = int.Parse(Console.ReadLine());

                                Console.WriteLine("Digite el segundo numero: \n");
                                int m = int.Parse(Console.ReadLine());

                                int total2 = r - m;

                                Console.WriteLine(" El resultado de la resta: " + total2);
                                break;

                            case "c":
                                // Terminar el bucle do-while y regresar al menú principal
                                break;

                            default:
                                Console.WriteLine("Opción no válida");
                                break;
                        }

                    } while (opcion2 != "c");
                    break;

                case 3:
                    // Salir del sistema
                    return;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}

