Public Class Valid_Palindrome
    Shared Function InputString()
        Console.WriteLine("Please input string to check palindrome")
        Dim str As String = Console.ReadLine()
        Return str
    End Function

    Shared Function Palindrome()
        Dim s = InputString(), t As String = ""

        ' Remove non-alphanumeric and change string to lowercase
        For i = 0 To s.Length - 1
            If Char.IsLetterOrDigit(s(i)) Then
                t += Char.ToLower(s(i))
            End If
        Next

        ' Clear s string and reverse add from t
        s = s.Substring(0, 0)
        For i = t.Length - 1 To 0 Step -1
            s += t(i)
        Next

        ' Console log result
        If t = s Then
            Console.WriteLine("True")
        Else
            Console.WriteLine("False")
        End If

        Return 0
    End Function
End Class
