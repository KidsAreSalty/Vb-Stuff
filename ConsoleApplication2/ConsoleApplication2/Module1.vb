Module Module1
    Dim ToConvert As Integer
    Dim ToCurrency As String
    Dim Half1 As Integer
    Dim Half2 As Integer
    Dim Half3 As Integer
    Dim Half4 As Integer
    Dim Half5 As Integer
    Dim FInalCost As Integer
    Dim FromCurrency As String


    Sub Main()
        ToCurrency = "Pounds"
        FromCurrency = "Euro's"

        Console.WriteLine("Please enter how much you would like to convert to " & ToCurrency)
        ToConvert = Console.ReadLine
        If ToConvert > "2" Then
        Then
            Half1 = ToConvert / "10"
            Half2 = Half1 / "2"
            Half3 = Half2 / "2"
            Half4 = Half3 / "2"
            Half5 = Half4 * "2"
            FInalCost = Half5 + ToConvert
            Console.WriteLine("You will get " & FromCurrency & FInalCost & "With the current commision")
        Else
            Console.WriteLine("You will get " & FromCurrency & FInalCost & "With the current commision")
        End If


    End Sub

End Module1
