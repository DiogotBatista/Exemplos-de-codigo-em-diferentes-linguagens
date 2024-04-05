package main

import "fmt"

func main() {
    total := 0
    for i := 1; i <= 10; i++ {
        total += i
    }
    fmt.Println("A soma dos números de 1 a 10 é:", total)
}
