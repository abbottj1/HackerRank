//https://www.hackerrank.com/challenges/botcleanr

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
    loc := strings.Fields(text)
    y, _ := strconv.ParseInt(loc[0], 10, 32)
    x, _ := strconv.ParseInt(loc[1], 10, 32)
    for j := 0; j < 5; j++ {
        text, _ = reader.ReadString('\n')
        line := strings.Split(text, "")
        for i := 0; i < 5; i++ {
            if line[i] == "d" {
                move, mvX, mvY := getMove(int(x), int(y), i, j)
                fmt.Println(move)
                x += mvX
                y += mvY
            }
        }
    }
}

func getMove(x, y, i, j int) (string, int64, int64) {
    diffX := x - i
    diffY := y - j
    if diffX == 0 && diffY == 0 {
        return "CLEAN", 0, 0
    }
    if math.Abs(float64(diffX)) > math.Abs(float64(diffY)) {
        if diffX < 0 {
            return "RIGHT", 1, 0
        }
        return "LEFT", -1, 0
    }
    if diffY > 0 {
        return "UP", 0, -1
    }
    return "DOWN", 0, 1
}
