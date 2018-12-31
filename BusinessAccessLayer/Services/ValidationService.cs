using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BusinessAccessLayer.Services
{
    public static class ValidationService
    {
        public static bool ValidateHotelName(string word)
        {
            Match match = Regex.Match(word, "[a-zA-Z]{3,}");
            if (match.Success)
            {
                return true;
            }
            else
                return false;
        }
        public static bool ValidateIsNumber(string word)
        {
            Match match = Regex.Match(word, "[0-9]{1,}");
            if (match.Success)
            {
                return true;
            }
            else
                return false;
        }
        public static bool ValidateIsPrice(string word)
        {
            Match match = Regex.Match(word, @"-?\d+(?:\.\d+)?");
            if (match.Success)
            {
                return true;
            }
            else
                return false;
        }
        public static bool ValidateBookingDates(DateTime StartDate, DateTime EndDate)
        {
            if (StartDate > DateTime.Now && EndDate > DateTime.Now)
            {
                if (EndDate > StartDate)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public static bool ValidateFoundationYear(DateTime foundationYear)
        {
            return (foundationYear > DateTime.Now) ? false : true;
           
        }

        public static bool ValidateRatingBookingDates(DateTime StartDate, DateTime EndDate)
        {
            return EndDate > StartDate ? true : false;

        }
    }
}
