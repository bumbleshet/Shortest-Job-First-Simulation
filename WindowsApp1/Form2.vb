Public Class Form2
    Dim counter As Integer = 0
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setMaxPB()
        setMaxSPB()
        setProcColor()
        max.Text = at(4) + wt(4) + bt(4)
        'MessageBox.Show(bt(0) & " " & bt(1) & " " & bt(2) & " " & bt(3) & " " & bt(4))
        label()
        setSPBColorAndLabel()


    End Sub
    Private Sub Form2_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.Enabled = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        table1.Rows.Clear()
        Timer1.Start()
        btn4.Enabled = False
    End Sub

    'Private Sub panel(sender As Object, e As Panel) Handles progressbar
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counter += 1
        If (counter <= at(4) + wt(4) + bt(4)) Then

            If (counter < at(0)) Then
                lblTime.ForeColor = Color.Black
                prog11.Value += 1

            ElseIf (counter > at(0) And counter <= at(0) + wt(0) + bt(0)) Then
                prog11.Value = at(0) + 1
                lblTime.ForeColor = setColor(p(0))
                prog1.Value += 1

            ElseIf (counter > at(0) + wt(0) + bt(0) And counter <= (at(1) + wt(1))) Then
                lblTime.ForeColor = Color.Black
                prog12.Value += 1

            ElseIf (counter > at(1) + wt(1) And counter <= at(1) + wt(1) + bt(1)) Then
                prog12.Value = (at(1) + wt(1)) - (at(0) + wt(0) + bt(0)) + 1
                lblTime.ForeColor = setColor(p(1))
                prog2.Value += 1

            ElseIf (counter > at(1) + wt(1) + bt(1) And counter <= (at(2) + wt(2))) Then
                lblTime.ForeColor = Color.Black
                prog13.Value += 1

            ElseIf (counter > at(2) + wt(2) And counter <= at(2) + wt(2) + bt(2)) Then
                prog13.Value = (at(2) + wt(2)) - (at(1) + wt(1) + bt(1)) + 1
                lblTime.ForeColor = setColor(p(2))
                prog3.Value += 1

            ElseIf (counter > at(2) + wt(2) + bt(2) And counter <= (at(3) + wt(3))) Then
                lblTime.ForeColor = Color.Black
                prog14.Value += 1

            ElseIf (counter > at(3) + wt(3) And counter <= at(3) + wt(3) + bt(3)) Then
                prog14.Value = (at(3) + wt(3)) - (at(2) + wt(2) + bt(2)) + 1
                lblTime.ForeColor = setColor(p(3))
                prog4.Value += 1

            ElseIf (counter > at(3) + wt(3) + bt(3) And counter <= (at(4) + wt(4))) Then
                lblTime.ForeColor = Color.Black
                prog15.Value += 1

            ElseIf (counter > at(4) + wt(4) And counter <= at(4) + wt(4) + bt(4)) Then
                prog15.Value = (at(4) + wt(4)) - (at(3) + wt(3) + bt(3)) + 1
                lblTime.ForeColor = setColor(p(4))
                prog5.Value += 1

            End If
            lblTime.Text = String.Format("{0:000}", counter)
            '
        Else
            Timer1.Stop()
            btn4.Enabled = True
            'label()
            For i As Integer = 0 To 4
                Dim x As String() = {at(i), bt(i), wt(i), tt(i), wt(i)}
                table1.Rows.Add(x)
            Next
            txtBoxWt.Text = wavg.ToString
            txtBoxTa.Text = tavg.ToString
            'MessageBox.Show(prog1.Value & " " & prog2.Value & " " & prog3.Value & " " & prog4.Value & " " & prog5.Value)
        End If


        'If (counter <> at(4) + tt(4)) Then
        '    counter += 1
        '    If (counter <= at(1) + tt(1)) Then
        '        progbar.Value = counter
        '    Else
        '        progbar2.Value = counter + 1 - at(1) + tt(1)
        '    End If
        '    lblTime.Text = String.Format("{0:000}", counter)
        'Else
        '    Timer1.Stop()
        '    btn4.Enabled = True
        '    label()
        '    For i As Integer = 0 To 4
        '        Dim x As String() = {at(i), bt(i), wt(i), tt(i), wt(i)}
        '        table1.Rows.Add(x)
        '    Next
        '    txtBoxWt.Text = wavg.ToString
        '    txtBoxTa.Text = tavg.ToString
        'End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Timer1.Stop()
        btn4.Enabled = True
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        lblTime.Text = "000"
        counter = 0
        prog11.Value = 0
        prog12.Value = 0
        prog13.Value = 0
        prog14.Value = 0
        prog15.Value = 0
        prog1.Value = 0
        prog2.Value = 0
        prog3.Value = 0
        prog4.Value = 0
        prog5.Value = 0
        txtBoxTa.Text = ""
        txtBoxWt.Text = ""
        table1.Rows.Clear()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Enabled = True
        Form1.Show()
        Me.Close()
    End Sub
    Public Sub label()
        setLbl(p(0), lb1)
        setLbl(p(1), lb2)
        setLbl(p(2), lb3)
        setLbl(p(3), lb4)
        setLbl(p(4), lb5)
        lbl2.Text = at(0) + wt(0) + bt(0)
        lbl3.Text = at(1) + wt(1) + bt(1)
        lbl4.Text = at(2) + wt(2) + bt(2)
        lbl5.Text = at(3) + wt(3) + bt(3)
    End Sub
    Public Sub setMaxPB()
        prog1.Maximum = bt(0)
        prog2.Maximum = bt(1)
        prog3.Maximum = bt(2)
        prog4.Maximum = bt(3)
        prog5.Maximum = bt(4)
    End Sub
    Public Sub setMaxSPB()
        prog11.Maximum = at(0) + 1
        prog12.Maximum = (at(1) + wt(1)) - (at(0) + wt(0) + bt(0)) + 1
        prog13.Maximum = (at(2) + wt(2)) - (at(1) + wt(1) + bt(1)) + 1
        prog14.Maximum = (at(3) + wt(3)) - (at(2) + wt(2) + bt(2)) + 1
        prog15.Maximum = (at(4) + wt(4)) - (at(3) + wt(3) + bt(3)) + 1
        'MessageBox.Show(at(0) & " " & (at(1) + wt(1)) - (at(0) + wt(0) + bt(0)) & " " & (at(2) + wt(2)) - (at(1) + wt(1) + bt(1)) & " " & (at(3) + wt(3)) - (at(2) + wt(2) + bt(2)) & " " & (at(4) + wt(4)) - (at(3) + wt(3) + bt(3)))
    End Sub
    Public Sub setProcColor()
        prog1.ForeColor = setColor(p(0))
        prog2.ForeColor = setColor(p(1))
        prog3.ForeColor = setColor(p(2))
        prog4.ForeColor = setColor(p(3))
        prog5.ForeColor = setColor(p(4))
    End Sub
    Public Sub setSPBColorAndLabel()
        If (at(0) = 0) Then
            prog11.ForeColor = setColor(p(0))
        Else
            lbl115.Text = "|"
            lbl11.Text = at(0)
        End If
        If (((at(1) + wt(1)) - (at(0) + wt(0) + bt(0))) = 0) Then
            prog12.ForeColor = setColor(p(1))
        Else
            lbl225.Text = "|"
            lbl22.Text = at(1)
        End If

        If (((at(2) + wt(2)) - (at(1) + wt(1) + bt(1))) = 0) Then
            prog13.ForeColor = setColor(p(2))
        Else
            lbl335.Text = "|"
            lbl33.Text = at(2)
        End If
        If (((at(3) + wt(3)) - (at(2) + wt(2) + bt(2))) = 0) Then
            prog14.ForeColor = setColor(p(3))
        Else
            lbl445.Text = "|"
            lbl44.Text = at(3)
        End If
        If (((at(4) + wt(4)) - (at(3) + wt(3) + bt(3))) = 0) Then
            prog15.ForeColor = setColor(p(4))
        Else
            lbl555.Text = "|"
            lbl55.Text = at(4)
        End If
    End Sub
End Class