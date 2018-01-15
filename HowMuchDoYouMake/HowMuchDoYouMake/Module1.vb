Module Module1
    Dim HoursWorked As Integer
    Dim HourlyRate As Integer
    Dim TotalPay As Integer
    Dim DailyPay As Integer
    Sub Main()

        Console.WriteLine("How many hours do you work each day?")
        HoursWorked = Console.ReadLine

        Console.WriteLine("How much do you get paid per hour?")
        HourlyRate = Console.ReadLine
        For counter As Integer = 1 To 7
            DailyPay = HoursWorked * HourlyRate
            TotalPay = TotalPay + DailyPay
        Next
        Console.WriteLine("You make £" & TotalPay & " Per week!")
        Console.ReadLine()

    End Sub

End Module
