Public Class Valid_Anagram
    Shared Function Anagram()
        Dim string1 As String = InputString()
        Dim string2 As String = InputString()
        Dim isAnagram As Boolean = True

        If string1.Length <> string2.Length Then
            isAnagram = False
        Else
            ' Convert strings to arrays
            Dim array1 As Char() = string1.ToCharArray
            Dim array2 As Char() = string2.ToCharArray

            ' Sort array
            Array.Sort(array1)
            Array.Sort(array2)

            ' Check each character and positions
            For i = 0 To array1.Length - 1
                If array1(i) <> array2(i) Then
                    isAnagram = False
                    Exit For
                End If
            Next
        End If

        Console.WriteLine("s = " + string1)
        Console.WriteLine("t = " + string2)
        Console.WriteLine(isAnagram)

        Return 0
    End Function

    Shared Function InputString()
        Console.WriteLine("Please input string")
        Dim str As String = Console.ReadLine()

        Return str
    End Function


End Class
