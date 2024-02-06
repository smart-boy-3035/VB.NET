Module Module1

    Sub Main()
        Dim n, t As Integer
        Dim i As Short
        Console.WriteLine("Enter any one number: ")
        n = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Table of your number is" & n)
        For i = 1 To 10 Step 1
            t = n * i
            Console.WriteLine(t)
        Next

        Console.ReadKey()
        prime()
    End Sub
    Sub prime()
        Dim n, s As Integer
        Dim i As Short
        Console.WriteLine("Enter any one number: ")
        n = Convert.ToInt32(Console.ReadLine())
        For i = 1 To n Step 1
            If n Mod i = 0 Then
                s = s + 1
            End If
        Next
        If s = 2 Then
            Console.WriteLine(" your number is Prime Number")
        Else
            Console.WriteLine("your number is not Prime Number")
        End If
        Console.ReadKey()
        factors()
    End Sub
    Sub factors()
        Dim n As Integer
        Dim i As Short
        Console.WriteLine("Enter any one number: ")
        n = Convert.ToInt32(Console.ReadLine())
        For i = 1 To n Step 1
            If n Mod i = 0 Then
                Console.WriteLine(i)
            End If
        Next
        Console.ReadKey()
        sum()
    End Sub
    Sub sum()
        Dim n As Integer
        Dim sum As Integer = 0
        Dim i As Short
        Console.WriteLine("Enter any one number: ")
        n = Convert.ToInt32(Console.ReadLine())
        For i = 1 To n Step 1
            If n Mod i = 0 Then
                Console.WriteLine(i)
                sum = sum + i
            End If
        Next
        Console.WriteLine("Sum of factors is: " & sum)
        Console.ReadKey()
        natural()
    End Sub
    Sub natural()
        Dim n As Integer
        Dim sum As Integer = 0
        Dim i As Short
        Console.WriteLine("Enter any one number: ")
        n = Convert.ToInt32(Console.ReadLine())
        For i = 1 To n Step 1
            If n Mod i = 0 Then
                sum = sum + i
            End If
        Next
        Console.WriteLine("Sum of  natural number is: " & sum)
        Console.ReadKey()
    End Sub
End Module
