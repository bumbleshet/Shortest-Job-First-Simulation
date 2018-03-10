<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lb5 = New System.Windows.Forms.Label()
        Me.lb4 = New System.Windows.Forms.Label()
        Me.lb3 = New System.Windows.Forms.Label()
        Me.lb2 = New System.Windows.Forms.Label()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.table1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBoxWt = New System.Windows.Forms.TextBox()
        Me.txtBoxTa = New System.Windows.Forms.TextBox()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.progressbar2 = New System.ComponentModel.BackgroundWorker()
        Me.prog1 = New System.Windows.Forms.ProgressBar()
        Me.prog2 = New System.Windows.Forms.ProgressBar()
        Me.prog3 = New System.Windows.Forms.ProgressBar()
        Me.prog5 = New System.Windows.Forms.ProgressBar()
        Me.prog4 = New System.Windows.Forms.ProgressBar()
        Me.prog15 = New System.Windows.Forms.ProgressBar()
        Me.prog14 = New System.Windows.Forms.ProgressBar()
        Me.prog13 = New System.Windows.Forms.ProgressBar()
        Me.prog12 = New System.Windows.Forms.ProgressBar()
        Me.prog11 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.max = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl25 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.lbl115 = New System.Windows.Forms.Label()
        Me.lbl22 = New System.Windows.Forms.Label()
        Me.lbl225 = New System.Windows.Forms.Label()
        Me.lbl33 = New System.Windows.Forms.Label()
        Me.lbl335 = New System.Windows.Forms.Label()
        Me.lbl44 = New System.Windows.Forms.Label()
        Me.lbl445 = New System.Windows.Forms.Label()
        Me.lbl55 = New System.Windows.Forms.Label()
        Me.lbl555 = New System.Windows.Forms.Label()
        CType(Me.table1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'lb5
        '
        Me.lb5.AutoSize = True
        Me.lb5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb5.ForeColor = System.Drawing.Color.Chocolate
        Me.lb5.Location = New System.Drawing.Point(26, 338)
        Me.lb5.Name = "lb5"
        Me.lb5.Size = New System.Drawing.Size(0, 13)
        Me.lb5.TabIndex = 19
        '
        'lb4
        '
        Me.lb4.AutoSize = True
        Me.lb4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb4.ForeColor = System.Drawing.Color.Magenta
        Me.lb4.Location = New System.Drawing.Point(26, 313)
        Me.lb4.Name = "lb4"
        Me.lb4.Size = New System.Drawing.Size(0, 13)
        Me.lb4.TabIndex = 18
        '
        'lb3
        '
        Me.lb3.AutoSize = True
        Me.lb3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb3.ForeColor = System.Drawing.Color.ForestGreen
        Me.lb3.Location = New System.Drawing.Point(26, 291)
        Me.lb3.Name = "lb3"
        Me.lb3.Size = New System.Drawing.Size(0, 13)
        Me.lb3.TabIndex = 17
        '
        'lb2
        '
        Me.lb2.AutoSize = True
        Me.lb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb2.ForeColor = System.Drawing.Color.Crimson
        Me.lb2.Location = New System.Drawing.Point(26, 268)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(0, 13)
        Me.lb2.TabIndex = 16
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.BackColor = System.Drawing.SystemColors.Window
        Me.lb1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lb1.Location = New System.Drawing.Point(26, 243)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(0, 13)
        Me.lb1.TabIndex = 15
        '
        'table1
        '
        Me.table1.AllowUserToAddRows = False
        Me.table1.AllowUserToResizeColumns = False
        Me.table1.AllowUserToResizeRows = False
        Me.table1.BackgroundColor = System.Drawing.Color.White
        Me.table1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.table1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.table1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.table1.Location = New System.Drawing.Point(63, 214)
        Me.table1.Name = "table1"
        Me.table1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.table1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.table1.Size = New System.Drawing.Size(561, 171)
        Me.table1.TabIndex = 14
        '
        'Column1
        '
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "At"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Bt"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Wt"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tt"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Rt"
        Me.Column5.Name = "Column5"
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(266, 162)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 21
        Me.btn1.Text = "Start"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(353, 162)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 23)
        Me.btn3.TabIndex = 22
        Me.btn3.Text = "Stop"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(368, 52)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(59, 31)
        Me.lblTime.TabIndex = 23
        Me.lblTime.Text = "000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(649, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Average Waiting Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(630, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Average Turn Around Time"
        '
        'txtBoxWt
        '
        Me.txtBoxWt.Location = New System.Drawing.Point(661, 241)
        Me.txtBoxWt.Name = "txtBoxWt"
        Me.txtBoxWt.ReadOnly = True
        Me.txtBoxWt.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxWt.TabIndex = 26
        '
        'txtBoxTa
        '
        Me.txtBoxTa.Location = New System.Drawing.Point(661, 308)
        Me.txtBoxTa.Name = "txtBoxTa"
        Me.txtBoxTa.ReadOnly = True
        Me.txtBoxTa.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxTa.TabIndex = 27
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(437, 162)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(75, 23)
        Me.btn4.TabIndex = 28
        Me.btn4.Text = "Reset"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(661, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Go back to input"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'prog1
        '
        Me.prog1.Location = New System.Drawing.Point(125, 91)
        Me.prog1.Name = "prog1"
        Me.prog1.Size = New System.Drawing.Size(85, 23)
        Me.prog1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prog1.TabIndex = 37
        '
        'prog2
        '
        Me.prog2.Location = New System.Drawing.Point(238, 91)
        Me.prog2.Name = "prog2"
        Me.prog2.Size = New System.Drawing.Size(85, 23)
        Me.prog2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prog2.TabIndex = 38
        '
        'prog3
        '
        Me.prog3.Location = New System.Drawing.Point(359, 91)
        Me.prog3.Name = "prog3"
        Me.prog3.Size = New System.Drawing.Size(85, 23)
        Me.prog3.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prog3.TabIndex = 39
        '
        'prog5
        '
        Me.prog5.Location = New System.Drawing.Point(584, 91)
        Me.prog5.Name = "prog5"
        Me.prog5.Size = New System.Drawing.Size(85, 23)
        Me.prog5.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prog5.TabIndex = 40
        '
        'prog4
        '
        Me.prog4.Location = New System.Drawing.Point(471, 91)
        Me.prog4.Name = "prog4"
        Me.prog4.Size = New System.Drawing.Size(85, 23)
        Me.prog4.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prog4.TabIndex = 41
        '
        'prog15
        '
        Me.prog15.ForeColor = System.Drawing.Color.Lime
        Me.prog15.Location = New System.Drawing.Point(554, 91)
        Me.prog15.Name = "prog15"
        Me.prog15.Size = New System.Drawing.Size(31, 23)
        Me.prog15.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prog15.TabIndex = 42
        '
        'prog14
        '
        Me.prog14.ForeColor = System.Drawing.Color.Lime
        Me.prog14.Location = New System.Drawing.Point(441, 91)
        Me.prog14.Name = "prog14"
        Me.prog14.Size = New System.Drawing.Size(31, 23)
        Me.prog14.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prog14.TabIndex = 43
        '
        'prog13
        '
        Me.prog13.ForeColor = System.Drawing.Color.Lime
        Me.prog13.Location = New System.Drawing.Point(321, 91)
        Me.prog13.Name = "prog13"
        Me.prog13.Size = New System.Drawing.Size(40, 23)
        Me.prog13.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prog13.TabIndex = 44
        '
        'prog12
        '
        Me.prog12.ForeColor = System.Drawing.Color.Lime
        Me.prog12.Location = New System.Drawing.Point(208, 91)
        Me.prog12.Name = "prog12"
        Me.prog12.Size = New System.Drawing.Size(31, 23)
        Me.prog12.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prog12.TabIndex = 45
        '
        'prog11
        '
        Me.prog11.BackColor = System.Drawing.Color.White
        Me.prog11.ForeColor = System.Drawing.Color.Lime
        Me.prog11.Location = New System.Drawing.Point(96, 91)
        Me.prog11.Name = "prog11"
        Me.prog11.Size = New System.Drawing.Size(31, 23)
        Me.prog11.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prog11.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(9, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "|"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "0"
        '
        'max
        '
        Me.max.AutoSize = True
        Me.max.Location = New System.Drawing.Point(662, 123)
        Me.max.Name = "max"
        Me.max.Size = New System.Drawing.Size(13, 13)
        Me.max.TabIndex = 48
        Me.max.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(664, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(9, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "|"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(202, 124)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(13, 13)
        Me.lbl2.TabIndex = 50
        Me.lbl2.Text = "0"
        '
        'lbl25
        '
        Me.lbl25.AutoSize = True
        Me.lbl25.Location = New System.Drawing.Point(204, 112)
        Me.lbl25.Name = "lbl25"
        Me.lbl25.Size = New System.Drawing.Size(9, 13)
        Me.lbl25.TabIndex = 51
        Me.lbl25.Text = "|"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(316, 124)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(13, 13)
        Me.lbl3.TabIndex = 52
        Me.lbl3.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(318, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(9, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "|"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(435, 124)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(13, 13)
        Me.lbl4.TabIndex = 54
        Me.lbl4.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(437, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(9, 13)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "|"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(549, 123)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(13, 13)
        Me.lbl5.TabIndex = 56
        Me.lbl5.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(551, 111)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(9, 13)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "|"
        '
        'lbl11
        '
        Me.lbl11.AutoSize = True
        Me.lbl11.Location = New System.Drawing.Point(120, 124)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(0, 13)
        Me.lbl11.TabIndex = 58
        '
        'lbl115
        '
        Me.lbl115.AutoSize = True
        Me.lbl115.Location = New System.Drawing.Point(122, 112)
        Me.lbl115.Name = "lbl115"
        Me.lbl115.Size = New System.Drawing.Size(0, 13)
        Me.lbl115.TabIndex = 59
        '
        'lbl22
        '
        Me.lbl22.AutoSize = True
        Me.lbl22.Location = New System.Drawing.Point(232, 124)
        Me.lbl22.Name = "lbl22"
        Me.lbl22.Size = New System.Drawing.Size(0, 13)
        Me.lbl22.TabIndex = 60
        '
        'lbl225
        '
        Me.lbl225.AutoSize = True
        Me.lbl225.Location = New System.Drawing.Point(234, 112)
        Me.lbl225.Name = "lbl225"
        Me.lbl225.Size = New System.Drawing.Size(0, 13)
        Me.lbl225.TabIndex = 61
        '
        'lbl33
        '
        Me.lbl33.AutoSize = True
        Me.lbl33.Location = New System.Drawing.Point(355, 124)
        Me.lbl33.Name = "lbl33"
        Me.lbl33.Size = New System.Drawing.Size(0, 13)
        Me.lbl33.TabIndex = 62
        '
        'lbl335
        '
        Me.lbl335.AutoSize = True
        Me.lbl335.Location = New System.Drawing.Point(357, 112)
        Me.lbl335.Name = "lbl335"
        Me.lbl335.Size = New System.Drawing.Size(0, 13)
        Me.lbl335.TabIndex = 63
        '
        'lbl44
        '
        Me.lbl44.AutoSize = True
        Me.lbl44.Location = New System.Drawing.Point(465, 124)
        Me.lbl44.Name = "lbl44"
        Me.lbl44.Size = New System.Drawing.Size(0, 13)
        Me.lbl44.TabIndex = 64
        '
        'lbl445
        '
        Me.lbl445.AutoSize = True
        Me.lbl445.Location = New System.Drawing.Point(467, 112)
        Me.lbl445.Name = "lbl445"
        Me.lbl445.Size = New System.Drawing.Size(0, 13)
        Me.lbl445.TabIndex = 65
        '
        'lbl55
        '
        Me.lbl55.AutoSize = True
        Me.lbl55.Location = New System.Drawing.Point(578, 124)
        Me.lbl55.Name = "lbl55"
        Me.lbl55.Size = New System.Drawing.Size(0, 13)
        Me.lbl55.TabIndex = 66
        '
        'lbl555
        '
        Me.lbl555.AutoSize = True
        Me.lbl555.Location = New System.Drawing.Point(580, 112)
        Me.lbl555.Name = "lbl555"
        Me.lbl555.Size = New System.Drawing.Size(0, 13)
        Me.lbl555.TabIndex = 67
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(793, 409)
        Me.Controls.Add(Me.lbl44)
        Me.Controls.Add(Me.lbl33)
        Me.Controls.Add(Me.lbl22)
        Me.Controls.Add(Me.lbl11)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.max)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.prog12)
        Me.Controls.Add(Me.prog15)
        Me.Controls.Add(Me.prog14)
        Me.Controls.Add(Me.prog13)
        Me.Controls.Add(Me.prog11)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.txtBoxTa)
        Me.Controls.Add(Me.txtBoxWt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lb5)
        Me.Controls.Add(Me.lb4)
        Me.Controls.Add(Me.lb3)
        Me.Controls.Add(Me.lb2)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.table1)
        Me.Controls.Add(Me.prog5)
        Me.Controls.Add(Me.prog4)
        Me.Controls.Add(Me.prog3)
        Me.Controls.Add(Me.prog2)
        Me.Controls.Add(Me.prog1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl25)
        Me.Controls.Add(Me.lbl55)
        Me.Controls.Add(Me.lbl555)
        Me.Controls.Add(Me.lbl445)
        Me.Controls.Add(Me.lbl335)
        Me.Controls.Add(Me.lbl225)
        Me.Controls.Add(Me.lbl115)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        CType(Me.table1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lb5 As Label
    Friend WithEvents lb4 As Label
    Friend WithEvents lb3 As Label
    Friend WithEvents lb2 As Label
    Friend WithEvents lb1 As Label
    Friend WithEvents table1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents btn1 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents lblTime As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBoxWt As TextBox
    Friend WithEvents txtBoxTa As TextBox
    Friend WithEvents btn4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents progressbar2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents prog1 As ProgressBar
    Friend WithEvents prog2 As ProgressBar
    Friend WithEvents prog3 As ProgressBar
    Friend WithEvents prog5 As ProgressBar
    Friend WithEvents prog4 As ProgressBar
    Friend WithEvents prog15 As ProgressBar
    Friend WithEvents prog14 As ProgressBar
    Friend WithEvents prog13 As ProgressBar
    Friend WithEvents prog12 As ProgressBar
    Friend WithEvents prog11 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents max As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl25 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lbl11 As Label
    Friend WithEvents lbl115 As Label
    Friend WithEvents lbl22 As Label
    Friend WithEvents lbl225 As Label
    Friend WithEvents lbl33 As Label
    Friend WithEvents lbl335 As Label
    Friend WithEvents lbl44 As Label
    Friend WithEvents lbl445 As Label
    Friend WithEvents lbl55 As Label
    Friend WithEvents lbl555 As Label
End Class
