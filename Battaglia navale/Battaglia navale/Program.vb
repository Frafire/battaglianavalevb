Imports System

Module Program
    Sub Main(args As String())
        Randomize()
        Dim Ngiocatore As String
        Dim assex As Int32
        Dim assey As Int32
        Dim coordinate As VariantType



        Console.WriteLine("Inserisci nome giocatore")
        Ngiocatore = Console.ReadLine
        Console.WriteLine(" 
              1 | 2 3 4 5 6 7 8 9
            A    
            B
            C
            D
            E
           ")

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








        Console.WriteLine(assex)
        Console.WriteLine(assey)



        Console.WriteLine(coordinate)





    End Sub
End Module
