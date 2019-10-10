package mybytes

var pc [256]byte

func GetBit(num uint8, pos uint8) bool {
	return num>>pos&1 == 1
}

func CountByteDiff(a uint8, b uint8) int {
	byteDiff := 0

	for i := 0; i < 8; i++ {
		if GetBit(uint8(a), uint8(i)) != GetBit(uint8(b), uint8(i)) {
			byteDiff++
		}
	}

	return byteDiff
}
