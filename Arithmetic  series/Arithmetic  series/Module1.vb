Module Module1
    Dim CommonDiff As Integer
    Dim FinalFirst As Integer
    Dim FinalSecond As Integer
    Sub Main()
        Console.WriteLine("Please Enter the Common difference!")
        CommonDiff = Console.ReadLine()
        Console.WriteLine("")
        Console.WriteLine("Here are your Terms")
        For counter = 1 To 20
            FinalFirst = counter
            FinalSecond = counter + CommonDiff
            Console.WriteLine(FinalFirst & " and " & FinalSecond)
            Threading.Thread.Sleep(100)
        Next
        Console.ReadLine()
    End Sub
End Module
