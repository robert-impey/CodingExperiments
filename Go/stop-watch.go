// To measure the passing of time
package main

import (
	"fmt"
	"time"
)

func main() {
	start := time.Now()

	fmt.Printf("Elapsed nanoseconds %d\n", time.Since(start).Nanoseconds())
}
