Public Class Valid_Sudoku
    Shared Function Sudoku()
        Dim board(,) As Char = {{"8", "3", ".", ".", "7", ".", ".", ".", "."}, {"6", ".", ".", "1", "9", "5", ".", ".", "."}, {".", "9", "8", ".", ".", ".", ".", "6", "."}, {"8", ".", ".", ".", "6", ".", ".", ".", "3"}, {"4", ".", ".", "8", ".", "3", ".", ".", "1"}, {"7", ".", ".", ".", "2", ".", ".", ".", "6"}, {".", "6", ".", ".", ".", ".", "2", "8", "."}, {".", ".", ".", "4", "1", "9", ".", ".", "5"}, {".", ".", ".", ".", "8", ".", ".", "7", "9"}}
        Dim rowHash(8) As HashSet(Of Char)
        Dim colHash(8) As HashSet(Of Char)
        Dim isValid, done As Boolean
        isValid = True
        done = False

        ' Initialize col's and row's hashSets
        For i = 0 To rowHash.Length - 1
            rowHash(i) = New HashSet(Of Char)()
            colHash(i) = New HashSet(Of Char)()
        Next

        Dim squareHash(2, 2) As HashSet(Of Char)
        ' Initialize squareHash's hashSets
        For i = 0 To 2
            For j = 0 To 2
                squareHash(i, j) = New HashSet(Of Char)()
            Next
        Next

        For row = 0 To 8
            For col = 0 To 8
                If board(row, col) = "." Then Continue For

                If rowHash(row).Contains(board(row, col)) Then
                    isValid = False
                    done = True
                    Exit For
                End If
                rowHash(row).Add(board(row, col))

                If colHash(col).Contains(board(row, col)) Then
                    isValid = False
                    done = True
                    Exit For
                End If
                colHash(col).Add(board(row, col))

                If squareHash(row / 4, col / 4).Contains(board(row, col)) Then
                    isValid = False
                    done = True
                    Exit For
                End If
                squareHash(row / 4, col / 4).Add(board(row, col))
            Next
            If done Then Exit For
        Next

        ' Console result
        Console.WriteLine("is valid: {0}", isValid)

        Return 0
    End Function
End Class
