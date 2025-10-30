// The Swift Programming Language
// https://docs.swift.org/swift-book

@main
struct FunctionsAndClosures {
    static func main() {
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

        func makeIncrementer() -> ((Int) -> Int) {
            func addOne(number: Int) -> Int {
                return 1 + number
            }
            return addOne
        }
        let increment = makeIncrementer()
        print(increment(7))

        func hasAnyMatches(list: [Int], condition: (Int) -> Bool) -> Bool {
            for item in list {
                if condition(item) {
                    return true
                }
            }
            return false
        }
        func lessThanTen(number: Int) -> Bool {
            return number < 10
        }
        let numbers = [20, 19, 7, 12]
        print(hasAnyMatches(list: numbers, condition: lessThanTen))

        print(
            numbers.map({ (number: Int) -> Int in
                let result = 3 * number
                return result
            }))

        print(
            numbers.map({ (number: Int) -> Int in
                if number % 2 == 0 {
                    return number
                }
                return 0
            }))

        let mappedNumbers = numbers.map({ number in 3 * number })
        print(mappedNumbers)

        let sortedNumbers = numbers.sorted { $0 > $1 }
        print(sortedNumbers)
    }
}
