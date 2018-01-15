Module Module1
    Sub Main()
        Dim FILE_NAME As String = "H:\Computer Sci\VbMadeMe.txt"
        Using writer As System.IO.StreamWriter =
            New System.IO.StreamWriter(FILE_NAME)

            writer.Write("This will be on the same line! ")
            writer.WriteLine("And so will i!")
            writer.WriteLine("But i will be on the line underneath!")
        End Using
        Console.WriteLine("Text has been written to file!")
        Console.ReadLine()
    End Sub
End Module
