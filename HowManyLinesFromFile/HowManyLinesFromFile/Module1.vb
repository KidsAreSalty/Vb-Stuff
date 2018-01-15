Module Module1
    Dim LineNumbers As Integer
    Sub Main()
        Dim TextLine As String = ""
        FileOpen(1, "H:\Computer Sci\TESTFILE5.txt", OpenMode.Input)
        While Not EOF(1)
            Input(1, TextLine)
            Console.WriteLine(TextLine)
            LineNumbers = LineNumbers + 1
        End While
        FileClose(1)
        Console.WriteLine()
        Console.WriteLine("There are a total of " & LineNumbers & " in the File")
        Console.ReadLine()
    End Sub

End Module
