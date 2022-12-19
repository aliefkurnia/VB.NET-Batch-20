    Module DecisionModule
    Sub OddEvenNumber()
        Dim num As Integer
        Console.Write("Enter a number: ")
        num = Console.ReadLine()

        If num Mod 2 = 0 Then
            Console.WriteLine("Even Number")
        Else
            Console.WriteLine("Odd Number")
        End If

    End Sub

    Sub Grade()
        Dim grade As Integer
        Console.Write("Enter a number: ")
        grade = Console.ReadLine()

        If grade < 50 Then
            Console.WriteLine("E")
        ElseIf (grade >= 50) And (grade <= 60) Then
            Console.WriteLine("D")
        ElseIf (grade >= 61) And (grade <= 70) Then
            Console.WriteLine("C")
        ElseIf (grade >= 71) And (grade <= 80) Then
            Console.WriteLine("B")
        ElseIf (grade >= 81) And (grade <= 100) Then
            Console.WriteLine("A")
        Else
            Console.WriteLine("failed")
        End If
    End Sub

    Sub GradeCase()
        Dim grade As Integer
        Console.Write("Enter a number: ")
        grade = Console.ReadLine()

        Select Case grade
            Case < 50
                Console.WriteLine("F")
            Case 50 To 60
                Console.WriteLine("D")
            Case 60 To 70
                Console.WriteLine("C")
            Case 71 To 80
                Console.WriteLine("B")
            Case 81 To 100
                Console.WriteLine("A")
            Case Else
                Console.WriteLine("masukin nilai yang bener su")
        End Select
    End Sub

    Sub WhoIsTheGreatest()
        Dim num As Integer
        Dim rnd As New Random()

        Console.Write("Enter Value Between (1-10) : ")
        num = Console.ReadLine()

        If (num > 10) Or (num < 0) Then
            Console.WriteLine("Out of range")
        Else
            Dim guess As Integer = rnd.NextInt64(1, 11)
            Console.WriteLine("Your Input: " & num & vbCrLf & "Computer: " & guess)

            If (num > guess) Then
                Console.WriteLine("You Win")
            ElseIf (num = guess) Then
                Console.WriteLine("SERI CUK")
            Else
                Console.WriteLine("You Lose")
            End If
        End If
    End Sub
End Module
