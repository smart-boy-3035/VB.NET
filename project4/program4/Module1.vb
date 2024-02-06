Imports System
Module Module1

    Sub Main()
        Dim length, breath As Single
        Dim area, perimeter As Single
        Console.Write("Enter length of a rectangle: ")
        length = Convert.ToSingle(Console.ReadLine())
        Console.Write("Enter breath of a rectangle: ")
        breath = Convert.ToSingle(Console.ReadLine())
        perimeter = 2 * (length + breath)
        area = length * breath
        Console.WriteLine("Perimeter of rectangle: " & perimeter)
        Console.WriteLine("Area of rectangle: " & area)
        Console.ReadKey()
        swap()


    End Sub
    Sub swap()
        Dim frist, second, c As Single
        Console.Write("Enter frist number: ")
        frist = Convert.ToSingle(Console.ReadLine())
        Console.Write("Enter second number: ")
        second = Convert.ToSingle(Console.ReadLine())
        c = frist
        frist = second
        second = c

        Console.WriteLine("Frist Number is: " & frist)
        Console.WriteLine("Second Number is: " & second)
        Console.ReadKey()

    End Sub


End Module
