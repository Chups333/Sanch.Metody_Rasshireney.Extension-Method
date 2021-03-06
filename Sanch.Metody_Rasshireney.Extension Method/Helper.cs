﻿using System;
using System.Collections;
using System.Linq;

namespace Sanch.Metody_Rasshireney.Extension_Method
{
    public static class Helper // - все методы расширения - он и есть метод расширения
    {
        public static bool isEven(this int i) // this - отличие от обычного метода - 
        //этот метод расширения появится для типов разширения int у которых подключено наше пространство имен
        {
            return i % 2 == 0;
        }

        public static bool IsDivided(this int i, int j)
        {
            return i % j == 0;
        }

        public static string ConvertToString(this IEnumerable collection)
        {
            var result = "";
            foreach(var item in collection)
            {
                result += item.ToString() + ",  \r\n";// \r\n - перенос строки
            }
            return result;
        }

        public static Road CreateRandomRoad(this Road road, int min, int max)
        {
            var rnd = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));
            road.Number = "M"+rnd.Next(1,100);
            road.Lenght = rnd.Next(min, max);
            return road;
        }
    }
}
