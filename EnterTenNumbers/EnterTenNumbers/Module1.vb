Module Module1
    Dim Number1 As Integer
    Dim Number2 As Integer
    Dim Number3 As Integer
    Dim Number4 As Integer
    Dim Number5 As Integer
    Dim Number6 As Integer
    Dim Number7 As Integer
    Dim Number8 As Integer
    Dim Number9 As Integer
    Dim Number10 As Integer

    Dim Highestnumber As Integer
    Dim Lowestnumber As Integer
    Dim AverageNumber As Integer
    Dim SumNumber As Integer

    Sub Main()
        Console.WriteLine("Enter the first number")
        Number1 = Console.ReadLine

        Console.WriteLine("Enter the second number")
        Number2 = Console.ReadLine

        Console.WriteLine("Enter the third number")
        Number3 = Console.ReadLine

        Console.WriteLine("Enter the fourth number")
        Number4 = Console.ReadLine

        Console.WriteLine("Enter the fith number")
        Number5 = Console.ReadLine

        Console.WriteLine("Enter the sixth number")
        Number6 = Console.ReadLine

        Console.WriteLine("Enter the seven number")
        Number7 = Console.ReadLine

        Console.WriteLine("Enter the eighths number")
        Number8 = Console.ReadLine

        Console.WriteLine("Enter the ninth number")
        Number9 = Console.ReadLine

        Console.WriteLine("Enter the tenth number")
        Number10 = Console.ReadLine

        SumNumber = Number1 + Number2 + Number3 + Number4 + Number5 + Number6 + Number7 + Number8 + Number9 + Number10
        Console.WriteLine("All the numbers added together is " & SumNumber)

        AverageNumber = SumNumber / 10
        Console.WriteLine("The average of all the numbers is " & AverageNumber)

        Console.ReadLine()
    End Sub

End Module
