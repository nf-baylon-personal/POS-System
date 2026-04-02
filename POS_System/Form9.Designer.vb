<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form9))
        ListBox1 = New ListBox()
        Label6 = New Label()
        TextBox5 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Button6 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Button4 = New Button()
        Timer1 = New Timer(components)
        Label8 = New Label()
        Label5 = New Label()
        Button5 = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.Font = New Font("Consolas", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 14
        ListBox1.Location = New Point(12, 73)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(404, 340)
        ListBox1.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(464, 87)
        Label6.Name = "Label6"
        Label6.Size = New Size(32, 18)
        Label6.TabIndex = 28
        Label6.Text = "ID#"
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(464, 109)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(45, 25)
        TextBox5.TabIndex = 27
        TextBox5.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(467, 312)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 25
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(665, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 18)
        Label3.TabIndex = 21
        Label3.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(464, 163)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 18)
        Label2.TabIndex = 20
        Label2.Text = "Job Title"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(520, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(40, 18)
        Label1.TabIndex = 19
        Label1.Text = "Name"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(665, 187)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(175, 25)
        TextBox3.TabIndex = 18
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(464, 187)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(175, 25)
        TextBox2.TabIndex = 17
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(520, 109)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(319, 25)
        TextBox1.TabIndex = 16
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(467, 248)
        Button6.Name = "Button6"
        Button6.Size = New Size(373, 29)
        Button6.TabIndex = 32
        Button6.Text = "Clear Editor"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(665, 296)
        Button3.Name = "Button3"
        Button3.Size = New Size(175, 29)
        Button3.TabIndex = 30
        Button3.Text = "Add New User"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(467, 296)
        Button2.Name = "Button2"
        Button2.Size = New Size(171, 29)
        Button2.TabIndex = 29
        Button2.Text = "Update Selection"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(227, 439)
        Button1.Name = "Button1"
        Button1.Size = New Size(189, 29)
        Button1.TabIndex = 33
        Button1.Text = "Load Selected"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(12, 439)
        Button4.Name = "Button4"
        Button4.Size = New Size(189, 29)
        Button4.TabIndex = 34
        Button4.Text = "Delete Selected"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(657, 531)
        Label8.Name = "Label8"
        Label8.Size = New Size(216, 20)
        Label8.TabIndex = 36
        Label8.Text = "NFJ Technologies Inc. | (C) 2026"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9F)
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(3, 531)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 20)
        Label5.TabIndex = 35
        Label5.Text = "Date"
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(467, 335)
        Button5.Name = "Button5"
        Button5.Size = New Size(373, 44)
        Button5.TabIndex = 37
        Button5.Text = "Return to Checkout"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(882, 553)
        Controls.Add(Button5)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(Button4)
        Controls.Add(Button1)
        Controls.Add(Button6)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label6)
        Controls.Add(TextBox5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ListBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form9"
        Text = "Admin Controls"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
End Class
