Public Class HabitacionPorHoras
    Inherits Voucher
    Property CostoHora As Decimal
    Property HoraEntrada As Date
    Property HoraSalida As Date
    Public Sub New(nombre As String, costoHora As Decimal, horaEntrada As Date, horaSalida As Date)
        Me.Nombre = nombre
        Me.HoraEntrada = horaEntrada
        Me.HoraSalida = horaSalida
        Me.CostoHora = costoHora
    End Sub
    Public Overrides Function CalcularPrecio() As Decimal
        ' ejemplo: 61 minutos son 2 horas
        Return Math.Ceiling(HoraSalida.Subtract(HoraEntrada).TotalHours) * CostoHora
    End Function
End Class
