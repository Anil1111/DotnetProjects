using System;

namespace Inheritance.Classes
{
    public class Car : Vehicle
    {


        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine($"Car is being initialized. {registrationNumber}");
        }
    }
}