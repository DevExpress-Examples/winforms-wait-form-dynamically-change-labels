Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen
Imports System.Threading

Namespace WaitForm_SetDescription
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnShowWaitForm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnShowWaitForm.Click
			'Open Wait Form
			SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)

			'The Wait Form is opened in a separate thread. To change its Description, use the SetWaitFormDescription method.
			For i As Integer = 1 To 100
				SplashScreenManager.Default.SetWaitFormDescription(i.ToString() & "%")
				Thread.Sleep(25)
			Next i

			'Close Wait Form
			SplashScreenManager.CloseForm(False)
		End Sub
	End Class
End Namespace
