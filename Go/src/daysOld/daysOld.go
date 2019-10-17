package main

import (
	"fmt"
	"math"
	"os"
	"time"
)

func main() {
	if len(os.Args) == 1 {
		os.Stderr.WriteString("Please tell me your date of birth!\n")
	} else {
		var layout = "2006-01-02"
		var dateOfBirth, dOBParseError = time.Parse(layout, os.Args[1])

		if dOBParseError != nil {
			fmt.Fprintf(os.Stderr, "Unable to parse your date of birth: %s\n", dOBParseError)
		} else {
			var age = time.Since(dateOfBirth)
			var ageInDays = math.Floor(age.Hours() / 24)

			if ageInDays < 0 {
				os.Stderr.WriteString("Wow! I must be talking to a foetus!\n")
			} else {
				fmt.Printf("Days old: %.0f\n", ageInDays)
			}
		}
	}
}
