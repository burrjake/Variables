﻿Option Strict On
Option Explicit On

Module Variables

    Sub Main()
        Dim myFirstNumber As Integer
        Dim mySecondNumber As Integer
        Dim result As Integer
        Dim aLittleString As String
        Dim someSortOfTest As Boolean

        myFirstNumber = 42
        mySecondNumber = 8
        result = myFirstNumber + mySecondNumber

        Console.WriteLine(myFirstNumber & "+" & mySecondNumber & "=" & result)
        Console.ReadLine()

        'Console.WriteLine(myFirstNumber)
        'Console.ReadLine()

        'aLittleString = "Some text"
        'Console.WriteLine(aLittleString)
        'Console.ReadLine()

        'someSortOfTest = True
        'Console.WriteLine(someSortOfTest)
        'Console.ReadLine()

        'x = 7

    End Sub

End Module
