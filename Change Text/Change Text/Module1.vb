Module Module1

    Sub Main()
        Dim TextLine As String
        Dim FILE_NAME As String = "H:\Computer Sci\FileToChange.txt"
        Dim textWriter As New System.IO.StreamWriter(FILE_NAME)
        InputString(1, FILE_NAME)
        While Not EOF(1)
            TextLine = LineInput(1)
            If TextLine = "HelloThere" Then
                Console.WriteLine("Found text that needs to be replaced")
            Else
                Console.WriteLine("Could not find the text that needs to be replaced")
            End If
        End While
        FileClose(1)
        Console.ReadLine()
    End Sub

End Module


