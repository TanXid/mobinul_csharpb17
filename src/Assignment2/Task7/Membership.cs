using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Membership
    {
        public const string UsernameRequiredMessage = "Username must be provided";
        public const string EmailRequiredMessage = "Email must be provided";
        public const string PasswordRequiredMessage = "Password must be provided";

        public static string Validate(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                return UsernameRequiredMessage;
            if (string.IsNullOrWhiteSpace(email))
                return EmailRequiredMessage;
            if (string.IsNullOrWhiteSpace(password))
                return PasswordRequiredMessage;

            return string.Empty;
        }
    }
}
