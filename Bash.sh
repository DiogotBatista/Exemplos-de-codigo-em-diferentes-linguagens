#!/bin/bash

# Bash
total=0
for ((i=1; i<=10; i++)); do
    ((total+=i))
done
echo "A soma dos números de 1 a 10 é: $total"
