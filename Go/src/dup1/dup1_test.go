package main

import (
	"bufio"
	"os"
	"testing"
)

func getFileCounts(file string) map[string]int {
	f, _ := os.Open("empty.txt")
	return count(bufio.NewScanner(f))
}

func TestEmpty(t *testing.T) {

	counts := getFileCounts("empty.txt")

	if len(counts) != 0 {
		t.Errorf("Expected the empty file to return 0 counts, got %d", len(counts))
	}
}

func TestSingleFruit(t *testing.T) {
	counts := getFileCounts("single-fruit.txt")

	if len(counts) != 0 {
		t.Errorf("Expected the single fruits file to return 0 count, got %d", len(counts))
	}
}
