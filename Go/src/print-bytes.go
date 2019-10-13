package main

import (
	"fmt"

	"mybytes"
)

func main() {

	for i := 0; i < 256; i++ {
		fmt.Printf("%d - ", i)
		for j := 7; j >= 0; j-- {
			if mybytes.GetBit(uint8(i), uint8(j)) {
				fmt.Print(1)
			} else {
				fmt.Print(0)
			}

		}
		fmt.Println()
	}
}
