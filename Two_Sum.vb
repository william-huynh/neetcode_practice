Public Class Two_Sum
    Shared Function Sum()
        ' Input variables
        Dim array() As Integer = Input.InputIntegerArray()
        Dim target As Integer = Input.InputInteger("Please input target number")
        Dim i = 0, j As Integer

        ' Find 2 number add up to target
        While i < array.Length
            j = i + 1
            While j < array.Length
                If (array(i) + array(j)) = target Then
                    Exit While
                End If
                j += 1
            End While
            If (array(i) + array(j)) = target Then
                Exit While
            End If
            i += 1
        End While

        ' Console log result
        Console.WriteLine(String.Format("nums = [{0}]", String.Join(", ", array)))
        Console.WriteLine("target = " + target.ToString())
        Console.WriteLine("[" + i.ToString() + "," + j.ToString() + "]")

        Return 0
    End Function
End Class
