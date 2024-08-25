Imports System.Console

Module Program
    Sub Main()
        Dim num1, num2, num3, sum As Integer
        Write("Enter your first number: ")
        num1 = ReadLine()
        Write("Enter your second number: ")
        num2 = ReadLine()
        Write("Enter your third number: ")
        num3 = ReadLine()
        sum = num1 + num2 + num3
        WriteLine("The sum of these numbers is equal to " & sum)
        ReadKey()
    End Sub
End Module