Imports System
Module Module1

    Sub Main()
        Dim radious As Single 'floating point data
        Const pi As Single = 3.14 'constant decalaration
        Dim area As Single
        Console.WriteLine("Enter radious of circle : ")
        radious = Convert.ToSingle(Console.ReadLine())
        area = pi * (radious ^ 2)
        Console.WriteLine("Radious of circle: " & radious)
        Console.WriteLine("Area of circle: " & area)

        Console.ReadKey()

    End Sub

End Module
