Imports System.IO
Imports System.Net
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.Net.NetworkInformation
Imports System.Management
Imports System.Runtime.InteropServices


Public Class Form1
    Dim p() As Process
    Private ofd As New OpenFileDialog
    Private J As String = ""
    Dim UserAccName As String = SystemInformation.UserName
    'On Load
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

        My.Computer.FileSystem.CopyFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\.minecraft\logs\latest.log",
Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\.minecraft\logs\latestc.log")

        Using reader As New StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\.minecraft\logs\latestc.log")
            While Not reader.EndOfStream
                Dim line As String = reader.ReadLine()
                If line.Contains("Setting user: ") Then

                    Dim lastpart As String = line.Substring(line.LastIndexOf(": ") + 1)

                    FlatLabel2.Text = (lastpart)
                    FlatAlertBox3.Visible = True
                    FlatAlertBox3.Text = ("Loaded username ")
                    Exit While
                End If
            End While
        End Using
        My.Computer.FileSystem.DeleteFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\.minecraft\logs\latestc.log")

    End Sub

    'recording check
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

        Dim recordings As New List(Of String)

        p = Process.GetProcessesByName("obs")
        If p.Count > 0 Then
            recordings.Add("OBS")
        End If
        p = Process.GetProcessesByName("obs32")
        If p.Count > 0 Then
        End If
        p = Process.GetProcessesByName("obs64")
        If p.Count > 0 Then
            recordings.Add("OBS")
        End If
        p = Process.GetProcessesByName("ShareX")
        If p.Count > 0 Then
            recordings.Add("ShareX")
        End If
        p = Process.GetProcessesByName("action")
        If p.Count > 0 Then
            recordings.Add("Action")
        End If
        p = Process.GetProcessesByName("NVIDIA Share")
        If p.Count > 0 Then
            recordings.Add("ShadowPlay")
        End If
        p = Process.GetProcessesByName("amddvr")
        If p.Count > 0 Then
            recordings.Add("AMD Relive")
        End If
        p = Process.GetProcessesByName("amdow")
        If p.Count > 0 Then
            recordings.Add("AMD Relive")
        End If
        p = Process.GetProcessesByName("WSHelper")
        If p.Count > 0 Then
            recordings.Add("WonderShare")
        End If

        Dim thing As String = String.Join(vbNewLine, recordings)

        MessageBox.Show(thing,
        "Recording Software",
        MessageBoxButtons.OK,
        MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button1)

    End Sub

    'javaw scanner
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Dim time As String = System.DateTime.Today.ToShortDateString
        FlatAlertBox1.Visible = False
        FlatAlertBox2.Visible = False
        FlatAlertBox3.Visible = False
        ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd.Multiselect = False

        If ofd.ShowDialog = DialogResult.OK Then

            J = IO.File.ReadAllText(ofd.FileName)

            Select Case True
                Case J.Contains("String1"), J.Contains("String2"), J.Contains("String3"), J.Contains("Etc Etc")
                    FlatAlertBox2.Visible = True
                    FlatAlertBox2.Text = "[ ! ] Cheats Found"
                    FlatTextBox3.Text = (time)
                Case Else
                    FlatAlertBox1.Visible = True
                    FlatAlertBox1.Text = "User is Clean"

            End Select

        Else

            MessageBox.Show("Please select a Javaw file!")


        End If
    End Sub

    'Explorer scanner
    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        Dim time As String = System.DateTime.Today.ToShortDateString
        FlatAlertBox1.Visible = False
        FlatAlertBox2.Visible = False
        FlatAlertBox3.Visible = False
        ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd.Multiselect = False

        If ofd.ShowDialog = DialogResult.OK Then

            J = IO.File.ReadAllText(ofd.FileName)

            Select Case True
                Case J.Contains("String1"), J.Contains("String2"), J.Contains("String3"), J.Contains("Etc Etc")
                    FlatAlertBox2.Visible = True
                    FlatAlertBox2.Text = "[ ! ] Cheats Found"
                    FlatTextBox3.Text = (time)
                Case Else
                    FlatAlertBox1.Visible = True
                    FlatAlertBox1.Text = "User is Clean"

            End Select

        Else

            MessageBox.Show("Please select a Explorer file!")


        End If
    End Sub

    'lsass scanner
    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Dim time As String = System.DateTime.Today.ToShortDateString
        FlatAlertBox1.Visible = False
        FlatAlertBox2.Visible = False
        FlatAlertBox3.Visible = False
        ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd.Multiselect = False

        If ofd.ShowDialog = DialogResult.OK Then

            J = IO.File.ReadAllText(ofd.FileName)

            Select Case True
                Case J.Contains("String1"), J.Contains("String2"), J.Contains("String3"), J.Contains("Etc Etc")
                    FlatAlertBox2.Visible = True
                    FlatAlertBox2.Text = "[ ! ] Cheats Found"
                    FlatTextBox3.Text = (time)
                Case Else
                    FlatAlertBox1.Visible = True
                    FlatAlertBox1.Text = "User is Clean"

            End Select


        Else

            MessageBox.Show("Please select a Javaw file!")


        End If
    End Sub

    'DWM scanner
    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        Dim time As String = System.DateTime.Today.ToShortDateString
        FlatAlertBox1.Visible = False
        FlatAlertBox2.Visible = False
        FlatAlertBox3.Visible = False
        ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        ofd.Multiselect = False

        If ofd.ShowDialog = DialogResult.OK Then

            J = IO.File.ReadAllText(ofd.FileName)

            Select Case True
                Case J.Contains("String1"), J.Contains("String2"), J.Contains("String3"), J.Contains("Etc Etc")
                    FlatAlertBox2.Visible = True
                    FlatAlertBox2.Text = "[ ! ] Cheats Found"
                    FlatTextBox3.Text = (time)
                Case Else
                    FlatAlertBox1.Visible = True
                    FlatAlertBox1.Text = "User is Clean"

            End Select


        Else

            MessageBox.Show("Please select a Javaw file!")


        End If

    End Sub

    'Alt checker
    Private Sub FlatButton8_Click(sender As Object, e As EventArgs) Handles FlatButton8.Click
        alts.Show()
        alts.FlatListBox1.Clear()



        If File.Exists("C:\Users\" & UserAccName & "\AppData\Roaming\.minecraft\launcher_profiles.json") = False Then
            MsgBox("File Not Found: launcher_profiles.json")
        Else

            Dim lines As String() = File.ReadAllLines("C:\Users\" & UserAccName & "\AppData\Roaming\.minecraft\launcher_profiles.json")
            Dim selectLines As IEnumerable(Of String) = lines.Where(Function(line) line.Contains("displayName"))

            For Each item In selectLines

                Dim cleanstring As String = Regex.Replace(item, "displayName", "")
                Dim cleanchars As String = Regex.Replace(cleanstring, "[^A-Za-z0-9\-/]", "")

                alts.FlatListBox1.AddItem(cleanchars)
                'MsgBox(cleanchars)

            Next

        End If
    End Sub

    'macro detect
    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        FlatAlertBox1.Visible = False
        FlatAlertBox2.Visible = False
        FlatAlertBox3.Visible = False
        If My.Computer.FileSystem.DirectoryExists("C:\ProgramData\Razer\Razer Central\Accounts\") Then
            Dim programFiles As New DirectoryInfo("C:\ProgramData\Razer\Razer Central\Accounts\")
            Dim result As List(Of DirectoryInfo)
            Dim counter As Integer = 0

            result = programFiles.GetDirectories("RZR*").ToList()

            For Each dir As DirectoryInfo In result
                Dim folder As String = (dir.FullName)
                Dim Files As String() = System.IO.Directory.GetFiles(folder & "\Emily3\Macros\", "*.xml")
                For Each sFile As String In Files
                    counter = counter + 1
                    Dim fileCont As String = System.IO.File.ReadAllText(sFile)
                    Dim startIndex = fileCont.IndexOf("Button")
                    If startIndex > 0 Then
                        FlatAlertBox2.Visible = True
                        FlatAlertBox2.Text = ("Possible macro found ")
                    Else
                    End If
                Next
            Next
        Else
        End If

        If My.Computer.FileSystem.DirectoryExists("C:\ProgramData\Razer\Synapse\Accounts") Then
            Dim programFiles As New DirectoryInfo("C:\ProgramData\Razer\Synapse\Accounts")
            Dim result As List(Of DirectoryInfo)
            Dim counter As Integer = 0

            result = programFiles.GetDirectories("AM_*").ToList()

            For Each dir As DirectoryInfo In result
                Dim folder As String = (dir.FullName)
                Dim Files As String() = System.IO.Directory.GetFiles(folder & "\Macros\", "*.xml")
                For Each sFile As String In Files
                    counter = counter + 1
                    Dim fileCont As String = System.IO.File.ReadAllText(sFile)
                    Dim startIndex = fileCont.IndexOf("Button")
                    If startIndex > 0 Then
                        FlatAlertBox2.Visible = True
                        FlatAlertBox2.Text = ("Possible macro found")
                    Else
                    End If
                Next
            Next
        Else
        End If
    End Sub

    'recycle bin check
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim ff As System.Security.Principal.WindowsIdentity
        ff = System.Security.Principal.WindowsIdentity.GetCurrent

        Dim ee = ff.User.ToString()

        Dim DirectoryInfo = New DirectoryInfo("C:\$Recycle.Bin\" & ee)

        Dim dt As String = Directory.GetLastWriteTime(DirectoryInfo.ToString)

        Dim Caption As String = "Recycle Bin (Last Modified): "
        Dim Buttons As MessageBoxButtons = MessageBoxButtons.OK

        Dim Result As DialogResult

        Result = MessageBox.Show(dt, Caption, Buttons)
    End Sub

    'website check
    Private Sub FlatButton10_Click(sender As Object, e As EventArgs) Handles FlatButton10.Click
        If My.Computer.FileSystem.FileExists("C:\Users\" & UserAccName & "\AppData\Local\Google\Chrome\User Data\Default\Historyc") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\" & UserAccName & "\AppData\Local\Google\Chrome\User Data\Default\Historyc")
        End If

        My.Computer.FileSystem.CopyFile("C:\Users\" & UserAccName & "\AppData\Local\Google\Chrome\User Data\Default\History",
"C:\Users\" & UserAccName & "\AppData\Local\Google\Chrome\User Data\Default\Historyc")

        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\" & UserAccName & "\AppData\Local\Google\Chrome\User Data\Default\Historyc")

        Dim webresults As New List(Of String)

        If fileReader.Contains("demon.gg") Then
            webresults.Add("Demon Found")
        End If
        If fileReader.Contains("vape.gg") Then
            webresults.Add("Vape Found")
        End If
        If fileReader.Contains("apolloclicker.pw") Then
            webresults.Add("Apollo Found")
        End If
        If fileReader.Contains("indigoclient.xyz") Then
            webresults.Add("Indigo Found")
        End If
        If fileReader.Contains("neverlack.in/dl/") Then
            webresults.Add("Drip Found")
        End If
        If fileReader.Contains("drip.gg") Then
            webresults.Add("Drip Found")
        End If
        If fileReader.Contains("wifi.rip") Then
            webresults.Add("Booter Found")
        End If
        If fileReader.Contains("quezstresser.xyz") Then
            webresults.Add("Booter Found")
        End If
        If fileReader.Contains("booter.xyz") Then
            webresults.Add("Booter Found")
        End If
        If fileReader.Contains("Booter.pw") Then
            webresults.Add("Booter Found")
        End If
        If fileReader.Contains("vbooter.org") Then
            webresults.Add("Booter Found")
        End If
        If fileReader.Contains("iDDos.net") Then
            webresults.Add("Booter Found")
        End If
        If fileReader.Contains("Str3ssed.me ") Then
            webresults.Add("Booter Found")
        End If
        If fileReader.Contains("Netstress.org") Then
            webresults.Add("Booter Found")
        End If

        Dim thing As String = String.Join(vbNewLine, webresults)

        MessageBox.Show(thing, "Web Results")

        My.Computer.FileSystem.DeleteFile("C:\Users\" & UserAccName & "\AppData\Local\Google\Chrome\User Data\Default\Historyc")

    End Sub

    'clear
    Private Sub Clear(ByRef Timeout As Integer)

        Dim floc As String = My.Application.Info.DirectoryPath
        Dim p As New System.Diagnostics.ProcessStartInfo("cmd.exe")

        p.Arguments = "/c TIMEOUT 2 & cd " & floc & " & del ""Cheater*"" " & ControlChars.Quote & Application.ExecutablePath & ControlChars.Quote
        p.CreateNoWindow = True
        p.ErrorDialog = False
        p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden

        System.Diagnostics.Process.Start(p)
        Application.ExitThread()
    End Sub


    'close
    Private Sub FlatClose1_Click(sender As Object, e As EventArgs) Handles FlatClose1.Click

        Clear(1)
        Me.Close()

    End Sub

    Private Sub FlatButton6_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click
        cps.Show()
    End Sub

End Class
