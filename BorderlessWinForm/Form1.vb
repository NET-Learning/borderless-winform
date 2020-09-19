Public Class Frm_Main

    '/*
    '*
    '* NECESSARY PARAMS
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


End Class
