using System;

namespace medidas
{
    class Program
    {
        static void Main(string[] args)
       {
           double metrosDigitado, metrosParaCm, metrosParaKm;
           Console.Write("entre com a medida em metros (m)");
           metrosDigitado =Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("---Equivalençia---");

           metrosParaCm = metrosDigitado/100;

           Console.WriteLine($"{metrosParaCm} Cm");

           Console.WriteLine($"{metrosDigitado} m");

           metrosParaKm = metrosDigitado/1000;

            Console.WriteLine($"{metrosParaKm} Km");

 }         
       }
}
    
