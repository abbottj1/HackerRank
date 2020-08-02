//https://www.hackerrank.com/challenges/botclean

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
    grid := [][]string{}
    for j := 0; j < 5; j++ {
        text, _ = reader.ReadString('\n')
        grid = append(grid, strings.Split(text, ""))
    }

    for {
        i, j, found := findNearest(grid, int(x), int(y))
        if !found {
            return
        }
        for {
            move:= getMove(int(x), int(y), i, j)
            fmt.Println(move)
            return
        }
    }
}

func findNearest(grid [][]string, x, y int) (int, int, bool) {
    size := len(grid)
    for s := 0; s < size; s++ {
        for i := -s; i <= s; i++ {
            for j := -s; j <= s; j++ {
                potX := x + i
                if potX < 0 || potX >= size {
                    continue
                }
                potY := y + j
                if potY < 0 || potY >= size {
                    continue
                }
                if grid[potY][potX] == "d" {
                    return potX, potY, true
                }
            }
        }
    }
    return 0, 0, false
}

func getMove(x, y, i, j int) (string) {
    diffX := x - i
    diffY := y - j
    if diffX == 0 && diffY == 0 {
        return "CLEAN"
    }
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
