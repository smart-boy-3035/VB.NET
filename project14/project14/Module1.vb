Module Module1

    Sub Main()
        Dim a, n, sum, t As Integer
        Console.WriteLine("Enter a number: ")
        n = Convert.ToInt32(Console.ReadLine())
        t = n
        sum = 0
        While n > 0
            a = n Mod 10
            sum = sum + a
            n = n \ 10

        End While
        Console.WriteLine("Your number is: " & n)
        Console.WriteLine("Sum of the  number is: " & sum)
        Console.ReadKey()

        factorial()
    End Sub
    Sub factorial()
        Dim a, n, fac, t As Integer
        Console.WriteLine("Enter a number: ")
        n = Convert.ToInt32(Console.ReadLine())
        t = n
        fac = 1
        While n > 0
            a = n Mod 10
            fac = fac * a
            n = n \ 10

        End While
        Console.WriteLine("Your number is: " & n)
        Console.WriteLine("Factorial of the  number is: " & fac)
        Console.ReadKey()
        armstrong()
    End Sub
    Sub armstrong()
        Dim a, n, arm, t As Integer
        Console.WriteLine("Enter a number: ")
        n = Convert.ToInt32(Console.ReadLine())
        t = n

        While n > 0
            a = n Mod 10
            arm = arm + a * a * a
            n = n \ 10

        End While
        Console.WriteLine("Your number is: " & n)
        If t = arm Then
            Console.WriteLine("It is Armstrong Number")
        Else
            Console.WriteLine("It is not Armstrong Number")
        End If
        Console.ReadKey()
    End Sub
End Module
