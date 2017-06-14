using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Ввод своих элементов - действительных чисел в порядке от a1 до a64");//Не обязательно
            Console.WriteLine("2 - Заполнение элементов соответсвенно номеру а1 = 1, а2 = 2, а3 = 3 и тд");

            //А такое заполнение:
            //а1  а3  а4  а10   
            //а2  а5  а9  а11
            //а6  а8  а12 а15
            //а7  а13 а14 а16                                 - обязательно
            int N = int.Parse(Console.ReadLine());
            int[,] arr = new int[N, N];
            int x = 0, y = 0;
            int i = 1;
            while (x != N - 1 && y != N - 1)
            {
                y++;
                arr
            }

            // Движение по диагонале до стенки, шаг вдоль стенки
        }
    }
}
