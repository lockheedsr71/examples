﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtchktimer = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtremovepath5 = New System.Windows.Forms.TextBox()
        Me.txtremovepath4 = New System.Windows.Forms.TextBox()
        Me.txtremovepath3 = New System.Windows.Forms.TextBox()
        Me.txtremovepath2 = New System.Windows.Forms.TextBox()
        Me.txtremovepath1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtfilepathclientout = New System.Windows.Forms.TextBox()
        Me.txtfilepathclient = New System.Windows.Forms.TextBox()
        Me.txtfilepathubix = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtstartin3 = New System.Windows.Forms.TextBox()
        Me.txtstartin2 = New System.Windows.Forms.TextBox()
        Me.txtstartin1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStrip1.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.TabPage2.SuspendLayout
        Me.GroupBox4.SuspendLayout
        Me.GroupBox3.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.TabPage3.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Send to Tray"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"),System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Relax Engine"
        Me.NotifyIcon1.Visible = true
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(117, 70)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ShowToolStripMenuItem.Text = "Settings"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 424)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Version :"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.TabControl1.Location = New System.Drawing.Point(150, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(478, 484)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabPage1.Controls.Add(Me.RichTextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(470, 453)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Welcome"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Chartreuse
        Me.RichTextBox1.Location = New System.Drawing.Point(8, 8)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(456, 383)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = "Welcome to RELAX Engine"&Global.Microsoft.VisualBasic.ChrW(10)&"This program auto extract recorded TS file on UBIX Server"& _ 
    "..Config file needed "&Global.Microsoft.VisualBasic.ChrW(10)&"to be configured before first run."&Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(470, 453)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Settings"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Button3.Location = New System.Drawing.Point(362, 420)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 27)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Save configs"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtchktimer)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox4.Location = New System.Drawing.Point(252, 24)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(208, 108)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = false
        Me.GroupBox4.Text = "Interval timers:"
        '
        'txtchktimer
        '
        Me.txtchktimer.Location = New System.Drawing.Point(142, 18)
        Me.txtchktimer.Name = "txtchktimer"
        Me.txtchktimer.Size = New System.Drawing.Size(60, 22)
        Me.txtchktimer.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label15.Location = New System.Drawing.Point(6, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(137, 15)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Program Interval (sec):"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtremovepath5)
        Me.GroupBox3.Controls.Add(Me.txtremovepath4)
        Me.GroupBox3.Controls.Add(Me.txtremovepath3)
        Me.GroupBox3.Controls.Add(Me.txtremovepath2)
        Me.GroupBox3.Controls.Add(Me.txtremovepath1)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox3.Location = New System.Drawing.Point(11, 240)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(449, 152)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = false
        Me.GroupBox3.Text = "Removing paths after extract:"
        '
        'txtremovepath5
        '
        Me.txtremovepath5.Location = New System.Drawing.Point(60, 119)
        Me.txtremovepath5.Name = "txtremovepath5"
        Me.txtremovepath5.Size = New System.Drawing.Size(383, 22)
        Me.txtremovepath5.TabIndex = 24
        '
        'txtremovepath4
        '
        Me.txtremovepath4.Location = New System.Drawing.Point(60, 94)
        Me.txtremovepath4.Name = "txtremovepath4"
        Me.txtremovepath4.Size = New System.Drawing.Size(383, 22)
        Me.txtremovepath4.TabIndex = 23
        '
        'txtremovepath3
        '
        Me.txtremovepath3.Location = New System.Drawing.Point(60, 69)
        Me.txtremovepath3.Name = "txtremovepath3"
        Me.txtremovepath3.Size = New System.Drawing.Size(383, 22)
        Me.txtremovepath3.TabIndex = 22
        '
        'txtremovepath2
        '
        Me.txtremovepath2.Location = New System.Drawing.Point(60, 44)
        Me.txtremovepath2.Name = "txtremovepath2"
        Me.txtremovepath2.Size = New System.Drawing.Size(383, 22)
        Me.txtremovepath2.TabIndex = 21
        '
        'txtremovepath1
        '
        Me.txtremovepath1.Location = New System.Drawing.Point(60, 19)
        Me.txtremovepath1.Name = "txtremovepath1"
        Me.txtremovepath1.Size = New System.Drawing.Size(383, 22)
        Me.txtremovepath1.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label9.Location = New System.Drawing.Point(8, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 15)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Path 1:"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label10.Location = New System.Drawing.Point(8, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Path 2:"
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label11.Location = New System.Drawing.Point(8, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 15)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Path 3:"
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label12.Location = New System.Drawing.Point(8, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 15)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Path 4:"
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label13.Location = New System.Drawing.Point(8, 121)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 15)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Path 5:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtfilepathclientout)
        Me.GroupBox2.Controls.Add(Me.txtfilepathclient)
        Me.GroupBox2.Controls.Add(Me.txtfilepathubix)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox2.Location = New System.Drawing.Point(9, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(451, 96)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "File and folders path:"
        '
        'txtfilepathclientout
        '
        Me.txtfilepathclientout.Location = New System.Drawing.Point(160, 68)
        Me.txtfilepathclientout.Name = "txtfilepathclientout"
        Me.txtfilepathclientout.Size = New System.Drawing.Size(285, 22)
        Me.txtfilepathclientout.TabIndex = 15
        '
        'txtfilepathclient
        '
        Me.txtfilepathclient.Location = New System.Drawing.Point(160, 41)
        Me.txtfilepathclient.Name = "txtfilepathclient"
        Me.txtfilepathclient.Size = New System.Drawing.Size(285, 22)
        Me.txtfilepathclient.TabIndex = 15
        '
        'txtfilepathubix
        '
        Me.txtfilepathubix.Location = New System.Drawing.Point(160, 15)
        Me.txtfilepathubix.Name = "txtfilepathubix"
        Me.txtfilepathubix.Size = New System.Drawing.Size(285, 22)
        Me.txtfilepathubix.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label6.Location = New System.Drawing.Point(6, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Source .TS file path : "
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label7.Location = New System.Drawing.Point(6, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 15)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Destination .TS file path :"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label8.Location = New System.Drawing.Point(6, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 15)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Result output Folder :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtstartin3)
        Me.GroupBox1.Controls.Add(Me.txtstartin2)
        Me.GroupBox1.Controls.Add(Me.txtstartin1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Location = New System.Drawing.Point(11, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 108)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Starting time sets:"
        '
        'txtstartin3
        '
        Me.txtstartin3.Location = New System.Drawing.Point(122, 76)
        Me.txtstartin3.Name = "txtstartin3"
        Me.txtstartin3.Size = New System.Drawing.Size(108, 22)
        Me.txtstartin3.TabIndex = 14
        '
        'txtstartin2
        '
        Me.txtstartin2.Location = New System.Drawing.Point(122, 48)
        Me.txtstartin2.Name = "txtstartin2"
        Me.txtstartin2.Size = New System.Drawing.Size(108, 22)
        Me.txtstartin2.TabIndex = 13
        '
        'txtstartin1
        '
        Me.txtstartin1.Location = New System.Drawing.Point(122, 21)
        Me.txtstartin1.Name = "txtstartin1"
        Me.txtstartin1.Size = New System.Drawing.Size(108, 22)
        Me.txtstartin1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "First start time : "
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label4.Location = New System.Drawing.Point(4, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Second start time :"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.Label5.Location = New System.Drawing.Point(6, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Third start time :"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer))
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Set the values for configuration file here : "
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabPage3.Controls.Add(Me.RichTextBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(470, 453)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "About"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178,Byte))
        Me.RichTextBox2.ForeColor = System.Drawing.Color.Red
        Me.RichTextBox2.Location = New System.Drawing.Point(10, 5)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(436, 174)
        Me.RichTextBox2.TabIndex = 6
        Me.RichTextBox2.Text = "RELAX Engine"&Global.Microsoft.VisualBasic.ChrW(10)&"TS File auto extractor and automation tool."&Global.Microsoft.VisualBasic.ChrW(10)&"Program developer and de"& _ 
    "signer : M.B.K"&Global.Microsoft.VisualBasic.ChrW(10)&"Freeware and free to copy . "&Global.Microsoft.VisualBasic.ChrW(10)&"(this program need UBIX Server to wo"& _ 
    "rk) ."&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(10)&"www.ir"&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Relax.My.Resources.Resources.satellite_icon_5_1_
        Me.PictureBox1.Location = New System.Drawing.Point(8, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = false
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(15, 285)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "tip"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(638, 508)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = true
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Form1"
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RELAX Engine"
        Me.ContextMenuStrip1.ResumeLayout(false)
        Me.TabControl1.ResumeLayout(false)
        Me.TabPage1.ResumeLayout(false)
        Me.TabPage2.ResumeLayout(false)
        Me.TabPage2.PerformLayout
        Me.GroupBox4.ResumeLayout(false)
        Me.GroupBox4.PerformLayout
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.TabPage3.ResumeLayout(false)
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label2 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtstartin1 As TextBox
    Friend WithEvents txtfilepathclientout As TextBox
    Friend WithEvents txtfilepathclient As TextBox
    Friend WithEvents txtfilepathubix As TextBox
    Friend WithEvents txtstartin3 As TextBox
    Friend WithEvents txtstartin2 As TextBox
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtremovepath5 As TextBox
    Friend WithEvents txtremovepath4 As TextBox
    Friend WithEvents txtremovepath3 As TextBox
    Friend WithEvents txtremovepath2 As TextBox
    Friend WithEvents txtremovepath1 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtchktimer As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Button3 As Button
End Class
