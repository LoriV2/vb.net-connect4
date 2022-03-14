<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.Grid1 = New connect4.Grid()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTurn = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlButtons
        '
        Me.pnlButtons.Location = New System.Drawing.Point(14, 14)
        Me.pnlButtons.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(467, 57)
        Me.pnlButtons.TabIndex = 1
        '
        'Grid1
        '
        Me.Grid1.Location = New System.Drawing.Point(14, 78)
        Me.Grid1.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Grid1.Name = "Grid1"
        Me.Grid1.Size = New System.Drawing.Size(402, 406)
        Me.Grid1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTurn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnNewGame)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Location = New System.Drawing.Point(488, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(360, 526)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info"
        '
        'txtTurn
        '
        Me.txtTurn.AutoSize = True
        Me.txtTurn.Location = New System.Drawing.Point(59, 31)
        Me.txtTurn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtTurn.Name = "txtTurn"
        Me.txtTurn.Size = New System.Drawing.Size(0, 15)
        Me.txtTurn.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Turn:"
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(266, 493)
        Me.btnNewGame.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(88, 27)
        Me.btnNewGame.TabIndex = 1
        Me.btnNewGame.Text = "New Game!"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(10, 493)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(88, 27)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "Reset!"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(862, 554)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.Grid1)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmMain"
        Me.Text = "Connect Four / Four On A Row"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grid1 As connect4.Grid
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTurn As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
