Module Module1
    Dim TheAverage As Integer
    Dim PeopleInClass As Integer
    Dim Temp As Integer
    Dim AmmountOfClasses As Integer
    Sub Main()
        Console.WriteLine("How many classes do you teach?")
        AmmountOfClasses = Console.ReadLine
        For counter = 1 To AmmountOfClasses
            Console.WriteLine("How many people are in your class?")
            Temp = Console.ReadLine()
            PeopleInClass = PeopleInClass + Temp
        Next
        TheAverage = PeopleInClass / AmmountOfClasses
        Console.WriteLine("The average number of students per class is " & TheAverage)
        Console.ReadLine()
    End Sub
End Module
