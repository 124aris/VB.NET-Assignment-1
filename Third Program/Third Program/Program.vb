Imports System.Console

Module Program
    Sub Main()
        Dim length, width, depth, volume As Double
        Write("Enter the length of your swimming pool: ")
        length = ReadLine()
        Write("Enter the width of your swimming pool: ")
        width = ReadLine()
        Write("Enter the depth of your swimming pool: ")
        depth = ReadLine()
        volume = length * width * depth
        WriteLine("The volume of water required to fill your swimming pool is " & volume)
        ReadKey()
    End Sub
End Module