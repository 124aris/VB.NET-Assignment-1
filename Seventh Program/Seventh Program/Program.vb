Imports System.Console

Module Program
    Sub Main()
        Dim num1, num2, product As Double
        Write("Enter you first double number: ")
        num1 = ReadLine()
        Write("Enter your second double number: ")
        num2 = ReadLine()
        product = num1 * num2
        product = Math.Round(product, 2)
        WriteLine("Product of these two double numbers is " & product)
        ReadKey()
    End Sub
End Module