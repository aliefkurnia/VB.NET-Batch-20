Imports System.Threading

Namespace PartTwo
    Public Class HR
        Implements IHR

        Public Sub DisplayEmployee(listEmp As List(Of Employee)) Implements IHR.DisplayEmployee

            For Each emp In listEmp
                Console.WriteLine(emp)
            Next

        End Sub

        Public Function InitEmployee() As List(Of Employee) Implements IHR.InitEmployee

            Dim listEmp As New List(Of Employee) From {
            New Employee("Alip", "Kurnia", DateTime.Now, 5_000),
            New Employee("suep", "sirajaguguk", DateTime.Now, 10_000),
            New Programmer("Yanto", "otnaY", DateTime.Now, 5_999, 100)
            }
            Return listEmp
        End Function

        Public Function FindEmployeeByID(listEmp As List(Of Employee), id As Integer) As Employee Implements IHR.FindEmployeeByID
            'declare variable untuk hold data employee
            Dim emp As Employee = Nothing

            For Each list In listEmp
                If (list.EmpId.Equals(id)) Then
                    emp = list
                    Return emp
                End If
            Next

            Return Nothing

        End Function


        Public Function TotalEmployeeByRole(listEmp As List(Of Employee), role As String) As Integer Implements IHR.TotalEmployeeByRole
            Dim countEmp As Integer

            For Each empl In listEmp
                If TypeName(empl) = role Then
                    countEmp += 1
                End If
            Next

            Return countEmp
        End Function

        Public Function TotalEmployeSalaryByRole(listEmp As List(Of Employee), role As String) As Integer Implements IHR.TotalEmployeSalaryByRole
            Dim CountEmp As Integer

            For Each empl In listEmp
                If TypeName(empl) = role Then
                    CountEmp = CountEmp + empl.TotalSalary
                End If
            Next
            Return CountEmp
        End Function

        Public Function TotalSalaryAll(listEmp As List(Of Employee)) As Integer Implements IHR.TotalSalaryAll
            Dim sum As Integer

            For Each empl In listEmp
                sum += empl.TotalSalary
            Next
            Return sum
        End Function
    End Class


End Namespace
