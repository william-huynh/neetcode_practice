Public Class Container_Water
    Shared Function InputArray()
        Console.WriteLine("Please input how many integers you would like to add")
        Dim count = CInt(Console.ReadLine())
        Dim array(count - 1) As Integer

        For i = 0 To count - 1
            Console.WriteLine("Please enter an integer")
            array(i) = CInt(Console.ReadLine())
        Next

        Return array
    End Function

    Shared Function Container()
        Dim arr = InputArray(),
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
