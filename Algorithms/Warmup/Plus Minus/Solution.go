package main

import (
    "bufio"
    "fmt"
    "io"
    "os"
    "strconv"
    "strings"
)

// Complete the plusMinus function below.
func plusMinus(arr []int32) {
    var pos, neg, zero float32
    l := float32(len(arr))
    for _, n := range(arr) {
        if n > 0 {
            pos++
        } else if n < 0 {
            neg++
        } else {
            zero++
        }
    }

    fmt.Printf("%1.6f\n%1.6f\n%1.6f\n", pos/l, neg/l, zero/l)
}

func main() {
    reader := bufio.NewReaderSize(os.Stdin, 1024 * 1024)

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

    plusMinus(arr)
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
