Imports System
Imports VbAppConsole.PartThree

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

        'ModuleArray.DisplayArray()
        'ModuleArray.InitListGeneric()


        'call interface kiri & implementation kanan

        'Dim Ihrvar As ITunjangan = New Programmer

        'Dim listEmp = Ihrvar.InitEmployee()
        'listEmp.Tmakan(500)

        ModuleTesting.nyoba()




        'Ihrvar.DisplayEmployee(listEmp)

        'find employee id

        'Dim emp = Ihrvar.FindEmployeeByID(listEmp, 1)
        'If emp IsNot Nothing Then
        '    Console.Write($"Employee Found :, {emp}")
        'Else
        '    Console.Write("Employee Not Found")
        'End If

        'ModulePartTwo.initEmployee()

        'Console.WriteLine($"Total Employee Programmer : {Ihrvar.TotalEmployee(listEmp, "Programmer")}")
        'Console.WriteLine($"total employee programmer : {Ihrvar.TotalEmployeeByRole(listEmp, "Employee")}")
        'Console.WriteLine($"total salary employee programmer : {Ihrvar.TotalEmployeSalaryByRole(listEmp, "Programmer")}")
        'Console.WriteLine(Ihrvar.TotalSalaryAll(listEmp))


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
