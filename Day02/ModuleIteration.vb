Module ModuleIteration


    'Do While 
    Sub doWhile()
        Dim i As Integer = 1
        Do While i <= 10
            Console.WriteLine(i)
            i += 1
        Loop
    End Sub

    'Do While Exit
    Sub doWhileExit(n As Integer)
        Dim i As Integer = 1
        Do While i <= n
            Console.WriteLine(i)
            If (i = 10) Then
                Exit Do
            Else
                i += 1
            End If
        Loop
    End Sub

    'For loop
    Sub ForLoop()
        For index = 1 To 5
            Console.Write("* ")
        Next
    End Sub

    Sub KotakBintang(num As Integer)
        'pindah baris
        For i = 1 To num
            'cetak horizontal
            For j = 1 To num
                Console.Write("* ")
            Next
            'pindah baris
            Console.WriteLine(" ")
        Next
    End Sub

End Module
