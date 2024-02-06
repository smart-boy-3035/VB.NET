Module Module1

    Sub Main()
        Dim height, base As Single
        ' Const pi As Single = 3.14
        Dim area As Single
        Console.Write("Enter height of a triangle: ")
        height = convert.ToSingle(Console.ReadLine())
        Console.Write("Enter base of a triangle: ")
        base = convert.ToSingle(Console.ReadLine())


        area = 0.5 * (height * base)

        Console.WriteLine("Area of triangle: " & area)
        Console.ReadKey()
        SimpleIntrest()
    End Sub
    Sub SimpleIntrest()

        Dim principal, time, rate As Single

        Dim SimpleIntrest As Single
        Console.Write("Enter principal Amount: ")
        principal = convert.ToSingle(Console.ReadLine())
        Console.Write("Enter time: ")
        time = convert.ToSingle(Console.ReadLine())
        Console.Write("Enter Rate of Intrest: ")
        rate = convert.ToSingle(Console.ReadLine())

        SimpleIntrest = (principal * time * rate) / 100

        Console.WriteLine("Simple Intrest : " & SimpleIntrest)
        Console.ReadKey()


    End Sub

End Module
