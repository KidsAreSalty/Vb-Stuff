Module Module1

    Sub Main()
        Dim TextLine As String
        Dim FILE_NAME As String = "H:\Computer Sci\FileToChange.txt"
        FileOpen(1, FILE_NAME, OpenMode.Input)
        While Not EOF(1)
            TextLine = LineInput(1)
            If TextLine = "HelloThere" Then
                Console.WriteLine("Found text")
            Else
                Console.WriteLine("Could not find the text")
            End If
        End While
        FileClose(1)
        Console.ReadLine()
    End Sub

End Module


