Module ModuleVariable

    Sub storeVariable()
        Dim number As Integer = 200
        Dim myName As String = "Bootcamp .NET"
        Console.WriteLine("Number : " & number & ", MyName : " & myName)
        myName = "CodeId"
        Console.WriteLine("myName : " & myName)
    End Sub


    'store constant variable

    Sub StoreConstant()
        Const PHI = 3.14159
        ' PHI = 345
        Console.WriteLine("PHI : " & PHI)
    End Sub

    'variable a, b, c
    'a=1, b=2, c=3 => a=3, b=3, c=2
    Sub SwapTwoVariable()
        'declare 3 variable
        Dim a, b, c As Integer
        Console.Write("Value A: ")
        a = Console.ReadLine()

        Console.Write("Value B: ")
        b = Console.ReadLine()

        Console.Write("Value C: ")
        c = Console.ReadLine()

        Console.WriteLine("Before: a = " & a & "b = " & b)

        c = a
        a = b
        b = c
        Console.WriteLine("After: a = " & a & "b = " & b)
    End Sub
End Module
