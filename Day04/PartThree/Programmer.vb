Namespace PartThree
    Public Class Programmer
        Inherits Employee
        Implements ITunjangan

        Private _transport As Double


        Public Sub New(firstName As String, lastName As String, joinDate As Date, basicSalary As Double, Optional transportasi As Double = Nothing)
            MyBase.New(firstName, lastName, joinDate, basicSalary)
            Transport = transportasi
            TotalSalary = basicSalary + transportasi

        End Sub

        Public Property Transport As Double
            Get
                Return _transport
            End Get
            Set(value As Double)
                _transport = value
                MyBase.TotalSalary = value + BasicSalary
            End Set
        End Property

        Public Overrides Property BasicSalary As Double
            Get
                Return MyBase.BasicSalary
            End Get
            Set(value As Double)
                MyBase.BasicSalary = value
                MyBase.TotalSalary = value + Transport
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

        Public Function Tbonus(bonus As Double) As Object Implements ITunjangan.Tbonus
            Throw New NotImplementedException()
        End Function

        Public Function TCommision(commision As Double) As Object Implements ITunjangan.TCommision
            Throw New NotImplementedException()
        End Function


        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()},
            Role        : Programmer,
            Tj Transport: {Transport}
            Nett Salary : {Nett()},
            GrossSalary : {Gross()},
            TotalSalary : {TotalSalary}
                    "
        End Function

        Private Function ITunjangan_TTransportasi(transportasi As Double) As Double Implements ITunjangan.TTransportasi
            Dim test As Integer
            If TypeName(Me) = "Programmer" Then

                MyBase.TotalSalary = test + BasicSalary
                MyBase.TotalSalary = test

            End If
            Return test
        End Function
    End Class


End Namespace