Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions

Public Class Form1
    Dim My_Process As New Process()
    Dim My_Process_Info As New ProcessStartInfo()
    Dim proc As System.Diagnostics.Process
    Dim pProcess As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\cnd.exe"
    Dim dll1 As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\AdbWinUsbApi.dll"
    Dim dll2 As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\AdbWinApi.dll"
    Dim fT As String = My.Computer.FileSystem.SpecialDirectories.Temp & "\token.txt"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PBar.Enabled = True
        PBar.Visible = True
        btnCopyToken.Text = "Copy"
        btnCopyCookie.Text = "Copy"
        txtUID.Text = ""
        txtToken.Text = ""
        txtCookie.Text = ""

        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        For Each proc As Process In Process.GetProcessesByName("cnd")
            proc.Kill()
        Next
        IO.File.WriteAllBytes(pProcess, My.Resources.adb)

    End Sub

    Public Function RunCharacterCheckASCII(ByVal s As String) As String
        Dim str As String = s
        Dim is_find As Boolean = False
        Dim ch As Char
        Dim ich As Integer = 0

        Try
            Dim schar As Char() = str.ToCharArray()

            For i As Integer = 0 To schar.Length - 1
                ch = schar(i)
                ich = Microsoft.VisualBasic.AscW(ch)

                If ich > 127 Then ' not ascii or extended ascii
                    is_find = True
                    schar(i) = "?"c
                End If
            Next

            If is_find Then str = New String(schar)
        Catch ex As Exception
        End Try

        Return str
    End Function

    Private Sub btnCopyToken_Click(sender As Object, e As EventArgs) Handles btnCopyToken.Click
        My.Computer.Clipboard.SetText(txtToken.Text)
        btnCopyToken.Text = "Đã copy"
    End Sub

    Private Sub btnCopyCookie_Click(sender As Object, e As EventArgs) Handles btnCopyCookie.Click
        My.Computer.Clipboard.SetText(txtCookie.Text)
        btnCopyCookie.Text = "Đã copy"
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub


    Function Decrypt(text As String, password As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Dim hash(31) As Byte
        Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(password))
        Array.Copy(temp, 0, hash, 0, 16)
        Array.Copy(temp, 0, hash, 15, 16)
        AES.Key = hash
        AES.Mode = Security.Cryptography.CipherMode.ECB
        Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
        Dim Buffer As Byte() = Convert.FromBase64String(text)
        decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Return decrypted
    End Function

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim sArgs As String = "/c adb pull /data/data/com.facebook.katana/app_light_prefs/com.facebook.katana/authentication " & fT
        Console.WriteLine(sArgs)
        Dim startInfo As New ProcessStartInfo("cmd.exe")
        startInfo.WindowStyle = ProcessWindowStyle.Minimized
        startInfo.Arguments = sArgs
        startInfo.RedirectStandardOutput = True
        startInfo.UseShellExecute = False
        startInfo.CreateNoWindow = True
        Dim p = Process.Start(startInfo)
        Dim result = p.StandardOutput.ReadToEnd()
        p.Close()
        If My.Computer.FileSystem.FileExists(fT) Then
            Dim t As String = My.Computer.FileSystem.ReadAllText(fT)
            My.Computer.FileSystem.DeleteFile(fT)
            t = Regex.Replace(t, "[^\u0020-\u007E]", "|")

            Dim m As Match = Regex.Match(t, "EAA(.*?)\|", RegexOptions.IgnoreCase)
            If (m.Success) Then
                Dim key As String = m.Groups(1).Value
                txtToken.Text = "EAA" & key
            Else
                MsgBox("Không tìm thấy Token. Bạn hãy chắc chắn đã làm đúng các bước?")
            End If

            Dim m2 As Match = Regex.Match(t, "\[\{(.*?)\}\]", RegexOptions.IgnoreCase)
            If (m2.Success) Then
                Dim key As String = m2.Groups(0).Value
                txtCookie.Text = key
            End If

            Dim m3 As Match = Regex.Match(t, "uid\|\|(.*?)\|", RegexOptions.IgnoreCase)
            If (m3.Success) Then
                Dim key As String = m3.Groups(1).Value
                txtUID.Text = key
            End If

        Else
            MsgBox("Không tìm thấy Token. Bạn hãy chắc chắn đã làm đúng các bước??")
        End If


        PBar.Enabled = False
        PBar.Visible = False

        For Each proc As Process In Process.GetProcessesByName("cnd")
            'proc.Kill()
        Next
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub
End Class
