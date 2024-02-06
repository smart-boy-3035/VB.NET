Module Module1

    Sub Main()
        Dim n As Single
        Console.WriteLine("Enter any four digits numbers: ")
        n = Convert.ToInt32(Console.ReadLine())
        If n Mod 4 = 0 Then
            Console.WriteLine(n & "is Leap year")
        Else
            Console.WriteLine(n & "is not Leap year")
            Console.ReadKey()


        End If

    End Sub


End Module
