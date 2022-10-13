using System;
namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Ingrese 2 numeros y se mostrara si es Mayor, Menor o si son Iguales");
            Console.Clear();
            Console.WriteLine("Ingrese el primer numero: ");
            //Console.ReadKey(); esto esta mal
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            //Console.ReadKey(); esto esta mal
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (n1 > n2)
            {
                Console.WriteLine("El numero mayor es: {0}", n1);
            }
            else if (n1 == n2)
            {
                Console.WriteLine("{0} es igual a {1}", n1, n2);
            }
            else
            {
                Console.WriteLine("El numero mayor es: {0}", n2);
          }
          Console.ReadKey();
        }
    }
}