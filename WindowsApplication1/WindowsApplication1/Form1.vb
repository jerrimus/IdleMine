Imports System.Net
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json


Public Class IdleMine
    Implements IMessageFilter

    Private _curwal1 As Object
    Private _curwal2 As Object

    Private Property cointype As String

    Private Property liner As String

    Private Property Aw As Object

    Private Property ismining As Integer

    Private Property minenow As Integer

    Private Property wait1 As Object

    Private Property counter As Object

    Private Property htnum As JToken

    Private Property curserv As Object

    Private Property curwal As Object

    Private Property curpas As Char



    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub timeslid_Scroll(sender As Object, e As EventArgs) Handles timeslid.Scroll
        minutes.Text = timeslid.Value
    End Sub

    Private Sub IdleMine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ismining = 0
        Dim cointype As String = "aeon"
        counter = 0
        If System.IO.File.Exists("a.pas") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("a.pas")
            liner = rd.ReadToEnd()
            pasbox.Text = liner
        End If
        If System.IO.File.Exists("a.wal") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("a.wal")
            liner = rd.ReadToEnd()
            aeonwal.Text = liner
        End If
        If System.IO.File.Exists("a.sv") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("a.sv")
            liner = rd.ReadToEnd()
            aeonsv.Text = liner
        End If
        If System.IO.File.Exists("l.wal") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("l.wal")
            liner = rd.ReadToEnd()
            leviarwal.Text = liner
        End If
        If System.IO.File.Exists("l.sv") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("l.sv")
            liner = rd.ReadToEnd()
            leviarsv.Text = liner
        End If
        If System.IO.File.Exists("i.wal") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("i.wal")
            liner = rd.ReadToEnd()
            intensewal.Text = liner
        End If
        If System.IO.File.Exists("i.sv") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("i.sv")
            liner = rd.ReadToEnd()
            intensesv.Text = liner
        End If
        If System.IO.File.Exists("m.wal") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("m.wal")
            liner = rd.ReadToEnd()
            monerowal.Text = liner
        End If
        If System.IO.File.Exists("m.sv") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("m.sv")
            liner = rd.ReadToEnd()
            monerosv.Text = liner
        End If
        If System.IO.File.Exists("s.wal") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("s.wal")
            liner = rd.ReadToEnd()
            sumowal.Text = liner
        End If
        If System.IO.File.Exists("s.sv") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("s.sv")
            liner = rd.ReadToEnd()
            sumosv.Text = liner
        End If
        If System.IO.File.Exists("karb.wal") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("karb.wal")
            liner = rd.ReadToEnd()
            aeonwal.Text = liner
        End If
        If System.IO.File.Exists("karb.sv") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("karb.sv")
            liner = rd.ReadToEnd()
            aeonsv.Text = liner
        End If
        If System.IO.File.Exists("masari.wal") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("masari.wal")
            liner = rd.ReadToEnd()
            aeonwal.Text = liner
        End If
        If System.IO.File.Exists("masari.sv") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("masari.sv")
            liner = rd.ReadToEnd()
            aeonsv.Text = liner
        End If
        If System.IO.File.Exists("elec.wal") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("elec.wal")
            liner = rd.ReadToEnd()
            aeonwal.Text = liner
        End If
        If System.IO.File.Exists("elec.sv") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("elec.sv")
            liner = rd.ReadToEnd()
            aeonsv.Text = liner
        End If


    End Sub





    Private Sub SaveWalletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveWalletToolStripMenuItem.Click
        If cointype = "aeon" & pass.Checked = True Then
            Dim liner As String
            liner = pasbox.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("a.pas")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If cointype = "intense" & pass.Checked = True Then
            Dim liner As String
            liner = pasbox.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("intense.pas")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If cointype = "karb" & pass.Checked = True Then
            Dim liner As String
            liner = pasbox.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("karb.pas")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If cointype = "leviar" & pass.Checked = True Then
            Dim liner As String
            liner = pasbox.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("leviar.pas")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If cointype = "masari" & pass.Checked = True Then
            Dim liner As String
            liner = pasbox.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("masari.pas")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If cointype = "monero" & pass.Checked = True Then
            Dim liner As String
            liner = pasbox.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("monero.pas")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If cointype = "sumo" & pass.Checked = True Then
            Dim liner As String
            liner = pasbox.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("sumo.pas")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If aeonwal.Text <> "" Then
            Dim liner As String
            liner = aeonwal.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("a.wal")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If aeonsv.Text <> "" Then
            liner = aeonsv.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("a.sv")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If leviarwal.Text <> "" Then
            liner = leviarwal.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("l.wal")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If leviarsv.Text <> "" Then
            liner = leviarsv.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("l.sv")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If intensewal.Text <> "" Then
            liner = intensewal.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("i.wal")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If intensesv.Text <> "" Then
            liner = intensesv.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("i.sv")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If monerosv.Text <> "" Then
            liner = monerosv.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("m.sv")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If monerowal.Text <> "" Then
            liner = monerowal.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("m.wal")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If sumosv.Text <> "" Then
            liner = sumosv.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("s.sv")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If sumowal.Text <> "" Then
            liner = sumowal.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("s.wal")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If sumosv.Text <> "" Then
            liner = karbsv.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("karb.sv")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If sumowal.Text <> "" Then
            liner = karbwal.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("karb.wal")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If sumosv.Text <> "" Then
            liner = masarisv.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("masari.sv")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If sumowal.Text <> "" Then
            liner = masariwal.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("masari.wal")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If elecsv.Text <> "" Then
            liner = sumosv.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("elec.sv")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If
        If elecwal.Text <> "" Then
            liner = sumowal.Text
            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("elec.wal")
            wx.Write(liner)
            wx.Flush()
            wx.Close()
        End If



    End Sub

    Private Sub strop_Click(sender As Object, e As EventArgs) Handles strop.Click
        If ismining = 0 Then
            counter = 0
            clocky.Enabled = False
            upp.Enabled = True
            strop.Text = "Stop"

            Dim curpas As String
            curpas = "x"

            Dim wx As System.IO.TextWriter
            wx = System.IO.File.CreateText("config.json")
            wx.WriteLine("{")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.Write("algo")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.Write(": ")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            If cointype = "aeon" Then
                wx.Write("cryptonight-lite")

            Else
                wx.Write("cryptonight")
            End If
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.WriteLine(",")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.Write("av")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.WriteLine(": 0,")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.Write("background")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.WriteLine(": true,")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.Write("colors")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.WriteLine(": false,")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.Write("cpu-affinity")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.WriteLine(": null,")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.Write("cpu-priority")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.WriteLine(": null,")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.Write("donate-level")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.WriteLine(": 1,")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.Write("log-file")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.WriteLine(": null,")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.Write("cpu-affinity")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            If AMbox.Checked = True Then


                Dim anumb = activeslide.Value
                wx.Write(": ")
                wx.Write(anumb)
                wx.WriteLine(",")
            Else
                wx.WriteLine(": 85,")
            End If
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.Write("print-time")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.WriteLine(": 120,")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.Write("retries")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.WriteLine(": 5,")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.Write("retry-pause")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.WriteLine(": 5,")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.Write("safe")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.WriteLine(": false,")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.Write("threads")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.WriteLine(": null,")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.Write("pools")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.WriteLine(": [")
            wx.WriteLine("{")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.Write("url")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.Write(": ")
        wx.Write(Microsoft.VisualBasic.Chr(34))
        If cointype = "aeon" Then
            wx.Write(aeonsv.Text)
        End If
        If cointype = "intense" Then
            wx.Write(intensesv.Text)
        End If
        If cointype = "leviar" Then
            wx.Write(leviarsv.Text)
        End If
        If cointype = "monero" Then
            wx.Write(monerosv.Text)
        End If
        If cointype = "sumo" Then
            wx.Write(sumosv.Text)
        End If
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.WriteLine(",")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.Write("user")
            wx.Write(Microsoft.VisualBasic.Chr(34))
            wx.Write(": ")
        wx.Write(Microsoft.VisualBasic.Chr(34))
        If cointype = "aeon" Then
            wx.Write(aeonwal.Text)
        End If
        If cointype = "intense" Then
            wx.Write(intensewal.Text)
        End If
        If cointype = "leviar" Then
            wx.Write(leviarwal.Text)
        End If
        If cointype = "monero" Then
            wx.Write(monerowal.Text)
        End If
        If cointype = "sumo" Then
            wx.Write(sumowal.Text)
            End If

            wx.Write(Microsoft.VisualBasic.Chr(34))
        wx.WriteLine(",")
        wx.Write(Microsoft.VisualBasic.Chr(34))
        wx.Write("pass")
        wx.Write(Microsoft.VisualBasic.Chr(34))
        wx.Write(": ")
        wx.Write(Microsoft.VisualBasic.Chr(34))
        wx.Write(curpas)
        wx.Write(Microsoft.VisualBasic.Chr(34))
        wx.WriteLine(",")
        wx.Write(Microsoft.VisualBasic.Chr(34))
        wx.Write("keepalive")
        wx.Write(Microsoft.VisualBasic.Chr(34))
        wx.WriteLine(": true,")
        wx.Write(Microsoft.VisualBasic.Chr(34))
        wx.Write("nicehash")
        wx.Write(Microsoft.VisualBasic.Chr(34))
        wx.WriteLine(": false,")
        wx.WriteLine("}")
        wx.WriteLine("],")
        wx.Write(Microsoft.VisualBasic.Chr(34))
        wx.Write("api")
        wx.Write(Microsoft.VisualBasic.Chr(34))
        wx.WriteLine(": {")
        wx.Write(Microsoft.VisualBasic.Chr(34))
        wx.Write("port")
        wx.Write(Microsoft.VisualBasic.Chr(34))
        wx.WriteLine(": 6565,")
        wx.Write(Microsoft.VisualBasic.Chr(34))
        wx.Write("access-token")
        wx.Write(Microsoft.VisualBasic.Chr(34))
        wx.WriteLine(": null,")
        wx.Write(Microsoft.VisualBasic.Chr(34))
        wx.Write("worker-id")
        wx.Write(Microsoft.VisualBasic.Chr(34))
        wx.WriteLine(": null,")
        wx.WriteLine("}")
        wx.WriteLine("}")
        wx.Flush()
        wx.Close()



        Dim ProcessProperties As New ProcessStartInfo

        ProcessProperties.FileName = "xmrig"

        ProcessProperties.WindowStyle = ProcessWindowStyle.Hidden

        Dim myProcess As Process = Process.Start(ProcessProperties)

        ismining = 1





        Else
        For Each P As Process In System.Diagnostics.Process.GetProcessesByName("xmrig")
            P.Kill()
        Next
        readout.Text = "Not mining"
        strop.Text = "Start"
        upp.Enabled = False
        clocky.Enabled = True
        upp.Enabled = False
        pingtab.Text = "0"
        pooltab.Text = "Not Connected"
        ismining = 0
        End If
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            Me.Hide()
            NotifyIcon1.BalloonTipTitle = "Idleminer"
            NotifyIcon1.BalloonTipText = readout.Text
            NotifyIcon1.ShowBalloonTip(5000)
        End If
    End Sub
    Private Sub NotifyIcon1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles NotifyIcon1.DoubleClick
        Me.Show()
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub



    Private Sub clocky_Tick(sender As Object, e As EventArgs) Handles clocky.Tick
        counter = +1
        If counter >= timeslid.Value Then
            If IMbox.Checked = True Then
                strop.PerformClick()
            End If
        End If
    End Sub




    Private Sub upp_Tick_1(sender As Object, e As EventArgs) Handles upp.Tick
        If ismining = 1 Then
            Dim request As HttpWebRequest
            Dim response As HttpWebResponse = Nothing
            Dim reader As IO.StreamReader
            request = DirectCast(WebRequest.Create("http://127.0.0.1:6565"), HttpWebRequest)

            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New IO.StreamReader(response.GetResponseStream())
            Dim juju As String
            juju = reader.ReadToEnd()

            Dim jResults As JObject = JsonConvert.DeserializeObject(juju)

            pooltab.Text = (jResults.SelectToken("connection").SelectToken("pool")).ToString

            pingtab.Text = (jResults.SelectToken("connection").SelectToken("ping")).ToString

            readout.Text = (jResults.SelectToken("results").SelectToken("hashes_total")).ToString
        End If
    End Sub


    Public Function PreFilterMessage(ByRef m As System.Windows.Forms.Message) As Boolean Implements IMessageFilter.PreFilterMessage


        Dim mouse As Boolean = (m.Msg >= &H200 And m.Msg <= &H20D) Or (m.Msg >= &HA0 And m.Msg <= &HAD)

        'Check for keyboard button presses
        Dim kbd As Boolean = (m.Msg >= &H100 And m.Msg <= &H109)

        If mouse Or kbd Then

            counter = 0
            upp.Enabled = False
            Return True
        End If
        Return False
    End Function



    Private Sub aeonmen_Click(sender As Object, e As EventArgs) Handles aeonmen.Click
        cointype = "aeon"
        Me.Text = "IdleMine 0.01  -  Aeon"
        If System.IO.File.Exists("a.pas") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("a.pas")
            liner = rd.ReadToEnd()
            pasbox.Text = liner
        End If
        elecmen.Checked = False
        intensemen.Checked = False
        leviarmen.Checked = False
        masarimen.Checked = False
        moneromen.Checked = False
        sumomen.Checked = False
        karbmen.Checked = False
        aeonwal.Visible = True
        aeonsv.Visible = True
        elecwal.Visible = False
        elecsv.Visible = False
        intensewal.Visible = False
        intensesv.Visible = False
        karbwal.Visible = False
        karbsv.Visible = False
        leviarwal.Visible = False
        leviarsv.Visible = False
        masariwal.Visible = False
        masarisv.Visible = False
        monerowal.Visible = False
        monerosv.Visible = False
        sumowal.Visible = False
        sumosv.Visible = False

    End Sub

    Private Sub elecmen_Click(sender As Object, e As EventArgs) Handles elecmen.Click
        cointype = "elec"
        Me.Text = "IdleMine 0.01  -  Electroneum"
        If System.IO.File.Exists("elec.pas") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("elec.pas")
            liner = rd.ReadToEnd()
            pasbox.Text = liner
        End If
        aeonmen.Checked = False
        intensemen.Checked = False
        leviarmen.Checked = False
        masarimen.Checked = False
        moneromen.Checked = False
        sumomen.Checked = False
        karbmen.Checked = False
        aeonwal.Visible = False
        aeonsv.Visible = False
        elecwal.Visible = True
        elecsv.Visible = True
        intensewal.Visible = False
        intensesv.Visible = False
        karbwal.Visible = False
        karbsv.Visible = False
        leviarwal.Visible = False
        leviarsv.Visible = False
        masariwal.Visible = False
        masarisv.Visible = False
        monerowal.Visible = False
        monerosv.Visible = False
        sumowal.Visible = False
        sumosv.Visible = False
    End Sub

    Private Sub intensemen_Click(sender As Object, e As EventArgs) Handles intensemen.Click
        cointype = "intense"
        Me.Text = "IdleMine 0.01  -  Intensecoin"
        If System.IO.File.Exists("intense.pas") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("intense.pas")
            liner = rd.ReadToEnd()
            pasbox.Text = liner
        End If
        aeonmen.Checked = False
        elecmen.Checked = False
        leviarmen.Checked = False
        masarimen.Checked = False
        moneromen.Checked = False
        sumomen.Checked = False
        karbmen.Checked = False
        aeonwal.Visible = False
        aeonsv.Visible = False
        elecwal.Visible = False
        elecsv.Visible = False
        intensewal.Visible = True
        intensesv.Visible = True
        karbwal.Visible = False
        karbsv.Visible = False
        leviarwal.Visible = False
        leviarsv.Visible = False
        masariwal.Visible = False
        masarisv.Visible = False
        monerowal.Visible = False
        monerosv.Visible = False
        sumowal.Visible = False
        sumosv.Visible = False
    End Sub

    Private Sub karbmen_Click(sender As Object, e As EventArgs) Handles karbmen.Click
        cointype = "karb"
        Me.Text = "IdleMine 0.01  -  Karbowanec"
        If System.IO.File.Exists("karb.pas") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("karb.pas")
            liner = rd.ReadToEnd()
            pasbox.Text = liner
        End If
        aeonmen.Checked = False
        intensemen.Checked = False
        leviarmen.Checked = False
        masarimen.Checked = False
        moneromen.Checked = False
        sumomen.Checked = False
        elecmen.Checked = False
        aeonwal.Visible = False
        aeonsv.Visible = False
        elecwal.Visible = False
        elecsv.Visible = False
        intensewal.Visible = False
        intensesv.Visible = False
        karbwal.Visible = True
        karbsv.Visible = True
        leviarwal.Visible = False
        leviarsv.Visible = False
        masariwal.Visible = False
        masarisv.Visible = False
        monerowal.Visible = False
        monerosv.Visible = False
        sumowal.Visible = False
        sumosv.Visible = False
    End Sub

    Private Sub leviarmen_Click(sender As Object, e As EventArgs) Handles leviarmen.Click
        cointype = "leviar"
        Me.Text = "IdleMine 0.01  -  Leviarcoin"
        If System.IO.File.Exists("leviar.pas") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("leviar.pas")
            liner = rd.ReadToEnd()
            pasbox.Text = liner
        End If
        aeonmen.Checked = False
        intensemen.Checked = False
        elecmen.Checked = False
        masarimen.Checked = False
        moneromen.Checked = False
        sumomen.Checked = False
        karbmen.Checked = False
        aeonwal.Visible = False
        aeonsv.Visible = False
        elecwal.Visible = False
        elecsv.Visible = False
        intensewal.Visible = False
        intensesv.Visible = False
        karbwal.Visible = False
        karbsv.Visible = False
        leviarwal.Visible = True
        leviarsv.Visible = True
        masariwal.Visible = False
        masarisv.Visible = False
        monerowal.Visible = False
        monerosv.Visible = False
        sumowal.Visible = False
        sumosv.Visible = False
    End Sub

    Private Sub masarimen_Click(sender As Object, e As EventArgs) Handles masarimen.Click
        cointype = "masari"
        Me.Text = "IdleMine 0.01  -  Masari"
        If System.IO.File.Exists("masari.pas") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("masari.pas")
            liner = rd.ReadToEnd()
            pasbox.Text = liner
        End If
        aeonmen.Checked = False
        intensemen.Checked = False
        leviarmen.Checked = False
        elecmen.Checked = False
        moneromen.Checked = False
        sumomen.Checked = False
        karbmen.Checked = False
        aeonwal.Visible = False
        aeonsv.Visible = False
        elecwal.Visible = False
        elecsv.Visible = False
        intensewal.Visible = False
        intensesv.Visible = False
        karbwal.Visible = False
        karbsv.Visible = False
        leviarwal.Visible = False
        leviarsv.Visible = False
        masariwal.Visible = True
        masarisv.Visible = True
        monerowal.Visible = False
        monerosv.Visible = False
        sumowal.Visible = False
        sumosv.Visible = False
    End Sub

    Private Sub moneromen_Click(sender As Object, e As EventArgs) Handles moneromen.Click
        cointype = "monero"
        Me.Text = "IdleMine 0.01  -  Monero"
        If System.IO.File.Exists("monero.pas") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("monero.pas")
            liner = rd.ReadToEnd()
            pasbox.Text = liner
        End If
        aeonmen.Checked = False
        intensemen.Checked = False
        leviarmen.Checked = False
        masarimen.Checked = False
        elecmen.Checked = False
        sumomen.Checked = False
        karbmen.Checked = False
        aeonwal.Visible = False
        aeonsv.Visible = False
        elecwal.Visible = False
        elecsv.Visible = False
        intensewal.Visible = False
        intensesv.Visible = False
        karbwal.Visible = False
        karbsv.Visible = False
        leviarwal.Visible = False
        leviarsv.Visible = False
        masariwal.Visible = False
        masarisv.Visible = False
        monerowal.Visible = True
        monerosv.Visible = True
        sumowal.Visible = False
        sumosv.Visible = False
    End Sub

    Private Sub sumomen_Click(sender As Object, e As EventArgs) Handles sumomen.Click
        cointype = "sumo"
        Me.Text = "IdleMine 0.01  -  Sumokoin"
        If System.IO.File.Exists("sumo.pas") Then

            Dim rd As System.IO.StreamReader
            Dim liner As String
            rd = IO.File.OpenText("sumo..pas")
            liner = rd.ReadToEnd()
            pasbox.Text = liner
        End If
        aeonmen.Checked = False
        intensemen.Checked = False
        leviarmen.Checked = False
        masarimen.Checked = False
        moneromen.Checked = False
        elecmen.Checked = False
        karbmen.Checked = False
        aeonwal.Visible = False
        aeonsv.Visible = False
        elecwal.Visible = False
        elecsv.Visible = False
        intensewal.Visible = False
        intensesv.Visible = False
        karbwal.Visible = False
        karbsv.Visible = False
        leviarwal.Visible = False
        leviarsv.Visible = False
        masariwal.Visible = False
        masarisv.Visible = False
        monerowal.Visible = False
        monerosv.Visible = False
        sumowal.Visible = True
        sumosv.Visible = True
    End Sub

    Private Sub pass_CheckedChanged(sender As Object, e As EventArgs) Handles pass.CheckedChanged
        If pass.Checked = True Then pasbox.Enabled = True
        If pass.Checked = False Then pasbox.Enabled = False
    End Sub
End Class







