package main

import (
	"fmt"
	"strings"
)

func wordCount(s string) map[string]int {
	m := make(map[string]int)

	words := strings.Fields(s)

	for _, word := range words {
		m[word]++
	}

	return m
}

func main() {
	fmt.Println(wordCount("How much wood would a woodchuck chuck if a woodchuck could chuck wood?"))
}
