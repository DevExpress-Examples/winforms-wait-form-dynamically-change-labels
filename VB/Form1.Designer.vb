Imports Microsoft.VisualBasic
Imports System
Namespace WaitForm_SetDescription
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim splashScreenManager1 As New DevExpress.XtraSplashScreen.SplashScreenManager(Me, Nothing, True, True)
			Me.btnShowWaitForm = New DevExpress.XtraEditors.SimpleButton()
			Me.SuspendLayout()
			' 
			' btnShowWaitForm
			' 
			Me.btnShowWaitForm.Location = New System.Drawing.Point(12, 12)
			Me.btnShowWaitForm.Name = "btnShowWaitForm"
			Me.btnShowWaitForm.Size = New System.Drawing.Size(128, 31)
			Me.btnShowWaitForm.TabIndex = 0
			Me.btnShowWaitForm.Text = "Show Wait Form"
'			Me.btnShowWaitForm.Click += New System.EventHandler(Me.btnShowWaitForm_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(616, 463)
			Me.Controls.Add(Me.btnShowWaitForm)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents btnShowWaitForm As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace

