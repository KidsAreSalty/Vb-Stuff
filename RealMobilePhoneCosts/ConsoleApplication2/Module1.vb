Module Module1
    Dim CostOfPhone As String
    Dim ContractLenth As String
    Dim MonthlyTarrif As String
    Dim NumOfFreeMinutes As String
    Dim NumOfminutesUsedPerMonth As String
    Dim CostPerMinute As Integer
    Dim PhoneCostPerMin As Integer
    Dim TarrifOverallmontlyCost As Integer
    Dim OverallMinutesused As Integer
    Dim WithOverallCost As Integer
    Dim FinalCost As Integer
    Sub Main()
        Console.WriteLine("What is the overall cost of your phone?")
        CostOfPhone = Console.ReadLine
        Console.WriteLine("how long is your contract for? (In Months)")
        ContractLenth = Console.ReadLine
        Console.WriteLine("What is your monthly tarrif? (How much do you pay per month)")
        MonthlyTarrif = Console.ReadLine
        Console.WriteLine("How many minutes do you get for free?")
        NumOfFreeMinutes = Console.ReadLine
        Console.WriteLine("How many minutes do you use per month?")
        NumOfminutesUsedPerMonth = Console.ReadLine
        TarrifOverallmontlyCost = ContractLenth * MonthlyTarrif
        OverallMinutesused = NumOfminutesUsedPerMonth - NumOfFreeMinutes
        WithOverallCost = TarrifOverallmontlyCost + CostOfPhone
        FinalCost = WithOverallCost / OverallMinutesused
        Console.WriteLine("You pay £" & FinalCost & " Per minute")
        Console.ReadLine()
    End Sub

End Module
