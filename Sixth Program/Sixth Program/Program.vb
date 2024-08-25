Imports System.Console

Module Program
    Sub Main()
        Dim firstname, message As String
        Write("What Is your First Name? ")
        firstname = ReadLine()
        message = "Hello " & firstname & ". How are you?"
        WriteLine(message)
        ReadKey()
    End Sub
End Module