using System;
using System.Text.Json;

namespace EXS_OperatorsOverloding_24_03_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new()
            {
                Fuel = 50,
                Speed = 200,
                Price = 65000,
                CarNumber = 1234,
                Year = 2020
            };
            Car car2 = new()
            {
                Fuel = 80,
                Speed = 250,
                Price = 85000,
                CarNumber = 9876,
                Year = 2019
            };
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> opertor '/' check:");
            Console.WriteLine(car1 / car2);
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> opertors '==', '>', 'Equals' check:\n");
            Console.WriteLine($"is {car1.Name} Equals({car2.Name}) - check by carNumber: {car1.Equals(car2)}");
            Console.WriteLine($"is {car1.Name} == {car2.Name} - check by carNumber: {car1 == car2}");
            Console.WriteLine($"is {car1.Name} > {car2.Name} - check by Speed: {car1 > car2}");
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> opertor '*' check:");
            Console.WriteLine(car1 * car2);
        }
    }
}
