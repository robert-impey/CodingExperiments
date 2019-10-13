// See http://tour.golang.org/#36
package main

import "golang.org/x/tour/pic"

func Pic(dx, dy int) [][]uint8 {
	s := make([][]uint8, dy)

	for y := 0; y < dy; y++ {
		row := make([]uint8, dy)

		for x := 0; x < dx; x++ {
			row[x] = uint8((x * y) / 2)
		}

		s[y] = row
	}

	return s
}

func main() {
	pic.Show(Pic)
}
