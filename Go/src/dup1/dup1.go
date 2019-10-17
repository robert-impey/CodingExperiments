// dup1 prints the text of each line from the standard input
// that appears more than once, preceded by its count.
package main

import (
	"bufio"
	"fmt"
	"os"
)

func main() {
	duplicateCounts := countDuplicates(bufio.NewScanner(os.Stdin))
	for line, n := range duplicateCounts {
		fmt.Printf("%d, %s\n", n, line)
	}
}

func countDuplicates(s *bufio.Scanner) map[string]int {
	counts := make(map[string]int)
	for s.Scan() {
		counts[s.Text()]++
	}
	duplicates := make(map[string]int)
	for line, n := range counts {
		if n > 1 {
			duplicates[line] = n
		}
	}
	return duplicates
}
