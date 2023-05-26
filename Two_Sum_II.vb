Public Class Two_Sum_II
    Shared Function Sum()
        Dim nums = Input.InputIntegerArray(), target = Input.InputInteger("Please input target number"), left = 0, right = nums.Length - 1, summary As Integer

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
