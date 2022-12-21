
Namespace PartTwo
    Public Class sales
        Inherits Employee
        Private _commision As Double
        Private _bonus As Double

        Public Sub New(FirstName As String, LastName As String, JoinDate As Date, basicSalary As Double,
                       Optional commision As Double = Nothing, Optional bonus As Double = Nothing)
            MyBase.New(FirstName, LastName, JoinDate, basicSalary)
            Me.Commision = commision
            Me.Bonus = bonus
            MyBase.TotalSalary = MyBase.TotalSalary + commision + bonus
        End Sub


        Public Overrides Function ToString() As String
            Return $"MyBase.ToString(),
            tJCommision : {Commision},
            tJBonus : {Bonus},
            TotalSalary : {TotalSalary}
                    "
        End Function

        Public Property Commision As Double
            Get
                Return _commision
            End Get
            Set(value As Double)
                _commision = value
                TotalSalary = value + BasicSalary
            End Set
        End Property

        Public Property Bonus As Double
            Get
                Return _bonus
            End Get
            Set(value As Double)
                _bonus = value
                TotalSalary = value + BasicSalary
            End Set
        End Property


        Public Overrides Property BasicSalary As Double
            Get
                Return MyBase.BasicSalary
            End Get
            Set(value As Double)
                MyBase.BasicSalary = value
                TotalSalary = value + Commision + Bonus
            End Set
        End Property

    End Class

End Namespace
