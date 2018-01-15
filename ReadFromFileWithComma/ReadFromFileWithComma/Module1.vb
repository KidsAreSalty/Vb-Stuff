Module Module1

    Sub Main()
        Dim TextLine As String = ""
        FileOpen(1, "H:\Computer Sci\TESTFILE2.txt", OpenMode.Input)
        While Not EOF(1)
            For counter = 1 To 5
                Input(1, TextLine)
                Console.WriteLine(TextLine)
            Next
        End While
        FileClose(1)
        Console.ReadLine()
    End Sub

End Module
