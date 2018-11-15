<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Custom
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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblCorrectAnswer = New System.Windows.Forms.Label()
        Me.lblIncorrect1 = New System.Windows.Forms.Label()
        Me.lblIncorrect2 = New System.Windows.Forms.Label()
        Me.lblIncorrect3 = New System.Windows.Forms.Label()
        Me.txtCorrect = New System.Windows.Forms.TextBox()
        Me.txtIncorrect2 = New System.Windows.Forms.TextBox()
        Me.txtIncorrect3 = New System.Windows.Forms.TextBox()
        Me.txtIncorrect1 = New System.Windows.Forms.TextBox()
        Me.txtQuestionPrompt = New System.Windows.Forms.TextBox()
        Me.btnSaveQuestion = New System.Windows.Forms.Button()
        Me.btnDiscard = New System.Windows.Forms.Button()
        Me.lblSavedQuestions = New System.Windows.Forms.Label()
        Me.listCustomQuestions = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.Location = New System.Drawing.Point(12, 9)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(113, 16)
        Me.lblPrompt.TabIndex = 4
        Me.lblPrompt.Text = "Question Prompt: "
        '
        'lblCorrectAnswer
        '
        Me.lblCorrectAnswer.AutoSize = True
        Me.lblCorrectAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectAnswer.Location = New System.Drawing.Point(12, 76)
        Me.lblCorrectAnswer.Name = "lblCorrectAnswer"
        Me.lblCorrectAnswer.Size = New System.Drawing.Size(101, 16)
        Me.lblCorrectAnswer.TabIndex = 5
        Me.lblCorrectAnswer.Text = "Correct Answer:"
        '
        'lblIncorrect1
        '
        Me.lblIncorrect1.AutoSize = True
        Me.lblIncorrect1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrect1.Location = New System.Drawing.Point(12, 102)
        Me.lblIncorrect1.Name = "lblIncorrect1"
        Me.lblIncorrect1.Size = New System.Drawing.Size(119, 16)
        Me.lblIncorrect1.TabIndex = 6
        Me.lblIncorrect1.Text = "Incorrect Answer 1:"
        '
        'lblIncorrect2
        '
        Me.lblIncorrect2.AutoSize = True
        Me.lblIncorrect2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrect2.Location = New System.Drawing.Point(12, 128)
        Me.lblIncorrect2.Name = "lblIncorrect2"
        Me.lblIncorrect2.Size = New System.Drawing.Size(119, 16)
        Me.lblIncorrect2.TabIndex = 7
        Me.lblIncorrect2.Text = "Incorrect Answer 2:"
        '
        'lblIncorrect3
        '
        Me.lblIncorrect3.AutoSize = True
        Me.lblIncorrect3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrect3.Location = New System.Drawing.Point(12, 154)
        Me.lblIncorrect3.Name = "lblIncorrect3"
        Me.lblIncorrect3.Size = New System.Drawing.Size(119, 16)
        Me.lblIncorrect3.TabIndex = 8
        Me.lblIncorrect3.Text = "Incorrect Answer 3:"
        '
        'txtCorrect
        '
        Me.txtCorrect.Location = New System.Drawing.Point(137, 76)
        Me.txtCorrect.Name = "txtCorrect"
        Me.txtCorrect.Size = New System.Drawing.Size(159, 20)
        Me.txtCorrect.TabIndex = 9
        '
        'txtIncorrect2
        '
        Me.txtIncorrect2.Location = New System.Drawing.Point(137, 127)
        Me.txtIncorrect2.Name = "txtIncorrect2"
        Me.txtIncorrect2.Size = New System.Drawing.Size(159, 20)
        Me.txtIncorrect2.TabIndex = 10
        '
        'txtIncorrect3
        '
        Me.txtIncorrect3.Location = New System.Drawing.Point(137, 153)
        Me.txtIncorrect3.Name = "txtIncorrect3"
        Me.txtIncorrect3.Size = New System.Drawing.Size(159, 20)
        Me.txtIncorrect3.TabIndex = 11
        '
        'txtIncorrect1
        '
        Me.txtIncorrect1.Location = New System.Drawing.Point(137, 101)
        Me.txtIncorrect1.Name = "txtIncorrect1"
        Me.txtIncorrect1.Size = New System.Drawing.Size(159, 20)
        Me.txtIncorrect1.TabIndex = 12
        '
        'txtQuestionPrompt
        '
        Me.txtQuestionPrompt.Location = New System.Drawing.Point(131, 12)
        Me.txtQuestionPrompt.Multiline = True
        Me.txtQuestionPrompt.Name = "txtQuestionPrompt"
        Me.txtQuestionPrompt.Size = New System.Drawing.Size(232, 57)
        Me.txtQuestionPrompt.TabIndex = 13
        '
        'btnSaveQuestion
        '
        Me.btnSaveQuestion.Location = New System.Drawing.Point(262, 179)
        Me.btnSaveQuestion.Name = "btnSaveQuestion"
        Me.btnSaveQuestion.Size = New System.Drawing.Size(101, 23)
        Me.btnSaveQuestion.TabIndex = 15
        Me.btnSaveQuestion.Text = "Save Question"
        Me.btnSaveQuestion.UseVisualStyleBackColor = True
        '
        'btnDiscard
        '
        Me.btnDiscard.Location = New System.Drawing.Point(137, 179)
        Me.btnDiscard.Name = "btnDiscard"
        Me.btnDiscard.Size = New System.Drawing.Size(101, 23)
        Me.btnDiscard.TabIndex = 16
        Me.btnDiscard.Text = "Discard Question"
        Me.btnDiscard.UseVisualStyleBackColor = True
        '
        'lblSavedQuestions
        '
        Me.lblSavedQuestions.AutoSize = True
        Me.lblSavedQuestions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavedQuestions.Location = New System.Drawing.Point(12, 215)
        Me.lblSavedQuestions.Name = "lblSavedQuestions"
        Me.lblSavedQuestions.Size = New System.Drawing.Size(114, 16)
        Me.lblSavedQuestions.TabIndex = 17
        Me.lblSavedQuestions.Text = "Saved Questions:"
        '
        'listCustomQuestions
        '
        Me.listCustomQuestions.FormattingEnabled = True
        Me.listCustomQuestions.Location = New System.Drawing.Point(29, 234)
        Me.listCustomQuestions.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.listCustomQuestions.Name = "listCustomQuestions"
        Me.listCustomQuestions.Size = New System.Drawing.Size(321, 108)
        Me.listCustomQuestions.TabIndex = 18
        '
        'Custom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 362)
        Me.Controls.Add(Me.listCustomQuestions)
        Me.Controls.Add(Me.lblSavedQuestions)
        Me.Controls.Add(Me.btnDiscard)
        Me.Controls.Add(Me.btnSaveQuestion)
        Me.Controls.Add(Me.txtQuestionPrompt)
        Me.Controls.Add(Me.txtIncorrect1)
        Me.Controls.Add(Me.txtIncorrect3)
        Me.Controls.Add(Me.txtIncorrect2)
        Me.Controls.Add(Me.txtCorrect)
        Me.Controls.Add(Me.lblIncorrect3)
        Me.Controls.Add(Me.lblIncorrect2)
        Me.Controls.Add(Me.lblIncorrect1)
        Me.Controls.Add(Me.lblCorrectAnswer)
        Me.Controls.Add(Me.lblPrompt)
        Me.Name = "Custom"
        Me.Text = "Custom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblCorrectAnswer As Label
    Friend WithEvents lblIncorrect1 As Label
    Friend WithEvents lblIncorrect2 As Label
    Friend WithEvents lblIncorrect3 As Label
    Friend WithEvents txtCorrect As TextBox
    Friend WithEvents txtIncorrect2 As TextBox
    Friend WithEvents txtIncorrect3 As TextBox
    Friend WithEvents txtIncorrect1 As TextBox
    Friend WithEvents txtQuestionPrompt As TextBox
    Friend WithEvents CustomQ As ListBox
    Friend WithEvents btnSaveQuestion As Button
    Friend WithEvents btnDiscard As Button
    Friend WithEvents lblSavedQuestions As Label
    Friend WithEvents listCustomQuestions As ListBox
End Class
