using System;


namespace Sanch.Metody_Rasshireney.Extension_Method
{
    public sealed class Road //sealed - запечатаннный класс
    {
        public string Number { get; set; }
        public int Lenght { get; set; }

        public override string ToString()
        {
            return $"Дорога {Number} длинной {Lenght}"; 
        }
    }
}
