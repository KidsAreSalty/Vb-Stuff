Module Module1
    Dim CostPerHundredGrams As Decimal
    Dim MassOfSweets As Decimal
    Dim DevidedCost As Decimal
    Dim TotalCost As Decimal
    Dim RoundedTotalCost As Decimal
    Sub Main()
        Console.WriteLine("How much does 100g of sweets cost?")
        CostPerHundredGrams = Console.ReadLine
        Console.WriteLine("What is the mass of the sweets you are buying?")
        MassOfSweets = Console.ReadLine
        DevidedCost = CostPerHundredGrams / 100
        TotalCost = MassOfSweets * DevidedCost
        RoundedTotalCost = Math.Round(TotalCost, 0)
        Console.WriteLine("You will pay £" & RoundedTotalCost & " For your sweets")
        Console.ReadLine()
    End Sub
End Module
