using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Domain.Attributes.Password
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class PasswordAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }

            string password = value.ToString();

            if (Regex.IsMatch(password, @"^(?=.*[A-Za-z])(?=.*\d).{6,}$"))
            {
                return true;
            }

            return false;
        }
    }
}