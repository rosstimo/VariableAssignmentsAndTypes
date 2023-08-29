Option Explicit On
Option Strict On

Module VariableAssignmentsAndTypes
    Sub Main()
        Dim fruit As String
        Dim number As Integer
        Dim price As Double
        Dim userInput As String
        Dim userNumber As Integer
        Const TAXRATE As Double = 0.06
        Const PI As Double = 3.1415926535897931
        fruit = "apple"
        number = 5
        'number = 5.976876
        price = 1.99
        Console.WriteLine("I have " & CStr(number) & " " & fruit & "s")
        userInput = Console.ReadLine()
        Console.WriteLine("You typed: " & userInput)
        Console.WriteLine($"You typed: {userInput}")

        Console.WriteLine("Please enter a number:")
        userInput = Console.ReadLine
        userNumber = CInt(userInput)
        Console.WriteLine($"You entered: {userNumber}")
        'add userNumber to number then display the equation and result
        Console.WriteLine($"{userNumber} + {number} = {userNumber + number}")
        'pause here until user presses enter
        Console.Read()
    End Sub

End Module
