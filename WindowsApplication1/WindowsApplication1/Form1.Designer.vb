<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IdleMine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IdleMine))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveWalletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.monerowal = New System.Windows.Forms.TextBox()
        Me.leviarwal = New System.Windows.Forms.TextBox()
        Me.intensewal = New System.Windows.Forms.TextBox()
        Me.sumowal = New System.Windows.Forms.TextBox()
        Me.aeonwal = New System.Windows.Forms.TextBox()
        Me.activeslide = New System.Windows.Forms.TrackBar()
        Me.strop = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.timeslid = New System.Windows.Forms.TrackBar()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.AMbox = New System.Windows.Forms.CheckBox()
        Me.IMbox = New System.Windows.Forms.CheckBox()
        Me.aeonsv = New System.Windows.Forms.TextBox()
        Me.leviarsv = New System.Windows.Forms.TextBox()
        Me.intensesv = New System.Windows.Forms.TextBox()
        Me.monerosv = New System.Windows.Forms.TextBox()
        Me.sumosv = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.minutes = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pooltab = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pingtab = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.readout = New System.Windows.Forms.ToolStripStatusLabel()
        Me.coinstat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.clocky = New System.Windows.Forms.Timer(Me.components)
        Me.upp = New System.Windows.Forms.Timer(Me.components)
        Me.CurrencyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.karbwal = New System.Windows.Forms.TextBox()
        Me.elecwal = New System.Windows.Forms.TextBox()
        Me.masariwal = New System.Windows.Forms.TextBox()
        Me.elecsv = New System.Windows.Forms.TextBox()
        Me.karbsv = New System.Windows.Forms.TextBox()
        Me.masarisv = New System.Windows.Forms.TextBox()
        Me.pasbox = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.CheckBox()
        Me.aeonmen = New System.Windows.Forms.ToolStripMenuItem()
        Me.elecmen = New System.Windows.Forms.ToolStripMenuItem()
        Me.intensemen = New System.Windows.Forms.ToolStripMenuItem()
        Me.leviarmen = New System.Windows.Forms.ToolStripMenuItem()
        Me.masarimen = New System.Windows.Forms.ToolStripMenuItem()
        Me.moneromen = New System.Windows.Forms.ToolStripMenuItem()
        Me.karbmen = New System.Windows.Forms.ToolStripMenuItem()
        Me.sumomen = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.activeslide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timeslid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CurrencyToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(597, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveWalletToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveWalletToolStripMenuItem
        '
        Me.SaveWalletToolStripMenuItem.Name = "SaveWalletToolStripMenuItem"
        Me.SaveWalletToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveWalletToolStripMenuItem.Text = "Save  Info"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'monerowal
        '
        Me.monerowal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monerowal.Location = New System.Drawing.Point(65, 55)
        Me.monerowal.Name = "monerowal"
        Me.monerowal.Size = New System.Drawing.Size(200, 18)
        Me.monerowal.TabIndex = 1
        Me.monerowal.Visible = False
        '
        'leviarwal
        '
        Me.leviarwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leviarwal.Location = New System.Drawing.Point(65, 55)
        Me.leviarwal.Name = "leviarwal"
        Me.leviarwal.Size = New System.Drawing.Size(200, 18)
        Me.leviarwal.TabIndex = 2
        Me.leviarwal.Visible = False
        '
        'intensewal
        '
        Me.intensewal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intensewal.Location = New System.Drawing.Point(65, 55)
        Me.intensewal.Name = "intensewal"
        Me.intensewal.Size = New System.Drawing.Size(200, 18)
        Me.intensewal.TabIndex = 3
        Me.intensewal.Visible = False
        '
        'sumowal
        '
        Me.sumowal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sumowal.Location = New System.Drawing.Point(65, 55)
        Me.sumowal.Name = "sumowal"
        Me.sumowal.Size = New System.Drawing.Size(200, 18)
        Me.sumowal.TabIndex = 4
        Me.sumowal.Visible = False
        '
        'aeonwal
        '
        Me.aeonwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aeonwal.Location = New System.Drawing.Point(65, 55)
        Me.aeonwal.Name = "aeonwal"
        Me.aeonwal.Size = New System.Drawing.Size(200, 18)
        Me.aeonwal.TabIndex = 6
        '
        'activeslide
        '
        Me.activeslide.Location = New System.Drawing.Point(207, 131)
        Me.activeslide.Maximum = 55
        Me.activeslide.Minimum = 10
        Me.activeslide.Name = "activeslide"
        Me.activeslide.Size = New System.Drawing.Size(120, 45)
        Me.activeslide.SmallChange = 5
        Me.activeslide.TabIndex = 7
        Me.activeslide.Value = 10
        '
        'strop
        '
        Me.strop.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strop.Location = New System.Drawing.Point(417, 149)
        Me.strop.Name = "strop"
        Me.strop.Size = New System.Drawing.Size(153, 73)
        Me.strop.TabIndex = 10
        Me.strop.Text = "Start"
        Me.strop.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(243, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Minutes"
        '
        'timeslid
        '
        Me.timeslid.LargeChange = 15
        Me.timeslid.Location = New System.Drawing.Point(207, 183)
        Me.timeslid.Maximum = 90
        Me.timeslid.Minimum = 15
        Me.timeslid.Name = "timeslid"
        Me.timeslid.Size = New System.Drawing.Size(120, 45)
        Me.timeslid.SmallChange = 15
        Me.timeslid.TabIndex = 20
        Me.timeslid.TickFrequency = 15
        Me.timeslid.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.timeslid.Value = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(217, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Less                   More"
        '
        'AMbox
        '
        Me.AMbox.AutoSize = True
        Me.AMbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AMbox.Location = New System.Drawing.Point(65, 131)
        Me.AMbox.Name = "AMbox"
        Me.AMbox.Size = New System.Drawing.Size(115, 24)
        Me.AMbox.TabIndex = 22
        Me.AMbox.Text = "Active Mode"
        Me.AMbox.UseVisualStyleBackColor = True
        '
        'IMbox
        '
        Me.IMbox.AutoSize = True
        Me.IMbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IMbox.Location = New System.Drawing.Point(65, 183)
        Me.IMbox.Name = "IMbox"
        Me.IMbox.Size = New System.Drawing.Size(92, 24)
        Me.IMbox.TabIndex = 23
        Me.IMbox.Text = "Idle Mine"
        Me.IMbox.UseVisualStyleBackColor = True
        '
        'aeonsv
        '
        Me.aeonsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aeonsv.Location = New System.Drawing.Point(290, 55)
        Me.aeonsv.Name = "aeonsv"
        Me.aeonsv.Size = New System.Drawing.Size(120, 18)
        Me.aeonsv.TabIndex = 25
        '
        'leviarsv
        '
        Me.leviarsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leviarsv.Location = New System.Drawing.Point(290, 55)
        Me.leviarsv.Name = "leviarsv"
        Me.leviarsv.Size = New System.Drawing.Size(120, 18)
        Me.leviarsv.TabIndex = 26
        Me.leviarsv.Visible = False
        '
        'intensesv
        '
        Me.intensesv.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intensesv.Location = New System.Drawing.Point(290, 55)
        Me.intensesv.Name = "intensesv"
        Me.intensesv.Size = New System.Drawing.Size(120, 18)
        Me.intensesv.TabIndex = 27
        Me.intensesv.Visible = False
        '
        'monerosv
        '
        Me.monerosv.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monerosv.Location = New System.Drawing.Point(290, 55)
        Me.monerosv.Name = "monerosv"
        Me.monerosv.Size = New System.Drawing.Size(120, 18)
        Me.monerosv.TabIndex = 28
        Me.monerosv.Visible = False
        '
        'sumosv
        '
        Me.sumosv.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sumosv.Location = New System.Drawing.Point(290, 55)
        Me.sumosv.Name = "sumosv"
        Me.sumosv.Size = New System.Drawing.Size(120, 18)
        Me.sumosv.TabIndex = 29
        Me.sumosv.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(111, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 20)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Wallet Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(307, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 20)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Server:Port"
        '
        'minutes
        '
        Me.minutes.AutoSize = True
        Me.minutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutes.Location = New System.Drawing.Point(222, 167)
        Me.minutes.Name = "minutes"
        Me.minutes.Size = New System.Drawing.Size(19, 13)
        Me.minutes.TabIndex = 33
        Me.minutes.Text = "15"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(-59, 69)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 34
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.pooltab, Me.ToolStripStatusLabel3, Me.pingtab, Me.ToolStripStatusLabel1, Me.readout, Me.coinstat})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 239)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(597, 22)
        Me.StatusStrip1.TabIndex = 41
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(34, 17)
        Me.ToolStripStatusLabel2.Text = "Pool:"
        '
        'pooltab
        '
        Me.pooltab.Name = "pooltab"
        Me.pooltab.Size = New System.Drawing.Size(34, 17)
        Me.pooltab.Text = "none"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(34, 17)
        Me.ToolStripStatusLabel3.Text = "Ping:"
        '
        'pingtab
        '
        Me.pingtab.Name = "pingtab"
        Me.pingtab.Size = New System.Drawing.Size(13, 17)
        Me.pingtab.Text = "0"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(74, 17)
        Me.ToolStripStatusLabel1.Text = "Total Hashes"
        '
        'readout
        '
        Me.readout.MergeAction = System.Windows.Forms.MergeAction.Replace
        Me.readout.Name = "readout"
        Me.readout.Size = New System.Drawing.Size(68, 17)
        Me.readout.Text = "Not Mining"
        '
        'coinstat
        '
        Me.coinstat.Name = "coinstat"
        Me.coinstat.Size = New System.Drawing.Size(0, 17)
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "IdleMIne"
        '
        'clocky
        '
        Me.clocky.Enabled = True
        Me.clocky.Interval = 60000
        '
        'upp
        '
        Me.upp.Interval = 30000
        '
        'CurrencyToolStripMenuItem
        '
        Me.CurrencyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aeonmen, Me.elecmen, Me.intensemen, Me.karbmen, Me.leviarmen, Me.masarimen, Me.moneromen, Me.sumomen})
        Me.CurrencyToolStripMenuItem.Name = "CurrencyToolStripMenuItem"
        Me.CurrencyToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.CurrencyToolStripMenuItem.Text = "Currency"
        '
        'karbwal
        '
        Me.karbwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.karbwal.Location = New System.Drawing.Point(65, 55)
        Me.karbwal.Name = "karbwal"
        Me.karbwal.Size = New System.Drawing.Size(200, 18)
        Me.karbwal.TabIndex = 43
        Me.karbwal.Visible = False
        '
        'elecwal
        '
        Me.elecwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elecwal.Location = New System.Drawing.Point(65, 55)
        Me.elecwal.Name = "elecwal"
        Me.elecwal.Size = New System.Drawing.Size(200, 18)
        Me.elecwal.TabIndex = 44
        Me.elecwal.Visible = False
        '
        'masariwal
        '
        Me.masariwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.masariwal.Location = New System.Drawing.Point(65, 55)
        Me.masariwal.Name = "masariwal"
        Me.masariwal.Size = New System.Drawing.Size(200, 18)
        Me.masariwal.TabIndex = 45
        Me.masariwal.Visible = False
        '
        'elecsv
        '
        Me.elecsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.elecsv.Location = New System.Drawing.Point(290, 55)
        Me.elecsv.Name = "elecsv"
        Me.elecsv.Size = New System.Drawing.Size(120, 18)
        Me.elecsv.TabIndex = 46
        Me.elecsv.Visible = False
        '
        'karbsv
        '
        Me.karbsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.karbsv.Location = New System.Drawing.Point(290, 55)
        Me.karbsv.Name = "karbsv"
        Me.karbsv.Size = New System.Drawing.Size(120, 18)
        Me.karbsv.TabIndex = 47
        Me.karbsv.Visible = False
        '
        'masarisv
        '
        Me.masarisv.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.masarisv.Location = New System.Drawing.Point(290, 55)
        Me.masarisv.Name = "masarisv"
        Me.masarisv.Size = New System.Drawing.Size(120, 18)
        Me.masarisv.TabIndex = 48
        Me.masarisv.Visible = False
        '
        'pasbox
        '
        Me.pasbox.Enabled = False
        Me.pasbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pasbox.Location = New System.Drawing.Point(143, 79)
        Me.pasbox.Name = "pasbox"
        Me.pasbox.Size = New System.Drawing.Size(122, 18)
        Me.pasbox.TabIndex = 49
        '
        'pass
        '
        Me.pass.AutoSize = True
        Me.pass.Location = New System.Drawing.Point(65, 80)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(72, 17)
        Me.pass.TabIndex = 50
        Me.pass.Text = "Password"
        Me.pass.UseVisualStyleBackColor = True
        '
        'aeonmen
        '
        Me.aeonmen.Checked = True
        Me.aeonmen.CheckOnClick = True
        Me.aeonmen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.aeonmen.Image = CType(resources.GetObject("aeonmen.Image"), System.Drawing.Image)
        Me.aeonmen.Name = "aeonmen"
        Me.aeonmen.Size = New System.Drawing.Size(152, 22)
        Me.aeonmen.Text = "Aeon"
        '
        'elecmen
        '
        Me.elecmen.CheckOnClick = True
        Me.elecmen.Image = CType(resources.GetObject("elecmen.Image"), System.Drawing.Image)
        Me.elecmen.Name = "elecmen"
        Me.elecmen.Size = New System.Drawing.Size(152, 22)
        Me.elecmen.Text = "Electroneum"
        '
        'intensemen
        '
        Me.intensemen.CheckOnClick = True
        Me.intensemen.Image = CType(resources.GetObject("intensemen.Image"), System.Drawing.Image)
        Me.intensemen.Name = "intensemen"
        Me.intensemen.Size = New System.Drawing.Size(152, 22)
        Me.intensemen.Text = "Intensecoin"
        '
        'leviarmen
        '
        Me.leviarmen.CheckOnClick = True
        Me.leviarmen.Image = CType(resources.GetObject("leviarmen.Image"), System.Drawing.Image)
        Me.leviarmen.Name = "leviarmen"
        Me.leviarmen.Size = New System.Drawing.Size(152, 22)
        Me.leviarmen.Text = "Leviarcoin"
        '
        'masarimen
        '
        Me.masarimen.CheckOnClick = True
        Me.masarimen.Image = CType(resources.GetObject("masarimen.Image"), System.Drawing.Image)
        Me.masarimen.Name = "masarimen"
        Me.masarimen.Size = New System.Drawing.Size(152, 22)
        Me.masarimen.Text = "Masari"
        '
        'moneromen
        '
        Me.moneromen.CheckOnClick = True
        Me.moneromen.Image = CType(resources.GetObject("moneromen.Image"), System.Drawing.Image)
        Me.moneromen.Name = "moneromen"
        Me.moneromen.Size = New System.Drawing.Size(152, 22)
        Me.moneromen.Text = "Monero"
        '
        'karbmen
        '
        Me.karbmen.CheckOnClick = True
        Me.karbmen.Image = CType(resources.GetObject("karbmen.Image"), System.Drawing.Image)
        Me.karbmen.Name = "karbmen"
        Me.karbmen.Size = New System.Drawing.Size(152, 22)
        Me.karbmen.Text = "Karbowanec"
        '
        'sumomen
        '
        Me.sumomen.CheckOnClick = True
        Me.sumomen.Image = CType(resources.GetObject("sumomen.Image"), System.Drawing.Image)
        Me.sumomen.Name = "sumomen"
        Me.sumomen.Size = New System.Drawing.Size(152, 22)
        Me.sumomen.Text = "Sumokoin"
        '
        'IdleMine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 261)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.pasbox)
        Me.Controls.Add(Me.masarisv)
        Me.Controls.Add(Me.karbsv)
        Me.Controls.Add(Me.elecsv)
        Me.Controls.Add(Me.masariwal)
        Me.Controls.Add(Me.elecwal)
        Me.Controls.Add(Me.karbwal)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.minutes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.sumosv)
        Me.Controls.Add(Me.monerosv)
        Me.Controls.Add(Me.intensesv)
        Me.Controls.Add(Me.leviarsv)
        Me.Controls.Add(Me.aeonsv)
        Me.Controls.Add(Me.IMbox)
        Me.Controls.Add(Me.AMbox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.timeslid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.strop)
        Me.Controls.Add(Me.activeslide)
        Me.Controls.Add(Me.aeonwal)
        Me.Controls.Add(Me.sumowal)
        Me.Controls.Add(Me.intensewal)
        Me.Controls.Add(Me.leviarwal)
        Me.Controls.Add(Me.monerowal)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "IdleMine"
        Me.Text = "IdleMine 0.01  -  Aeon"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.activeslide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.timeslid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveWalletToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents monerowal As System.Windows.Forms.TextBox
    Friend WithEvents leviarwal As System.Windows.Forms.TextBox
    Friend WithEvents intensewal As System.Windows.Forms.TextBox
    Friend WithEvents sumowal As System.Windows.Forms.TextBox
    Friend WithEvents aeonwal As System.Windows.Forms.TextBox
    Friend WithEvents activeslide As System.Windows.Forms.TrackBar
    Friend WithEvents strop As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents timeslid As System.Windows.Forms.TrackBar
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents AMbox As System.Windows.Forms.CheckBox
    Friend WithEvents IMbox As System.Windows.Forms.CheckBox
    Friend WithEvents aeonsv As System.Windows.Forms.TextBox
    Friend WithEvents leviarsv As System.Windows.Forms.TextBox
    Friend WithEvents intensesv As System.Windows.Forms.TextBox
    Friend WithEvents monerosv As System.Windows.Forms.TextBox
    Friend WithEvents sumosv As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents minutes As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents readout As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents coinstat As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents clocky As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents upp As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pooltab As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents pingtab As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CurrencyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents aeonmen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents elecmen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents intensemen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents karbmen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents leviarmen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents masarimen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents moneromen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sumomen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents karbwal As System.Windows.Forms.TextBox
    Friend WithEvents elecwal As System.Windows.Forms.TextBox
    Friend WithEvents masariwal As System.Windows.Forms.TextBox
    Friend WithEvents elecsv As System.Windows.Forms.TextBox
    Friend WithEvents karbsv As System.Windows.Forms.TextBox
    Friend WithEvents masarisv As System.Windows.Forms.TextBox
    Friend WithEvents pasbox As System.Windows.Forms.TextBox
    Friend WithEvents pass As System.Windows.Forms.CheckBox

End Class
