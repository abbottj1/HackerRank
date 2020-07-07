package main

import (
	"bufio"
	"fmt"
	"io"
	"os"
	"strconv"
	"strings"
)

// Complete the maxSubarray function below.
func maxSubarray(arr []int32) []int32 {
	maxSub := int32(0)
	maxSeq := int32(0)
	subs := make([]int32, len(arr))
	hasPos := false
	maxNeg := int32(0)
	for i, n := range arr {
		if n >= 0 {
			hasPos = true
			maxSeq = maxSeq + n
		} else if n > maxNeg || maxNeg == 0 {
			maxNeg = n
		}
		if i > 0 {
			sub := subs[i-1] + n
			if sub > 0 {
				subs[i] = sub
			} else {
				subs[i] = 0
			}
		} else {
			subs[i] = n
		}
		if subs[i] > maxSub {
			maxSub = subs[i]
		}
	}
	if !hasPos {
		maxSeq = maxNeg
		maxSub = maxNeg
	}
	return []int32{maxSub, maxSeq}
}

func main() {
	reader := bufio.NewReaderSize(os.Stdin, 1024*1024)

	stdout, err := os.Create(os.Getenv("OUTPUT_PATH"))
	checkError(err)

	defer stdout.Close()

	writer := bufio.NewWriterSize(stdout, 1024*1024)

	tTemp, err := strconv.ParseInt(readLine(reader), 10, 64)
	checkError(err)
	t := int32(tTemp)

	for tItr := 0; tItr < int(t); tItr++ {
		nTemp, err := strconv.ParseInt(readLine(reader), 10, 64)
		checkError(err)
		n := int32(nTemp)

		arrTemp := strings.Split(readLine(reader), " ")

		var arr []int32

		for i := 0; i < int(n); i++ {
			arrItemTemp, err := strconv.ParseInt(arrTemp[i], 10, 64)
			checkError(err)
			arrItem := int32(arrItemTemp)
			arr = append(arr, arrItem)
		}

		result := maxSubarray(arr)

		for i, resultItem := range result {
			fmt.Fprintf(writer, "%d", resultItem)

			if i != len(result)-1 {
				fmt.Fprintf(writer, " ")
			}
		}

		fmt.Fprintf(writer, "\n")
	}

	writer.Flush()
}

func readLine(reader *bufio.Reader) string {
	str, _, err := reader.ReadLine()
	if err == io.EOF {
		return ""
	}

	return strings.TrimRight(string(str), "\r\n")
}

func checkError(err error) {
	if err != nil {
		panic(err)
	}
}
