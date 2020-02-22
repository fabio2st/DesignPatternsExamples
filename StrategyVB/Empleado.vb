Public Class Empleado
    Public Sub New(nombre As String, pagoBehavior As PagoBehavior)
        Me.Nombre = nombre
        Me.PagoBehavior = pagoBehavior
    End Sub
    Property Nombre As String
    Property PagoBehavior As PagoBehavior
    Public Function CalcularPago() As Decimal
        Return PagoBehavior.Calcular()
    End Function
End Class