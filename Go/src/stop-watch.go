// To measure the passing of time
package main

import (
	"fmt"
	"time"
)

func main() {
	start := time.Now()

	max := 1000
	total := 0
	for i := 0; i < max; i++ {
		total += i
		for j := 0; j < max; j++ {
			total += j
		}
	}
	fmt.Printf("Total: %d\n", total)

	fmt.Printf("Elapsed nanoseconds %d\n", time.Since(start).Nanoseconds())
}
