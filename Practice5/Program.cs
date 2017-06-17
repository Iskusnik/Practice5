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

            arr[0, 0] = 1;
            i++;
            while (i <= N * N) //x != N - 1 && y != N - 1
            {
                


                /*
                if (x == N - 1 || x == 0)
                {
                    y++;
                    arr[y, x] = i;
                    i++;
                }
                else
                if (y == N - 1 || y == 0)
                {
                    x++;
                    arr[y, x] = i;
                    i++;
                }*/

                if (x == 0 && y != N - 1)
                {
                    y++;
                    arr[y, x] = i;
                    i++;

                    while (y != 0)
                    {
                        y--;
                        x++;
                        arr[y, x] = i;
                        i++;
                    }
                }

                if (y == N - 1 && x != N - 1)
                {
                    x++;
                    arr[y, x] = i;
                    i++;

                    while (x != N - 1)
                    {
                        y--;
                        x++;
                        arr[y, x] = i;
                        i++;
                    }
                }

                if (y == 0 && x != N - 1)
                {
                    x++;
                    arr[y, x] = i;
                    i++;

                    while (x != 0)
                    {
                        y++;
                        x--;
                        arr[y, x] = i;
                        i++;
                    }
                }

                if (x == N - 1 && y != N - 1)
                {
                    y++;
                    arr[y, x] = i;
                    i++;
                    while (y != N - 1)
                    {
                        y++;
                        x--;
                        arr[y, x] = i;
                        i++;
                    }
                }

                
                
                

            }

            for (int Ycoord = 0; Ycoord < N; Ycoord++)
            {
                Console.WriteLine();
                Console.WriteLine();
                for (int Xcoord = 0; Xcoord < N; Xcoord++)
                    Console.Write("{0,-5}", arr[Ycoord, Xcoord]);
            }
            // Движение по диагонале до стенки, шаг вдоль стенки
        }
    }
}
