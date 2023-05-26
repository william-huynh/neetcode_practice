Public Class Three_Sum
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

    Shared Function Sum()
        Dim nums = InputArray(), start = 0, left, right, target As Integer
        Dim result As New List(Of List(Of Integer))

        ' If array less than 2, then exit
        If nums.Length <= 2 Then Return 0

        ' Sort array
        Array.Sort(nums)

        ' Loop to find combinations
        While start < nums.Length - 2
            target = nums(start) * -1
            left = start + 1
            right = nums.Length - 1

            While left < right
                If nums(left) + nums(right) > target Then
                    right -= 1
                ElseIf nums(left) + nums(right) < target Then
                    left += 1
                Else
                    Dim solution As New List(Of Integer)({nums(start), nums(left), nums(right)})
                    result.Add(solution)

                    While left < right And nums(left) = solution(1)
                        left += 1
                    End While

                    While left < right And nums(right) = solution(2)
                        right -= 1
                    End While
                End If
            End While

            Dim currentStartNumber As Integer = nums(start)
            While start < nums.Length - 2 And nums(start) = currentStartNumber
                start += 1
            End While
        End While

        ' Console result
        Console.Write("Output: [")
        For Each numberList As List(Of Integer) In result
            Console.Write("[")
            For Each number As Integer In numberList
                Console.Write("{0}", number)
                If number <> numberList(numberList.Count - 1) Then
                    Console.Write(",")
                End If
            Next
            Console.Write("]")
            If Not numberList.SequenceEqual(result(result.Count - 1)) Then
                Console.Write(",")
            End If
        Next
        Console.Write("]")

        Return 0
    End Function
End Class
