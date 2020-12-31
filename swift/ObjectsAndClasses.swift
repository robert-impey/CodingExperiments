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

class Square: NamedShape {
    var sideLength: Double

    init (sideLength: Double, name: String) {
        self.sideLength = sideLength
        super.init(name: name)
        numberOfSides = 4
    }

    func area() -> Double {
        return sideLength * sideLength
    }

    override func simpleDescription() -> String {
        return "A square with sides of length \(sideLength)."
    }
}

let test = Square(sideLength: 5.2, name: "my test square")
print(test.area())
print(test.simpleDescription())
