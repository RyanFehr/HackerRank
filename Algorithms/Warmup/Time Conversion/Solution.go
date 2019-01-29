package main

import (
    "bufio"
    "fmt"
    "io"
    "os"
    "strings"
    "time"
)

/*
 * Complete the timeConversion function below.
 */
func timeConversion(s string) (string, err) {
    ampm := "03:04:05PM"
    military := "15:04:05"
    t, err := time.Parse(ampm, s)
    if err != nil {
        fmt.Println(err)
        return "", err
    }
    return t.Format(military), nil
}

func main() {
    reader := bufio.NewReaderSize(os.Stdin, 1024 * 1024)

    outputFile, err := os.Create(os.Getenv("OUTPUT_PATH"))
    checkError(err)

    defer outputFile.Close()

    writer := bufio.NewWriterSize(outputFile, 1024 * 1024)

    s := readLine(reader)

    result, err := timeConversion(s)
    checkError(err)

    fmt.Fprintf(writer, "%s\n", result)

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
