// See https://docs.swift.org/swift-book/GuidedTour/GuidedTour.html#ID463

func greet(person: String, day: String) -> String {
    return "Hello \(person), today is \(day)."
}
print(greet(person: "Bob", day: "Tuesday"))

func greet2(person: String, special: String) -> String {
    return "Hello \(person), today's special is \(special)."
}
print(greet2(person: "Alice", special: "beef stew"))