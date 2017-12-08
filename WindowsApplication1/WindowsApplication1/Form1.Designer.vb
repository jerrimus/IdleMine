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
        Me.aeonsel = New System.Windows.Forms.CheckBox()
        Me.leviarsel = New System.Windows.Forms.CheckBox()
        Me.intensesel = New System.Windows.Forms.CheckBox()
        Me.monerosel = New System.Windows.Forms.CheckBox()
        Me.sumosel = New System.Windows.Forms.CheckBox()
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
        Me.MenuStrip1.SuspendLayout()
        CType(Me.activeslide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.timeslid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(783, 24)
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
        Me.SaveWalletToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SaveWalletToolStripMenuItem.Text = "Save Wallets"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'monerowal
        '
        Me.monerowal.Enabled = False
        Me.monerowal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monerowal.Location = New System.Drawing.Point(127, 158)
        Me.monerowal.Name = "monerowal"
        Me.monerowal.Size = New System.Drawing.Size(200, 18)
        Me.monerowal.TabIndex = 1
        '
        'leviarwal
        '
        Me.leviarwal.Enabled = False
        Me.leviarwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leviarwal.Location = New System.Drawing.Point(127, 100)
        Me.leviarwal.Name = "leviarwal"
        Me.leviarwal.Size = New System.Drawing.Size(200, 18)
        Me.leviarwal.TabIndex = 2
        '
        'intensewal
        '
        Me.intensewal.Enabled = False
        Me.intensewal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intensewal.Location = New System.Drawing.Point(127, 126)
        Me.intensewal.Name = "intensewal"
        Me.intensewal.Size = New System.Drawing.Size(200, 18)
        Me.intensewal.TabIndex = 3
        '
        'sumowal
        '
        Me.sumowal.Enabled = False
        Me.sumowal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sumowal.Location = New System.Drawing.Point(127, 188)
        Me.sumowal.Name = "sumowal"
        Me.sumowal.Size = New System.Drawing.Size(200, 18)
        Me.sumowal.TabIndex = 4
        '
        'aeonwal
        '
        Me.aeonwal.Enabled = False
        Me.aeonwal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aeonwal.Location = New System.Drawing.Point(127, 69)
        Me.aeonwal.Name = "aeonwal"
        Me.aeonwal.Size = New System.Drawing.Size(200, 18)
        Me.aeonwal.TabIndex = 6
        '
        'activeslide
        '
        Me.activeslide.Location = New System.Drawing.Point(618, 48)
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
        Me.strop.Location = New System.Drawing.Point(618, 160)
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
        Me.Label9.Location = New System.Drawing.Point(661, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Minutes"
        '
        'timeslid
        '
        Me.timeslid.LargeChange = 15
        Me.timeslid.Location = New System.Drawing.Point(618, 100)
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
        Me.Label10.Location = New System.Drawing.Point(628, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Less                   More"
        '
        'AMbox
        '
        Me.AMbox.AutoSize = True
        Me.AMbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AMbox.Location = New System.Drawing.Point(497, 48)
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
        Me.IMbox.Location = New System.Drawing.Point(497, 98)
        Me.IMbox.Name = "IMbox"
        Me.IMbox.Size = New System.Drawing.Size(92, 24)
        Me.IMbox.TabIndex = 23
        Me.IMbox.Text = "Idle Mine"
        Me.IMbox.UseVisualStyleBackColor = True
        '
        'aeonsv
        '
        Me.aeonsv.Location = New System.Drawing.Point(333, 69)
        Me.aeonsv.Name = "aeonsv"
        Me.aeonsv.Size = New System.Drawing.Size(120, 20)
        Me.aeonsv.TabIndex = 25
        '
        'leviarsv
        '
        Me.leviarsv.Enabled = False
        Me.leviarsv.Location = New System.Drawing.Point(333, 98)
        Me.leviarsv.Name = "leviarsv"
        Me.leviarsv.Size = New System.Drawing.Size(120, 20)
        Me.leviarsv.TabIndex = 26
        '
        'intensesv
        '
        Me.intensesv.Enabled = False
        Me.intensesv.Location = New System.Drawing.Point(333, 126)
        Me.intensesv.Name = "intensesv"
        Me.intensesv.Size = New System.Drawing.Size(120, 20)
        Me.intensesv.TabIndex = 27
        '
        'monerosv
        '
        Me.monerosv.Enabled = False
        Me.monerosv.Location = New System.Drawing.Point(333, 158)
        Me.monerosv.Name = "monerosv"
        Me.monerosv.Size = New System.Drawing.Size(120, 20)
        Me.monerosv.TabIndex = 28
        '
        'sumosv
        '
        Me.sumosv.Enabled = False
        Me.sumosv.Location = New System.Drawing.Point(333, 188)
        Me.sumosv.Name = "sumosv"
        Me.sumosv.Size = New System.Drawing.Size(120, 20)
        Me.sumosv.TabIndex = 29
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(165, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 20)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Wallet Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(344, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 20)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Server:Port"
        '
        'minutes
        '
        Me.minutes.AutoSize = True
        Me.minutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutes.Location = New System.Drawing.Point(636, 80)
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
        'aeonsel
        '
        Me.aeonsel.AutoSize = True
        Me.aeonsel.Checked = True
        Me.aeonsel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.aeonsel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aeonsel.Location = New System.Drawing.Point(12, 66)
        Me.aeonsel.Name = "aeonsel"
        Me.aeonsel.Size = New System.Drawing.Size(66, 24)
        Me.aeonsel.TabIndex = 35
        Me.aeonsel.Text = "Aeon"
        Me.aeonsel.UseVisualStyleBackColor = True
        '
        'leviarsel
        '
        Me.leviarsel.AutoSize = True
        Me.leviarsel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.leviarsel.Location = New System.Drawing.Point(12, 96)
        Me.leviarsel.Name = "leviarsel"
        Me.leviarsel.Size = New System.Drawing.Size(99, 24)
        Me.leviarsel.TabIndex = 36
        Me.leviarsel.Text = "Leviarcoin"
        Me.leviarsel.UseVisualStyleBackColor = True
        '
        'intensesel
        '
        Me.intensesel.AutoSize = True
        Me.intensesel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intensesel.Location = New System.Drawing.Point(12, 123)
        Me.intensesel.Name = "intensesel"
        Me.intensesel.Size = New System.Drawing.Size(111, 24)
        Me.intensesel.TabIndex = 37
        Me.intensesel.Text = "Intensecoin"
        Me.intensesel.UseVisualStyleBackColor = True
        '
        'monerosel
        '
        Me.monerosel.AutoSize = True
        Me.monerosel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monerosel.Location = New System.Drawing.Point(12, 156)
        Me.monerosel.Name = "monerosel"
        Me.monerosel.Size = New System.Drawing.Size(82, 24)
        Me.monerosel.TabIndex = 38
        Me.monerosel.Text = "Monero"
        Me.monerosel.UseVisualStyleBackColor = True
        '
        'sumosel
        '
        Me.sumosel.AutoSize = True
        Me.sumosel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sumosel.Location = New System.Drawing.Point(12, 185)
        Me.sumosel.Name = "sumosel"
        Me.sumosel.Size = New System.Drawing.Size(99, 24)
        Me.sumosel.TabIndex = 39
        Me.sumosel.Text = "Sumokoin"
        Me.sumosel.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.pooltab, Me.ToolStripStatusLabel3, Me.pingtab, Me.ToolStripStatusLabel1, Me.readout, Me.coinstat})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 249)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(783, 22)
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
        'IdleMine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 271)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.sumosel)
        Me.Controls.Add(Me.monerosel)
        Me.Controls.Add(Me.intensesel)
        Me.Controls.Add(Me.leviarsel)
        Me.Controls.Add(Me.aeonsel)
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
        Me.Text = "IdleMine 0.01"
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
    Friend WithEvents aeonsel As System.Windows.Forms.CheckBox
    Friend WithEvents leviarsel As System.Windows.Forms.CheckBox
    Friend WithEvents intensesel As System.Windows.Forms.CheckBox
    Friend WithEvents monerosel As System.Windows.Forms.CheckBox
    Friend WithEvents sumosel As System.Windows.Forms.CheckBox
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

End Class
