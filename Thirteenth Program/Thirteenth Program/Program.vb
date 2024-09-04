Imports System.Console

Module Program
    Sub Main()
        Dim celsius, fahrenheit, inches, centimetres, stones, kilograms As Double
        Write("Enter the Temperature in Celsius: ")
        celsius = ReadLine()
        fahrenheit = (9 / 5 * celsius) + 32
        WriteLine("The Temperature in Fahrenheit is " & fahrenheit)
        Write("Enter the Person's Height in Inches: ")
        inches = ReadLine()
        centimetres = inches * 2.54
        WriteLine("The Person's Height in Centimetres is " & centimetres)
        Write("Enter the Person's Weight in Stones: ")
        stones = ReadLine()
        kilograms = stones * 6.364
        WriteLine("The Person's Weight in Kilograms is " & kilograms)
        ReadKey()
    End Sub
End Module
