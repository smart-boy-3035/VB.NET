Module Module1

    Sub Main()
        Dim radious, height As Integer
        Dim pi As Single = 3.14
        Dim volume As Integer

        Console.WriteLine("Enter radious of a cylinder: ")
        radious = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter height of a cylinder: ")
        height = Convert.ToInt32(Console.ReadLine())

        volume = pi * radious * radious * height

        Console.WriteLine(" radious of a cylinder: " & radious)
        Console.WriteLine(" height of a cylinder: " & height)
        Console.WriteLine("Volume of a cylinder: " & volume)

        Console.ReadKey()


        squ()
    End Sub
    Sub squ()
        Dim side As Integer
        Dim area, perimeter As Integer
        Console.Write("Enter a side of a square: ")
        side = Convert.ToInt32(Console.ReadLine())

        perimeter = 4 * side
        area = side * side
        Console.WriteLine("Side of a square is: " & side)
        Console.WriteLine("Perimeter of a square is: " & perimeter)
        Console.WriteLine("Area of a square is: " & area)
        Console.ReadKey()

        rect()
    End Sub
    Sub rect()
        Dim length, breath As Integer
        Dim area As Integer
        Console.Write("Enter length of a rectangle: ")
        length = Convert.ToInt32(Console.ReadLine())
        Console.Write("Enter breath of a rectangle: ")
        breath = Convert.ToInt32(Console.ReadLine())
        If length And breath > 0 Then
            area = length * breath
            Console.WriteLine("Length of a rectangle is: " & length)
            Console.WriteLine("Breath of a rectangle is: " & breath)
            Console.WriteLine("Area of a rectangle is: " & area)
        End If
        Console.ReadKey()

    End Sub
End Module
