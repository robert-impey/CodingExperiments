package main

import (
	"flag"
	"fmt"
)

func printMultiples(number int, numberOfMultiples int) {
	currentTotal := 0

	for i := 0; i < numberOfMultiples; i++ {
		currentTotal += number
		fmt.Println(currentTotal)
	}
}

func main() {
	var number = flag.Int("number", 5, "The number to be multiplied")
	var numberOfMultiples = flag.Int("numberOfMultiples", 5, "The number of multiples to print")
	flag.Parse()

	printMultiples(*number, *numberOfMultiples)
}
