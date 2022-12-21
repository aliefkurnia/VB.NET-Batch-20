Namespace PartTwo
    Module ModulePartTwo
        Sub initEmployee()

            ''Create Object Employee Encapsulation
            'Dim emp1 As New Employee(1, "Alip", "Kurnia", DateTime.Now, 5_000)
            ''display employee info
            'Console.WriteLine(emp1.ToString())

            'emp1.FirstName = "Alief"
            'emp1.BasicSalary = 6_000
            'Console.WriteLine(emp1.ToString())

            'Dim emp2 As New Employee("suep", "sirajaguguk", DateTime.Now, 10_000)
            'Console.WriteLine(emp2.ToString())

            ''create object programmer
            'Dim emp3 As New Programmer("Yanto", "otnaY", DateTime.Now, 5_999, 100)

            Dim emp4 As New QA("Alip", "Kurnia", DateTime.Now, 5_000)
            'display employee info
            Console.WriteLine(emp4.ToString())

            'emp3.BasicSalary = 6_000
            'emp3.Transportasi = 5_00
            'Console.WriteLine(emp3.ToString())

        End Sub
    End Module
End Namespace

