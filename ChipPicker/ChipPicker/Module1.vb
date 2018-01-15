Module Module1
    Dim Chip1 As Integer
    Dim Chip2 As Integer
    Sub Main()
        Console.WriteLine("Please enter the First chip number!")
        Chip1 = Console.ReadLine
        Console.WriteLine("Please enter the Second chip!")
        Chip2 = Console.ReadLine
        If Chip1 > Chip2 Then
            Console.WriteLine("The First Chip seems to be bigger!" & "(" & Chip1 & ")")
        Else
            Console.WriteLine("The Second Chip seems to be bigger!" & "(" & Chip2 & ")")
        End If
        Console.ReadLine()
    End Sub
End Module
