Module ModuleMath

    Sub OperationMath()
        Dim y As Double
        y = 12 + (15 + 3) - 2 ^ 3 \ 4 * 5
        Console.WriteLine(y)
    End Sub

    'pembagian dan sisa
    Sub BagiSisa()
        Dim num1, num2, bagi, sisa As Double

        Console.Write("Enter Number 1 :")
        num1 = Console.ReadLine()
        Console.Write("Enter Number 2 :")
        num2 = Console.ReadLine()

        'result
        bagi = num1 \ num2
        sisa = num1 Mod num2

        Console.WriteLine("Result Bagi : " & bagi & ", Sisa : " & sisa)
    End Sub

End Module
