namespace FindReversedWords.Lib
{
    public class ReversedWordPair
    {
        protected bool Equals(ReversedWordPair other)
        {
            return string.Equals(firstWord, other.firstWord) && string.Equals(secondWord, other.secondWord);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((ReversedWordPair) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((firstWord != null ? firstWord.GetHashCode() : 0)*397) ^ (secondWord != null ? secondWord.GetHashCode() : 0);
            }
        }

        private readonly string firstWord;
        public string FirstWord { get { return firstWord; } }

        private readonly string secondWord;
        public string SecondWord { get { return secondWord; } }

        public ReversedWordPair(string firstWord, string secondWord)
        {
            this.firstWord = firstWord;
            this.secondWord = secondWord;
        }

        public override string ToString()
        {
            return string.Format("{0} <-> {1}", firstWord, secondWord);
        }
    }
}
