Public Class Servicio
    Inherits VoucherDecorator
    Public Property Precio As Decimal
    Public Sub New(habitacion As Voucher, nombre As String, precio As Decimal)
        MyBase.New(habitacion, nombre)
        Me.Precio = precio
    End Sub

    Public Overrides Function CalcularPrecio() As Decimal
        Return Precio + Habitacion.CalcularPrecio()
    End Function
End Class
