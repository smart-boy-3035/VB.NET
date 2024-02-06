Module Module1

    Sub Main()
        Dim n As Single
        Console.WriteLine("Enter a day number in a weak: ")
        n = Convert.ToInt32(Console.ReadLine())
        Select Case (n)
            Case 1
                Console.WriteLine("Sunday")

            Case 2
                Console.WriteLine("Monday")

            Case 3
                Console.WriteLine("Tuesday")

            Case 4
                Console.WriteLine("Wednesday")

            Case 5
                Console.WriteLine("Thursday")

            Case 6
                Console.WriteLine("Friday")

            Case 7
                Console.WriteLine("Satuarday")

            Case Else
                Console.WriteLine("You entered a wrong number")


        End Select
        Console.ReadKey()
        year()
    End Sub
    Sub year()
        Dim n As Single
        Console.WriteLine("Enter a year number in a year: ")
        n = Convert.ToInt32(Console.ReadLine())
        Select Case (n)
            Case 1
                Console.WriteLine("January")

            Case 2
                Console.WriteLine("February")

            Case 3
                Console.WriteLine("March")

            Case 4
                Console.WriteLine("April")

            Case 5
                Console.WriteLine("May")

            Case 6
                Console.WriteLine("June")

            Case 7
                Console.WriteLine("July")

            Case 8
                Console.WriteLine("August")

            Case 9
                Console.WriteLine("September")

            Case 10
                Console.WriteLine("October")

            Case 11
                Console.WriteLine("November")

            Case 12
                Console.WriteLine("December")


            Case Else
                Console.WriteLine("You entered a wrong number")


        End Select
        Console.ReadKey()
        Add()
    End Sub

    Sub Add()





        Dim num1, num2 As Double
        Dim operation As Char

        Console.WriteLine("Enter the first number: ")
        num1 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Enter the second number: ")
        num2 = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Menu:")
        Console.WriteLine("1. Add")
        Console.WriteLine("2. Subtract")
        Console.WriteLine("3. Multiply")
        Console.WriteLine("4. Divide")
        Console.WriteLine("Enter your choice : ")
        operation = Convert.ToChar(Console.ReadLine())

        Select Case operation
            Case "1"c
                Console.WriteLine("Result: " & (num1 + num2))
            Case "2"c
                Console.WriteLine("Result: " & (num1 - num2))
            Case "3"c
                Console.WriteLine("Result: " & (num1 * num2))
            Case "4"c
                If num2 <> 0 Then
                    Console.WriteLine("Result: " & (num1 / num2))
                Else
                    Console.WriteLine("Cannot divide by zero.")
                End If
            Case Else
                Console.WriteLine("Invalid input.")
        End Select

        Console.ReadLine()
        Console.ReadKey()
        student()
    End Sub
    Sub student()

        Dim n As Single
        Console.WriteLine("Enter Roll number of class: ")
        n = Convert.ToInt32(Console.ReadLine())
        Select Case (n)
            Case 1
                Console.WriteLine("Shubham Singh")

            Case 2
                Console.WriteLine("Shivam Singh")

            Case 3
                Console.WriteLine("Durgesh Singh")

            Case 4
                Console.WriteLine("Ankit singh")

            Case 5
                Console.WriteLine("Aman Kumar")

            Case 6
                Console.WriteLine("Bhaw Priya Bhavna")

            Case 7
                Console.WriteLine("Rahul Kumar")

            Case Else
                Console.WriteLine("You entered a Invalid Roll number")


        End Select
        Console.ReadKey()

    End Sub
End Module
