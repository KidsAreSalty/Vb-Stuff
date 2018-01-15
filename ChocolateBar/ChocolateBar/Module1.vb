Module Module1
    Dim Choice As String
    Dim Change As Decimal
    Dim Money As Decimal
    Sub Main()
        Console.WriteLine("Welcome to Charlie's Tuck Shop!")
        Console.WriteLine("Here are the Chocolate bars we offer!")
        Console.WriteLine("")
        Console.WriteLine("MarsBar")
        Console.WriteLine("Twix")
        Console.WriteLine("MilkyBar")
        Console.WriteLine("Freddo")
        Console.WriteLine("")
        Console.WriteLine("Please Select Which Chocolate bar you would like! (Please enter the name)")
        Choice = Console.ReadLine()

        If Choice = "marsbar" Then
            Dim Cost As Decimal = 0.5
            Console.WriteLine("Total comes to " & Cost & "p ")
            Console.WriteLine("Please enter your money (Decimal Form)")
            Money = Console.ReadLine
            Change = ChoiceMarsBar(Cost, Money)
        End If

        If Choice = "twix" Then
            Dim Cost As Decimal = 0.45
            Console.WriteLine("Total comes to " & Cost & "p ")
            Console.WriteLine("Please enter your money (Decimal Form)")
            Money = Console.ReadLine
            Change = ChoiceTwix(Cost, Money)
        End If

        If Choice = "milkybar" Then
            Dim Cost As Decimal = 0.2
            Console.WriteLine("Total comes to " & Cost & "p ")
            Console.WriteLine("Please enter your money (Decimal Form)")
            Money = Console.ReadLine
            Change = ChoiceMilky(Cost, Money)
        End If

        If Choice = "freddo" Then
            Dim Cost As Decimal = 0.1
            Console.WriteLine("Total comes to " & Cost & "p ")
            Console.WriteLine("Please enter your money (Decimal Form)")
            Money = Console.ReadLine
            Change = ChoiceFreddo(Cost, Money)
        End If

        Console.WriteLine("Your change is " & Change)
        Console.ReadLine()
    End Sub


    Function ChoiceMarsBar(cost, money) As Decimal
        ChoiceMarsBar = money - cost
    End Function

    Function ChoiceTwix(cost, money) As Decimal
        ChoiceTwix = money - cost
    End Function

    Function ChoiceMilky(cost, money) As Decimal
        ChoiceMilky = money - cost
    End Function

    Function ChoiceFreddo(cost, money) As Decimal
        ChoiceFreddo = money - cost
    End Function


End Module
