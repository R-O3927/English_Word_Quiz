Imports System
Imports System.Windows.Forms

Public Class EnglishWordQuizApp : Inherits Form

    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub EnglishWordQuizApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Visible = True

        Dim quiz As New QuizCls

        '問題文、クイズ、答えの定義と問題数カウントのための変数を宣言
        quiz.Arr_Main = {"次の単語を英語に訳して下さい。", "次の単語を日本語に訳して下さい。"}
        quiz.Arr_Quiz = {"犬", "猫", "家族", "学校", "趣味", "辞書", "図書館", "dog", "cat", "family", "school", "hobby", "dictionary", "library"}
        quiz.Arr_Answer = {"dog", "cat", "family", "school", "hobby", "dictionary", "library", "犬", "猫", "家族", "学校", "趣味", "辞書", "図書館"}
        quiz.Quiz_Count = 1

        '初期値
        Label_Count.Text = quiz.Quiz_Count.ToString
        Label_Quiz.Text = quiz.Arr_Quiz(quiz.Quiz_Count - 1)
        TextBox_Answer.Text = ""
        Label_CorrectAnswer.Text = quiz.Arr_Answer(quiz.Quiz_Count - 1)
        Label_CorrectOrIncorrect.Text = ""

        '表示、非表示
        Label_CorrectAnswer.Visible = False
        Label_CorrectOrIncorrect.Visible = False
        Button_NextQuiz.Visible = False
        Button_Exit.Visible = False

        '何問目かによって問題文を変える
        If quiz.Quiz_Count < 8 Then
            Label_Main.Text = quiz.Arr_Main(0)

        Else
            Label_Main.Text = quiz.Arr_Main(1)
        End If

    End Sub

    Private Sub Button_Answer_Click(sender As Object, e As EventArgs) Handles Button_Answer.Click

        '正誤判定
        If TextBox_Answer.Text = Label_CorrectAnswer.Text Then
            Label_CorrectOrIncorrect.Text = "〇"
            Label_CorrectOrIncorrect.ForeColor = Color.Red

        Else
            Label_CorrectOrIncorrect.Text = "×"
            Label_CorrectOrIncorrect.ForeColor = Color.Blue

        End If

        '表示、非表示
        Label_CorrectAnswer.Visible = True
        Label_CorrectOrIncorrect.Visible = True
        Button_NextQuiz.Visible = True
        Button_Exit.Visible = True


    End Sub

    Private Sub Button_NextQuiz_Click(sender As Object, e As EventArgs) Handles Button_NextQuiz.Click

        Dim quiz As New QuizCls

        '次の問題及び答えの取得（定義し直し）と問題数カウントアップ
        quiz.Arr_Main = {"次の単語を英語に訳して下さい。", "次の単語を日本語に訳して下さい。"}
        quiz.Arr_Quiz = {"犬", "猫", "家族", "学校", "趣味", "辞書", "図書館", "dog", "cat", "family", "school", "hobby", "dictionary", "library"}
        quiz.Arr_Answer = {"dog", "cat", "family", "school", "hobby", "dictionary", "library", "犬", "猫", "家族", "学校", "趣味", "辞書", "図書館"}
        quiz.Quiz_Count = CInt(Label_Count.Text) + 1

        '初期値
        Label_Count.Text = quiz.Quiz_Count.ToString
        Label_Quiz.Text = quiz.Arr_Quiz(quiz.Quiz_Count - 1)
        TextBox_Answer.Text = ""
        Label_CorrectAnswer.Text = quiz.Arr_Answer(quiz.Quiz_Count - 1)
        Label_CorrectOrIncorrect.Text = ""

        '表示、非表示
        Label_CorrectAnswer.Visible = False
        Label_CorrectOrIncorrect.Visible = False
        Button_NextQuiz.Visible = False
        Button_Exit.Visible = False

        '何問目かによって問題文を変える
        If quiz.Quiz_Count < 8 Then
            Label_Main.Text = quiz.Arr_Main(0)

        Else
            Label_Main.Text = quiz.Arr_Main(1)
        End If

    End Sub

    Private Sub Button_Exit_Click(sender As Object, e As EventArgs) Handles Button_Exit.Click

        Me.Visible = False

        Dim ef As New ExitForm
        ef.Show()

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub InitializeComponent()
        Label_Main = New Label()
        Label_Count = New Label()
        Label_Quiz = New Label()
        TextBox_Answer = New TextBox()
        Label_CorrectAnswer = New Label()
        Label_CorrectOrIncorrect = New Label()
        Button_Answer = New Button()
        Button_NextQuiz = New Button()
        Label_Item1 = New Label()
        Label_Item2 = New Label()
        Button_Exit = New Button()
        SuspendLayout()
        ' 
        ' Label_Main
        ' 
        Label_Main.Font = New Font("ＭＳ ゴシック", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label_Main.Location = New Point(136, 22)
        Label_Main.Name = "Label_Main"
        Label_Main.Size = New Size(628, 45)
        Label_Main.TabIndex = 0
        Label_Main.Text = "Label1"
        Label_Main.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label_Count
        ' 
        Label_Count.Font = New Font("ＭＳ ゴシック", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label_Count.Location = New Point(136, 104)
        Label_Count.Name = "Label_Count"
        Label_Count.Size = New Size(37, 52)
        Label_Count.TabIndex = 1
        Label_Count.Text = "Label2"
        Label_Count.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label_Quiz
        ' 
        Label_Quiz.Font = New Font("ＭＳ ゴシック", 14.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label_Quiz.Location = New Point(110, 196)
        Label_Quiz.Name = "Label_Quiz"
        Label_Quiz.Size = New Size(183, 65)
        Label_Quiz.TabIndex = 2
        Label_Quiz.Text = "Label3"
        Label_Quiz.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TextBox_Answer
        ' 
        TextBox_Answer.Font = New Font("ＭＳ ゴシック", 14.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        TextBox_Answer.Location = New Point(466, 211)
        TextBox_Answer.Name = "TextBox_Answer"
        TextBox_Answer.Size = New Size(345, 35)
        TextBox_Answer.TabIndex = 3
        TextBox_Answer.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label_CorrectAnswer
        ' 
        Label_CorrectAnswer.Font = New Font("ＭＳ ゴシック", 14.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label_CorrectAnswer.Location = New Point(353, 304)
        Label_CorrectAnswer.Name = "Label_CorrectAnswer"
        Label_CorrectAnswer.Size = New Size(194, 72)
        Label_CorrectAnswer.TabIndex = 4
        Label_CorrectAnswer.Text = "Label4"
        Label_CorrectAnswer.TextAlign = ContentAlignment.MiddleCenter
        Label_CorrectAnswer.Visible = False
        ' 
        ' Label_CorrectOrIncorrect
        ' 
        Label_CorrectOrIncorrect.Font = New Font("ＭＳ ゴシック", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label_CorrectOrIncorrect.Location = New Point(571, 299)
        Label_CorrectOrIncorrect.Name = "Label_CorrectOrIncorrect"
        Label_CorrectOrIncorrect.Size = New Size(193, 118)
        Label_CorrectOrIncorrect.TabIndex = 5
        Label_CorrectOrIncorrect.Text = "Label5"
        Label_CorrectOrIncorrect.TextAlign = ContentAlignment.MiddleCenter
        Label_CorrectOrIncorrect.Visible = False
        ' 
        ' Button_Answer
        ' 
        Button_Answer.BackColor = SystemColors.InactiveCaption
        Button_Answer.Font = New Font("ＭＳ ゴシック", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button_Answer.Location = New Point(110, 299)
        Button_Answer.Name = "Button_Answer"
        Button_Answer.Size = New Size(161, 84)
        Button_Answer.TabIndex = 6
        Button_Answer.Text = "回答"
        Button_Answer.UseVisualStyleBackColor = False
        ' 
        ' Button_NextQuiz
        ' 
        Button_NextQuiz.BackColor = SystemColors.InactiveCaption
        Button_NextQuiz.Font = New Font("ＭＳ ゴシック", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button_NextQuiz.Location = New Point(614, 88)
        Button_NextQuiz.Name = "Button_NextQuiz"
        Button_NextQuiz.Size = New Size(257, 84)
        Button_NextQuiz.TabIndex = 7
        Button_NextQuiz.Text = "次の問題へ"
        Button_NextQuiz.UseVisualStyleBackColor = False
        Button_NextQuiz.Visible = False
        ' 
        ' Label_Item1
        ' 
        Label_Item1.Font = New Font("ＭＳ ゴシック", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label_Item1.Location = New Point(70, 111)
        Label_Item1.Name = "Label_Item1"
        Label_Item1.Size = New Size(60, 38)
        Label_Item1.TabIndex = 8
        Label_Item1.Text = "第"
        Label_Item1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label_Item2
        ' 
        Label_Item2.Font = New Font("ＭＳ ゴシック", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Label_Item2.Location = New Point(179, 111)
        Label_Item2.Name = "Label_Item2"
        Label_Item2.Size = New Size(52, 38)
        Label_Item2.TabIndex = 9
        Label_Item2.Text = "問"
        Label_Item2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button_Exit
        ' 
        Button_Exit.BackColor = SystemColors.InactiveCaption
        Button_Exit.Font = New Font("ＭＳ ゴシック", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button_Exit.Location = New Point(596, 462)
        Button_Exit.Name = "Button_Exit"
        Button_Exit.Size = New Size(257, 84)
        Button_Exit.TabIndex = 10
        Button_Exit.Text = "終了"
        Button_Exit.UseVisualStyleBackColor = False
        Button_Exit.Visible = False
        ' 
        ' EnglishWordQuizApp
        ' 
        BackColor = Color.PaleTurquoise
        ClientSize = New Size(883, 590)
        Controls.Add(Button_Exit)
        Controls.Add(Label_Item2)
        Controls.Add(Label_Item1)
        Controls.Add(Button_NextQuiz)
        Controls.Add(Button_Answer)
        Controls.Add(Label_CorrectOrIncorrect)
        Controls.Add(Label_CorrectAnswer)
        Controls.Add(TextBox_Answer)
        Controls.Add(Label_Quiz)
        Controls.Add(Label_Count)
        Controls.Add(Label_Main)
        Name = "EnglishWordQuizApp"
        Text = "英単語アプリ"
        ResumeLayout(False)
        PerformLayout()

    End Sub


    Friend WithEvents Label_Count As Label
    Friend WithEvents Label_Quiz As Label
    Friend WithEvents TextBox_Answer As TextBox
    Friend WithEvents Label_CorrectAnswer As Label
    Friend WithEvents Label_CorrectOrIncorrect As Label
    Friend WithEvents Button_Answer As Button
    Friend WithEvents Button_NextQuiz As Button
    Private components As System.ComponentModel.IContainer
    Friend WithEvents Label_Item1 As Label
    Friend WithEvents Label_Item2 As Label
    Friend WithEvents Button_Exit As Button

    Friend WithEvents Label_Main As Label

End Class
