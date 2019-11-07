Module Module1

    Sub Main()
        Dim LevelPlace As String
        Dim RowClip As String
        Dim move As String
        Dim RoomX As Integer = "1"
        Dim RoomY As Integer = "1"
        Dim Column As Integer = 2
        Dim Row As Integer = 3
        Dim Continoo = True
        Dim LevelFriend As IO.StreamReader
        Dim Board(,) As String
        'Dimming space ^^^
        Do
            setBOARD(Board, Column, Row, LevelFriend, RoomX, RoomY, RowClip, LevelPlace)

            For y = 0 To 5
                For x = 0 To 5
                    Console.Write(Board(y, x))
                Next
                Console.WriteLine()
            Next
            Console.WriteLine("input your move")
            move = Console.ReadLine()
            If move = "W" Then Row = Row - 1
            If move = "S" Then Row = Row + 1
            If move = "D" Then Column = Column + 1
            If move = "A" Then Column = Column - 1
        Loop Until Continoo = False
    End Sub
    Sub setBOARD(ByRef Board, Column, Row, LevelFriend, RoomX, RoomY, RowClip, LevelPlace)
        LevelPlace = RoomX & " , " & RoomY
        LevelFriend = LevelPlace
        LevelFriend = New IO.StreamReader("1,1.txt")
        Dim Segment As Integer
        Dim Line As Integer
        For Line = 0 To 9
            RowClip = LevelFriend.Readline
            For Segment = 0 To 9

                Board(Segment, Line) = RowClip(Segment)

            Next
            Line = 0
        Next
        Board(Row, Column) = "H"
        Console.Clear()

    End Sub
End Module
