Module Module1
    Sub Main()
        Dim FILE_NAME As String = "H:\Computer Sci\VbMadeMe.txt"
        Dim textWriter As New System.IO.StreamWriter(FILE_NAME)
        If System.IO.File.Exists(FILE_NAME) = True Then
            textWriter.Write("HelloTherle")
            Console.WriteLine("Text written to file")
        Else
            Console.WriteLine("File Does Not Exist")
            Console.ReadLine()
            Console.WriteLine("Making the file and filling it!")
            textWriter.Write("HelloThere")
            Console.WriteLine("Text written to file")
        End If
        textWriter.Close()
        Console.ReadLine()
    End Sub

End Module
