Imports System

Module Program
    Sub Main(args As String())
        Randomize()
        'variabili
        Dim Ngiocatore As String
        Dim rules As Char
        Dim assex As Int32
        Dim assey As Int32
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
        Dim perdite As String
        Dim incro As String
        Dim rulesr As String
        Dim acapo As String

        'regole del gioco
        rulesr = "Benvenuto nel gioco di battaglia navale, ecco le regole! 
             1) Per inserire il colpo o le barche bisogna inserire le coordinate avete la tabella qua sotto (es A3, D5)
             2) Per vincere in battaglia navale bisogna cercare di distruggere le barche prima del tuo avversario
             3) Si hanno 5 barche a testa e si dividono in 3 fregate 2 cacciatorpedinieri l'Incrociatore "

        Console.WriteLine("Inserisci nome giocatore")
        Ngiocatore = Console.ReadLine


        Console.WriteLine("vuoi vedere le regole? (s/n)")
        rules = Console.ReadLine

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
                            Console.WriteLine("umh! strano che ci fai qui? tieni un regalino  https://www.youtube.com/watch?v=i1ojUmdF42U")
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
        Console.WriteLine("inserisci posizione della 1a fregata")

        freg1 = Console.ReadLine
        Console.WriteLine("inserisci posizione della 2a fregata")
        freg1 = UCase(freg1)
        freg2 = Console.ReadLine
        freg2 = UCase(freg2)
        Console.WriteLine("inserisci posizione della 3a fregata")
        freg3 = Console.ReadLine
        freg3 = UCase(freg3)
        Console.WriteLine("inserisci posizione del cacciotorpediniere")
        caccia1 = Console.ReadLine
        caccia1 = UCase(caccia1)
        Console.WriteLine("inserisci posizione del cacciotorpediniere di seconda classe")
        caccia2 = Console.ReadLine
        caccia2 = UCase(caccia2)
        Console.WriteLine("inserisci l'incrociatore d'alto mare")
        incro = Console.ReadLine
        incro = UCase(incro)
        'posizione barca computer (già solo UNA barca...) 
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
        Do
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
            'TEST ONLY (togliere ' per far funzionare il test)
            'Console.WriteLine(nave1C)
            acapo = " "
            Console.WriteLine(acapo)

            Console.WriteLine("Capitano! pronti a sparare aspettiamo le coordinate!")
            Gsparo = Console.ReadLine
            If Gsparo = nave1C Then
                Console.WriteLine("un ricognitore ci conferma che una fregata nemica è stata affondata")
            Else
                If Gsparo = nave2C Then
                    Console.WriteLine("colpo assegno incrociatore a picco")
                Else
                    Console.WriteLine("rapporti sul campo ci informano che il colpo è andato a vuoto")
                End If
            End If

            Console.WriteLine(acapo)
            'TEST ONLY (togliere ' per far funzionare il test)
            'Console.WriteLine(coordinate)
            perdite = 0
            Console.WriteLine(Ngiocatore & Space(1) & "il nemico si prepara a spararci addosso!!")
            If coordinate Is freg1 Then
                Console.WriteLine("Una fregata sta colando a picco")
                freg1 = "0"
                perdite = perdite + 1
            Else
                If coordinate Is caccia1 Then
                    Console.WriteLine("cacciatorpediniere alleato colpito e affondato")
                    caccia1 = "0"
                    perdite = perdite + 1
                Else
                    If coordinate Is caccia2 Then
                        Console.WriteLine("Una nave alleata sta affondando in posizione" & caccia2)
                        caccia2 = "0"
                        perdite = perdite + 1
                    Else
                        If coordinate Is freg2 Then
                            Console.WriteLine("Fregata colpita da missili in posizione" & freg2 & "aggiustiamo il tiro per difenderci!")
                            perdite = perdite + 1
                            freg2 = "0"
                        Else
                            If coordinate Is freg3 Then
                                Console.WriteLine("Capitano! Fregata in fiamme stanno abbandonando la nave")
                                perdite = perdite + 1
                                freg3 = "0"
                            Else
                                If incro Is coordinate Then
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




    End Sub
End Module
