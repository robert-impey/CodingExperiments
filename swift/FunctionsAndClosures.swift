// See https://docs.swift.org/swift-book/GuidedTour/GuidedTour.html#ID463

func greet(person: String, day: String) -> String {
    return "Hello \(person), today is \(day)."
}
print(greet(person: "Bob", day: "Tuesday"))

func greet2(person: String, special: String) -> String {
    return "Hello \(person), today's special is \(special)."
}
print(greet2(person: "Alice", special: "beef stew"))

func greet3(_ person: String, on day: String) -> String {
    return "Hello \(person), today is \(day)."
}
print(greet3("John", on: "Wednesday"))

func calculateStatistics(scores: [Int]) -> (min: Int, max: Int, sum: Int) {
    var min = scores[0]
    var max = scores[0]
    var sum = 0

    for score in scores {
        if score > max {
            max = score
        } else if score < min {
            min = score
        }
        sum += score
    }

    return (min, max, sum)
}
let statistics = calculateStatistics(scores: [5, 3, 100, 3, 9])
print(statistics.sum)
print(statistics.2)
print(statistics.min)
print(statistics.max)

func returnFifteen() -> Int {
    var y = 10
    func add() {
        y += 5
    }
    add()
    return y
}
print(returnFifteen())
