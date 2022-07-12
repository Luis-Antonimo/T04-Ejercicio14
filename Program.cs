using System;

namespace T04Ejercicio14
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escriba el radio del círculo:");
            double radio = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * (Math.Pow(radio, 2));
            Console.WriteLine("El area del círculo es: " + area);
        }
    }
}