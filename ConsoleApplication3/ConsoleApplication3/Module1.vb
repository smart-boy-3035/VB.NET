Module Module1

    Sub Main()
        Dim num As Integer
        Console.WriteLine("Enter a numbers: ")
        num = Convert.ToInt32(Console.ReadLine())
        prime(num)
    End Sub
    Function prime(ByVal n As Integer) As Integer
        Dim c As Integer = 0
        Dim i As Short
        Console.WriteLine("Value of n: " & n)
        For i = 1 To n Step 1
            If n Mod i = 0 Then
                c = c + 1
            End If

        Next
        If c = 2 Then
            Console.WriteLine("Prime Number")
        Else
            Console.WriteLine(" Not Prime Number")
        End If

        ' Return (c)
        Console.ReadKey()
       
    End Function
End Module
