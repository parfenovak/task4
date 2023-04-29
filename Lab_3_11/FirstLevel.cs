using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_11
{
    internal class FirstLevel
    {
        private String mark { get; set; }

        private int enginePower { get; set; }

        private int placesNumber { get; set; }

        public FirstLevel(String mark, int enginePower,int placesNumber) 
        {
            this.mark = mark;
            this.enginePower = enginePower;
            this.placesNumber = placesNumber;
        }

        public virtual double countQuality()
        {
            return placesNumber * enginePower * 0.1;
        }
        
        public virtual void getInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Информация о машине:");
            Console.WriteLine("Марка -  " + this.mark);
            Console.WriteLine("Мощность двигателя - " + this.enginePower);
            Console.WriteLine("Количество мест - " + this.placesNumber);
        }
    }
}
