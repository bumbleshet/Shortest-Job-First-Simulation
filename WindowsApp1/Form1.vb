Imports WindowsApp1.utility
Public Class Form1
    Dim y As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initializeTable()
        randomizeAt()
        randomizeBt()
        For i As Integer = 0 To 4
            table1.Rows.Add(at(i), bt(i))
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clearData()
        'getData()
        If (getData()) Then
            sortAt()
            sortBtAtEt()
            Me.Enabled = False
            Form2.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = False
    End Sub

    Private Sub dataGridView1_CellValidating(ByVal sender As Object, ByVal e As DataGridViewCellValidatingEventArgs) Handles table1.CellValidating

        Me.table1.Rows(e.RowIndex).ErrorText = ""
        Dim newInteger As Integer

        ' Don't try to validate the 'new row' until finished 
        ' editing since there
        ' is not any point in validating its initial value.
        If table1.Rows(e.RowIndex).IsNewRow Then Return

        'validate if input is valid
        If Not Integer.TryParse(e.FormattedValue.ToString(), newInteger) _
            OrElse newInteger < 0 OrElse newInteger > 100 Then
            e.Cancel = True
            Me.table1.Rows(e.RowIndex).ErrorText = "the value must be a non-negative integer and below 100"
        End If

        'check If input has duplicate at
        If (e.ColumnIndex = 0) Then
            For i = 0 To table1.Rows.Count - 1
                If (table1(0, i).Value = e.FormattedValue) Then
                    e.Cancel = True
                    Me.table1.Rows(e.RowIndex).ErrorText = "Duplicate Arrival Time"
                End If
            Next
        End If
    End Sub

    Public Sub sortAt()
        For i = 0 To 4
            For j = 0 To 4
                If (at(i) < at(j)) Then
                    temp = p(j)
                    p(j) = p(i)
                    p(i) = temp
                    temp = at(j)
                    at(j) = at(i)
                    at(i) = temp
                    temp = bt(j)
                    bt(j) = bt(i)
                    bt(i) = temp
                End If
            Next
        Next
        'MessageBox.Show(p(0) & " " & p(1) & " " & p(2) & " " & p(3) & " " & p(4))
    End Sub
    Public Sub sortAt2()
        For i = 0 To 4
            For j = 0 To 4
                If (bt(i) = bt(j) And at(j) > at(i)) Then
                    temp = p(j)
                    p(j) = p(i)
                    p(i) = temp
                    temp = at(j)
                    at(j) = at(i)
                    at(i) = temp
                    temp = bt(j)
                    bt(j) = bt(i)
                    bt(i) = temp
                End If
            Next
        Next
    End Sub
    Public Sub sortBtAtEt()
        'MessageBox.Show(bt(0) & " " & bt(1) & " " & bt(2) & " " & bt(3) & " " & bt(4))
        For j = 0 To 4
            If (j = 0) Then
                btime = btime + at(0)
            End If
            btime = btime + bt(j)
            min = bt(k)
            For i = k To 4
                'If (bt(i) = bt(k) And at(k) < at(i)) Then
                '    temp = p(k)
                '    p(k) = p(i)
                '    p(i) = temp
                '    temp = at(k)
                '    at(k) = at(i)
                '    at(i) = temp
                '    temp = bt(k)
                '    bt(k) = bt(i)
                '    bt(i) = temp
                'End If
                If ((btime >= at(i)) And bt(i) < bt(k)) Then
                    temp = p(k)
                    p(k) = p(i)
                    p(i) = temp
                    temp = at(k)
                    at(k) = at(i)
                    at(i) = temp
                    temp = bt(k)
                    bt(k) = bt(i)
                    bt(i) = temp
                End If
            Next
            k += 1
        Next
        sortAt2()
        wt(0) = 0

        Dim lp As Integer = 0
        For i = 1 To 4
            If (at(i - 1) > sum) Then
                'ta = ta + bt(lp) + at(lp)
                sum = sum + bt(lp) + (at(lp) - sum)
            Else
                'ta = ta + bt(lp)
                sum = sum + bt(lp)
            End If
            If (at(i) > sum) Then
                wt(i) = sum - at(i) + (at(i) - sum)
                'tt(lp) = ta - at(lp)
                ' tsum = tsum + tt(lp)
                wsum = wsum + wt(i)
            Else
                'tt(lp) = ta - at(lp)
                'tsum = tsum + tt(lp)
                wt(i) = sum - at(i)
                wsum = wsum + wt(i)
            End If

            lp += 1
            'MessageBox.Show(i & " " & sum & " " & bt(i - 1) & " " & wt(i) & " " & at(i) & " " & wsum)
        Next
        'lp += 1
        'ta = ta + bt(lp)

        'tsum = tsum + tt(lp)

        wavg = (wsum / 5)

        For i = 0 To 4
            If (at(i) > ta And i = 0) Then
                ta = ta + bt(i) + at(i)
            ElseIf (at(i) > ta) Then
                ta = ta + (at(i) - ta) + bt(i)
            Else
                ta = ta + bt(i)
            End If
            tt(i) = ta - at(i)
            tsum = tsum + tt(i)
        Next

        tavg = (tsum / 5)
        'MessageBox.Show(tavg & wavg)

    End Sub
    Public Function getData() As Boolean
        For i As Integer = 0 To 4
            Try
                bt(i) = table1(1, i).Value
                at(i) = table1(0, i).Value
            Catch ex As Exception
                MessageBox.Show("Input must be 1-5 at and bt, and non zero (0-100) integer")
                Exit For
                Return False
            End Try

        Next
        Return True
    End Function

    Public Sub clearData()
        p = New Integer() {1, 2, 3, 4, 5}
        i = 0
        min = 0
        k = 1
        btime = 0
        bt(10) = 0
        temp = 0
        j = 0
        at(10) = 0
        wt(10) = 0
        tt(10) = 0
        ta = 0
        sum = 0
        wavg = 0
        tavg = 0
        tsum = 0
        wsum = 0
    End Sub
    Public Sub initializeTable()
        table1.Rows.Add()
        table1.Rows.Add()
        table1.Rows.Add()
        table1.Rows.Add()
        table1.Rows.Add()
        table1.AllowUserToAddRows = False
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        table1.Enabled = False
        'table1.Rows.Clear()
        randomizeAt()
        randomizeBt()
        For j As Integer = 0 To 1
            For i As Integer = 0 To 4
                If (j = 0) Then
                    table1(j, i).Value = (at(i))
                Else
                    table1(j, i).Value = (bt(i))
                End If

            Next
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        table1.Enabled = True
        'table1.Rows.Clear()
        clearTable()

        'initializeTable()
        'table1.Rows(0).Selected = True
    End Sub
    Public Sub clearTable()
        'table1.Rows(0).Cells(0).Selected = True
        table1.RefreshEdit()

        For j As Integer = 0 To 1
            For i As Integer = 0 To 4
                'MessageBox.Show(table1(j, i).Value)
                table1(j, i).Value = ("")
            Next
        Next

    End Sub
End Class
