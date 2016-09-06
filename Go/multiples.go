package main

import "fmt"

func printMultiples(number int, numberOfMultiples int) {
	currentTotal := 0

	for i := 0; i < numberOfMultiples; i++ {
		currentTotal += number
		fmt.Println(currentTotal)
	}
}

func main() {
	number := 5
	numberOfMultiples := 7

	printMultiples(number, numberOfMultiples)
}
