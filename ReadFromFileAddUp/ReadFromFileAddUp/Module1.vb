Module Module1
    Dim FinalNumber As Integer
    Sub Main()
        Dim TextLine As Integer
        FileOpen(1, "H:\Computer Sci\TESTFILE4.txt", OpenMode.Input)
        While Not EOF(1)
            For counter = 1 To 10
                Input(1, TextLine)
                Console.WriteLine(TextLine)
                FinalNumber = TextLine + FinalNumber
            Next
        End While
        FileClose(1)
        Console.WriteLine()
        Console.WriteLine("The Final Number is " & FinalNumber)
        Console.ReadLine()
    End Sub

End Module
