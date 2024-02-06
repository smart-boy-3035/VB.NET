Module Module1

    Sub Main()
        Dim n As Integer
        Dim i As Short
        Console.Write("Enter a number: ")
        n = Console.ReadLine()
        For i = 1 To 10 Step 1
            Console.WriteLine(n * i)
        Next
        Console.ReadKey()

    End Sub

End Module
