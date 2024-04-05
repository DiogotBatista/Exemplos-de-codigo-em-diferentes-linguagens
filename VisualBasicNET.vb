' Visual Basic .NET
Module Program
    Sub Main()
        Dim total As Integer = 0
        For i As Integer = 1 To 10
            total += i
        Next
        Console.WriteLine("A soma dos números de 1 a 10 é: " & total)
    End Sub
End Module
