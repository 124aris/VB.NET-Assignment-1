Imports System.Console

Module Program
    Sub Main()
        Randomize()
        Dim randnum, i As Integer
        For i = 1 To 6
            randnum = Int(Rnd() * 6) + 5
            WriteLine("Generated Random Number: " & randnum)
        Next
        ReadKey()
    End Sub
End Module