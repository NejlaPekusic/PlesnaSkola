using System;
using System.Collections.Generic;
using System.Text;

namespace PlesnaSkola.Model
{
    public static class DateTimeExtension
    {
        public static int GetAge(this DateTime datumRodjenja)
        {
            var today = DateTime.Today;
            var age = today.Year - datumRodjenja.Year;
            if (datumRodjenja.Date > today.AddYears(-age)) age--;

            return age;
        }
    }
}
