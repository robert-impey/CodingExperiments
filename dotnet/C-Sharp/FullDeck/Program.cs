// Compare to the Q program
// fd:"234567890JQKA" cross "DCHS"

var cards = "234567890JQKA";
var suits = "DCHS";

var cardsCount = cards.Length * suits.Length;

var fullDeck = new char[cardsCount, 2];

var deckPosition = 0;
for (var i = 0; i < cards.Length; i++)
{
    for (var j = 0; j < suits.Length; j++)
    {
        fullDeck[deckPosition, 0] = cards[i];
        fullDeck[deckPosition, 1] = suits[j];
        deckPosition++;
    }
}

for (var i = 0; i < cardsCount; i++)
{
    Console.WriteLine($"{fullDeck[i, 0]}{fullDeck[i, 1]}");
}
