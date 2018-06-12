using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 4, K = 3, D = 5;
            int start = N + D + 1;
            int finish = N + D + 2;
            FordFulkerson fordFulkersonModel = new FordFulkerson(6);

            int[,]  graph= { {0, 16, 13, 0, 0, 0}, 
                            {0, 0, 10, 12, 0, 0},
                            {0, 4, 0, 0, 14, 0},
                            {0, 0, 9, 0, 0, 20},
                            {0, 0, 0, 7, 0, 4},
                            {0, 0, 0, 0, 0, 0}
                            };


            //Не встиг довести до кінця, алгоритм Форда — Фалкерсона працює правильно
            Console.WriteLine( "The maximum possible flow is {0}", fordFulkersonModel.fordFulkerson(graph, 0, 5));        
        }
    }
}
