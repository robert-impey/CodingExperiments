package main

import (
	"bufio"
	"fmt"
	"os"
	"testing"
)

func getFileDuplicateCounts(file string) map[string]int {
	f, err := os.Open(file)
	if err != nil {
		fmt.Fprintf(os.Stderr, "Unable to open '%s'", file)
	}
	return countDuplicates(bufio.NewScanner(f))
}

func TestFiles(t *testing.T) {
	cases := []struct {
		file          string
		expectedCount int
	}{
		{"empty.txt", 0},
		{"single-fruit.txt", 0},
		{"single-fruits.txt", 0},
		{"duplicated-fruit.txt", 2},
	}

	for _, c := range cases {
		got := getFileDuplicateCounts(c.file)
		if len(got) != c.expectedCount {
			t.Errorf("Expected '%s' to return %d counts, got %d", c.file, c.expectedCount, len(got))
		}
	}
}

func TestDuplicatedFruit(t *testing.T) {
	cases := []struct {
		fruit         string
		expectedCount int
	}{
		{"apples", 3},
		{"bananas", 2},
	}

	counts := getFileDuplicateCounts("duplicated-fruit.txt")
	for _, c := range cases {

		if counts[c.fruit] != c.expectedCount {
			t.Errorf("Expected %d '%s', got %d", c.expectedCount, c.fruit, counts[c.fruit])
		}
	}
}
