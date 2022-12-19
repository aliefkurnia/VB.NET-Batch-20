Namespace PartTwo
    Public Class Programmer
        Inherits Employee
        Private _transportasi As Double

        Public Sub New(firstName As String, lastName As String, joinDate As Date, basicSalary As Double, Optional transportasi As Double = Nothing)
            MyBase.New(firstName, lastName, joinDate, basicSalary)
            _transportasi = transportasi
            MyBase.TotalSalary = MyBase.TotalSalary + transportasi
        End Sub

        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()},
            tJTransport : {_transportasi},
            TotalSalary : {TotalSalary}
                    "
        End Function


        Public Property Transportasi As Double
            Get
                Return _transportasi
            End Get
            Set(value As Double)
                _transportasi = value
                TotalSalary = value + BasicSalary
            End Set
        End Property
        Public Overrides Property BasicSalary As Double
            Get
                Return MyBase.BasicSalary
            End Get
            Set(value As Double)
                MyBase.BasicSalary = value
                TotalSalary = value + Transportasi
            End Set
        End Property
    End Class

End Namespace
