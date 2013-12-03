using System;

namespace LspPeople
{
    public class PersonWithDateOfBirthV2 : PersonWithAgeV2
    {
        private DateTime _dateOfBirth;

        public DateTime DateOfBirth
        {
            set
            {
                _dateOfBirth = value;
            }
        }

        public override int Age
        {
            get 
            {
                return DateTimeHelper.YearsSince(_dateOfBirth);
            }
        }
    }
}
