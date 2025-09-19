using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создание массива
            string[] A = new string[3] { "Опель", "Мерседс", "Aуди" };

            //поменяли в масиве певый элемент и индексом 0
            A[0] = "БМВ";

            //Вывод 
            Console.WriteLine(A[0]);
            Console.WriteLine(A[1]);
            Console.WriteLine(A[2]);

            //новый массив (перевернулина оборот)
            string[] B = new string[3];
            B[0] = A[2];
            B[1] = A[1];
            B[2] = A[0];
            Console.WriteLine(B[0]);
            Console.WriteLine(B[1]);
            Console.WriteLine(B[2]);

        }
    }
}
