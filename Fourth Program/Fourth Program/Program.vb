Imports System.Console

Module Program
    Sub Main()
        Dim randnum As Integer
        Do Until randnum = 6
            randnum = Random(1, 7)
        Loop

        ReadKey()
    End Sub
End Module
