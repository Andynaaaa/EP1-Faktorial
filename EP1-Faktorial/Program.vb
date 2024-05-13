Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim soucet As Integer = 0
        Do
            Console.Write("Zadej číslo: ")
            cislo = Console.ReadLine
            If cislo <= 0 Then
                Console.Write("Chybný vstup. Zadejte prosím celé číslo.")
                End
            End If

            If cislo > 10 Then
                Console.Write("Zadali jste hodnotu vyšší než 10. Prosím zadejte nižší hodnotu.")
                End
            End If

            If cislo = 1 > 0 Then
                Console.Write("Záporné hodnoty nejsou povoleny. Zadejte prosím kladné celé číslo.")
                End
            End If
        Loop

        For i = 1 To cislo
            soucet = soucet + i
        Next

            Console.WriteLine($"Součet od 1 do {cislo} je {soucet}")

    End Sub
End Module