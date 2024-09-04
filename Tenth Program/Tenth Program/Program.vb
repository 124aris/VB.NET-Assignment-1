Imports System.Console
Imports System.Numerics

Module Program
    Sub Main()
        Dim total, raw, percentage As Double
        Write("Enter Total Number of Marks of the Exam: ")
        total = ReadLine()
        Write("Enter the Raw Score of the Student: ")
        raw = ReadLine()
        percentage = Math.Round(raw / total * 100, 2)
        WriteLine("The Percentage of Marks Student Scored is " & percentage & "%")
        ReadKey()
    End Sub
End Module
