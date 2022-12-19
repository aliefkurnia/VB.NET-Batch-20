Namespace PartOne
    Module ModulePartTwo
        Sub initEmployee()

            'Create Object Employee without encapsulation
            Dim emp1 As New Employee With {
                .empId = 1,
                .firstName = "alip",
                .lastName = "kurnia",
                .joinDate = #12/12/2022 08:00:00 AM#,
                .basicSalary = 5_000
            }
            'display employee info
            Console.WriteLine(emp1.ToString())

            emp1.basicSalary = 4_000_000
            Console.WriteLine(emp1.ToString())
        End Sub
    End Module
End Namespace

