Namespace PartTwo
    Public Class QA
        Inherits Employee
        Private _makan As Double

        Public Sub New(FirstName As String, LastName As String, JoinDate As Date, basicSalary As Double, Optional makan As Double = Nothing)

            MyBase.New(FirstName, LastName, JoinDate, basicSalary)
            Me.Makan = makan
            MyBase.TotalSalary = MyBase.TotalSalary + makan
        End Sub


        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()},
            tJMakan : {Makan},
            TotalSalary : {TotalSalary}
                        "
        End Function
        Public Property Makan As Double
            Get
                Return _makan
            End Get
            Set(value As Double)
                _makan = value
            End Set
        End Property

        Public Overrides Property BasicSalary As Double
            Get
                Return MyBase.BasicSalary
            End Get
            Set(value As Double)
                MyBase.BasicSalary = value
                TotalSalary = value + Makan
            End Set
        End Property
    End Class


End Namespace
