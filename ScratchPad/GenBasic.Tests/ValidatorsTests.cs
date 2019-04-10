using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using GenBasic.Classes;
using Xunit;

namespace Generics.Tests
{
    public class ValidatorsTests
    {
        [Fact]
        public void GetCarValidators_WhenCalled_ShouldReturnFalse()
        {
            var car = new Car();
            IEnumerable<Func<Car, bool>> validators = Validators.GetCarValidators();
            Assert.False(IsCarValid(validators,car));
        }

        [Fact]
        public void GetCarValidators_WhenCalled_ShouldReturnTrue()
        {
            var car = new Car {Make = "Honda", Model = "Prius"};
            IEnumerable<Func<Car, bool>> validators = Validators.GetCarValidators();
            Assert.True(IsCarValid(validators, car));
        }

        private static bool IsCarValid(IEnumerable<Func<Car, bool>> validators, Car car)
        {
            foreach (var validator in validators)
            {
                if (!validator(car))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
