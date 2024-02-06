Imports System
Module Module1

    Sub Main()
        Dim name, fathersname, mothersname As String
        Dim addres, qualification As String
        Dim mobilenumber As Long
        Console.Write("Enter your name:")
        name = Console.ReadLine()
        Console.Write("Enter fathers-name:")
        fathersname = Console.ReadLine()
        Console.Write("Enter mothers-name:")
        mothersname = Console.ReadLine()
        Console.Write("Enter your addres:")
        addres = Console.ReadLine()
        Console.Write("Enter your qualification:")
        qualification = Console.ReadLine()
        Console.Write("Enter your mobile-number:")
        mobilenumber = Console.ReadLine()
        Console.WriteLine("Name:" & name)
        Console.WriteLine("fathersname:" & fathersname)
        Console.WriteLine("mothersname:" & mothersname)
        Console.WriteLine("Addres:" & addres)
        Console.WriteLine("qualification:" & qualification)
        Console.WriteLine("mobilenumber:" & mobilenumber)
        Console.ReadKey()
    End Sub

End Module
