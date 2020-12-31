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

class Circle: NamedShape {
    var radius: Double

    init (radius: Double, name: String) {
        self.radius = radius
        super.init(name: name)
        numberOfSides = 1
    }

    func area() -> Double {
        return Double.pi * self.radius * self.radius
    }

    override func simpleDescription() -> String {
        return "A circle with a radius of \(self.radius)."
    }
}

let testCircle = Circle(radius: 3.4, name: "my test circle")
print(testCircle.area())
print(testCircle.simpleDescription())

class EquilateralTriangle: NamedShape {
    var sideLength: Double = 0.0

    init (sideLength: Double, name: String) {
        self.sideLength = sideLength
        super.init(name: name)
        numberOfSides = 3
    }

    var perimeter: Double {
        get {
            return 3.0 * sideLength
        }
        set {
            sideLength = newValue / 3.0
        }
    }

    override func simpleDescription() -> String {
        return "An equilateral triangle with sides of length \(sideLength)."
    }
}

var triangle = EquilateralTriangle(sideLength: 3.1, name: "a triangle")
print(triangle.perimeter)
triangle.perimeter = 9.3
print(triangle.sideLength)
print(triangle.perimeter)
