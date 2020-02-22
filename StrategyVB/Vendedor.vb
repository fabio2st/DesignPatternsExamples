Public Class Vendedor
    Implements PagoBehavior
    Public Sub New(porcentajeComision As Decimal, totalVenta As Decimal)
        Me.PorcentajeComision = porcentajeComision
        Me.TotalVenta = totalVenta
    End Sub
    Public Property PorcentajeComision As Decimal
    Public Property TotalVenta As Decimal
    Public Function Calcular() As Decimal Implements PagoBehavior.Calcular
        Return TotalVenta * PorcentajeComision / 100
    End Function
End Class