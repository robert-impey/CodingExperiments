package main

import (
	"crypto/sha256"
	"fmt"
	"os"

	"mybytes"
)

func main() {
	w1 := os.Args[1]
	w2 := os.Args[2]

	c1 := sha256.Sum256([]byte(w1))
	c2 := sha256.Sum256([]byte(w2))

	byteDiff := 0
	for i := range c1 {
		byteDiff += mybytes.CountByteDiff(c1[i], c2[i])
	}

	fmt.Printf("%s - %x\n", w1, c1)
	fmt.Printf("%s - %x\n", w2, c2)

	fmt.Printf("Byte diff: %d\n", byteDiff)
}
