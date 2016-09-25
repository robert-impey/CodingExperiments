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
            fmt.Printf("Days old: %.0f\n", math.Floor(age.Hours()/24))
		}
	}
}
