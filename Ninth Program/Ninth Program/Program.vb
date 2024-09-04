Imports System.Console

Module Program
    Sub Main()
        Dim radius, area, circumference As Double
        Const pi As Double = Math.PI
        Write("Enter the Radius of Your Circle: ")
        radius = ReadLine()
        area = pi * (radius ^ 2)
        circumference = 2 * pi * radius
        WriteLine("The Area of the Circle with the Radius " & radius & " is " & area & " and Circumference is " & circumference)
        ReadKey()
    End Sub
End Module