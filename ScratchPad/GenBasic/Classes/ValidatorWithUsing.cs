using System;
using System.Collections.Generic;

namespace GenBasic.Classes
{
    using PhoneValidator = Func<Phone, bool>;

    //Cleaner - using nested definitions
    public static class ValidatorWithUsing
    {
        public static IEnumerable<PhoneValidator> GetPhoneValidators()
        {
            var result = new List<PhoneValidator>
            {
                phone => !string.IsNullOrEmpty(phone.Manufacturer),
                phone => !string.IsNullOrEmpty(phone.Model)
            };

            return result;
        }
    }
}