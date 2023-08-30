Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraSplashScreen
Imports System.Threading

Namespace WaitForm_SetDescription

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub btnShowWaitForm_Click(ByVal sender As Object, ByVal e As EventArgs)
            'Open Wait Form
            SplashScreenManager.ShowForm(Me, GetType(WaitForm1), True, True, False)
            'The Wait Form is opened in a separate thread. To change its Description, use the SetWaitFormDescription method.
            For i As Integer = 1 To 100
                Call SplashScreenManager.Default.SetWaitFormDescription(i.ToString() & "%")
                Thread.Sleep(25)
            Next

            'Close Wait Form
            SplashScreenManager.CloseForm(False)
        End Sub
    End Class
End Namespace
