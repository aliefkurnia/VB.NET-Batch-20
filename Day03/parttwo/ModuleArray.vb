Namespace PartTwo
    Module ModuleArray
        Function GetArray() As Integer()
            Dim arr() As Integer = New Integer(2) {1, 2, 3}
            Return arr
        End Function

        Sub DisplayArray()
            Dim arr1() As Integer
            arr1 = GetArray()

            For i = 0 To arr1.Length - 1
                Console.WriteLine($"{arr1(i)}")
            Next
        End Sub

        Sub InitListGeneric()
            Dim listCodee As New List(Of String) From {"paguyuban 1", "paguyuban 2", "paguyuban 3"}

            For Each list In listCodee
                Console.WriteLine(list)
            Next

        End Sub

    End Module
End Namespace
