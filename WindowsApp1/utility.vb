Module utility
    Public i As Integer, p = New Integer() {1, 2, 3, 4, 5}, min As Integer, k As Integer = 1, btime As Integer = 0
    Public bt(10) As Integer, temp As Integer, j As Integer, at(10) As Integer, wt(10) As Integer, tt(10) As Integer, ta As Integer = 0, sum As Integer = 0
    Public wavg As Double = 0.0, tavg As Double = 0.0, tsum As Integer = 0, wsum As Integer = 0
    Public Function setLbl(ByVal n As Integer, ByVal lbl As Label) As Label
        lbl.Text = "P" & n
        Select Case n
            Case 1
                lbl.ForeColor = Drawing.Color.MidnightBlue
            Case 2
                lbl.ForeColor = Drawing.Color.Crimson
            Case 3
                lbl.ForeColor = Drawing.Color.DodgerBlue
            Case 4
                lbl.ForeColor = Drawing.Color.Magenta
            Case 5
                lbl.ForeColor = Drawing.Color.Chocolate
        End Select
        Return lbl
    End Function
    Public Function setColor(ByVal n As Integer) As Color
        Dim color1 As Color
        Select Case n
            Case 1
                color1 = Color.MidnightBlue
            Case 2
                color1 = Color.Crimson
            Case 3
                color1 = Color.DodgerBlue
            Case 4
                color1 = Color.Magenta
            Case 5
                color1 = Color.Chocolate
        End Select
        Return color1
    End Function

    Public Sub randomizeAt()
        'MessageBox.Show(at(0) & " " & at(1) & " " & at(2) & " " & at(3) & " " & at(4))
        Dim rand As New Random()
        Dim counter = 0

        'Do Until counter = count + 1
        '    Dim someNumber As Integer = rand.Next(min, max + 1)
        '    ' Only add the number if it is not already in the array
        '    If Not randomNumbers.Contains(someNumber) Then
        '        randomNumbers(counter) = someNumber
        '        counter += 1
        '    End If
        'Loop
        Do Until counter = 5
            'For i As Integer = 0 To 4
            Dim n As Integer = rand.Next(1, 26)
            If Not at.Contains(n) Then
                at(counter) = n
                counter += 1
            End If
        Loop
    End Sub
    Public Sub randomizeBt()
        For i As Integer = 0 To 4
            Dim n As Integer = CInt(Math.Ceiling(Rnd() * 25 + 1))
            bt(i) = n
        Next
    End Sub


End Module
