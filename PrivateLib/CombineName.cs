using System;
using System.Security.Cryptography.X509Certificates;

namespace PrivateLib
{
    public class Name
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }

    public class CombineName
    {
        private string currentFirstName = string.Empty;
        private string currentMiddleName = string.Empty;
        private string currentLastName = string.Empty;

        CombineName(Name name)
        {
            currentFirstName = name.FirstName ?? "";
            currentMiddleName = name.MiddleName ?? "";
            currentLastName = name.LastName ?? "";
        }

        public string GetName()
        {
            return string.Concat(currentFirstName, currentMiddleName, currentLastName);
        }
    }

}
