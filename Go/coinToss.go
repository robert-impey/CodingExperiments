package main

import (
	"flag"
	"fmt"
	"math/rand"
	"time"
)

func main() {
	rand.Seed(time.Now().UTC().UnixNano())

	var competitionSize, runs int
	flag.IntVar(&competitionSize, "competitionSize", 10, "The size of each coin tossing competition.")
	flag.IntVar(&runs, "runs", 10, "The number of runs of the competition")

	flag.Parse()

	fmt.Println("heads, tails, flips")
	for i := 0; i < runs; i++ {
		countHeads := 0
		for j := 0; j < competitionSize; j++ {
			countHeads += rand.Intn(2)
		}

		fmt.Printf("%d, %d, %d\n", countHeads, competitionSize-countHeads, competitionSize)
	}
}
