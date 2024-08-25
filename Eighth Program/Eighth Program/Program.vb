Imports System.Console

Module Program
    Sub Main()
        Dim length, breadth, area As Double
        Write("Enter the length of your rectangle: ")
        length = ReadLine()
        Write("Enter the breadth of your rectangle: ")
        breadth = ReadLine()
        area = length * breadth
        WriteLine("The are of your rectangle is " & area)
        ReadKey()
    End Sub
End Module