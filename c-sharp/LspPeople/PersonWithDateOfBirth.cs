using System;

namespace LspPeople
{
    public class PersonWithDateOfBirth : PersonWithAge
    {
        public DateTime DateOfBirth { get; set; }

        public override int Age
        {
            get
            {
                return DateTimeHelper.YearsSince(DateOfBirth);
            }
            set
            {
                // Not sure what to do here!
                throw new NotImplementedException();
            }
        }
    }
}
