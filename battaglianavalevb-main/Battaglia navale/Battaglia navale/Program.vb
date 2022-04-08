Imports System

Module Program
    Sub Main(args As String())
        Randomize()
        'variabili
        Dim Ngiocatore As String
        Dim rules As Char
        Dim assex As Decimal
        Dim assey As Decimal
        Dim coordinate As String
        Dim freg1 As String
        Dim freg2 As String
        Dim freg3 As String
        Dim caccia2 As String
        Dim caccia1 As String
        Dim Sassex As Int32
        Dim Sassey As Int32
        Dim nave1C As String
        Dim nave2C As String
        Dim Gsparo As String
        Dim turno As Integer
        Dim perdite As Int16
        Dim incro As String
        Dim rulesr As String
        Dim acapo As String
        Dim nave3c As String
        Dim perditen As Int16
        Dim cont As Char

        'regole del gioco
        rulesr = "Benvenuto nel gioco di battaglia navale, ecco le regole! 
             1) Per inserire il colpo o le barche bisogna inserire le coordinate avete la tabella qua sotto (es A3, D5)
             2) Per vincere in battaglia navale bisogna cercare di distruggere le barche prima del tuo avversario
             3) Si hanno 5 barche a testa e si dividono in 3 fregate 2 cacciatorpedinieri e l'Incrociatore 
             4) siate buoni col programma che non è a prova di bomba "


        Console.WriteLine("Inserisci nome giocatore")
        Ngiocatore = Console.ReadLine
#Region ""
        If Ngiocatore = "Rentedcoast" Then
            Console.WriteLine("LODE AL SOLEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE")
        End If
