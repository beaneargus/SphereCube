﻿Module Module1
    Dim input As String
    Sub Main()
        ' Set Variables
        Dim Volume As Double = 0
        Dim Length As Double = 0
        Dim Radius As Double = 0
        Dim ResultString As String = ""

        ' Cube or Sphere
        Console.WriteLine("Calculating Volume: input 1 for cube,input 2 for sphere")
        input = Console.ReadLine()

        If input = "1" Then
            ' - Cube

            ' --Prompt for Length of Side
            Console.WriteLine("Input length of side")
            Length = Console.ReadLine()

            ' --Calculate Cube Volume
            Volume = Length ^ 3

        Else
            ' - Sphere

            ' -- Prompt for Radius
            Console.WriteLine("Input sphere radius")
            Radius = Console.ReadLine()

            ' -- Calculate Sphere Volume
            Volume = (4 / 3) * Math.PI * (Radius ^ 3)

        End If

        ' Output Volume
        ResultString = Volume.ToString()
        If input = "1" Then
            Console.WriteLine("Cube has a volume of " + ResultString)

        Else

            Console.WriteLine("Sphere has a volume of " + ResultString)
        End If


        ' End with Pause
        Console.ReadKey()



    End Sub

End Module