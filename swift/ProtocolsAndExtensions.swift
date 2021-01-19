// See https://docs.swift.org/swift-book/GuidedTour/GuidedTour.html#ID466

protocol ExampleProtocol {
    var simpleDescription: String { get }
    mutating func adjust()
}

class SimpleClass: ExampleProtocol {
    var simpleDescription: String = "A very simple class."
    var anotherPropery: Int = 69105
    func adjust() {
        simpleDescription += " Now 100% adjusted."
    }    
}

var a = SimpleClass()
a.adjust()
let aDescription = a.simpleDescription
print(aDescription)
