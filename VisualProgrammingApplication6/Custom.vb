Public Class Custom
    Private objCustomQuestions As New ArrayList

    Private strPrompt As String
    Private strCorrect As String
    Private strIncorrect1 As String
    Private strIncorrect2 As String
    Private strIncorrect3 As String

    Public Sub DisplayCustomQuestion(custom As Custom)
        txtQuestionPrompt.Text = custom.strPrompt
        txtCorrect.Text = custom.strCorrect
        txtIncorrect1.Text = custom.strIncorrect1
        txtIncorrect2.Text = custom.strIncorrect2
        txtIncorrect3.Text = custom.strIncorrect3

    End Sub


    Private Sub ClearList()
        'Clear the list
        ' AryCustom.Items.Clear()
    End Sub



    Public Sub CreateCustomQuestion(Prompt As String, Correct As String,
                                   Incorrect1 As String, Incorrect2 As String,
                                   Incorrect3 As String)
        Dim objNewCustomQuestion As Custom

#Disable Warning BC42104 ' Variable is used before it has been assigned a value
        objNewCustomQuestion.strPrompt = Prompt
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
        objNewCustomQuestion.strCorrect = Correct
        objNewCustomQuestion.strIncorrect1 = Incorrect1
        objNewCustomQuestion.strIncorrect2 = Incorrect2
        objNewCustomQuestion.strIncorrect3 = Incorrect3

        objCustomQuestions.Add(objNewCustomQuestion)

        listCustomQuestions.Items.Add(objNewCustomQuestion)
    End Sub



    Private Sub btnSaveQuestion_Click(sender As Object, e As EventArgs) Handles btnSaveQuestion.Click
        Dim objCustom As Custom
        'DisplayCustomQuestion(objCustom)



        CreateCustomQuestion("When is the best time to wear a striped sweater?", "All the time", "Sometimes", "Never", "More often than not")
        Dim objFoundPrompt As Custom = objCustomQuestions(txtQuestionPrompt.Text)
        If Not IsNothing(objFoundPrompt.strPrompt) Then
            MessageBox.Show("The Prompt is :" & objFoundPrompt.Name, "Custom Questions")
        Else
            MessageBox.Show("There is no Custom Question with this Prompt" & txtQuestionPrompt.Text & ".", "Custom Questions")
        End If
        Dim objFoundCorrectAnswer As Custom = objCustomQuestions(txtCorrect.Text)
        If Not IsNothing(objFoundCorrectAnswer.strCorrect) Then
            MessageBox.Show("The Correct Answer is :" & objFoundCorrectAnswer.Name, "Custom Questions")
        Else
            MessageBox.Show("There is no Custom Question with this correct Answer" & txtCorrect.Text & ".", "Custom Questions")
        End If
        Dim objFoundIncorrectAnswer1 As Custom = objCustomQuestions(txtIncorrect1.Text)
        If Not IsNothing(objFoundIncorrectAnswer1.strCorrect) Then
            MessageBox.Show("The inCorrect Answer is :" & objFoundIncorrectAnswer1.Name, "Custom Questions")
        Else
            MessageBox.Show("There is no Custom Question with this incorrect Answer" & txtIncorrect1.Text & ".", "Custom Questions")
        End If
        Dim objFoundIncorrectAnswer2 As Custom = objCustomQuestions(txtIncorrect2.Text)
        If Not IsNothing(objFoundIncorrectAnswer2.strCorrect) Then
            MessageBox.Show("The inCorrect Answer is :" & objFoundIncorrectAnswer2.Name, "Custom Questions")
        Else
            MessageBox.Show("There is no Custom Question with this incorrect Answer" & txtIncorrect2.Text & ".", "Custom Questions")
        End If
        Dim objFoundIncorrectAnswer3 As Custom = objCustomQuestions(txtIncorrect3.Text)
        If Not IsNothing(objFoundIncorrectAnswer3.strCorrect) Then
            MessageBox.Show("The inCorrect Answer is :" & objFoundIncorrectAnswer3.Name, "Custom Questions")
        Else
            MessageBox.Show("There is no Custom Question with this incorrect Answer" & txtIncorrect3.Text & ".", "Custom Questions")
        End If
    End Sub



    Public Overrides Function ToString() As String
        Return strPrompt & " (" & strCorrect & strIncorrect1 & strIncorrect2 & strIncorrect3 & ")"
    End Function

    Private Sub listCustomQuestions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listCustomQuestions.SelectedIndexChanged
        Dim objCustom As Custom

        '        DisplayCustomQuestion(objCustom)

    End Sub
End Class