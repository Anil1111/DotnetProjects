using System;
using System.Collections.Generic;
using GenBasic.Classes;
using Xunit;

namespace Generics.Tests
{
    using PhoneValidator = Func<Phone, bool>;

    public class ValidatorsWithUsingTests
    {
        [Fact]
        public void GetPhoneValidators_WhenCalled_ShouldReturnFalse()
        {
            var phone = new Phone();
            IEnumerable<PhoneValidator> validators = ValidatorWithUsing.GetPhoneValidators();
            Assert.False(IsPhoneValid(validators, phone));

        }

        [Fact]
        public void GetPhoneValidators_WhenCalled_ShouldReturnTrue()
        {
            var phone = new Phone {Manufacturer = "Samsung", Model = "Galaxy S10"};
            IEnumerable<PhoneValidator> validators = ValidatorWithUsing.GetPhoneValidators();
            Assert.True(IsPhoneValid(validators, phone));
        }


        private bool IsPhoneValid(IEnumerable<PhoneValidator> validators, Phone phone)
        {
            foreach (var validator in validators)
            {
                if (!validator(phone))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
