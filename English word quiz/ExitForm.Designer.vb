<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExitForm
    Inherits System.Windows.Forms.Form

    Public Sub New()

        InitializeComponent()

    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click

        Dim mf As New EnglishWordQuizApp

        Me.Close()
        Application.Exit()

    End Sub



    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label_Main = New Label()
        Button_Close = New Button()
        SuspendLayout()
        ' 
        ' Label_Main
        ' 
        Label_Main.Font = New Font("ＭＳ ゴシック", 16.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label_Main.Location = New Point(155, 144)
        Label_Main.Name = "Label_Main"
        Label_Main.Size = New Size(582, 126)
        Label_Main.TabIndex = 0
        Label_Main.Text = "お疲れ様でした。「アプリを閉じる」ボタンでアプリを終了します。"
        Label_Main.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button_Close
        ' 
        Button_Close.BackColor = SystemColors.InactiveCaption
        Button_Close.Font = New Font("ＭＳ ゴシック", 14.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        Button_Close.Location = New Point(287, 328)
        Button_Close.Name = "Button_Close"
        Button_Close.Size = New Size(295, 91)
        Button_Close.TabIndex = 1
        Button_Close.Text = "アプリを閉じる"
        Button_Close.UseVisualStyleBackColor = False
        ' 
        ' ExitForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(869, 527)
        Controls.Add(Button_Close)
        Controls.Add(Label_Main)
        Name = "ExitForm"
        Text = "英単語アプリ"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label_Main As Label
    Friend WithEvents Button_Close As Button
End Class
