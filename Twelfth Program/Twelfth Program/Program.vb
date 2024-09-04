Imports System.Console

Module Program
    Sub Main()
        Dim radius, height, open_area, closed_area, volume As Double
        Const pi As Double = Math.PI
        Write("Enter the Radius of the Cylinder: ")
        radius = ReadLine()
        Write("Enter the Height of the Cylinder: ")
        height = ReadLine()
        open_area = Math.Round(2 * pi * radius * height, 2)
        closed_area = Math.Round(2 * pi * radius * (height + radius), 2)
        volume = Math.Round(pi * (radius ^ 2) * height, 2)
        WriteLine("Volume of Cylinder with Radius " & radius & " and Height " & height & " is " & volume)
        WriteLine("Area of an Open Cylinder with Radius " & radius & " and Height " & height & " is " & open_area)
        WriteLine("Area of a Closed Cylinder with Radius " & radius & " and Height " & height & " is " & closed_area)
        ReadKey()
    End Sub
End Module
