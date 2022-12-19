Module ModuleDateTime
    Sub ShowDate()
        Dim date1 As Date = #12/15/2022 10:53:01 AM#
        Console.WriteLine("Date1 : " & date1)

        Dim currentdate As Date = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        Console.WriteLine("Sekarang : " & currentdate)
        currentdate = currentdate.AddDays(2)
        Console.WriteLine("lusa : " & currentdate)

        Dim hari, bulan, tahun As Integer
        hari = Day(currentdate)
        bulan = Month(currentdate)
        tahun = Year(currentdate)

        Console.WriteLine("Hari : " & hari & vbCrLf & "Bulan : " & bulan & vbCrLf & "Tahun : " & tahun)
    End Sub

End Module
