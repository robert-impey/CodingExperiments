namespace BookFinding
{
    class Book
    {
        internal Book(string name, int numberOfPages, Colour colour)
        {
            Name = name;
            NumberOfPages = numberOfPages;
            Colour = colour;
        }

        internal string Name { get; }
        internal int NumberOfPages { get; }
        internal Colour Colour { get; }
    }
}
