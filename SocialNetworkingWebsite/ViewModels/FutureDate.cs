using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace SocialNetworkingWebsite.ViewModels
{
    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), 
                "d MM yyyy", 
                CultureInfo.CurrentCulture,
                DateTimeStyles.None, 
                out dateTime);

            return (isValid && dateTime > DateTime.Now);
        }
    }
}