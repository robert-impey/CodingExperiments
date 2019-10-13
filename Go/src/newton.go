// See http://tour.golang.org/#23
// and http://tour.golang.org/#55

package main

import (
	"fmt"
	"math"
)

type ErrNegativeSqrt float64

func (e ErrNegativeSqrt) Error() string {
	return fmt.Sprint("Cannot Sqrt negative numbers: ", float64(e))
}

func Sqrt(x float64) (float64, error) {
	if x < 0 {
		return math.NaN(), ErrNegativeSqrt(x)
	}
	z := 1.0
	for i := 0; i < 10; i++ {
		z = z - ((z*z - x) / (2 * x))
	}
	return z, nil
}

func main() {
	for i := -2; i <= 10; i++ {
		mine, sqrtError := Sqrt(float64(i))
		if sqrtError == nil {
			builtIn := math.Sqrt(float64(i))

			error := math.Abs(mine - builtIn)

			fmt.Printf("%d,%f,%f,%f\n", i, mine, builtIn, error)
		} else {
			fmt.Println(sqrtError.Error())
		}
	}
}
