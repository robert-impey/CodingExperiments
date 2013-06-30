/**
 * The second attempt.
 * 
 * We declare the Age property to be abstract because we
 * will implement it differently in the subclasses.
 */

namespace LspPeople
{
    public abstract class PersonWithAgeV2 : Person
    {
        public abstract int Age { get; }
    }
}
