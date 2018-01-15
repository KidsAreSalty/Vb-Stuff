Module Module1
    Dim ToConvert As Single
    Dim ToCurrency As String
    Dim Half1 As Single
    Dim Half2 As Single
    Dim Half3 As Single
    Dim Half4 As Single
    Dim Half5 As Single
    Dim FInalCost As Single
    Dim FromCurrency As String
    Sub Main()
        ToCurrency = "Pounds"
        FromCurrency = "£"

        Console.WriteLine("Please enter how much you would like to convert to " & ToCurrency)
        ToConvert = Console.ReadLine
        If ToConvert > 2 Then
            Half1 = ToConvert / 10
            Half2 = Half1 / 2
            Half3 = Half2 / 2
            Half4 = Half3 / 2
            Half5 = Half4 * 2
            FInalCost = Half5 + ToConvert
            Console.WriteLine("You will get " & FromCurrency & FInalCost & "With the current commision")
        Else
            FInalCost = ToConvert
            Console.WriteLine("You will get " & FInalCost & " " & FromCurrency & "  With the current commision")
        End If
        Console.ReadLine()
    End Sub


End Module