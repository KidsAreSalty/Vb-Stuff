Module Module1

    Sub Main()
        Dim TextLine As String
        FileOpen(1, "H:\Computer Sci\TESTFILE.txt", OpenMode.Input)
        While Not EOF(1)
            TextLine = LineInput(1)
            Console.WriteLine(TextLine)
        End While
        FileClose(1)
        Console.ReadLine()
    End Sub

End Module
