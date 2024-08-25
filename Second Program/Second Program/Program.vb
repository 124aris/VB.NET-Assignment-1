Imports System.Console

Module Program
    Sub Main()
        Dim num1, num2, product As Integer
        Write("Enter your first number: ")
        num1 = ReadLine()
        Write("Enter your second number: ")
        num2 = ReadLine()
        product = num1 * num2
        WriteLine("The product of these numbers is " & product)
        ReadKey()
    End Sub
End Module
