using System;

class programa

{
    static void Main(string[] args)



    {

        int opcion1;
        string opcion2;
        do
        {
            Console.WriteLine("\n---------Elija una de los programas siguientes: \n---------------");
            Console.WriteLine("\n---------1-Captura de nombre-------------\n");
            Console.WriteLine("\n---------2-Calculadora-------------------\n");
            Console.WriteLine("\n---------3-Salir del sistema-------------\n");
            opcion1 = int.Parse(Console.ReadLine());

            switch (opcion1)
            {
                case 1:
                    Console.WriteLine("Digite su nombre: \n");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("\n Su nombre es: " + nombre);
                    break;


                case 2:
                    Console.WriteLine("\n Bienvenido a la calculadora\n");
                    Console.WriteLine("\n --------a) Suma\n");
                    Console.WriteLine("\n --------b) Resta\n");
                    Console.WriteLine("\n --------c) Retornar al menu anterior\n");
                    opcion2 = (Console.ReadLine());
                    switch (opcion2)
                    {
                        case "a":
                            Console.WriteLine("\n Digite el primer numero: \n");
                            int n = int.Parse(Console.ReadLine());

                            Console.WriteLine("\n Digite el segundo numero: \n");
                            int j = int.Parse(Console.ReadLine());

                            int total = n + j;
                            Console.WriteLine("El resultado de la suma es : " + total);
                            break;

                        case "b":
                            Console.WriteLine("\n Digite el primer numero: \n");
                            int r = int.Parse(Console.ReadLine());

                            Console.WriteLine("\n Digite el segundo numero: \n");
                            int m = int.Parse(Console.ReadLine());

                            int total2 = r - m;
                            Console.WriteLine("El resultado de la resta es : " + total2);
                            break;

                        case "c":
                        default:
                            Console.WriteLine(opcion1);
                            Console.Clear();
                            break;

                    }
                    break;



            }
        } while (opcion1 != 3);
    }
}