Module Module1
    Dim userGuess As String
    Dim newWord As String
    Sub Main()
        Console.WriteLine("What is the new word?")
        newWord = Console.ReadLine
        Console.WriteLine("make your Guess!")
        userGuess = Console.ReadLine
        If userGuess = newWord Then
            Console.WriteLine("Wow you got it right!")
            Console.ReadLine()
        Else
            Console.WriteLine("Sorry you got it wrong :(")
            Console.ReadLine()
        End If
    End Sub

End Module
