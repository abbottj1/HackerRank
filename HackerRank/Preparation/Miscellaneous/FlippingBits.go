package main

import (
    "bufio"
    "fmt"
    "io"
    "os"
    "strconv"
    "strings"
)

// Complete the flippingBits function below.
func flippingBits(n int64) int64 {
    //Get 32 bits
    const MaxUint = ^uint32(0) 

    //Convert to 64 bits
    const MaxInt = int64(MaxUint) 

    //XOR with input
    return n ^ MaxInt
}

func main() {
    reader := bufio.NewReaderSize(os.Stdin, 1024 * 1024)

    stdout, err := os.Create(os.Getenv("OUTPUT_PATH"))
    checkError(err)

    defer stdout.Close()

    writer := bufio.NewWriterSize(stdout, 1024 * 1024)

    qTemp, err := strconv.ParseInt(readLine(reader), 10, 64)
    checkError(err)
    q := int32(qTemp)

    for qItr := 0; qItr < int(q); qItr++ {
        n, err := strconv.ParseInt(readLine(reader), 10, 64)
        checkError(err)

        result := flippingBits(n)

        fmt.Fprintf(writer, "%d\n", result)
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
