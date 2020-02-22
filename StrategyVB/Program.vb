Imports System
Module Program
    Sub Main(args As String())
        Dim empleado As New Empleado("Pepe", New Administrativo(20000, 1500, 2500))
        Console.WriteLine(empleado.Nombre)
        Console.WriteLine(empleado.PagoBehavior)
        Console.WriteLine(empleado.CalcularPago())
        empleado.PagoBehavior = New Contratado(20, 600)
        Console.WriteLine(empleado.PagoBehavior)
        Console.WriteLine(empleado.CalcularPago())
        empleado.PagoBehavior = New Vendedor(5, 200000)
        Console.WriteLine(empleado.PagoBehavior)
        Console.WriteLine(empleado.CalcularPago())
    End Sub
End Module
