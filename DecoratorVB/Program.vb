Imports System

Module Program
    Sub Main(args As String())
        Dim voucher1 As Voucher
        voucher1 = New HabitacionPorHoras("Habitacion simple", 300, Date.Now, Date.Now.AddMinutes(90))
        Console.WriteLine(voucher1.Nombre & " $" & voucher1.CalcularPrecio)
        voucher1 = New Adicional(voucher1, "Sabana", 50, 2)
        Console.WriteLine(voucher1.Nombre & " $" & voucher1.CalcularPrecio)
        voucher1 = New Servicio(voucher1, "Internet", 100)
        Console.WriteLine(voucher1.Nombre & " $" & voucher1.CalcularPrecio)
    End Sub
End Module
