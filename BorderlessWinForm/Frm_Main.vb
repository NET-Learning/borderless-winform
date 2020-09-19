Public Class Frm_Main

    '/*
    '*
    '* NECESSARY PARAMS
    '*
    '*/

    ' Movement params
    Dim IsFormMoving As Boolean = False
    Dim MouseX As Integer
    Dim MouseY As Integer

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

End Class
