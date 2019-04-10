using System;
using System.Collections.Generic;

namespace GenBasic.Classes
{
    //Nested Generic Definitions
    public static class Validators
    {
        //This is an IEnumerable that takes a list of delegates and returns a bool
        public static IEnumerable<Func<Car, bool>> GetCarValidators()
        {
            var result = new List<Func<Car, bool>>
            {
                car => !string.IsNullOrEmpty(car.Make),
                car => !string.IsNullOrEmpty(car.Model)
            };

            return result;
        }
    }

}
