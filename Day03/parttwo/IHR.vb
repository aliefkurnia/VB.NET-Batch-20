Namespace PartTwo
    Public Interface IHR

        Function InitEmployee() As List(Of Employee)

        Function FindEmployeeByID(listEmp As List(Of Employee), id As Integer) As Employee


        Function TotalEmployeeByRole(listEmp As List(Of Employee), role As String) As Integer

        Function TotalEmployeSalaryByRole(listEmp As List(Of Employee), role As String) As Integer

        Function TotalSalaryAll(listEmp As List(Of Employee)) As Integer

        Sub DisplayEmployee(listEmp As List(Of Employee))
    End Interface


End Namespace
