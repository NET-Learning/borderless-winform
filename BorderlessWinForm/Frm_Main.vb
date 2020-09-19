Imports System.Runtime.InteropServices

Public Class Frm_Main

    '/*
    '*
    '* NECESSARY PARAMS
    '*
    '*/

    ' Movement params
    Private IsFormMoving As Boolean = False
    Private MouseX As Integer
    Private MouseY As Integer
    ' Shadow WinForm
    Private Const CS_DROPSHADOW As Integer = 131072

    ' Override the CreateParams property
    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim vCreateParams As CreateParams = MyBase.CreateParams
            ' Check OS Before using XP drop shadow
            Dim OSVersion As Version = System.Environment.OSVersion.Version()
            ' Select case...
            Select Case OSVersion.Major
                Case Is < 5
                Case 5
                    If OSVersion.Minor > 0 Then
                        vCreateParams.ClassStyle = vCreateParams.ClassStyle Or CS_DROPSHADOW
                    End If
                Case Is > 5
                    vCreateParams.ClassStyle = vCreateParams.ClassStyle Or CS_DROPSHADOW
                Case Else
            End Select
            ' Return value
            Return vCreateParams
        End Get
    End Property

    '/*
    '*
    '* INIT COMPONENT
    '*
    '*/

    Private Sub Frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Center main label
        Me.Lbl_Main_Name.Left = (Me.Lbl_Main_Name.Parent.Width / 2) - (Me.Lbl_Main_Name.Width / 2)
    End Sub

    Private Sub Btn_Main_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Main_Exit.Click
        ' Close application
        Me.Close()
    End Sub


    '/*
    '*
    '* INIT MOVEMENT
    '*
    '*/

    Private Sub PanelGradient1_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelGradient1.MouseDown
        ' If...
        If e.Button = MouseButtons.Left Then
            ' Change values
            IsFormMoving = True
            Me.MouseX = Cursor.Position.X - Left
            Me.MouseY = Cursor.Position.Y - Top
        End If
    End Sub

    Private Sub PanelGradient1_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelGradient1.MouseMove
        ' If...
        If IsFormMoving = True Then
            ' Change values
            Me.Left = Cursor.Position.X - Me.MouseX
            Me.Top = Cursor.Position.Y - Me.MouseY
        End If
    End Sub

    Private Sub PanelGradient1_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelGradient1.MouseUp
        ' Change values
        IsFormMoving = False
    End Sub


    Private Sub Frm_Main_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ' Add border to the form
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.DarkOrange, ButtonBorderStyle.Solid)
    End Sub

End Class
