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
}

let ace = Rank.ace
let rawAce = ace.rawValue

print(ace.simpleDescription())
print(rawAce)
