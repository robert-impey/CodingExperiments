package main

import "fmt"

func main() {
	number := 7
	currentTotal := number

	for i := 0; i < 10; i++ {
		fmt.Println(currentTotal)
		currentTotal += number
	}
}
