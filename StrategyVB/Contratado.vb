Public Class Contratado
    Implements PagoBehavior
    Public Sub New(horasTrabajadas As UShort, montoHora As Decimal)
        Me.HorasTrabajadas = horasTrabajadas
        Me.MontoHora = montoHora
    End Sub
    Public Property HorasTrabajadas As UShort
    Public Property MontoHora As Decimal
    Public Function Calcular() As Decimal Implements PagoBehavior.Calcular
        Return HorasTrabajadas * MontoHora
    End Function
End Class