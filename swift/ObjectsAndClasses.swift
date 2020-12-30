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
