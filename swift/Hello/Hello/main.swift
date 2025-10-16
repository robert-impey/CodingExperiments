//
//  main.swift
//  Hello
//
//  Created by Robert Impey on 16/10/2025.
//

import Foundation

// See https://docs.swift.org/swift-book/GuidedTour/GuidedTour.html#

print("Hello, world!")

let float4: Float = 4

print(float4)

let label = "The width is "
let width = 94
let widthLabel = label + String(width)
print(widthLabel)

let apples = 3
let oranges = 5
let appleSummary = "I have \(apples) apples."
let fruitSummary =  "I have \(apples + oranges) pieces of fruit."
print(appleSummary)
print(fruitSummary)

let quotation = """
I said "I have \(apples) apples."
Then I said "I have \(apples + oranges) pieces of fruit."
"""
print(quotation)

var shoppingList = ["catfish", "water", "tulips"]
print(shoppingList[1])
shoppingList[1] = "bottle of water"
print(shoppingList[1])

shoppingList.append("blue paint")
print(shoppingList)

var occupations = [
    "Malcolm" : "Captain",
    "Kaylee" : "Mechanic"
]
occupations["Jayne"] = "Public Relations"
print(occupations)

let emptyArray = [String]()
let emptyDictionary = [String: Float]()
print(emptyArray)
print(emptyDictionary)

