// See https://docs.swift.org/swift-book/GuidedTour/GuidedTour.html#ID466

protocol ExampleProtocol {
    var simpleDescription: String { get }
    mutating func adjust()
    func augmentedDescription () -> String
}

class SimpleClass: ExampleProtocol {
    var simpleDescription: String = "A very simple class."
    var anotherPropery: Int = 69105
    func adjust() {
        simpleDescription += " Now 100% adjusted."
    }
    func augmentedDescription() -> String {
        return simpleDescription + " Augmented."
    }
}

var a = SimpleClass()
a.adjust()
let aDescription = a.simpleDescription
print(aDescription)
print(a.augmentedDescription())
print(a.simpleDescription)

struct SimpleStructure: ExampleProtocol {
    var simpleDescription: String = "A simple structure"
    mutating func adjust() {
        simpleDescription += " (adjusted)"
    }
    func augmentedDescription() -> String {
        return simpleDescription + " (aug'd)"
    }
}

var b = SimpleStructure()
b.adjust()
let bDescription = b.simpleDescription
print(bDescription)
print(b.augmentedDescription())
print(b.simpleDescription)
