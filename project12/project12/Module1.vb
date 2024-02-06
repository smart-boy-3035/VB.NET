Module Module1

    Sub Main()

        Dim name As String
        Dim mobnum As Long
        Dim id, tnc As Integer
        Dim MOBbill As Double

        Console.Write("Enter your name: ")
        name = Console.ReadLine()
        Console.Write("Enter your Mobile Number: ")
        mobnum = Console.ReadLine()
        Console.Write("Enter your id: ")
        id = Convert.ToInt32(Console.ReadLine())
        Console.Write("Enter your total Number of calls in a month: ")
        tnc = Convert.ToInt32(Console.ReadLine())
        If tnc <= 50 Then
            MOBbill = 0.0
        ElseIf tnc <= 150 Then
            MOBbill = (tnc - 50) * 0.5
        ElseIf tnc <= 250 Then
            MOBbill = 50 * 0.5 + (tnc - 150) * 1.0
        Else
            MOBbill = 50 * 0.5 + 100 * 1.0 + (tnc - 250) * 1.5
        End If
        Console.WriteLine("Your Name is : " & name)
        Console.WriteLine("Your Mobile Number is: " & mobnum)
        Console.WriteLine("Your ID is : " & id)
        Console.WriteLine("Your total Number of calls in a month is: " & tnc)
        Console.WriteLine("Your total Number of calls bill in a month is Rs: " & MOBbill)
        Console.ReadKey()

    End Sub

End Module
