Public Class Container_Water
    Shared Function Container()
        Dim arr = Input.InputIntegerArray(),
            left = 0,
            right = arr.Length - 1,
            area = 0, width, height As Integer

        ' Loop to find the most area
        While left < right
            height = Math.Min(arr(left), arr(right))
            width = right - left
            If area < (height * width) Then area = (height * width)
            If right > left + 1 Then
                right -= 1
            Else
                right = arr.Length - 1
                left += 1
            End If
        End While

        ' Console result
        Console.WriteLine("area: {0}", area)

        Return 0
    End Function
End Class
