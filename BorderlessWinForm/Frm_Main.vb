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
        ' Set style to resizable
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
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

    '/*
    '*
    '* INIT PAINT
    '*
    '*/

    Private Sub Frm_Main_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ' Add border to the form
        ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.DarkOrange, ButtonBorderStyle.Solid)
    End Sub



    '/*
    '*
    '* INIT RESIZE API
    '*
    '*/

    Private Const HTLEFT As Integer = 10, HTRIGHT As Integer = 11, HTTOP As Integer = 12, HTTOPLEFT As Integer = 13, HTTOPRIGHT As Integer = 14, HTBOTTOM As Integer = 15, HTBOTTOMLEFT As Integer = 16, HTBOTTOMRIGHT As Integer = 17

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        MyBase.WndProc(m)
        If m.Msg = &H84 Then
            Dim mp = Me.PointToClient(Cursor.Position)

            If TopLeft.Contains(mp) Then
                m.Result = CType(HTTOPLEFT, IntPtr)
            ElseIf TopRight.Contains(mp) Then
                m.Result = CType(HTTOPRIGHT, IntPtr)
            ElseIf BottomLeft.Contains(mp) Then
                m.Result = CType(HTBOTTOMLEFT, IntPtr)
            ElseIf BottomRight.Contains(mp) Then
                m.Result = CType(HTBOTTOMRIGHT, IntPtr)
            ElseIf TopY.Contains(mp) Then
                m.Result = CType(HTTOP, IntPtr)
            ElseIf LeftX.Contains(mp) Then
                m.Result = CType(HTLEFT, IntPtr)
            ElseIf RightX.Contains(mp) Then
                m.Result = CType(HTRIGHT, IntPtr)
            ElseIf BottomY.Contains(mp) Then
                m.Result = CType(HTBOTTOM, IntPtr)
            End If
        End If
    End Sub

    Dim rng As New Random
    Function RandomColour() As Color
        Return Color.FromArgb(255, rng.Next(255), rng.Next(255), rng.Next(255))
    End Function

    Const ImaginaryBorderSize As Integer = 16

    Function TopY() As Rectangle
        Return New Rectangle(0, 0, Me.ClientSize.Width, ImaginaryBorderSize)
    End Function

    Function LeftX() As Rectangle
        Return New Rectangle(0, 0, ImaginaryBorderSize, Me.ClientSize.Height)
    End Function

    Function BottomY() As Rectangle
        Return New Rectangle(0, Me.ClientSize.Height - ImaginaryBorderSize, Me.ClientSize.Width, ImaginaryBorderSize)
    End Function

    Function RightX() As Rectangle
        Return New Rectangle(Me.ClientSize.Width - ImaginaryBorderSize, 0, ImaginaryBorderSize, Me.ClientSize.Height)
    End Function

    Function TopLeft() As Rectangle
        Return New Rectangle(0, 0, ImaginaryBorderSize, ImaginaryBorderSize)
    End Function

    Function TopRight() As Rectangle
        Return New Rectangle(Me.ClientSize.Width - ImaginaryBorderSize, 0, ImaginaryBorderSize, ImaginaryBorderSize)
    End Function

    Function BottomLeft() As Rectangle
        Return New Rectangle(0, Me.ClientSize.Height - ImaginaryBorderSize, ImaginaryBorderSize, ImaginaryBorderSize)
    End Function

    Function BottomRight() As Rectangle
        Return New Rectangle(Me.ClientSize.Width - ImaginaryBorderSize, Me.ClientSize.Height - ImaginaryBorderSize, ImaginaryBorderSize, ImaginaryBorderSize)
    End Function

End Class
