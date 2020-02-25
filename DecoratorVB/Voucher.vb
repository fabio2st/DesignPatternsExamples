Public MustInherit Class Voucher
    Overridable Property Nombre As String
    MustOverride Function CalcularPrecio() As Decimal
End Class
