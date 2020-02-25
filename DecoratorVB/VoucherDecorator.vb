Public MustInherit Class VoucherDecorator
    Inherits Voucher
    Public Property Habitacion As Voucher
    Protected _nombre As String
    Public Overrides Property Nombre() As String
        Get
            Return Habitacion.Nombre & ", " & _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Protected Sub New(habitacion As Voucher, nombre As String)
        Me.Habitacion = habitacion
        Me.Nombre = nombre
    End Sub
End Class
