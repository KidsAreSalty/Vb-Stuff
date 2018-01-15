Module Module1
    Dim limit As Integer
    Dim Binary As Integer
    Dim Denery As Integer
    Dim Final As Integer
    Dim run As String = True
    Sub Main()
        Do While run = True
            Denery = 0
            Console.WriteLine("Please enter the Binary!")
            Binary = Console.ReadLine
            limit = limit - Len(Binary)
            For position = 1 To limit
                If Mid(Binary, position, 1) Then
                    Denery = Denery + 2 ^ (limit - position)
                End If
                If Mid(Binary, position, 1) Then
                    Denery = Denery + 2 ^ (limit - position)
                End If
            Next
            run = False
        Loop
        Console.WriteLine("Here is your Denery: " & Final)
        Console.ReadLine()
    End Sub
End Module
