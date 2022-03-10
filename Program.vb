Imports System

Module Program
    ' lavoro di Fatelli, Foti, Danut, Viery
    Sub Main(args As String())
        Randomize()
        'variabili
        Dim giocatore As String
        Dim Ngiocatore As String
        Dim congame As Char
        Dim computer As String
        Dim MyValue As Integer

        Console.WriteLine("inserisci il nome giocatore")
        Ngiocatore = Console.ReadLine()
        'Il DO che finisce con LOOP fa continuare il programma fino alla sua chiusura
        Do
            Console.WriteLine("Scegli carta,forbice,sasso")
            giocatore = Console.ReadLine()
            'controlla che tu abbia scritto corretto
            If "carta" = giocatore Then
            Else
                If "forbice" = giocatore Then
                Else
                    If "sasso" = giocatore Then
                    Else
                        Console.WriteLine("babbo\a! ,hai scritto una cavolata")
                        Console.WriteLine("Scegli carta,forbice o sasso")
                        giocatore = Console.ReadLine
                        If "carta" = giocatore Then
                        Else
                            If "forbice" = giocatore Then
                            Else
                                If "sasso" = giocatore Then
                                Else End
                                End If
                            End If
                        End If
                    End If
                End If

            End If
            'decisione computer 
            MyValue = Int((3 * Rnd()) + 1)
            If 1 = MyValue Then
                computer = "sasso"
            Else
                If 2 = MyValue Then
                    computer = "carta"
                Else
                    computer = "forbice"
                End If
            End If
            Console.WriteLine("scelta computer " & computer)
            'fine della scelta
            Console.WriteLine(Ngiocatore & Space(1) & "hai")

            'inizio regole del gioco 
            If 1 = MyValue Then
                If giocatore = "carta" Then
                    Console.WriteLine("vinto")
                ElseIf giocatore = "sasso" Then
                    Console.WriteLine("pareggiato")
                Else
                    Console.WriteLine("perso")

                End If
            Else
                If 2 = MyValue Then
                    If "carta" = giocatore Then
                        Console.WriteLine("pareggiato")
                    ElseIf "forbice" = giocatore Then
                        Console.WriteLine("vinto")
                    Else
                        Console.WriteLine("perso")

                    End If
                End If
                If 3 = MyValue Then
                    If "sasso" = giocatore Then
                        Console.WriteLine("vinto")
                    Else
                        If "forbice" = giocatore Then
                            Console.WriteLine("pareggiato")
                        Else
                            Console.WriteLine("perso")

                        End If
                    End If
                End If
            End If

            'fine regole del gioco
            Console.WriteLine("Vuoi fare un altra partita? (s/n)")
        congame = Console.ReadLine
        If "n" = congame Then
            End
        Else
            If "s" = congame Then

            Else
                Console.WriteLine("Devi scrivere (s/n)!")
                Console.WriteLine("Vuoi fare un altra partita? (s/n)")
                congame = Console.ReadLine
                If "n" = congame Then
                    End
                Else
                    If "s" = congame Then
                    Else
                        Console.WriteLine("non sai leggere!? Addio!")
                        End
                    End If
                End If
            End If
        End If
        Loop

    End Sub
End Module
