Module Module1
    Dim TimesTable As Integer
    Dim TheTimesTable As Integer
    Sub Main()
        Console.WriteLine("Hi! Which time tables would you like to be displayed?")
        TimesTable = Console.ReadLine()
        Console.WriteLine("")
        Console.WriteLine("Here you go!")
        For timestables As Integer = 1 To 12
            TheTimesTable = timestables * TimesTable
            Console.WriteLine(TheTimesTable)
        Next
        Console.ReadLine()
    End Sub

End Module
