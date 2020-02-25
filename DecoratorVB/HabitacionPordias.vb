Public Class HabitacionPordias
    Inherits Voucher
    Property CostoDia As Decimal
    Property DiaEntrada As Date
    Property DiaSalida As Date
    Public Sub New(nombre As String, costoDia As Decimal, diaEntrada As Date, diaSalida As Date)
        Me.Nombre = nombre
        Me.CostoDia = costoDia
        Me.DiaEntrada = diaEntrada
        Me.DiaSalida = diaSalida
    End Sub
    Public Overrides Function CalcularPrecio() As Decimal
        Return DiaSalida.Subtract(DiaEntrada).Days * CostoDia
    End Function
End Class