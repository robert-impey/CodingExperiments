// https://docs.swift.org/swift-book/GuidedTour/GuidedTour.html#ID462

let individualScores = [73, 43, 103, 87, 12]
var teamScore = 0
for score in individualScores {
    if score > 50 {
        teamScore += 3
    } else {
        teamScore += 1
    }
}
print(teamScore)
