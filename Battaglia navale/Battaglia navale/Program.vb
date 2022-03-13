Imports System

Module Program
    Sub Main(args As String())
        Randomize()
        Dim Ngiocatore As String
        Dim rules As Char
        Dim assex As Int32
        Dim assey As Int32
        Dim coordinate As String
        Dim nave1G As String
        Dim nave2G As String
        Dim Sassex As Int32
        Dim Sassey As Int32
        Dim nave1C As String
        Dim nave2C As String
        Dim Gsparo As String



        Console.WriteLine("Inserisci nome giocatore")
        Ngiocatore = Console.ReadLine

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

           ")
        'tabella^
        Console.WriteLine("vuoi vedere le regole? (s/n)")
        rules = Console.ReadLine
        If rules = "n" Then
        Else
            Console.WriteLine("Benvenuto nel gioco di battaglia navale, ecco le regole! 
               1) Per inserire il colpo o le barche bisogna inserire le coordinate avete la tabella sopra (es A3, D5)
               2) Per vincere in battaglia navale bisogna cercare di distruggere le barche prima del tuo avversario
                                                                                                                     ")


        End If
        Console.WriteLine("inserisci posizione della fregata")
        nave1G = Console.ReadLine
        Console.WriteLine("inserisci posizione del cacciotorpediniere")
        nave2G = Console.ReadLine

        'posizione barca computer (già solo UNA barca...) 
        Sassex = Int((9 * Rnd()) + 1)
        Sassey = Int((5 * Rnd()) + 1)
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
                        End If
                    End If
                    End If
                End If
            End If


        'scelta computer
        assex = Int((9 * Rnd()) + 1)
        assey = Int((5 * Rnd()) + 1)
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
                        End If
                    End If
                End If
            End If
        End If
        'FINE VARIABILI SCELTA COMPUTER
        Console.WriteLine(nave1C)

        Console.WriteLine("Capitano! pronti a sparare aspettiamo coordinate!")
        Gsparo = Console.ReadLine
        If Gsparo = nave1C Then
            Console.WriteLine("un ricognitore ci conferma che una fregata nemica è stata affondata")
        Else
            Console.WriteLine("rapporti sul campo ci informano che il colpo è andato a vuoto")
        End If



        Console.WriteLine(coordinate)
        Console.WriteLine("Capitano il nemico si prepara a spararci addosso!!")
        If coordinate IsNot nave1G Then
            Console.WriteLine("il colpo del nemico non è andato a segno!")
        Else
            If coordinate Is nave2G Then
                Console.WriteLine("cacciatorpediniere alleato colpito e affondato")
            Else
                Console.WriteLine("colpito e affondato")
            End If

        End If







    End Sub
End Module
