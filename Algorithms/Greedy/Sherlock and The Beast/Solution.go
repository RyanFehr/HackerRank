package main

import (
    "bufio"
    "fmt"
    "io"
    "os"
    "strconv"
    "strings"
)

// Complete the decentNumber function below.
func decentNumber(n int32)  {
    decent := "-1"

    k := (n-1)/3 + 1
    x := 2 * n
    y := -n
    xp := x - 5 * k
    yp := y + 3 * k

    if xp >= 0 && yp >= 0 {
        decent = strings.Repeat("5", int(3*xp))+strings.Repeat("3", int(5*yp))
    }
    fmt.Println(decent)
}

func main() {
    reader := bufio.NewReaderSize(os.Stdin, 16 * 1024 * 1024)

    tTemp, err := strconv.ParseInt(strings.TrimSpace(readLine(reader)), 10, 64)
    checkError(err)
    t := int32(tTemp)

    for tItr := 0; tItr < int(t); tItr++ {
        nTemp, err := strconv.ParseInt(strings.TrimSpace(readLine(reader)), 10, 64)
        checkError(err)
        n := int32(nTemp)

        decentNumber(n)
    }
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
