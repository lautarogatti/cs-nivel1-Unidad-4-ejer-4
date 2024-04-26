using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero. */

            int n1, n2, n3, rSuma, rProduc;

            Console.WriteLine("Por favor, ingrese el primer numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, ingrese el segundo numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, ingrese el tercer numero");
            n3 = int.Parse(Console.ReadLine());

            rSuma = n1 + n2;

            rProduc = n2 * n3;

            if(rSuma > rProduc)
                Console.WriteLine("La suma es mayor");
            else
                Console.WriteLine("La suma es menor");
        }
    }
}
