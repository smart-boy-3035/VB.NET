Module Module1

    Sub Main()
        Dim n As Integer
        Console.WriteLine("Enter any number in a weak: ")
        n = Convert.ToInt16(Console.ReadLine())
        If n = 1 Then
            Console.WriteLine("Monday")
        ElseIf n = 2 Then
            Console.WriteLine("Tueday")
        ElseIf n = 3 Then
            Console.WriteLine("Wednesday")
        ElseIf n = 4 Then
            Console.WriteLine("Thrusday")
        ElseIf n = 5 Then
            Console.WriteLine("Friday")
        ElseIf n = 6 Then
            Console.WriteLine("Saturday")
        ElseIf n = 7 Then
            Console.WriteLine("Sunday")
        Else
            Console.WriteLine("Wrong Enter please try again")
            Console.ReadKey()

        End If
        greatest()
    End Sub
    Sub greatest()
        Dim a, b, c, d As Integer
        Console.WriteLine("Enter any number : ")
        a = Convert.ToInt16(Console.ReadLine())

        Console.WriteLine("Enter any number : ")
        b = Convert.ToInt16(Console.ReadLine())

        Console.WriteLine("Enter any number : ")
        c = Convert.ToInt16(Console.ReadLine())

        Console.WriteLine("Enter any number : ")
        d = Convert.ToInt16(Console.ReadLine())

        If a > b And a > c And a > d Then
            Console.WriteLine(a & " is greatest")

        ElseIf b > a And b > c And b > d Then
            Console.WriteLine(b & " is greatest")

        ElseIf c > a And c > b And c > d Then
            Console.WriteLine(c & " is greatest")
        Else
            Console.WriteLine(d & " is greatest")
            Console.ReadKey()


        End If
        smallest()
    End Sub
    Sub smallest()
        Dim a, b, c, d As Integer
        Console.WriteLine("Enter any number : ")
        a = Convert.ToInt16(Console.ReadLine())

        Console.WriteLine("Enter any number : ")
        b = Convert.ToInt16(Console.ReadLine())

        Console.WriteLine("Enter any number : ")
        c = Convert.ToInt16(Console.ReadLine())

        Console.WriteLine("Enter any number : ")
        d = Convert.ToInt16(Console.ReadLine())

        If a < b And a < c And a < d Then
            Console.WriteLine(a & " is smallest")

        ElseIf b < a And b < c And b < d Then
            Console.WriteLine(b & " is smallest")

        ElseIf c < a And c < b And c < d Then
            Console.WriteLine(c & " is smallest")
        Else
            Console.WriteLine(d & " is smallest")
            Console.ReadKey()


        End If



    End Sub
End Module
