Module Module1
    Dim RandomNumber As Integer
    Dim Difficulty As String
    Dim Easy As String
    Dim Medium As String
    Dim Hard As String


    Sub Main()
        Console.WriteLine("Hello and welcome to the Guessing game!")
        Console.WriteLine("Please Select a difficulty, you can chose either Easy, Medium or Hard")
        Difficulty = Console.ReadLine
        Console.WriteLine("you have selected: " & Difficulty)
        Dim rand As New Random()
        Dim RandomNumber = rand.Next(1, 100)
        Console.WriteLine(RandomNumber)

        If Difficulty = "easy" Then
            RunEasy(RandomNumber)
        End If

        If Difficulty = "medium" Then
            RunMedium(RandomNumber)
        End If

        If Difficulty = "hard" Then
            RunHard(RandomNumber)
        End If
        Console.WriteLine("   -   Would you like to play again? (Type y/n)")
        If Console.ReadLine = "y" Then
            Console.Clear()
            Main()
        Else
            Console.WriteLine("")
            Console.WriteLine("Ok Goodbye!")
            Threading.Thread.Sleep(2000)
        End If

    End Sub

    Sub RunEasy(RandomNumber)
        Easy = "True"
        While Easy = "True"
            Do While Easy = "True"
                Dim Guess As Integer
                Console.WriteLine("Please Make Your Guess!")
                Guess = Console.ReadLine
                If Guess > RandomNumber Then
                    Console.WriteLine("You Were too high!")
                Else
                    Console.WriteLine("You were too low!")
                End If
                If Guess = RandomNumber Then
                    Console.Write("YES! You did it! Woohoo")
                    Easy = "False"
                End If
            Loop
        End While
    End Sub

    Sub RunMedium(RandomNumber)
        For counter As Integer = 1 To 10
            Dim Guess As Integer
            Console.WriteLine("Please Make Your Guess!")
            Guess = Console.ReadLine
            If Guess > RandomNumber Then
                Console.WriteLine("You Were too high!")
            Else
                Console.WriteLine("You were too low!")
            End If
            If Guess = RandomNumber Then
                Console.Write("YES! You did it! Woohoo")
                Medium = "False"
            End If
            If counter = 10 Then
                Exit For
            End If
        Next
        Console.WriteLine("Oh No! You only had 10 Tries!")
        Console.ReadLine()
    End Sub

    Sub RunHard(RandomNumber)
        For counter As Integer = 1 To 5
            Dim Guess As Integer
            Console.WriteLine("Please Make Your Guess!")
            Guess = Console.ReadLine
            If Guess > RandomNumber Then
                Console.WriteLine("You Were too high!")
            Else
                Console.WriteLine("You were too low!")
            End If
            If Guess = RandomNumber Then
                Console.Write("YES! You did it! Woohoo")
                Medium = "False"
            End If
            If counter = 10 Then
                Exit For
            End If
        Next
        Console.WriteLine("Oh No! You only had 5 Tries!")
        Console.ReadLine()
    End Sub

End Module
