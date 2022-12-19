Imports System
Imports VbAppConsole.PartTwo

Module Program
    Sub Main(args As String())
        'Console.WriteLine("Hello World!")

        'call method SayMyName
        'SayMyName()

        'call methode variable
        'ModuleVariable.storeVariable()
        'ModuleVariable.SwapTwoVariable()

        'ModuleMath.OperationMath()
        'DecisionModule.WhoIsTheGreatest()
        'ModuleDateTime.ShowDate()
        'ModuleIteration.KotakBintang(5)
        ModulePartTwo.initEmployee()
    End Sub

    Sub SayMyName()
        'declare variable
        Dim myName As String
        Console.Write("Enter Your Name : ")

        'use ReadLine
        myName = Console.ReadLine()

        'display result
        Console.WriteLine("Your Name :" & myName)
    End Sub


End Module
