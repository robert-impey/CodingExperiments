// To walk the files recursively of a directory

package main

import (
	"fmt"
	"os"
	"path/filepath"
)

func main() {
	if len(os.Args) < 2 {
		fmt.Println("Please give me a directory to walk!")
	} else {
		path := os.Args[1]
		err := filepath.Walk(path, walker)
		if err != nil {
			fmt.Println(err)
		}
	}
}

func walker(path string, info os.FileInfo, err error) error {
	if err != nil {
		fmt.Println(err)
		return err
	} else {
		fmt.Println(info.Name())
	}
	return nil
}
