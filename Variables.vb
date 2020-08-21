Option Strict On
Option Explicit On
Module Variables

    Sub Main()
        'assigning a variable 
        Dim myFirstNumber As Integer
        Dim mySecondNumber As Integer
        Dim aLittleString As String
        Dim someSortOfTest As Boolean
        Dim result As Integer




        myFirstNumber = 42


        Console.WriteLine(myFirstNumber)
        Console.ReadLine()

        aLittleString = "some text"

        Console.WriteLine(aLittleString)
        Console.ReadLine()

        someSortOfTest = True

        Console.WriteLine(someSortOfTest)
        Console.ReadLine()

        'Break it with wrong data type

        'mySecondNumber = "5"

        'MakeSureToDeclareVaribles
        'X = 7

        'Console.WriteLine(x)
        'Console.ReadLine()

        'do math 
        mySecondNumber = 8

        Console.WriteLine(myFirstNumber + mySecondNumber)
        Console.ReadLine()
        'myFirstNumber +mySecondNumber

        result = (myFirstNumber + mySecondNumber)

        Console.WriteLine(result)
        Console.ReadLine()









    End Sub

End Module
