package main

import (
	"fmt"
	"math/cmplx"
)

func cbrt(x complex128) complex128 {
	z := complex128(1)

	for i := 0; i < 5; i++ { // How do we calculate how many iterations we need for it not to change the output?
		z -= (cmplx.Pow(z, complex128(3)) - x) / (3 * cmplx.Pow(z, complex128(2)))
	}

	return z
}

func main() {
	fmt.Println(cbrt(complex128(2)))
}
