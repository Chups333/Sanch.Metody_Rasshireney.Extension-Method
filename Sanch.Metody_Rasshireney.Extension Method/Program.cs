using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanch.Metody_Rasshireney.Extension_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //методы расширения нужны если мы работаем со встроенными стандартными типами данных
            //2. когда нужно добавить какие то методы к стандартным типам (class Road : Int32 - не можем)
            //3.
            Console.WriteLine("Введите число:");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int result))
            {
                var IsEven = result.isEven(); //var IsEven = isEven(result); - тоже самое
                if (IsEven)
                {
                    Console.WriteLine($"{result} - четное");

                }
                else
                {
                    Console.WriteLine($"{result} - нечетное");
                }

                //int h = 77;
                //h.isEven - тоже будет этот метод (смотри хелпер)

                //int h = 182; 
                //h.IsDivided(7); h - i , и этому методу остается передать j

               
                

            }
            else
            {
                Console.WriteLine("Это не число");
            }

            

            var roads = new List<Road>();
            for (int i = 0; i < 10; i++)
            {
                var road = new Road();
                road.CreateRandomRoad(1000, 10000);// смотри Helper
                roads.Add(road);
            }

            var roadsName = roads.ConvertToString();

            Console.WriteLine(roadsName);

            Console.ReadKey();
        }

        /*
        static bool isEven(int i)
        {
            return i % 2 == 0;
        }
        */
    }
}
