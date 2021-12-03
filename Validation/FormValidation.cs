using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Forms;

namespace Hospital_Management_System.Validation
{
    public class FormValidation
    {
        public FormValidation()
        {
        }
        public bool NameValidation(string text, out string errorMessage)
        {
            if(string.IsNullOrWhiteSpace(text))
            {
                errorMessage = "This is required.";
                return false;
            }
            else
            {
                //!Regex.IsMatch(text, "^[A-Z][a-zA-Z]*$")
                if (!Regex.IsMatch(text, @"^[a-zA-Z]+$"))
                {
                    errorMessage = "Must be valid chrecter\n" + "For example 'Kamal' ";
                    return false;
                }
                else
                {
                    errorMessage = "";
                    return true;
                }
            }
        }
        public bool EmailValidation(string email, out string errorMessage)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            if (!Regex.IsMatch(email, pattern) || string.IsNullOrWhiteSpace(email))
            {
                errorMessage = "email address must be valid email address format.\n" +
                     "For example 'someone@example.com' ";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }
        }
        public bool PhoneNumberValidation(string phoneNumber, out string errorMessage)
        {
            if (!Regex.IsMatch(phoneNumber, @"^([01]|\+88)?\d{11}") || string.IsNullOrWhiteSpace(phoneNumber) )
            {
                errorMessage = "Phone Number must be valid Phone Number format.\n" +
                     "For example '01524558899' ";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }
        }
    }
}
