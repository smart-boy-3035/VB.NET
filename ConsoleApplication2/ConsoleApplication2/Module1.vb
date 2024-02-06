Module Module1

    Sub Main()
        Exchange()
    End Sub
    Function Exchange()
        Dim a, b, t As Integer
        Console.WriteLine("Enter any two numbers: ")
        a = Convert.ToInt32(Console.ReadLine())
        b = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Value of a : " & a)
        Console.WriteLine("Value of b : " & b)
        t = a
        a = b
        b = t
        Console.WriteLine("Exachange value of a : " & a)
        Console.WriteLine("Exachange value of b : " & b)
        Console.ReadKey()
    End Function
End Module
