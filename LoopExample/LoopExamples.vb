Option Explicit On

Module LoopExamples

    Sub Main()
        'Dim pattern As String
        'For i = 1 To 10
        '    'Console.WriteLine(i)
        '    pattern &= "*"
        '    Console.WriteLine(pattern)
        'Next

        Dim count As Integer '= 11
        'Do While count <= 10
        '    count += 1
        'Loop

        Do
            count += 1
        Loop While count <= 10
        Console.Read()
    End Sub

End Module
