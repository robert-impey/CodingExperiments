package main

import (
	"fmt"
	"os"
)

func main() {
	fmt.Println(os.Getenv("HOME")) // Works on Mac OSX
	fmt.Println(os.Getenv("HOMEDIR"))
	fmt.Println(os.Getenv("USERPROFILE")) // Works on Windows
}
