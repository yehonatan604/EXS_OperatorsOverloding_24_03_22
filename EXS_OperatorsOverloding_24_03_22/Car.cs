using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXS_OperatorsOverloding_24_03_22
{
    public class Car
    {
        //fields
        private static int count = 0;
        //properties
        public string Name { get; set; }
        public int Fuel { get; set; }
        public int Speed { get; set; }
        public int Price { get; set; }
        public int CarNumber { get; set; }
        public int Year { get; set; }
        //defualt ctor
        public Car()
        {
            count++;
            Name = nameof(Car) + count.ToString();
        }
        //overrides
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
        public override bool Equals(object? obj)
        {
            Car? car = obj as Car;
            return CarNumber == car?.CarNumber;
        }
        public override int GetHashCode()
        {
            Random rnd = new();
            return rnd.Next(1000, 9999);
        }
        //operator overloads
        public static bool operator ==(Car car1, Car car2)
        {
            return car1.CarNumber == car2.CarNumber;
        }
        public static bool operator !=(Car car1, Car car2)
        {
            return !(car1 == car2);
        }
        public static bool operator >(Car car1, Car car2)
        {
            if (car1.Speed > car2.Speed)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Car car1, Car car2)
        {
            return !(car1 > car2);
        }
        public static string operator /(Car car1, Car car2)
        {
            Console.WriteLine($"\nBefore dividing:\n\n{car1.Name}:\n{car1}\n{car2.Name}:\n{car2}");
            int i = car1.Fuel + car2.Fuel;
            car1.Fuel = i / 2;
            car2.Fuel = car1.Fuel;
            return $"\nAfter dividing:\n\n{car1.Name}:\n{car1}\n{car2.Name}:\n{car2}";
        }
        public static string operator *(Car car1, Car car2)
        {
            int speed;
            int price;
            int year;
            int car1Points = 0;
            int car2Points = 0;
            Car speedCar;
            Car priceCar;
            Car yearCar;
            Car winner;

            if (car1 > car2)
            {
                car1Points++;
                speed = car1.Speed;
                speedCar = car1;
            }
            else
            {
                car2Points++;
                speed = car2.Speed;
                speedCar = car2;
            }
            if (car1.Price > car2.Price)
            {
                car1Points++;
                price = car1.Price;
                priceCar = car1;
            }
            else
            {
                car2Points++;
                price = car2.Price;
                priceCar = car2;
            }
            if (car1.Year > car2.Year)
            {
                car1Points++;
                year = car1.Year;
                yearCar = car1;
            }
            else
            {
                car2Points++;
                year = car2.Year;
                yearCar = car2;
            }
            if (car1Points > car2Points)
            {
                winner = car1;
            }
            else
            {
                winner = car2;
            }
            return $"\nhighest speed between {car1.Name} & {car2.Name}: {speed} ({speedCar.Name})\n" +
                   $"highest price between {car1.Name} & {car2.Name}: {price} ({priceCar.Name})\n" +
                   $"highest year between {car1.Name} & {car2.Name}: {year} ({yearCar.Name})\n" +
                   $"\nWinner is: {winner.Name}";
        }
    }
}
