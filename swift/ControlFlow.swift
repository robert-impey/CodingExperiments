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
