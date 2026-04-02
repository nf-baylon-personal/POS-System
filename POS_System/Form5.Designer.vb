<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label8 = New Label()
        Label5 = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.BorderStyle = BorderStyle.None
        ListBox1.Font = New Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 12
        ListBox1.Location = New Point(15, 66)
        ListBox1.Margin = New Padding(3, 2, 3, 2)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(478, 252)
        ListBox1.TabIndex = 0
        ' 
        ' ListBox2
        ' 
        ListBox2.Font = New Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 12
        ListBox2.Location = New Point(525, 66)
        ListBox2.Margin = New Padding(3, 2, 3, 2)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(236, 268)
        ListBox2.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(15, 326)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(231, 29)
        Button1.TabIndex = 2
        Button1.Text = "Load Selection"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(524, 346)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(237, 22)
        Button2.TabIndex = 3
        Button2.Text = "Clear Selection"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(264, 326)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(231, 29)
        Button3.TabIndex = 4
        Button3.Text = "Return to Checkout"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(575, 397)
        Label8.Name = "Label8"
        Label8.Size = New Size(173, 15)
        Label8.TabIndex = 33
        Label8.Text = "NFJ Technologies Inc. | (C) 2026"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9F)
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(3, 397)
        Label5.Name = "Label5"
        Label5.Size = New Size(31, 15)
        Label5.TabIndex = 32
        Label5.Text = "Date"
        ' 
        ' Timer1
        ' 
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(772, 415)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form5"
        Text = "Transaction Records"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
End Class
