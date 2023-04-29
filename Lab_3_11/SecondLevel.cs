using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_11
{   
    internal class CarWithYear : Car
    {
        private int year { get; set; }

        public CarWithYear(String mark, int enginePower, int placesNumber, int year)
                :base(mark,enginePower,placesNumber)
        {
            this.year = year;
        }

        public override double countQuality()
        {
            return base.countQuality() - 1.5 * (DateTime.Now.Year - this.year) ;
        }

        public override void getInfo()
        {
            base.getInfo();
            Console.WriteLine("Год производства -  " + this.year);
        }
    }
}
