﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnquit = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnanswer3 = New System.Windows.Forms.RadioButton()
        Me.btnanswer1 = New System.Windows.Forms.RadioButton()
        Me.btnanswer4 = New System.Windows.Forms.RadioButton()
        Me.btnanswer2 = New System.Windows.Forms.RadioButton()
        Me.btnconfirm = New System.Windows.Forms.Button()
        Me.lblquestion = New System.Windows.Forms.Label()
        Me.btnhelp4 = New System.Windows.Forms.Button()
        Me.btnhelp3 = New System.Windows.Forms.Button()
        Me.btnhelp2 = New System.Windows.Forms.Button()
        Me.btnhelp1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Millionaire Game"
        '
        'btnquit
        '
        Me.btnquit.Location = New System.Drawing.Point(323, 507)
        Me.btnquit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnquit.Name = "btnquit"
        Me.btnquit.Size = New System.Drawing.Size(100, 28)
        Me.btnquit.TabIndex = 46
        Me.btnquit.Text = "Quit"
        Me.btnquit.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(491, 68)
        Me.lblScore.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(0, 17)
        Me.lblScore.TabIndex = 38
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnanswer3)
        Me.GroupBox2.Controls.Add(Me.btnanswer1)
        Me.GroupBox2.Controls.Add(Me.btnanswer4)
        Me.GroupBox2.Controls.Add(Me.btnanswer2)
        Me.GroupBox2.Location = New System.Drawing.Point(51, 326)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(789, 145)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'btnanswer3
        '
        Me.btnanswer3.AutoSize = True
        Me.btnanswer3.Location = New System.Drawing.Point(444, 39)
        Me.btnanswer3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnanswer3.Name = "btnanswer3"
        Me.btnanswer3.Size = New System.Drawing.Size(61, 21)
        Me.btnanswer3.TabIndex = 19
        Me.btnanswer3.TabStop = True
        Me.btnanswer3.Text = "Pluto"
        Me.btnanswer3.UseVisualStyleBackColor = True
        '
        'btnanswer1
        '
        Me.btnanswer1.AutoSize = True
        Me.btnanswer1.Location = New System.Drawing.Point(8, 39)
        Me.btnanswer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnanswer1.Name = "btnanswer1"
        Me.btnanswer1.Size = New System.Drawing.Size(80, 21)
        Me.btnanswer1.TabIndex = 17
        Me.btnanswer1.TabStop = True
        Me.btnanswer1.Text = "Mercury"
        Me.btnanswer1.UseVisualStyleBackColor = True
        '
        'btnanswer4
        '
        Me.btnanswer4.AutoSize = True
        Me.btnanswer4.Location = New System.Drawing.Point(444, 82)
        Me.btnanswer4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnanswer4.Name = "btnanswer4"
        Me.btnanswer4.Size = New System.Drawing.Size(71, 21)
        Me.btnanswer4.TabIndex = 20
        Me.btnanswer4.TabStop = True
        Me.btnanswer4.Text = "Saturn"
        Me.btnanswer4.UseVisualStyleBackColor = True
        '
        'btnanswer2
        '
        Me.btnanswer2.AutoSize = True
        Me.btnanswer2.Location = New System.Drawing.Point(8, 82)
        Me.btnanswer2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnanswer2.Name = "btnanswer2"
        Me.btnanswer2.Size = New System.Drawing.Size(69, 21)
        Me.btnanswer2.TabIndex = 18
        Me.btnanswer2.TabStop = True
        Me.btnanswer2.Text = "Venus"
        Me.btnanswer2.UseVisualStyleBackColor = True
        '
        'btnconfirm
        '
        Me.btnconfirm.Location = New System.Drawing.Point(191, 507)
        Me.btnconfirm.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnconfirm.Name = "btnconfirm"
        Me.btnconfirm.Size = New System.Drawing.Size(100, 28)
        Me.btnconfirm.TabIndex = 45
        Me.btnconfirm.Text = "Confirm"
        Me.btnconfirm.UseVisualStyleBackColor = True
        '
        'lblquestion
        '
        Me.lblquestion.BackColor = System.Drawing.Color.White
        Me.lblquestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblquestion.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblquestion.Location = New System.Drawing.Point(51, 118)
        Me.lblquestion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblquestion.Name = "lblquestion"
        Me.lblquestion.Size = New System.Drawing.Size(966, 123)
        Me.lblquestion.TabIndex = 44
        Me.lblquestion.Text = "Which planet is closest to the Sun?"
        '
        'btnhelp4
        '
        Me.btnhelp4.BackColor = System.Drawing.Color.Blue
        Me.btnhelp4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhelp4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhelp4.ForeColor = System.Drawing.Color.Yellow
        Me.btnhelp4.Location = New System.Drawing.Point(824, 267)
        Me.btnhelp4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnhelp4.Name = "btnhelp4"
        Me.btnhelp4.Size = New System.Drawing.Size(193, 52)
        Me.btnhelp4.TabIndex = 43
        Me.btnhelp4.Text = "Add Time"
        Me.btnhelp4.UseVisualStyleBackColor = False
        '
        'btnhelp3
        '
        Me.btnhelp3.BackColor = System.Drawing.Color.Blue
        Me.btnhelp3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhelp3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhelp3.ForeColor = System.Drawing.Color.Yellow
        Me.btnhelp3.Location = New System.Drawing.Point(563, 267)
        Me.btnhelp3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnhelp3.Name = "btnhelp3"
        Me.btnhelp3.Size = New System.Drawing.Size(224, 52)
        Me.btnhelp3.TabIndex = 42
        Me.btnhelp3.Text = "Stop Time"
        Me.btnhelp3.UseVisualStyleBackColor = False
        '
        'btnhelp2
        '
        Me.btnhelp2.BackColor = System.Drawing.Color.Blue
        Me.btnhelp2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhelp2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhelp2.ForeColor = System.Drawing.Color.Yellow
        Me.btnhelp2.Location = New System.Drawing.Point(308, 267)
        Me.btnhelp2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnhelp2.Name = "btnhelp2"
        Me.btnhelp2.Size = New System.Drawing.Size(213, 52)
        Me.btnhelp2.TabIndex = 40
        Me.btnhelp2.Text = "50/50"
        Me.btnhelp2.UseVisualStyleBackColor = False
        '
        'btnhelp1
        '
        Me.btnhelp1.BackColor = System.Drawing.Color.Blue
        Me.btnhelp1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhelp1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhelp1.ForeColor = System.Drawing.Color.Yellow
        Me.btnhelp1.Location = New System.Drawing.Point(51, 267)
        Me.btnhelp1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnhelp1.Name = "btnhelp1"
        Me.btnhelp1.Size = New System.Drawing.Size(224, 52)
        Me.btnhelp1.TabIndex = 39
        Me.btnhelp1.Text = "Show Answer"
        Me.btnhelp1.UseVisualStyleBackColor = False
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnquit)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnconfirm)
        Me.Controls.Add(Me.lblquestion)
        Me.Controls.Add(Me.btnhelp4)
        Me.Controls.Add(Me.btnhelp3)
        Me.Controls.Add(Me.btnhelp2)
        Me.Controls.Add(Me.btnhelp1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Game"
        Me.Text = "Form4"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnquit As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnanswer3 As RadioButton
    Friend WithEvents btnanswer1 As RadioButton
    Friend WithEvents btnanswer4 As RadioButton
    Friend WithEvents btnanswer2 As RadioButton
    Friend WithEvents btnconfirm As Button
    Friend WithEvents lblquestion As Label
    Friend WithEvents btnhelp4 As Button
    Friend WithEvents btnhelp3 As Button
    Friend WithEvents btnhelp2 As Button
    Friend WithEvents btnhelp1 As Button
End Class
