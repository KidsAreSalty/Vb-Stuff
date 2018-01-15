Module Module1
    Sub Main()
        'Dim GetNumbers As Integer
        Dim OperatorChoice As String
        Dim OutputResult As String
        Dim NumberOne As String
        Dim NumberTwo As String
        Console.WriteLine("Please Enter Number One")
        NumberOne = Console.ReadLine()
        Console.WriteLine("Please Enter the Second Number (Optional)")
        NumberTwo = Console.ReadLine
        Console.WriteLine("Please Enter the Symbol of mathmatics you would like to use here are the Exmaples:")
        Console.WriteLine("Multiplication = *")
        Console.WriteLine("Devision = /")
        Console.WriteLine("Addition = +")
        Console.WriteLine("Subtraction = -")
        Console.WriteLine("Sqauring = 2")
        Console.WriteLine("Inverse = i")
        Console.WriteLine("Please enter the method:")
        OperatorChoice = Console.ReadLine
        If OperatorChoice = "/" Then
            OutputResult = Devision(NumberOne, NumberTwo)
        End If
        If OperatorChoice = "*" Then
            OutputResult = Multiplication(NumberOne, NumberTwo)
        End If
        If OperatorChoice = "+" Then
            OutputResult = Addition(NumberOne, NumberTwo)
        End If
        If OperatorChoice = "-" Then
            OutputResult = Subtraction(NumberOne, NumberTwo)
        End If
        If OperatorChoice = "2" Then
            OutputResult = Squared(NumberOne)
        End If
        If OperatorChoice = "i" Then
            Dim Inverse As String = "1/"
            OutputResult = Inverse + (NumberOne)
        End If
        Console.WriteLine("You Final Number is: " & OutputResult)
        Console.ReadLine()
    End Sub



    Function Devision(NumberOne, NumberTwo) As Decimal

        Devision = NumberOne / NumberTwo

    End Function

    Function Multiplication(NumberOne, NumberTwo) As Decimal

        Multiplication = NumberOne * NumberTwo

    End Function

    Function Addition(NumberOne, NumberTwo) As Decimal

        Addition = NumberOne + NumberTwo

    End Function

    Function Subtraction(NumberOne, NumberTwo) As Decimal

        Subtraction = NumberOne - NumberTwo

    End Function

    Function Squared(NumberOne) As Decimal

        Squared = NumberOne * NumberOne

    End Function


End Module
