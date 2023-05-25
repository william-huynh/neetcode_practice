Public Class Two_Sum_II
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

    Shared Function InputInt()
        Console.WriteLine("Please input target number")
        Dim target As Integer = CInt(Console.ReadLine())
        Return target
    End Function

    Shared Function Sum()
        Dim nums = InputArray(), target = InputInt(), left = 0, right = nums.Length - 1, summary As Integer

        While left < right
            summary = nums(left) + nums(right)
            If summary = target Then Exit While
            If summary < target Then left += 1
            If summary > target Then right -= 1
        End While

        ' Console result
        Console.WriteLine("[{0},{1}]", left + 1, right + 1)

        Return 0
    End Function
End Class
