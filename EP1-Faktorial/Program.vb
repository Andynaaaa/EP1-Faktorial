Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim soucet As Integer = 0

        Console.Write("Zadej èíslo: ")
        cislo = Console.ReadLine
        If cislo <= 0 Then
            Console.Write("chyba vstupu")
            End
        End If

        If cislo > 10 Then
            Console.Write("zadej menší číslo")
            End
        End If







        For i = 1 To cislo
            soucet = soucet + i
        Next

        Console.WriteLine($"Souèet od 1 do {cislo} je {soucet}")

    End Sub
End Module