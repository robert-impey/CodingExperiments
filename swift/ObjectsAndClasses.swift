// See https://docs.swift.org/swift-book/GuidedTour/GuidedTour.html#ID464

class Shape {
    var numberOfSides = 0
    let totalInternalAngle = 360

    func simpleDescription() -> String {
        return "A shape with \(numberOfSides) sides."
    }

    func paint(colour: String) -> () {
        print("Painting the shape \(colour).")
    }
}

var shape = Shape()
shape.numberOfSides = 7
var shapeDescription = shape.simpleDescription()
print(shapeDescription)

class NamedShape {
    var numberOfSides: Int = 0
    var name: String

    init(name: String) {
        self.name = name
    }

    func simpleDescription() -> String {
        return "A shape with \(numberOfSides) sides."
    }
}

var namedShape = NamedShape(name: "Fred")
print(namedShape.name)