#End Region

        Console.WriteLine("vuoi vedere le regole? (s/n)")
        rules = Console.ReadLine
        perdite = 0
        If rules = "n" Then
        Else
            If rules = "s" Then
                Console.WriteLine(rulesr)
            Else
                Console.WriteLine("scegli 's' o 'n'")
                rules = Console.ReadLine
                If rules = "n" Then
                Else
                    If rules = "f" Then
                        Console.WriteLine("ma?! strano che ci fai qui? mi sa che hai trovato un easteregg, gg, goditi questo video----> https://youtu.be/BBJa32lCaaY")
                        End
                    Else
                        If rules = "s" Then
                            Console.WriteLine(rulesr)
                        Else
                            End

                        End If
                    End If
                End If
            End If
        End If
        Do
            Console.WriteLine(" 
           +-----+---+---+---+---+---+---+---+---+
           |   1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |
           +-----+---+---+---+---+---+---+---+---+
           | A   |   |   |   |   |   |   |   |   |
           +-----+---+---+---+---+---+---+---+---+
           | B   |   |   |   |   |   |   |   |   |
           +-----+---+---+---+---+---+---+---+---+
           | C   |   |   |   |   |   |   |   |   |
           +-----+---+---+---+---+---+---+---+---+
           | D   |   |   |   |   |   |   |   |   |
           +-----+---+---+---+---+---+---+---+---+
           | E   |   |   |   |   |   |   |   |   |
           +-----+---+---+---+---+---+---+---+---+
           | F   |   |   |   |   |   |   |   |   |
           +-----+---+---+---+---+---+---+---+---+
           | G   |   |   |   |   |   |   |   |   |
           +-----+---+---+---+---+---+---+---+---+
           ")
            'tabella^
            'fase input

            Do
                Console.WriteLine("inserisci posizione della 1a fregata")

                freg1 = Console.ReadLine
                If freg1 = "a1" Or freg1 = "a2" Or freg1 = "a3" Or freg1 = "a4" Or freg1 = "a5" Or freg1 = "a6" Or freg1 = "a7" Or freg1 = "a8" Or freg1 = "a9" Then
                    Exit Do
                Else
                    If freg1 = "b1" Or freg1 = "b2" Or freg1 = "b3" Or freg1 = "b4" Or freg1 = "b5" Or freg1 = "b6" Or freg1 = "b7" Or freg1 = "b8" Or freg1 = "b9" Then
                        Exit Do
                    Else
                        If freg1 = "c1" Or freg1 = "c2" Or freg1 = "c3" Or freg1 = "c4" Or freg1 = "c5" Or freg1 = "c6" Or freg1 = "c7" Or freg1 = "c8" Or freg1 = "c9" Then
                            Exit Do
                        Else
                            If freg1 = "d1" Or freg1 = "d2" Or freg1 = "d3" Or freg1 = "d4" Or freg1 = "d5" Or freg1 = "d6" Or freg1 = "d7" Or freg1 = "d8" Or freg1 = "d9" Then
                                Exit Do
                            Else
                                If freg1 = "e1" Or freg1 = "e2" Or freg1 = "e3" Or freg1 = "e4" Or freg1 = "e5" Or freg1 = "e6" Or freg1 = "e7" Or freg1 = "e8" Or freg1 = "e9" Then
                                    Exit Do
                                Else
                                    If freg1 = "f1" Or freg1 = "f2" Or freg1 = "f3" Or freg1 = "f4" Or freg1 = "f5" Or freg1 = "f6" Or freg1 = "f7" Or freg1 = "f8" Or freg1 = "f9" Then
                                        Exit Do
                                    Else
                                        If freg1 = "g1" Or freg1 = "g2" Or freg1 = "g3" Or freg1 = "g4" Or freg1 = "g5" Or freg1 = "g6" Or freg1 = "g7" Or freg1 = "g8" Or freg1 = "g9" Then

                                            Exit Do
                                        Else
                                            Console.WriteLine("impossibile posizionare la 1a fregata")





                                        End If
                                    End If

                                End If
                            End If




                        End If
                    End If
                End If

            Loop




            freg1 = LCase(freg1)


            Do
                Console.WriteLine("inserisci posizione della 2a fregata")

                freg2 = Console.ReadLine

                If freg2 = "a1" Or freg2 = "a2" Or freg2 = "a3" Or freg2 = "a4" Or freg2 = "a5" Or freg2 = "a6" Or freg2 = "a7" Or freg2 = "a8" Or freg2 = "a9" Then
                    Exit Do
                Else
                    If freg2 = "b1" Or freg2 = "b2" Or freg2 = "b3" Or freg2 = "b4" Or freg2 = "b5" Or freg2 = "b6" Or freg2 = "b7" Or freg2 = "b8" Or freg2 = "b9" Then
                        Exit Do
                    Else
                        If freg2 = "c1" Or freg2 = "c2" Or freg2 = "c3" Or freg2 = "c4" Or freg2 = "c5" Or freg2 = "c6" Or freg2 = "c7" Or freg2 = "c8" Or freg2 = "c9" Then
                            Exit Do
                        Else
                            If freg2 = "d1" Or freg2 = "d2" Or freg2 = "d3" Or freg2 = "d4" Or freg2 = "d5" Or freg2 = "d6" Or freg2 = "d7" Or freg2 = "d8" Or freg2 = "d9" Then
                                Exit Do
                            Else
                                If freg2 = "e1" Or freg2 = "e2" Or freg2 = "e3" Or freg2 = "e4" Or freg2 = "e5" Or freg2 = "e6" Or freg2 = "e7" Or freg2 = "e8" Or freg2 = "e9" Then
                                    Exit Do
                                Else
                                    If freg2 = "f1" Or freg2 = "f2" Or freg2 = "f3" Or freg2 = "f4" Or freg2 = "f5" Or freg2 = "f6" Or freg2 = "f7" Or freg2 = "f8" Or freg2 = "f9" Then
                                        Exit Do
                                    Else
                                        If freg2 = "g1" Or freg2 = "g2" Or freg2 = "g3" Or freg2 = "g4" Or freg2 = "g5" Or freg2 = "g6" Or freg2 = "g7" Or freg2 = "g8" Or freg2 = "g9" Then

                                            Exit Do
                                        Else
                                            Console.WriteLine("impossibile posizionare la 2a fregata")





                                        End If
                                    End If

                                End If
                            End If




                        End If
                    End If
                End If

            Loop

            freg2 = LCase(freg2)

            Do
                Console.WriteLine("inserisci posizione della 3a fregata")
                freg3 = Console.ReadLine
                If freg3 = "a1" Or freg3 = "a2" Or freg3 = "a3" Or freg3 = "a4" Or freg3 = "a5" Or freg3 = "a6" Or freg3 = "a7" Or freg3 = "a8" Or freg3 = "a9" Then
                    Exit Do
                Else
                    If freg3 = "b1" Or freg3 = "b2" Or freg3 = "b3" Or freg3 = "b4" Or freg3 = "b5" Or freg3 = "b6" Or freg3 = "b7" Or freg3 = "b8" Or freg3 = "b9" Then
                        Exit Do
                    Else
                        If freg3 = "c1" Or freg3 = "c2" Or freg3 = "c3" Or freg3 = "c4" Or freg3 = "c5" Or freg3 = "c6" Or freg3 = "c7" Or freg3 = "c8" Or freg3 = "c9" Then
                            Exit Do
                        Else
                            If freg3 = "d1" Or freg3 = "d2" Or freg3 = "d3" Or freg3 = "d4" Or freg3 = "d5" Or freg3 = "d6" Or freg3 = "d7" Or freg3 = "d8" Or freg3 = "d9" Then
                                Exit Do
                            Else
                                If freg3 = "e1" Or freg3 = "e2" Or freg3 = "e3" Or freg3 = "e4" Or freg3 = "e5" Or freg3 = "e6" Or freg3 = "e7" Or freg3 = "e8" Or freg3 = "e9" Then
                                    Exit Do
                                Else
                                    If freg3 = "f1" Or freg3 = "f2" Or freg3 = "f3" Or freg3 = "f4" Or freg3 = "f5" Or freg3 = "f6" Or freg3 = "f7" Or freg3 = "f8" Or freg3 = "f9" Then
                                        Exit Do
                                    Else
                                        If freg3 = "g1" Or freg3 = "g2" Or freg3 = "g3" Or freg3 = "g4" Or freg3 = "g5" Or freg3 = "g6" Or freg3 = "g7" Or freg3 = "g8" Or freg3 = "g9" Then

                                            Exit Do
                                        Else
                                            Console.WriteLine("impossibile posizionare la 3a fregata")





                                        End If
                                    End If

                                End If
                            End If




                        End If
                    End If
                End If

            Loop
            freg3 = LCase(freg3)
            do
            Console.WriteLine("inserisci posizione del cacciotorpediniere")
                caccia1 = Console.ReadLine
                If caccia1 = "a1" Or caccia1 = "a2" Or caccia1 = "a3" Or caccia1 = "a4" Or caccia1 = "a5" Or caccia1 = "a6" Or caccia1 = "a7" Or caccia1 = "a8" Or caccia1 = "a9" Then
                    Exit Do
                Else
                    If caccia1 = "b1" Or caccia1 = "b2" Or caccia1 = "b3" Or caccia1 = "b4" Or caccia1 = "b5" Or caccia1 = "b6" Or caccia1 = "b7" Or caccia1 = "b8" Or caccia1 = "b9" Then
                        Exit Do
                    Else
                        If caccia1 = "c1" Or caccia1 = "c2" Or caccia1 = "c3" Or caccia1 = "c4" Or caccia1 = "c5" Or caccia1 = "c6" Or caccia1 = "c7" Or caccia1 = "c8" Or caccia1 = "c9" Then
                            Exit Do
                        Else
                            If caccia1 = "d1" Or caccia1 = "d2" Or caccia1 = "d3" Or caccia1 = "d4" Or caccia1 = "d5" Or caccia1 = "d6" Or caccia1 = "d7" Or caccia1 = "d8" Or caccia1 = "d9" Then
                                Exit Do
                            Else
                                If caccia1 = "e1" Or caccia1 = "e2" Or caccia1 = "e3" Or caccia1 = "e4" Or caccia1 = "e5" Or caccia1 = "e6" Or caccia1 = "e7" Or caccia1 = "e8" Or caccia1 = "e9" Then
                                    Exit Do
                                Else
                                    If caccia1 = "f1" Or caccia1 = "f2" Or caccia1 = "f3" Or caccia1 = "f4" Or caccia1 = "f5" Or caccia1 = "f6" Or caccia1 = "f7" Or caccia1 = "f8" Or caccia1 = "f9" Then
                                        Exit Do
                                    Else
                                        If caccia1 = "g1" Or caccia1 = "g2" Or caccia1 = "g3" Or caccia1 = "g4" Or caccia1 = "g5" Or caccia1 = "g6" Or caccia1 = "g7" Or caccia1 = "g8" Or caccia1 = "g9" Then

                                            Exit Do
                                        Else
                                            Console.WriteLine("impossibile posizionare la 1° caccia")





                                        End If
                                    End If

                                End If
                            End If




                        End If
                    End If
                End If

            Loop
            caccia1 = LCase(caccia1)
            Do
                Console.WriteLine("inserisci posizione del cacciotorpediniere di seconda classe")
                caccia2 = Console.ReadLine
                If caccia2 = "a1" Or caccia2 = "a2" Or caccia2 = "a3" Or caccia2 = "a4" Or caccia2 = "a5" Or caccia2 = "a6" Or caccia2 = "a7" Or caccia2 = "a8" Or caccia2 = "a9" Then
                    Exit Do
                Else
                    If caccia2 = "b1" Or caccia2 = "b2" Or caccia2 = "b3" Or caccia2 = "b4" Or caccia2 = "b5" Or caccia2 = "b6" Or caccia2 = "b7" Or caccia2 = "b8" Or caccia2 = "b9" Then
                        Exit Do
                    Else
                        If caccia2 = "c1" Or caccia2 = "c2" Or caccia2 = "c3" Or caccia2 = "c4" Or caccia2 = "c5" Or caccia2 = "c6" Or caccia2 = "c7" Or caccia2 = "c8" Or caccia2 = "c9" Then
                            Exit Do
                        Else
                            If caccia2 = "d1" Or caccia2 = "d2" Or caccia2 = "d3" Or caccia2 = "d4" Or caccia2 = "d5" Or caccia2 = "d6" Or caccia2 = "d7" Or caccia2 = "d8" Or caccia2 = "d9" Then
                                Exit Do
                            Else
                                If caccia2 = "e1" Or caccia2 = "e2" Or caccia2 = "e3" Or caccia2 = "e4" Or caccia2 = "e5" Or caccia2 = "e6" Or caccia2 = "e7" Or caccia2 = "e8" Or caccia2 = "e9" Then
                                    Exit Do
                                Else
                                    If caccia2 = "f1" Or caccia2 = "f2" Or caccia2 = "f3" Or caccia2 = "f4" Or caccia2 = "f5" Or caccia2 = "f6" Or caccia2 = "f7" Or caccia2 = "f8" Or caccia2 = "f9" Then
                                        Exit Do
                                    Else
                                        If caccia2 = "g1" Or caccia2 = "g2" Or caccia2 = "g3" Or caccia2 = "g4" Or caccia2 = "g5" Or caccia2 = "g6" Or caccia2 = "g7" Or caccia2 = "g8" Or caccia2 = "g9" Then

                                            Exit Do
                                        Else
                                            Console.WriteLine("impossibile posizionare la 2° caccia")





                                        End If
                                    End If

                                End If
                            End If




                        End If
                    End If
                End If

            Loop

            caccia2 = LCase(caccia2)
            Do
                Console.WriteLine("inserisci l'incrociatore d'alto mare")
                incro = Console.ReadLine
                If incro = "a1" Or incro = "a2" Or incro = "a3" Or incro = "a4" Or incro = "a5" Or incro = "a6" Or incro = "a7" Or incro = "a8" Or incro = "a9" Then
                    Exit Do
                Else
                    If incro = "b1" Or incro = "b2" Or incro = "b3" Or incro = "b4" Or incro = "b5" Or incro = "b6" Or incro = "b7" Or incro = "b8" Or incro = "b9" Then
                        Exit Do
                    Else
                        If incro = "c1" Or incro = "c2" Or incro = "c3" Or incro = "c4" Or incro = "c5" Or incro = "c6" Or incro = "c7" Or incro = "c8" Or incro = "c9" Then
                            Exit Do
                        Else
                            If incro = "d1" Or incro = "d2" Or incro = "d3" Or incro = "d4" Or incro = "d5" Or incro = "d6" Or incro = "d7" Or incro = "d8" Or incro = "d9" Then
                                Exit Do
                            Else
                                If incro = "e1" Or incro = "e2" Or incro = "e3" Or incro = "e4" Or incro = "e5" Or incro = "e6" Or incro = "e7" Or incro = "e8" Or incro = "e9" Then
                                    Exit Do
                                Else
                                    If incro = "f1" Or incro = "f2" Or incro = "f3" Or incro = "f4" Or incro = "f5" Or incro = "f6" Or incro = "f7" Or incro = "f8" Or incro = "f9" Then
                                        Exit Do
                                    Else
                                        If incro = "g1" Or incro = "g2" Or incro = "g3" Or incro = "g4" Or incro = "g5" Or incro = "g6" Or incro = "g7" Or incro = "g8" Or incro = "g9" Then

                                            Exit Do
                                        Else
                                            Console.WriteLine("impossibile posizionare l'incrociatore")





                                        End If
                                    End If

                                End If
                            End If




                        End If
                    End If
                End If

            Loop
            incro = LCase(incro)
                'posizione barca computer (già solo UNA barca...) 
                Do
                    Sassex = Int((9 * Rnd()) + 1)
                    Sassey = Int((7 * Rnd()) + 1)
                    If Sassey = "1" Then
                        If Sassex = "1" Then
                            nave1C = "A1"
                        Else
                            If Sassex = "2" Then
                                nave1C = "A2"
                            Else
                                If Sassex = "3" Then
                                    nave1C = "A3"
                                Else
                                    If Sassex = "4" Then
                                        nave1C = "A4"
                                    Else
                                        If Sassex = "5" Then
                                            nave1C = "A5"
                                        Else
                                            If Sassex = "6" Then
                                                nave1C = "A6"
                                            Else

                                                If Sassex = "7" Then
                                                    nave1C = "A7"
                                                Else

                                                    If assex = "8" Then
                                                        nave1C = "A8"
                                                    Else
                                                        nave1C = "A9"


                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If

                            End If

                        End If
                    Else
                        If Sassey = "2" Then
                            If Sassex = "1" Then
                                nave1C = "B1"
                            Else
                                If Sassex = "2" Then
                                    nave1C = "B2"
                                Else
                                    If Sassex = "3" Then
                                        nave1C = "B3"
                                    Else
                                        If Sassex = "4" Then
                                            nave1C = "B4"
                                        Else
                                            If Sassex = "5" Then
                                                nave1C = "B5"
                                            Else
                                                If Sassex = "6" Then
                                                    nave1C = "B6"
                                                Else

                                                    If Sassex = "7" Then
                                                        nave1C = "B7"
                                                    Else

                                                        If assex = "8" Then
                                                            nave1C = "B8"
                                                        Else
                                                            nave1C = "B9"

                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        Else
                            If Sassey = "3" Then
                                If Sassex = "1" Then
                                    nave1C = "C1"
                                Else
                                    If Sassex = "2" Then
                                        nave1C = "C2"
                                    Else
                                        If Sassex = "3" Then
                                            nave1C = "C3"
                                        Else
                                            If Sassex = "4" Then
                                                nave1C = "C4"
                                            Else
                                                If Sassex = "5" Then
                                                    nave1C = "C5"
                                                Else
                                                    If Sassex = "6" Then
                                                        nave1C = "C6"
                                                    Else

                                                        If Sassex = "7" Then
                                                            nave1C = "C7"
                                                        Else

                                                            If assex = "8" Then
                                                                nave1C = "C8"
                                                            Else
                                                                nave1C = "C9"
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            Else
                                If Sassey = "4" Then
                                    If Sassex = "1" Then
                                        nave1C = "D1"
                                    Else
                                        If Sassex = "2" Then
                                            nave1C = "D2"
                                        Else
                                            If Sassex = "3" Then
                                                nave1C = "D3"
                                            Else
                                                If Sassex = "4" Then
                                                    nave1C = "D4"
                                                Else
                                                    If Sassex = "5" Then
                                                        nave1C = "D5"
                                                    Else
                                                        If Sassex = "6" Then
                                                            nave1C = "D6"
                                                        Else

                                                            If Sassex = "7" Then
                                                                nave1C = "D7"
                                                            Else

                                                                If assex = "8" Then
                                                                    nave1C = "D8"
                                                                Else
                                                                    nave1C = "D9"

                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                Else
                                    If Sassey = "5" Then
                                        If Sassex = "1" Then
                                            nave1C = "E1"
                                        Else
                                            If Sassex = "2" Then
                                                nave1C = "E2"
                                            Else
                                                If Sassex = "3" Then
                                                    nave1C = "E3"
                                                Else
                                                    If Sassex = "4" Then
                                                        nave1C = "E4"
                                                    Else
                                                        If Sassex = "5" Then
                                                            nave1C = "E5"
                                                        Else
                                                            If Sassex = "6" Then
                                                                nave1C = "E6"
                                                            Else

                                                                If Sassex = "7" Then
                                                                    nave1C = "E7"
                                                                Else

                                                                    If assex = "8" Then
                                                                        nave1C = "E8"
                                                                    Else
                                                                        nave1C = "E9"
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    Else
                                        If Sassey = "6" Then
                                            If Sassex = "1" Then
                                                nave1C = "F1"
                                            Else
                                                If Sassex = "2" Then
                                                    nave1C = "F2"
                                                Else
                                                    If Sassex = "3" Then
                                                        nave1C = "F3"
                                                    Else
                                                        If Sassex = "4" Then
                                                            nave1C = "F4"
                                                        Else
                                                            If Sassex = "5" Then
                                                                nave1C = "F5"
                                                            Else
                                                                If Sassex = "6" Then
                                                                    nave1C = "F6"
                                                                Else

                                                                    If Sassex = "7" Then
                                                                        nave1C = "F7"
                                                                    Else

                                                                        If assex = "8" Then
                                                                            nave1C = "F8"
                                                                        Else
                                                                            nave1C = "F9"

                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        Else
                                            If Sassey = "7" Then
                                                If Sassex = "1" Then
                                                    nave1C = "G1"
                                                Else
                                                    If Sassex = "2" Then
                                                        nave1C = "G2"
                                                    Else
                                                        If Sassex = "3" Then
                                                            nave1C = "G3"
                                                        Else
                                                            If Sassex = "4" Then
                                                                nave1C = "G4"
                                                            Else
                                                                If Sassex = "5" Then
                                                                    nave1C = "G5"
                                                                Else
                                                                    If Sassex = "6" Then
                                                                        nave1C = "G6"
                                                                    Else

                                                                        If Sassex = "7" Then
                                                                            nave1C = "G7"
                                                                        Else

                                                                            If assex = "8" Then
                                                                                nave1C = "G8"
                                                                            Else
                                                                                nave1C = "G9"

                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    assex = 0 And assey = 0
                    assex = Int((9 * Rnd()) + 1)
                    assey = Int((7 * Rnd()) + 1)
                    If assey = "1" Then
                        If assex = "1" Then
                            nave2C = "A1"
                        Else
                            If assex = "2" Then
                                nave2C = "A2"
                            Else
                                If assex = "3" Then
                                    nave2C = "A3"
                                Else
                                    If assex = "4" Then
                                        nave2C = "A4"
                                    Else
                                        If assex = "5" Then
                                            nave1C = "A5"
                                        Else
                                            If assex = "6" Then
                                                nave1C = "A6"
                                            Else

                                                If assex = "7" Then
                                                    nave2C = "A7"
                                                Else

                                                    If assex = "8" Then
                                                        nave2C = "A8"
                                                    Else
                                                        nave2C = "A9"


                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If

                            End If

                        End If
                    Else
                        If assey = "2" Then
                            If assex = "1" Then
                                nave2C = "B1"
                            Else
                                If assex = "2" Then
                                    nave2C = "B2"
                                Else
                                    If assex = "3" Then
                                        nave2C = "B3"
                                    Else
                                        If assex = "4" Then
                                            nave2C = "B4"
                                        Else
                                            If assex = "5" Then
                                                nave2C = "B5"
                                            Else
                                                If assex = "6" Then
                                                    nave2C = "B6"
                                                Else

                                                    If assex = "7" Then
                                                        nave2C = "B7"
                                                    Else

                                                        If assex = "8" Then
                                                            nave2C = "B8"
                                                        Else
                                                            nave2C = "B9"

                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        Else
                            If assey = "3" Then
                                If assex = "1" Then
                                    nave2C = "C1"
                                Else
                                    If assex = "2" Then
                                        nave2C = "C2"
                                    Else
                                        If assex = "3" Then
                                            nave2C = "C3"
                                        Else
                                            If assex = "4" Then
                                                nave2C = "C4"
                                            Else
                                                If assex = "5" Then
                                                    nave2C = "C5"
                                                Else
                                                    If assex = "6" Then
                                                        nave2C = "C6"
                                                    Else

                                                        If assex = "7" Then
                                                            nave2C = "C7"
                                                        Else

                                                            If assex = "8" Then
                                                                nave2C = "C8"
                                                            Else
                                                                nave2C = "C9"
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            Else
                                If assey = "4" Then
                                    If assex = "1" Then
                                        nave2C = "D1"
                                    Else
                                        If assex = "2" Then
                                            nave2C = "D2"
                                        Else
                                            If assex = "3" Then
                                                nave2C = "D3"
                                            Else
                                                If assex = "4" Then
                                                    nave2C = "D4"
                                                Else
                                                    If assex = "5" Then
                                                        nave2C = "D5"
                                                    Else
                                                        If assex = "6" Then
                                                            nave2C = "D6"
                                                        Else

                                                            If assex = "7" Then
                                                                nave2C = "D7"
                                                            Else

                                                                If assex = "8" Then
                                                                    nave2C = "D8"
                                                                Else
                                                                    nave2C = "D9"
                                                                End If

                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                Else
                                    If assey = "5" Then
                                        If assex = "1" Then
                                            nave2C = "E1"
                                        Else
                                            If assex = "2" Then
                                                nave2C = "E2"
                                            Else
                                                If assex = "3" Then
                                                    nave2C = "E3"
                                                Else
                                                    If assex = "4" Then
                                                        nave2C = "E4"
                                                    Else
                                                        If assex = "5" Then
                                                            nave2C = "E5"
                                                        Else
                                                            If assex = "6" Then
                                                                nave2C = "E6"
                                                            Else

                                                                If assex = "7" Then
                                                                    nave2C = "E7"
                                                                Else

                                                                    If assex = "8" Then
                                                                        nave2C = "E8"
                                                                    Else
                                                                        nave2C = "E9"
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    Else
                                        If assey = "6" Then
                                            If assex = "1" Then
                                                nave2C = "F1"
                                            Else
                                                If assex = "2" Then
                                                    nave2C = "F2"
                                                Else
                                                    If assex = "3" Then
                                                        nave2C = "F3"
                                                    Else
                                                        If assex = "4" Then
                                                            nave2C = "F4"
                                                        Else
                                                            If assex = "5" Then
                                                                nave2C = "F5"
                                                            Else
                                                                If assex = "6" Then
                                                                    nave2C = "F6"
                                                                Else

                                                                    If assex = "7" Then
                                                                        nave2C = "F7"
                                                                    Else

                                                                        If assex = "8" Then
                                                                            nave2C = "F8"
                                                                        Else
                                                                            nave2C = "F9"
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        Else
                                            If assey = "7" Then
                                                If assex = "1" Then
                                                    nave2C = "G1"
                                                Else
                                                    If assex = "2" Then
                                                        nave2C = "G2"
                                                    Else
                                                        If assex = "3" Then
                                                            nave2C = "G3"
                                                        Else
                                                            If assex = "4" Then
                                                                nave2C = "G4"
                                                            Else
                                                                If assex = "5" Then
                                                                    nave2C = "G5"
                                                                Else
                                                                    If assex = "6" Then
                                                                        nave2C = "G6"
                                                                    Else

                                                                        If assex = "7" Then
                                                                            nave2C = "G7"
                                                                        Else

                                                                            If assex = "8" Then
                                                                                nave2C = "G8"
                                                                            Else
                                                                                nave2C = "G9"
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If

                            End If
                        End If
                    End If
                    assex = Int((9 * Rnd()) + 1)
                    assex = Int((7 * Rnd()) + 1)
                    If assey = "1" Then
                        If assex = "1" Then
                            nave3c = "A1"
                        Else
                            If assex = "2" Then
                                nave3c = "A2"
                            Else
                                If assex = "3" Then
                                    nave3c = "A3"
                                Else
                                    If assex = "4" Then
                                        nave3c = "A4"
                                    Else
                                        If assex = "5" Then
                                            nave3c = "A5"
                                        Else
                                            If assex = "6" Then
                                                nave3c = "A6"
                                            Else

                                                If assex = "7" Then
                                                    nave3c = "A7"
                                                Else

                                                    If assex = "8" Then
                                                        nave3c = "A8"
                                                    Else
                                                        nave3c = "A9"


                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If

                            End If

                        End If
                    Else
                        If assey = "2" Then
                            If assex = "1" Then
                                nave3c = "B1"
                            Else
                                If assex = "2" Then
                                    nave3c = "B2"
                                Else
                                    If assex = "3" Then
                                        nave3c = "B3"
                                    Else
                                        If assex = "4" Then
                                            nave3c = "B4"
                                        Else
                                            If assex = "5" Then
                                                nave3c = "B5"
                                            Else
                                                If assex = "6" Then
                                                    nave3c = "B6"
                                                Else

                                                    If assex = "7" Then
                                                        nave3c = "B7"
                                                    Else

                                                        If assex = "8" Then
                                                            nave3c = "B8"
                                                        Else
                                                            nave3c = "B9"

                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        Else
                            If assey = "3" Then
                                If assex = "1" Then
                                    nave3c = "C1"
                                Else
                                    If assex = "2" Then
                                        nave3c = "C2"
                                    Else
                                        If assex = "3" Then
                                            nave3c = "C3"
                                        Else
                                            If assex = "4" Then
                                                nave3c = "C4"
                                            Else
                                                If assex = "5" Then
                                                    nave3c = "C5"
                                                Else
                                                    If assex = "6" Then
                                                        nave3c = "C6"
                                                    Else

                                                        If assex = "7" Then
                                                            nave3c = "C7"
                                                        Else

                                                            If assex = "8" Then
                                                                nave3c = "C8"
                                                            Else
                                                                nave3c = "C9"
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            Else
                                If assey = "4" Then
                                    If assex = "1" Then
                                        nave3c = "D1"
                                    Else
                                        If assex = "2" Then
                                            nave3c = "D2"
                                        Else
                                            If assex = "3" Then
                                                nave3c = "D3"
                                            Else
                                                If assex = "4" Then
                                                    nave3c = "D4"
                                                Else
                                                    If assex = "5" Then
                                                        nave3c = "D5"
                                                    Else
                                                        If assex = "6" Then
                                                            nave3c = "D6"
                                                        Else

                                                            If assex = "7" Then
                                                                nave3c = "D7"
                                                            Else

                                                                If assex = "8" Then
                                                                    nave3c = "D8"
                                                                Else
                                                                    nave3c = "D9"
                                                                End If

                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                Else
                                    If assey = "5" Then
                                        If assex = "1" Then
                                            nave3c = "E1"
                                        Else
                                            If assex = "2" Then
                                                nave3c = "E2"
                                            Else
                                                If assex = "3" Then
                                                    nave3c = "E3"
                                                Else
                                                    If assex = "4" Then
                                                        nave3c = "E4"
                                                    Else
                                                        If assex = "5" Then
                                                            nave3c = "E5"
                                                        Else
                                                            If assex = "6" Then
                                                                nave3c = "E6"
                                                            Else

                                                                If assex = "7" Then
                                                                    nave3c = "E7"
                                                                Else

                                                                    If assex = "8" Then
                                                                        nave3c = "E8"
                                                                    Else
                                                                        nave3c = "E9"
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    Else
                                        If assey = "6" Then
                                            If assex = "1" Then
                                                nave3c = "F1"
                                            Else
                                                If assex = "2" Then
                                                    nave3c = "F2"
                                                Else
                                                    If assex = "3" Then
                                                        nave3c = "F3"
                                                    Else
                                                        If assex = "4" Then
                                                            nave3c = "F4"
                                                        Else
                                                            If assex = "5" Then
                                                                nave3c = "F5"
                                                            Else
                                                                If assex = "6" Then
                                                                    nave3c = "F6"
                                                                Else

                                                                    If assex = "7" Then
                                                                        nave3c = "F7"
                                                                    Else

                                                                        If assex = "8" Then
                                                                            nave3c = "F8"
                                                                        Else
                                                                            nave3c = "F9"
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        Else
                                            If assey = "7" Then
                                                If assex = "1" Then
                                                    nave3c = "G1"
                                                Else
                                                    If assex = "2" Then
                                                        nave3c = "G2"
                                                    Else
                                                        If assex = "3" Then
                                                            nave3c = "G3"
                                                        Else
                                                            If assex = "4" Then
                                                                nave3c = "G4"
                                                            Else
                                                                If assex = "5" Then
                                                                    nave3c = "G5"
                                                                Else
                                                                    If assex = "6" Then
                                                                        nave3c = "G6"
                                                                    Else

                                                                        If assex = "7" Then
                                                                            nave3c = "G7"
                                                                        Else

                                                                            If assex = "8" Then
                                                                                nave3c = "G8"
                                                                            Else
                                                                                nave3c = "G9"
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If

                            End If
                        End If
                    End If
                    'fase controllo navi
                    If nave1C = nave2C Then
                        If nave2C = nave3c Then

                        End If
                    Else
                        If nave2C = nave3c Then

                        Else
                            If nave1C = nave3c Then
                            Else
                                Exit Do
                            End If
                        End If
                    End If
                Loop
                Do Until perdite = 8 Or perditen = 3
                    'scelta computer
                    assex = Int((9 * Rnd()) + 1)
                    assey = Int((7 * Rnd()) + 1)
                    If assey = "1" Then
                        If assex = "1" Then
                            coordinate = "A1"
                        Else
                            If assex = "2" Then
                                coordinate = "A2"
                            Else
                                If assex = "3" Then
                                    coordinate = "A3"
                                Else
                                    If assex = "4" Then
                                        coordinate = "A4"
                                    Else
                                        If assex = "5" Then
                                            coordinate = "A5"
                                        Else
                                            If assex = "6" Then
                                                coordinate = "A6"
                                            Else

                                                If assex = "7" Then
                                                    coordinate = "A7"
                                                Else

                                                    If assex = "8" Then
                                                        coordinate = "A8"
                                                    Else
                                                        coordinate = "A9"


                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If

                            End If

                        End If
                    Else
                        If assey = "2" Then
                            If assex = "1" Then
                                coordinate = "B1"
                            Else
                                If assex = "2" Then
                                    coordinate = "B2"
                                Else
                                    If assex = "3" Then
                                        coordinate = "B3"
                                    Else
                                        If assex = "4" Then
                                            coordinate = "B4"
                                        Else
                                            If assex = "5" Then
                                                coordinate = "B5"
                                            Else
                                                If assex = "6" Then
                                                    coordinate = "B6"
                                                Else

                                                    If assex = "7" Then
                                                        coordinate = "B7"
                                                    Else

                                                        If assex = "8" Then
                                                            coordinate = "B8"
                                                        Else
                                                            coordinate = "B9"

                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        Else
                            If assey = "3" Then
                                If assex = "1" Then
                                    coordinate = "C1"
                                Else
                                    If assex = "2" Then
                                        coordinate = "C2"
                                    Else
                                        If assex = "3" Then
                                            coordinate = "C3"
                                        Else
                                            If assex = "4" Then
                                                coordinate = "C4"
                                            Else
                                                If assex = "5" Then
                                                    coordinate = "C5"
                                                Else
                                                    If assex = "6" Then
                                                        coordinate = "C6"
                                                    Else

                                                        If assex = "7" Then
                                                            coordinate = "C7"
                                                        Else

                                                            If assex = "8" Then
                                                                coordinate = "C8"
                                                            Else
                                                                coordinate = "C9"
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            Else
                                If assey = "4" Then
                                    If assex = "1" Then
                                        coordinate = "D1"
                                    Else
                                        If assex = "2" Then
                                            coordinate = "D2"
                                        Else
                                            If assex = "3" Then
                                                coordinate = "D3"
                                            Else
                                                If assex = "4" Then
                                                    coordinate = "D4"
                                                Else
                                                    If assex = "5" Then
                                                        coordinate = "D5"
                                                    Else
                                                        If assex = "6" Then
                                                            coordinate = "D6"
                                                        Else

                                                            If assex = "7" Then
                                                                coordinate = "D7"
                                                            Else

                                                                If assex = "8" Then
                                                                    coordinate = "D8"
                                                                Else
                                                                    coordinate = "D9"
                                                                End If

                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                Else
                                    If assey = "5" Then
                                        If assex = "1" Then
                                            coordinate = "E1"
                                        Else
                                            If assex = "2" Then
                                                coordinate = "E2"
                                            Else
                                                If assex = "3" Then
                                                    coordinate = "E3"
                                                Else
                                                    If assex = "4" Then
                                                        coordinate = "E4"
                                                    Else
                                                        If assex = "5" Then
                                                            coordinate = "E5"
                                                        Else
                                                            If assex = "6" Then
                                                                coordinate = "E6"
                                                            Else

                                                                If assex = "7" Then
                                                                    coordinate = "E7"
                                                                Else

                                                                    If assex = "8" Then
                                                                        coordinate = "E8"
                                                                    Else
                                                                        coordinate = "E9"
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    Else
                                        If assey = "6" Then
                                            If assex = "1" Then
                                                coordinate = "F1"
                                            Else
                                                If assex = "2" Then
                                                    coordinate = "F2"
                                                Else
                                                    If assex = "3" Then
                                                        coordinate = "F3"
                                                    Else
                                                        If assex = "4" Then
                                                            coordinate = "F4"
                                                        Else
                                                            If assex = "5" Then
                                                                coordinate = "F5"
                                                            Else
                                                                If assex = "6" Then
                                                                    coordinate = "F6"
                                                                Else

                                                                    If assex = "7" Then
                                                                        coordinate = "F7"
                                                                    Else

                                                                        If assex = "8" Then
                                                                            coordinate = "F8"
                                                                        Else
                                                                            coordinate = "F9"
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        Else
                                            If assey = "7" Then
                                                If assex = "1" Then
                                                    coordinate = "G1"
                                                Else
                                                    If assex = "2" Then
                                                        coordinate = "G2"
                                                    Else
                                                        If assex = "3" Then
                                                            coordinate = "G3"
                                                        Else
                                                            If assex = "4" Then
                                                                coordinate = "G4"
                                                            Else
                                                                If assex = "5" Then
                                                                    coordinate = "G5"
                                                                Else
                                                                    If assex = "6" Then
                                                                        coordinate = "G6"
                                                                    Else

                                                                        If assex = "7" Then
                                                                            coordinate = "G7"
                                                                        Else

                                                                            If assex = "8" Then
                                                                                coordinate = "G8"
                                                                            Else
                                                                                coordinate = "G9"
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If

                            End If
                        End If
                    End If



                    'FINE VARIABILI SCELTA COMPUTER
                    'TEST ONLY 
                    If "frafire" = Ngiocatore Then
                        Console.WriteLine(nave1C & nave2C & nave3c)
                    Else

                    End If
                    acapo = " "
                    Console.WriteLine(acapo)

                    Console.WriteLine("Capitano! pronti a sparare aspettiamo le coordinate!")
                    Gsparo = Console.ReadLine
                    Gsparo = UCase(Gsparo)
                    If Gsparo = nave1C Then
                        Console.WriteLine("un ricognitore ci conferma che una fregata nemica è stata affondata")
                        perditen = perditen + 1
                        nave1C = 0
                    Else
                        If Gsparo = nave2C Then
                            Console.WriteLine("colpo assegno incrociatore a picco")
                            perditen = perditen + 1
                            nave2C = 0

                        Else
                            If Gsparo = nave3c Then
                                Console.WriteLine("colpo a segno")
                                perditen = perditen + 1
                                nave3c = 0

                            Else
                                Console.WriteLine("rapporti sul campo ci informano che il colpo è andato a vuoto")
                            End If
                        End If
                    End If
                    If perditen = 2 Then
                        Console.WriteLine("manca solo una nave!")
                    Else

                    End If

                    Console.WriteLine(acapo)
                    'TEST ONLY (togliere ' per far funzionare il test)
                    If "frafire" = Ngiocatore Then
                        Console.WriteLine(coordinate)
                    Else

                    End If
                    Console.WriteLine(acapo)

                    Console.WriteLine(Ngiocatore & Space(1) & "il nemico si prepara a spararci addosso!!")
                    If coordinate = freg1 Then
                        Console.WriteLine("Una fregata sta colando a picco")
                        freg1 = "0"
                        perdite = perdite + 1
                    Else
                        If coordinate = caccia1 Then
                            Console.WriteLine("il cacciatorpediniere ALLEATO è stato colpito e sta affondando")
                            caccia1 = "0"
                            perdite = perdite + 1
                        Else
                            If coordinate = caccia2 Then
                                Console.WriteLine("Una nave alleata sta affondando in posizione " & caccia2)
                                caccia2 = "0"
                                perdite = perdite + 1
                            Else
                                If coordinate = freg2 Then
                                    Console.WriteLine("Fregata colpita da missili in posizione" & Space(1) & freg2 & Space(1) & "aggiustiamo il tiro per difenderci!")
                                    perdite = perdite + 1
                                    freg2 = "0"
                                Else
                                    If coordinate = freg3 Then
                                        Console.WriteLine("Capitano! Fregata in fiamme stanno abbandonando la nave")
                                        perdite = perdite + 1
                                        freg3 = "0"
                                    Else
                                        If incro = coordinate Then
                                            Console.WriteLine("Capitano hanno colpito l'ammiraglia")
                                            perdite = perdite + 1
                                            incro = "0"
                                        Else
                                            Console.WriteLine("il colpo del nemico non è andato a segno!")
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    Console.WriteLine(acapo)
                    turno = turno + 1
                    Console.WriteLine("Fine del " & turno & " turno. Risultati dalla nostra parte navi affondate" & Space(1) & perdite)
                Loop
                If perdite = 8 Then
                    Console.WriteLine("il nemico ci ha distrutto! ci riferaremo! ")
                Else
                    Console.WriteLine(Ngiocatore & Space(1) & "abbiamo vinto! la flotta nemica è stata distrutta")
                End If
                Console.WriteLine("vuoi continuare a giocare s/n")
                cont = Console.ReadLine
                If cont = "s" Then
                    perdite = 0
                    turno = 0
                    perditen = 0
                Else
                    Exit Do
                    Console.WriteLine(Ngiocatore & Space(1) & "Grazie per aver giocato")
                End If
            Loop


    End Sub
End Module
