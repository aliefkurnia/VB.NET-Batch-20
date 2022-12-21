Namespace PartThree
    Public Class QA
        Inherits Employee
        Implements ITunjangan

        Private _makan As Double

        Public Sub New(firstName As String, lastName As String, joinDate As Date, basicSalary As Double, Optional TMakan As Double = Nothing)
            MyBase.New(firstName, lastName, joinDate, basicSalary)
            Makan = TMakan
            TotalSalary = basicSalary + TMakan

        End Sub

        Public Property Makan As Double
            Get
                Return _makan
            End Get
            Set(value As Double)
                _makan = value
                MyBase.TotalSalary = value + BasicSalary
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

        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()},
            Role        : QA,
            Tj Makan    : {Makan}
            Nett Salary : {Nett()},
            GrossSalary : {Gross()},
            TotalSalary : {TotalSalary}
                    "
        End Function

        Public Function Tmakan(makan As Double) As Object Implements ITunjangan.Tmakan
            Dim makanT As Integer
            If TypeName(Me) = "QA" Then

                MyBase.TotalSalary = makanT + BasicSalary
                MyBase.TotalSalary = makanT
            End If
            Return makanT
        End Function

        Public Function TTransportasi(transportasi As Double) As Double Implements ITunjangan.TTransportasi
            Throw New NotImplementedException()
        End Function

        Public Function Tbonus(bonus As Double) As Object Implements ITunjangan.Tbonus
            Throw New NotImplementedException()
        End Function

        Public Function TCommision(commision As Double) As Object Implements ITunjangan.TCommision
            Throw New NotImplementedException()
        End Function
    End Class


End Namespace
