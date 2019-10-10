package mybytes

import (
	"testing"
)

func TestCountByteDiff(t *testing.T) {
	cases := []struct {
		a, b uint8
		diff int
	}{
		{0, 0, 0},
		{255, 255, 0},
		{0, 255, 8},
		{255, 0, 8},
		{254, 255, 1},
	}

	for _, c := range cases {
		got := CountByteDiff(c.a, c.b)
		if got != c.diff {
			t.Errorf("CountByteDiff(%d, %d) != %d\n", c.a, c.b, c.diff)
		}
	}
}
