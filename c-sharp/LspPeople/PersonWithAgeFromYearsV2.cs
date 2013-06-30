namespace LspPeople
{
    public class PersonWithAgeFromYearsV2 : PersonWithAgeV2
    {
        private int _yearsOld;

        public int YearsOld
        {
            set
            {
                _yearsOld = value;
            }
        }

        public override int Age
        {
            get 
            {
                return _yearsOld;
            }
        }
    }
}
