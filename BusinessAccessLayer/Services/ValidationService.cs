using BusinessAccessLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BusinessAccessLayer.Services
{
    public  class ValidationService:IValidationService
    {
        public  bool ValidateHotelName(string word)
        {
            Match match = Regex.Match(word, "[a-zA-Z]{3,}");

            return match.Success;
        }

        public  bool ValidateIsNumber(string word)
        {
            Match match = Regex.Match(word, "[0-9]{1,}");

            return match.Success;
        }

        public bool ValidateIsPrice(string word)
        {
            Match match = Regex.Match(word, @"-?\d+(?:\.\d+)?");

            return match.Success;
        }

        public bool ValidateBookingDates(DateTime StartDate, DateTime EndDate)
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

        public bool ValidateFoundationYear(DateTime foundationYear)
        {
            return (foundationYear > DateTime.Now) ? false : true;

        }

        public bool ValidateRatingBookingDates(DateTime StartDate, DateTime EndDate)
        {
            return EndDate > StartDate ? true : false;

        }
    }
}
