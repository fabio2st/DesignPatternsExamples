Public Class Administrativo
    Implements PagoBehavior
    Public Sub New(sueldoMensual As Decimal, retenciones As Decimal, asignaciones As Decimal)
        Me.SueldoMensual = sueldoMensual
        Me.Retenciones = retenciones
        Me.Asignaciones = asignaciones
    End Sub
    Public Property SueldoMensual As Decimal
    Public Property Retenciones As Decimal
    Public Property Asignaciones As Decimal
    Public Function Calcular() As Decimal Implements PagoBehavior.Calcular
        Return SueldoMensual + Asignaciones - Retenciones
    End Function
End Class