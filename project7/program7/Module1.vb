Module Module1

    Sub Main()
        Dim x As Integer
        Console.WriteLine("Enter any  number: ")
        x = Convert.ToInt32(Console.ReadLine())
        If x Mod 2 = 0 Then
            Console.WriteLine(x & " is even number")
        Else
            Console.WriteLine(x & " is odd number")
            Console.ReadKey()
        End If
        check()
    End Sub
    Sub check()
        Dim x As Integer
        Console.WriteLine("Enter any  number: ")
        x = Convert.ToInt32(Console.ReadLine())
        If x > 0 Then
            Console.WriteLine(x & " is positive number")
        Else
            Console.WriteLine(x & " is negetive number")
            Console.ReadKey()
        End If
    End Sub

End Module
