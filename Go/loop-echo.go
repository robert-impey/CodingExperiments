// Prints its command line arguments
package main

import (
	"fmt"
	"os"
	"time"
)

func main() {
	var s, sep string
	start := time.Now()

	for _, arg := range os.Args[1:] {
		s += sep + arg
		sep = " "
	}

	nsec := time.Since(start).Nanoseconds()

	fmt.Printf("String length %d\n", len(s))
	fmt.Printf("Loop echo took %d nanoseconds\n", nsec)
}
