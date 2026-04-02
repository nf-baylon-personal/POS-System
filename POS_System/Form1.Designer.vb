<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        TextBox1 = New TextBox()
        ListBox1 = New ListBox()
        TextBox2 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox4 = New TextBox()
        Button2 = New Button()
        TextBox3 = New TextBox()
        MenuStrip1 = New MenuStrip()
        mnuSettings = New ToolStripMenuItem()
        AccountDetailsToolStripMenuItem = New ToolStripMenuItem()
        LogOutToolStripMenuItem = New ToolStripMenuItem()
        QuitProgramToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        WindowsToolStripMenuItem = New ToolStripMenuItem()
        InventoryManagementToolStripMenuItem = New ToolStripMenuItem()
        TransactionRecordsToolStripMenuItem = New ToolStripMenuItem()
        Button4 = New Button()
        ListBox2 = New ListBox()
        Button3 = New Button()
        ComboBox1 = New ComboBox()
        Timer1 = New Timer(components)
        Label4 = New Label()
        Button5 = New Button()
        Label5 = New Label()
        TextBox6 = New TextBox()
        Label6 = New Label()
        Label8 = New Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ControlLightLight
        Button1.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(221, 481)
        Button1.Name = "Button1"
        Button1.Size = New Size(224, 30)
        Button1.TabIndex = 0
        Button1.Text = "Add Item"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(12, 101)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(292, 25)
        TextBox1.TabIndex = 1
        ' 
        ' ListBox1
        ' 
        ListBox1.BorderStyle = BorderStyle.None
        ListBox1.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 18
        ListBox1.Location = New Point(512, 112)
        ListBox1.Name = "ListBox1"
        ListBox1.ScrollAlwaysVisible = True
        ListBox1.Size = New Size(332, 234)
        ListBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(512, 425)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(149, 25)
        TextBox2.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(513, 405)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 18)
        Label1.TabIndex = 5
        Label1.Text = "Gross"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(698, 405)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 18)
        Label2.TabIndex = 6
        Label2.Text = "VAT"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(514, 463)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 18)
        Label3.TabIndex = 8
        Label3.Text = "Total"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(513, 486)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(148, 25)
        TextBox4.TabIndex = 9
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(698, 463)
        Button2.Name = "Button2"
        Button2.Size = New Size(153, 53)
        Button2.TabIndex = 10
        Button2.Text = "Payment"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(698, 425)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(146, 25)
        TextBox3.TabIndex = 17
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuSettings, WindowsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(882, 26)
        MenuStrip1.TabIndex = 19
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuSettings
        ' 
        mnuSettings.DropDownItems.AddRange(New ToolStripItem() {AccountDetailsToolStripMenuItem, LogOutToolStripMenuItem, QuitProgramToolStripMenuItem, ToolStripMenuItem2})
        mnuSettings.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        mnuSettings.Name = "mnuSettings"
        mnuSettings.Size = New Size(86, 22)
        mnuSettings.Text = "Settings"
        ' 
        ' AccountDetailsToolStripMenuItem
        ' 
        AccountDetailsToolStripMenuItem.Name = "AccountDetailsToolStripMenuItem"
        AccountDetailsToolStripMenuItem.Size = New Size(242, 26)
        AccountDetailsToolStripMenuItem.Text = "Account Details"
        ' 
        ' LogOutToolStripMenuItem
        ' 
        LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        LogOutToolStripMenuItem.Size = New Size(242, 26)
        LogOutToolStripMenuItem.Text = "Log Out"
        ' 
        ' QuitProgramToolStripMenuItem
        ' 
        QuitProgramToolStripMenuItem.Name = "QuitProgramToolStripMenuItem"
        QuitProgramToolStripMenuItem.Size = New Size(242, 26)
        QuitProgramToolStripMenuItem.Text = "Quit Program"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(242, 26)
        ToolStripMenuItem2.Text = "*******************"
        ' 
        ' WindowsToolStripMenuItem
        ' 
        WindowsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {InventoryManagementToolStripMenuItem, TransactionRecordsToolStripMenuItem})
        WindowsToolStripMenuItem.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        WindowsToolStripMenuItem.Size = New Size(54, 22)
        WindowsToolStripMenuItem.Text = "Page"
        ' 
        ' InventoryManagementToolStripMenuItem
        ' 
        InventoryManagementToolStripMenuItem.Name = "InventoryManagementToolStripMenuItem"
        InventoryManagementToolStripMenuItem.Size = New Size(250, 26)
        InventoryManagementToolStripMenuItem.Text = "Inventory Management"
        ' 
        ' TransactionRecordsToolStripMenuItem
        ' 
        TransactionRecordsToolStripMenuItem.Name = "TransactionRecordsToolStripMenuItem"
        TransactionRecordsToolStripMenuItem.Size = New Size(250, 26)
        TransactionRecordsToolStripMenuItem.Text = "Transaction Records"
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(698, 368)
        Button4.Name = "Button4"
        Button4.Size = New Size(153, 28)
        Button4.TabIndex = 20
        Button4.Text = "Remove Selected"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' ListBox2
        ' 
        ListBox2.BorderStyle = BorderStyle.None
        ListBox2.Font = New Font("Consolas", 10F)
        ListBox2.FormattingEnabled = True
        ListBox2.Location = New Point(12, 142)
        ListBox2.Name = "ListBox2"
        ListBox2.ScrollAlwaysVisible = True
        ListBox2.Size = New Size(425, 300)
        ListBox2.TabIndex = 21
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(315, 100)
        Button3.Name = "Button3"
        Button3.Size = New Size(130, 29)
        Button3.TabIndex = 22
        Button3.Text = "Search"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.ControlLightLight
        ComboBox1.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Item SKU", "Description"})
        ComboBox1.Location = New Point(95, 442)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(185, 26)
        ComboBox1.TabIndex = 23
        ComboBox1.Text = "Description"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F)
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(4, 530)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 20)
        Label4.TabIndex = 24
        Label4.Text = "Date"
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.ControlLightLight
        Button5.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = SystemColors.ControlText
        Button5.Location = New Point(507, 368)
        Button5.Name = "Button5"
        Button5.Size = New Size(154, 28)
        Button5.TabIndex = 25
        Button5.Text = "Clear Checkout"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(11, 446)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 18)
        Label5.TabIndex = 26
        Label5.Text = "Search By"
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(56, 483)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(148, 25)
        TextBox6.TabIndex = 27
        TextBox6.Text = "1"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlLightLight
        Label6.Location = New Point(11, 488)
        Label6.Name = "Label6"
        Label6.Size = New Size(32, 18)
        Label6.TabIndex = 28
        Label6.Text = "Qty"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.ForeColor = SystemColors.ControlLightLight
        Label8.Location = New Point(658, 530)
        Label8.Name = "Label8"
        Label8.Size = New Size(216, 20)
        Label8.TabIndex = 29
        Label8.Text = "NFJ Technologies Inc. | (C) 2026"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(882, 553)
        Controls.Add(Label8)
        Controls.Add(Label6)
        Controls.Add(TextBox6)
        Controls.Add(Label5)
        Controls.Add(Button5)
        Controls.Add(Label4)
        Controls.Add(ComboBox1)
        Controls.Add(Button3)
        Controls.Add(ListBox2)
        Controls.Add(Button4)
        Controls.Add(TextBox3)
        Controls.Add(Button2)
        Controls.Add(TextBox4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(ListBox1)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(MenuStrip1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "POS Checkout"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents WindowsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventoryManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuSettings As ToolStripMenuItem
    Friend WithEvents AccountDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionRecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button4 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem

End Class
