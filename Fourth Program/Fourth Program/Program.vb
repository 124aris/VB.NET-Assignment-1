Imports System.Console

Module Program
    Sub Main()
        Randomize()
        Dim randnum As Integer
        Do
            randnum = Int(Rnd() * 6) + 1
            WriteLine("Generated random number: " & randnum)
        Loop While randnum <> 6
        WriteLine("Number 6 was generated. Closing the Program.")
        ReadKey()
    End Sub
End Module