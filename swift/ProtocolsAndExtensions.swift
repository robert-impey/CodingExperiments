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

extension Int: ExampleProtocol {
    var simpleDescription: String {
        return "The number \(self)"
    }
    mutating func adjust() {
        self += 42
    }
    func augmentedDescription() -> String {
        return "\(self) (augmented)"
    }
}

print(7.simpleDescription)

extension Double {
    func absoluteValue() -> Double {
        if self >= 0.0 {
            return self
        }
        return -1.0 * self
    }
}

print(-1.0.absoluteValue())
var d: Double = -1.0
print(d.absoluteValue())

print(a.anotherPropery)
let protocolValue: ExampleProtocol = a
print(protocolValue.simpleDescription)
//print(protocolValue.anotherPropery)
