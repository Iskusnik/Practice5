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

            //А такое заполнение:
            //а1  а3  а4  а10   
            //а2  а5  а9  а11
            //а6  а8  а12 а15
            //а7  а13 а14 а16        
            Console.WriteLine("Введите сторону квадрата, который будет заполнен числами");
            int N = int.Parse(Console.ReadLine());
            int[,] arr = new int[N, N];
            int x = 0, y = 0;
            int i = 1;
            int[] a = new int[N * N];
            
            Console.WriteLine("Введите 0 для ручного заполнения последовательности a");
            Console.WriteLine("Введите не 0 для заполнения последовательности a по типу a1 = 1, a2 = 2 ... an = n");
            if (Console.ReadLine() == "0")
                for (i = 0; i < N * N; i++)
                {
                    Console.WriteLine("a{0} = ", i + 1);
                    a[i] = int.Parse(Console.ReadLine());
                }
            else
                for (i = 0; i < N * N; i++)
                    a[i] = i + 1;
            arr[0, 0] = a[0];
            i = 1;
            while (i < N * N) //x != N - 1 && y != N - 1
            {

                if (x == 0 && y != N - 1)
                {
                    y++;
                    arr[y, x] = a[i];
                    i++;

                    while (y != 0)
                    {
                        y--;
                        x++;
                        arr[y, x] = a[i];
                        i++;
                    }
                }

                if (y == N - 1 && x != N - 1)
                {
                    x++;
                    arr[y, x] = a[i];
                    i++;

                    while (x != N - 1)
                    {
                        y--;
                        x++;
                        arr[y, x] = a[i];
                        i++;
                    }
                }

                if (y == 0 && x != N - 1)
                {
                    x++;
                    arr[y, x] = a[i];
                    i++;

                    while (x != 0)
                    {
                        y++;
                        x--;
                        arr[y, x] = a[i];
                        i++;
                    }
                }

                if (x == N - 1 && y != N - 1)
                {
                    y++;
                    arr[y, x] = a[i];
                    i++;
                    while (y != N - 1)
                    {
                        y++;
                        x--;
                        arr[y, x] = a[i];
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
        }
    }
}
