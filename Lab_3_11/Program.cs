namespace Lab_3_11
{
    using System;

    class Program
    {
        static void Main()
        {

            Console.WriteLine("Введите марку первой машины:");
            String firstMark = Console.ReadLine();
            Console.WriteLine("Введите мощность двигателя первой машины:");
            int firstEnginePower = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество мест первой машины:");
            int firstPlacesNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            FirstLevel firstLevelCar = new FirstLevel(firstMark, firstEnginePower, firstPlacesNumber);
            firstLevelCar.getInfo();
            Console.WriteLine("Качество для машины первого уровня: " + firstLevelCar.countQuality());

            Console.WriteLine("Введите марку второй машины:");
            String secondMark = Console.ReadLine();
            Console.WriteLine("Введите мощность двигателя второй машины:");
            int secondEnginePower = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество мест второй машины:");
            int secondPlacesNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите год производства второй машины:");
            int secondYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            SecondLevel secondLevelCar = new SecondLevel(secondMark, secondEnginePower, secondPlacesNumber, secondYear);
            secondLevelCar.getInfo();
            Console.WriteLine("Качество для машины второго уровня " + secondLevelCar.countQuality());
        }

       
    }

}
