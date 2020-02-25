Public Class Adicional
    Inherits VoucherDecorator
    Public Overrides Property Nombre() As String
        Get
            Return Habitacion.Nombre & ", " & Cantidad & " " & _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Property PrecioUnitario As Decimal
    Property Cantidad As UShort
    Public Sub New(habitacion As Voucher, nombre As String, precioUnitario As Decimal, cantidad As UShort)
        MyBase.New(habitacion, nombre)
        Me.PrecioUnitario = precioUnitario
        Me.Cantidad = cantidad
    End Sub
    Public Overrides Function CalcularPrecio() As Decimal
        Return (PrecioUnitario * Cantidad) + Habitacion.CalcularPrecio()
    End Function
End Class
