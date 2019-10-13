// Prints its command line arguments
package main

import (
	"fmt"
	"os"
	"strings"
	"time"
)

func main() {
	start := time.Now()

	s := strings.Join(os.Args[1:], " ")

	nsec := time.Since(start).Nanoseconds()

	fmt.Printf("String length %d\n", len(s))

	fmt.Printf("Join echo took %d nanoseconds\n", nsec)
}
