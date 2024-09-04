Imports System.Console
Imports System.Transactions

Module Program
    Sub Main()
        Dim pounds, euros, exchange_rate As Double
        Write("Enter the Number of Pounds You Have: ")
        pounds = ReadLine()
        exchange_rate = 1.15
        Write("Enter the Exchange Rate: ")
        exchange_rate = ReadLine()
        euros = pounds * exchange_rate
        WriteLine("The Number of Euros You Have are " & euros & " Euros")
        ReadKey()
    End Sub
End Module
