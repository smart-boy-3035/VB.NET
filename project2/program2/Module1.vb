Imports System

Module Module1
    Dim x As String
    ' x is variable of type module
    Sub Main()
        Dim y As Integer
        ' y is local variable
        x = "Smart Boy"
        y = 3035
        Console.WriteLine(x)
        Console.WriteLine("value of y: " & y)
        Console.ReadKey()
        myproc()
        Dim result As String
        result = myfunction()
        Console.WriteLine(result)

    End Sub
    Sub myproc()
        x = "Shubham Singh Rajput"
        Console.WriteLine("My Name is: " & x)
    End Sub
    Function myfunction() As String
        x = "VB.NET"
        myfunction = x
        Console.ReadKey()
    End Function
End Module
