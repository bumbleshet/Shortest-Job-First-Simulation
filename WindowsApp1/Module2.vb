Imports WindowsApp1.utility
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initializeTable()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        getData()
        processList = processList.OrderBy(Function(m) m.at).ThenBy(Function(m) m.bt).ToList()

        'processList.Sort(
        '    Function(x, y)
        '        If (x.bt.CompareTo(y.bt) = 0) Then
        '            Return x.at.CompareTo(y.at)
        '        Else
        '            Return x.bt.CompareTo(y.bt)
        '        End If
        '    End Function)
        'While (processList <> Nothing)

        'End While
        'MessageBox.Show(n)
        MessageBox.Show("List in sorted order: ")
        For Each a In processList

            If gantt > a.at Then
                'assign all greater tx  
                For Each b In processList
                    If gantt > b.at Then
                        readyQueue.Add(b)
                    End If
                Next
                readyQueue.Sort(Function(x, y) x.bt.CompareTo(y.bt))
                gantt = gantt + readyQueue(0).bt
            Else
                'kung magwait ang process
                gantt = gantt + (a.at - gantt) + a.bt
            End If

        Next
        'Dim i As Integer = 0

        'While (True)
        '    If (processList Is Nothing) Then
        '        Exit While
        '    ElseIf (gantt = processList(0).at) Then
        '        gantt = gantt + (processList(0).at - gantt) + processList(0).bt
        '        processList.Remove(processList(0))
        '    ElseIf (gantt > processList(0).at) Then
        '        gantt = gantt + processList(0).bt
        '        processList.Remove(processList(0))
        '    End If
        '    gantt += 1

        'End While
        MessageBox.Show(gantt)
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

        'check if input has duplicate at
        If (e.ColumnIndex = 0) Then
            For i = 0 To table1.Rows.Count - 1
                If (table1(0, i).Value = e.FormattedValue) Then
                    e.Cancel = True
                    Me.table1.Rows(e.RowIndex).ErrorText = "Duplicate Arrival Time"
                End If
            Next
        End If

    End Sub


    Public Sub getData()
        ' n = 0
        For i = 0 To table1.Rows.Count - 1
            Dim proc As New process
            proc.processNumber = i + 1
            proc.at = table1(0, i).Value
            proc.bt = table1(1, i).Value
            ' n = n + proc.bt
            processList.Add(proc)
        Next
    End Sub


    Public Sub initializeTable()
        table1.Rows.Add()
        table1.Rows.Add()
        table1.Rows.Add()
        table1.Rows.Add()
        table1.Rows.Add()
        table1.AllowUserToAddRows = False
    End Sub

End Class
Module utility
    Public Structure process
        Public processNumber As Integer
        Public at As Integer
        Public bt As Integer
    End Structure
    Public n As Integer
    Public gantt As Integer
    Public processList As New List(Of process)()
    Public templist As New List(Of process)()
    Public readyQueue As New List(Of process)()
