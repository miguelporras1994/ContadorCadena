using System;

namespace CadenaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] words = { 1, 50, 80, 12, 8, 5 };

            int count = words.Length;
            int num  = 0, contador = 0;
            

            foreach (var i in words) 
            {
                contador = contador + 1;

                if (num <= i)
                {
                    num = i;
                   
                }
                if (count == contador)
                {
                    Console.WriteLine("numero mas grande de la lista es : " + num);


                }

            }
        }
    }
}
