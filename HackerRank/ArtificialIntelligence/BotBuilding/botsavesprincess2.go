//https://www.hackerrank.com/challenges/saveprincess2

package main

import (
    "bufio"
    "fmt"
    "math"
    "os"
    "strconv"
    "strings"
)

func main() {
    reader := bufio.NewReader(os.Stdin)
    text, _ := reader.ReadString('\n')
    n, _ := strconv.ParseInt(strings.TrimSpace(text), 10, 32)
    text, _ = reader.ReadString('\n')
    loc := strings.Fields(text)
    y, _ := strconv.ParseInt(loc[0], 10, 32)
    x, _ := strconv.ParseInt(loc[1], 10, 32)
    for j := 0; j < int(n); j++ {
        text, _ = reader.ReadString('\n')
        line := strings.Split(text, "")
        for i := 0; i < int(n); i++ {
            if line[i] == "p" {
                fmt.Println(getMove(int(x), int(y), i, j))
                return
            }
        }
    }
}

func getMove(x, y, i, j int) string {
    diffX := x - i
    diffY := y - j
    if math.Abs(float64(diffX)) > math.Abs(float64(diffY)) {
        if diffX < 0 {
            return "RIGHT"
        }
        return "LEFT"
    }
    if diffY > 0 {
        return "UP"
    }
    return "DOWN"
}

