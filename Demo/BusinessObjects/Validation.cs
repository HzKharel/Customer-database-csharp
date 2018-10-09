using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjects
{
   public class Validation
    {
        
        public string Validate(string id_, string Name_, string LastName_, string Email_, string Telephone_)
        {
            int Validated_telephone;
            int Validated_ID;
            if ((!Int32.TryParse(id_, out Validated_ID)) && Validated_ID < 10001 || Validated_ID > 50000)
            {
                return "ID validation failed. Please make sure its between 10001 and 50000.";
            }
            if (String.IsNullOrEmpty(Name_) || String.IsNullOrEmpty(LastName_))
            {
                return "Name validation failed. Please make sure that both, first and last names are entered.";
            }
            if (!Email_.Contains("@"))
            {
                return "Email verification failed. Plese check your email and try again.";
            }
            if (!Int32.TryParse(Telephone_, out Validated_telephone))
            {
                return "Telephone can only be digits (0-9).";
            }
            else
            {
                return "Validation Sucessful";
            }
        }
    }
}
