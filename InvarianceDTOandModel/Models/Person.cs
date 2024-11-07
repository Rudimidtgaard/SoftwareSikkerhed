using System.Text.RegularExpressions;

namespace ValidateTheNameModelBinding.Models
{
    public class Person
    {
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName)
        {
            isFirstNameValid(firstName);
            isLastNameValid(lastName);

            this.firstName = firstName; 
            this.lastName = lastName;
        }

        private void isFirstNameValid(string name)
        {
            ///Add Invariance validation Here
            /// Throw an Exception if the name is invalid
            /// 

            if (!ValidateName(name))
                throw new Exception();

        }
        private void isLastNameValid(string name)
        {
            ///Add Invariance validation Here
            /// Throw an Exception if the name is invalid

            if (!ValidateName(name))
                throw new Exception();
        }

        private static bool ValidateName(string? nameInput)
        {
            if (string.IsNullOrWhiteSpace(nameInput))
                return false;

            if (nameInput.Length > 20)
                return false;

            if (nameInput.Length <= 3)
                return false;

            var regexPattern = @"^[a-zA-Z]+$";
            if (!Regex.IsMatch(nameInput, regexPattern))
                return false;

            return true;
        }

    }
}
