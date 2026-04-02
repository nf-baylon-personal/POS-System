<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        TextBox1 = New TextBox()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        Button2 = New Button()
        ListBox1 = New ListBox()
        Button4 = New Button()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button3 = New Button()
        TextBox5 = New TextBox()
        Label4 = New Label()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Label8 = New Label()
        Label5 = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(359, 102)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(368, 25)
        TextBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(740, 100)
        Button1.Name = "Button1"
        Button1.Size = New Size(135, 29)
        Button1.TabIndex = 2
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Item SKU", "Description"})
        ComboBox1.Location = New Point(715, 472)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 26)
        ComboBox1.TabIndex = 3
        ComboBox1.Text = "Description"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(12, 298)
        Button2.Name = "Button2"
        Button2.Size = New Size(148, 29)
        Button2.TabIndex = 4
        Button2.Text = "Update Selection"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.BorderStyle = BorderStyle.None
        ListBox1.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 18
        ListBox1.Location = New Point(366, 145)
        ListBox1.Name = "ListBox1"
        ListBox1.ScrollAlwaysVisible = True
        ListBox1.Size = New Size(509, 306)
        ListBox1.TabIndex = 6
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(393, 471)
        Button4.Name = "Button4"
        Button4.Size = New Size(155, 29)
        Button4.TabIndex = 7
        Button4.Text = "Load Selection"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(96, 168)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(241, 25)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(12, 219)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(148, 25)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(189, 219)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(148, 25)
        TextBox4.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(96, 145)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 18)
        Label1.TabIndex = 11
        Label1.Text = "Description"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(12, 197)
        Label2.Name = "Label2"
        Label2.Size = New Size(48, 18)
        Label2.TabIndex = 12
        Label2.Text = "Price"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(189, 197)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 18)
        Label3.TabIndex = 13
        Label3.Text = "Qty"
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(189, 298)
        Button3.Name = "Button3"
        Button3.Size = New Size(148, 29)
        Button3.TabIndex = 14
        Button3.Text = "Add New Item"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(12, 168)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(78, 25)
        TextBox5.TabIndex = 15
        TextBox5.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(12, 145)
        Label4.Name = "Label4"
        Label4.Size = New Size(32, 18)
        Label4.TabIndex = 16
        Label4.Text = "SKU"
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(12, 335)
        Button5.Name = "Button5"
        Button5.Size = New Size(325, 29)
        Button5.TabIndex = 17
        Button5.Text = "Return to Checkout"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(12, 263)
        Button6.Name = "Button6"
        Button6.Size = New Size(325, 29)
        Button6.TabIndex = 18
        Button6.Text = "Clear Editor"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button7.Location = New Point(554, 471)
        Button7.Name = "Button7"
        Button7.Size = New Size(155, 29)
        Button7.TabIndex = 19
        Button7.Text = "Delete Selection"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(657, 530)
        Label8.Name = "Label8"
        Label8.Size = New Size(216, 20)
        Label8.TabIndex = 31
        Label8.Text = "NFJ Technologies Inc. | (C) 2026"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9F)
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(3, 530)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 20)
        Label5.TabIndex = 30
        Label5.Text = "Date"
        ' 
        ' Timer1
        ' 
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(882, 553)
        Controls.Add(Label8)
        Controls.Add(Label5)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Label4)
        Controls.Add(TextBox5)
        Controls.Add(Button3)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Button4)
        Controls.Add(ListBox1)
        Controls.Add(Button2)
        Controls.Add(ComboBox1)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form2"
        Text = "Inventory Management"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1 As Timer
End Class
