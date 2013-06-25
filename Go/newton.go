// See http://tour.golang.org/#23

package main

import (
	"fmt"
	"math"
)

func Sqrt(x float64) (float64, error) {
	z := 1.0
	for i := 0; i < 10; i++ {
		z = z - ((z*z - x) / (2 * x))
	}
	return z, nil
}

func main() {
	for i := -2; i <= 10; i++ {
		mine, _ := Sqrt(float64(i))
		builtIn := math.Sqrt(float64(i))

		error := math.Abs(mine - builtIn)

		fmt.Printf("%d,%f,%f,%f\n", i, mine, builtIn, error)
	}
}
