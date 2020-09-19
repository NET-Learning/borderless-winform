<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Lbl_Main_Name = New System.Windows.Forms.Label()
        Me.PanelGradient1 = New BorderlessWinForm.PanelGradient()
        Me.Btn_Main_Exit = New System.Windows.Forms.Button()
        Me.PanelGradient1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Main_Name
        '
        Me.Lbl_Main_Name.AutoSize = True
        Me.Lbl_Main_Name.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Main_Name.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Main_Name.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Lbl_Main_Name.Location = New System.Drawing.Point(188, 246)
        Me.Lbl_Main_Name.Name = "Lbl_Main_Name"
        Me.Lbl_Main_Name.Size = New System.Drawing.Size(625, 78)
        Me.Lbl_Main_Name.TabIndex = 0
        Me.Lbl_Main_Name.Text = "Borderless WinForm"
        '
        'PanelGradient1
        '
        Me.PanelGradient1.ColorBottom = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.PanelGradient1.ColorTop = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.PanelGradient1.Controls.Add(Me.Btn_Main_Exit)
        Me.PanelGradient1.Controls.Add(Me.Lbl_Main_Name)
        Me.PanelGradient1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGradient1.Location = New System.Drawing.Point(0, 0)
        Me.PanelGradient1.Name = "PanelGradient1"
        Me.PanelGradient1.Size = New System.Drawing.Size(980, 600)
        Me.PanelGradient1.TabIndex = 1
        '
        'Btn_Main_Exit
        '
        Me.Btn_Main_Exit.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Main_Exit.DialogResult = System.Windows.Forms.DialogResult.Abort
        Me.Btn_Main_Exit.FlatAppearance.BorderSize = 0
        Me.Btn_Main_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.Btn_Main_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Btn_Main_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Main_Exit.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Btn_Main_Exit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Btn_Main_Exit.Location = New System.Drawing.Point(934, 1)
        Me.Btn_Main_Exit.Name = "Btn_Main_Exit"
        Me.Btn_Main_Exit.Size = New System.Drawing.Size(45, 35)
        Me.Btn_Main_Exit.TabIndex = 1
        Me.Btn_Main_Exit.Text = "r"
        Me.Btn_Main_Exit.UseVisualStyleBackColor = False
        '
        'Frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(980, 600)
        Me.Controls.Add(Me.PanelGradient1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Main"
        Me.Text = "BorderlessWinForm"
        Me.PanelGradient1.ResumeLayout(False)
        Me.PanelGradient1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lbl_Main_Name As Label
    Friend WithEvents PanelGradient1 As PanelGradient
    Friend WithEvents Btn_Main_Exit As Button
End Class
