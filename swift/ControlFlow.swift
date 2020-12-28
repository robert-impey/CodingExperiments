// https://docs.swift.org/swift-book/GuidedTour/GuidedTour.html#ID462

let individualScores = [73, 43, 103, 87, 12]
var teamScore = 0
for score in individualScores {
    if score > 50 {
        teamScore += 3
    } else {
        teamScore += 1
    }
}
print(teamScore)

var optionalString: String? = "Hello"
print(optionalString == nil)

var optionalName: String? = nil //"John Appleseed"
var greeting = "Hello!"
if let name = optionalName {
    greeting = "Hello, \(name)"
} else {
    greeting = "Hello, stranger!"
}
print(greeting)

let nickname: String? = "Johnny" //nil
let fullName: String = "John Appleseed"
let informalGreeting = "Hi, \(nickname ?? fullName)"
print(informalGreeting)

let vegetable = "red pepper"
switch vegetable {
    case "celery":
        print("Add some raisins and make ants on a log.")
    case "cucumber", "watercress":
        print("That would make a good tea sandwich.")
    case let x where x.hasSuffix("pepper"):
        print("Is it a spicy \(x)?")
    default:
        print("Everything tastes good in soup.")
}

let interestingNumbers = [
    "Prime": [2, 3, 5, 7, 11, 13],
    "Fibonacci": [1, 1, 2, 3, 5, 8],
    "Square": [1, 4, 9, 16, 25],
]
var largest = 0
var largestKind: String? = nil
for (kind, numbers) in interestingNumbers {
    for number in numbers {
        if number > largest {
            largest = number
            largestKind = kind
        }
    }
}
print(largest)
// See https://www.andyibanez.com/posts/pattern-matching/#:~:text=In%20Swift%2C%20Optionals%20are%20just%20syntactic%20sugar%20for,even.%20Take%20a%20look%20at%20the%20following%20code%3A
if case let lk? = largestKind {
    print("The kind of the largest number was \(lk)")
} else {
    print("No largest kind found!")
}

var n = 2
while n < 100 {
    n *= 2
}
print(n)

var m = 2
repeat {
    m *= 2
} while m < 100
print(m)

var total = 0
for i in 0..<4 {
    total += i
}
print(total)
