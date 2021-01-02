// See https://docs.swift.org/swift-book/GuidedTour/GuidedTour.html#ID465

enum Rank: Int {
    case ace = 1
    case two, three, four, five, six, seven, eight, nine, ten
    case jack, queen, king

    func simpleDescription() -> String {
        switch self {
            case .ace:
                return "ace"
            case .jack:
                return "jack"
            case .queen:
                return "queen"
            case .king:
                return "king"
            default:
                return String(self.rawValue)
        }
    }

    func compare(_ other: Rank) -> Int {
        return self.rawValue - other.rawValue
    }
}

let ace = Rank.ace
let rawAce = ace.rawValue

print(ace.simpleDescription())
print(rawAce)

print(ace.compare(Rank.king))
print(Rank.five.compare(Rank.five))
print(Rank.king.compare(ace))

if let convertedRank = Rank(rawValue: 3) {
    let threeDescription = convertedRank.simpleDescription()
    print(threeDescription)
}

enum Suit {
    case spades, hearts, diamonds, clubs

    func simpleDescription() -> String {
        switch self {
            case .spades:
                return "spades"
            case .hearts:
                return "hearts"
            case .diamonds:
                return "diamonds"
            case .clubs:
                return "clubs"
        }
    }

    func colour() -> String {
        switch self {
            case .spades, .clubs:
                return "black"
            case .hearts, .diamonds:
                return "red"
        }
    }
}

let hearts = Suit.hearts
let heartsDescription = hearts.simpleDescription()
print(heartsDescription)

print(Suit.hearts.colour())
print(Suit.clubs.colour())
