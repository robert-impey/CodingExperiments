package main

import (
	"fmt"
	"time"
)

func main() {
	today := time.Now().Weekday()
	fmt.Println(today)

	fileNameTime := time.Now().UTC().Format(time.RFC3339Nano)
	fmt.Println(fileNameTime)
}
