package main

import (
	"bufio"
	"os"
	"testing"
)

func TestEmpty(t *testing.T) {
	f, _ := os.Open("empty.txt")
	counts := count(bufio.NewScanner(f))

	if len(counts) != 0 {
		t.Errorf("Expected the empty file to return 0 counts, got %d", len(counts))
	}
}

func TestSingleFruit(t *testing.T) {
	f, _ := os.Open("single-fruit.txt")
	counts := count(bufio.NewScanner(f))

	if len(counts) != 0 {
		t.Errorf("Expected the single fruits file to return 0 count, got %d", len(counts))
	}
}
