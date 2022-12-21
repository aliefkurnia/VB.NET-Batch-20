Imports VbAppConsole.PartTwo

Namespace PartThree
    Module ModuleTesting

        Sub nyoba()

            Dim testing1 As New Programmer("ayam", "kambing", DateTime.Now, 500_000, 50_000)
            Console.WriteLine(testing1)

            Dim testing2 As New Sales("Andik", "Firmansyah", DateTime.Now, 100_000, 500, 500)
            Console.Write(testing2)

            Dim testing3 As New QA("Antonio", "Zuckeberg", DateTime.Now, 200_000, 100)
            Console.Write(testing3)
        End Sub

    End Module


End Namespace
