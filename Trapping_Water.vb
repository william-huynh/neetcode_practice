Public Class Trapping_Water
    Shared Function Trap()
        'Dim container() = {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1},
        '    left = 0, right = container.Length - 1,
        '    leftHeight = 0, rightHeight = 0, amount As Integer

        'While left <= right
        '    If container(left) < container(right) Then
        '        amount -= container(left)
        '        leftHeight = Math.Max(leftHeight, container(left))
        '        left += 1
        '        amount += leftHeight
        '    Else
        '        amount -= container(right)
        '        rightHeight = Math.Max(rightHeight, container(right))
        '        right -= 1
        '        amount += rightHeight
        '    End If
        'End While

        'Console.WriteLine("amount: {0}", amount)

        Dim container = Input.InputIntegerArray(),
            left = 0, right = container.Length - 1,
            leftHeight = container(left), rightHeight = container(right),
            amount As Integer = 0

        While left < right
            If leftHeight < rightHeight Then
                left += 1
                leftHeight = Math.Max(leftHeight, container(left))
                amount += leftHeight - container(left)
            Else
                right -= 1
                rightHeight = Math.Max(rightHeight, container(right))
                amount += rightHeight - container(right)
            End If
        End While

        Console.WriteLine("amount: {0}", amount)

        Return 0
    End Function
End Class
