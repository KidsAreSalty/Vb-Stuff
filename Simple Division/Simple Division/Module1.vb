Module Module1
    Dim UserNumberOne As Integer
    Dim UserNumberTwo As Integer
    Dim Devided As Decimal
    Dim NoRound As Integer
    Dim ToThree As Decimal
    Dim ToZero As Decimal
    Sub Main()
        Console.WriteLine("Please enter your first number!")
        UserNumberOne = Console.ReadLine

        Console.WriteLine("Please enter your second number!")
        UserNumberTwo = Console.ReadLine

        Devided = UserNumberOne / UserNumberTwo
        Console.WriteLine("Your two numbers devided with no rounding is " & Devided)

        ToThree = Math.Round(Devided, 2)
        Console.WriteLine("You number rounded to three decimal places is " & ToThree)

        ToThree = Math.Round(Devided, 0)
        Console.WriteLine("You number rounded to 0 decimal places is " & ToThree)

        Console.ReadLine()



    End Sub

End Module
