Module Module1
    Dim DriversAge As Integer
    Dim NeededAge As Integer
    Sub Main()

        NeededAge = "17"

        Console.WriteLine("Please enter your age!")
        DriversAge = Console.ReadLine
        If DriversAge > NeededAge Then
            Console.WriteLine("You are old enough to drive.")
        Else
            Console.WriteLine("Sorry you are not old enough to drive!.")
            Console.WriteLine("You must be at least " & NeededAge & " to drive!")
        End If
        Console.ReadLine()
    End Sub

End Module
