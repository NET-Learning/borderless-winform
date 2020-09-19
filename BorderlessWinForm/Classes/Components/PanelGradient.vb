Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class PanelGradient
    Inherits Panel

    Public Property ColorTop As Color
    Public Property ColorBottom As Color


    '/*
    '*
    '* PANEL DESIGN
    '*
    '*/

    Private Sub PanelGradient_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        ' Common
        Dim LinearBrush As LinearGradientBrush = New LinearGradientBrush(Me.ClientRectangle, Me.ColorTop, Me.ColorBottom, 90.0F)
        Dim vGraphics As Graphics = e.Graphics
        ' New vals
        vGraphics.FillRectangle(LinearBrush, Me.ClientRectangle)
    End Sub

End Class


