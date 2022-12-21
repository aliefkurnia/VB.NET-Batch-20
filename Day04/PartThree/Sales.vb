
Namespace PartThree
    Public Class Sales
        Inherits Employee
        Implements ITunjangan

        Private _commision As Double
        Private _bonus As Double

        Public Property Commision As Double
            Get
                Return _commision
            End Get
            Set(value As Double)
                _commision = value
                MyBase.TotalSalary = value + BasicSalary
            End Set
        End Property

        Public Property Bonus As Double
            Get
                Return _bonus
            End Get
            Set(value As Double)
                _bonus = value
                MyBase.TotalSalary = value + BasicSalary

            End Set
        End Property

        Public Sub New(firstName As String, lastName As String, joinDate As Date, basicSalary As Double, Optional commisionx As Double = Nothing, Optional bonusx As Double = Nothing)
            MyBase.New(firstName, lastName, joinDate, basicSalary)
            Bonus = bonusx
            Commision = commisionx
            TotalSalary = basicSalary + Commision + Bonus
        End Sub

        Public Overrides Property BasicSalary As Double
            Get
                Return MyBase.BasicSalary
            End Get
            Set(value As Double)
                MyBase.BasicSalary = value
                MyBase.TotalSalary = value + Bonus + Commision
            End Set
        End Property

        Public Overrides Function Gross() As Double
            Dim kotor As Double

            kotor = MyBase.TotalSalary
            Return kotor

        End Function


        Public Overrides Function Nett() As Double
            Dim bersih As Double
            Dim BPJSKes As Double = (1 / 100) * MyBase.TotalSalary
            Dim BPJSket As Double = (2 / 100) * MyBase.TotalSalary
            bersih = MyBase.TotalSalary - (BPJSKes + BPJSket)
            Return bersih
        End Function


        Public Function Tmakan(makan As Double) As Object Implements ITunjangan.Tmakan
            Throw New NotImplementedException()
        End Function

        Public Function TTransportasi(transportasi As Double) As Double Implements ITunjangan.TTransportasi
            Throw New NotImplementedException()
        End Function

        Public Function Tbonus(bonus As Double) As Object Implements ITunjangan.Tbonus
            Dim bonusT As Double
            If TypeName(Me) = "Sales" Then

                MyBase.TotalSalary = bonusT + BasicSalary
                MyBase.TotalSalary = bonusT

            End If
            Return bonusT
        End Function

        Public Function TCommision(commision As Double) As Object Implements ITunjangan.TCommision
            Dim BonusC As Double
            If TypeName(Me) = "Sales" Then

                MyBase.TotalSalary = BonusC + BasicSalary
                MyBase.TotalSalary = BonusC

            End If
            Return TotalSalary
        End Function

        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()},
            Role        : Sales,
            Tj Bonus    : {Bonus}
            Tj Commision: {Commision},
            Nett Salary : {Nett()},
            GrossSalary : {Gross()},
            TotalSalary : {TotalSalary}
                    "
        End Function
    End Class

End Namespace
