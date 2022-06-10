Imports System.IO
Imports System.Text

Public Class LauncherOptions

    Private Sub gOptions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        Main.Enabled = True
    End Sub

    Private Sub applyBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles applyBt.Click

        If RadioButton1.Checked Then

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "Resolution", &H0)

        End If

        If RadioButton2.Checked Then

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "Resolution", &H1)

        End If

        If RadioButton3.Checked Then

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "Resolution", &H2)

        End If

        If RadioButton4.Checked Then

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "Resolution", &H3)

        End If

        If RadioButton5.Checked Then

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "Resolution", &H4)

        End If

        If RadioButton6.Checked Then

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "Resolution", &H5)

        End If


        If CheckBox1.Checked Then

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "MusicOnOff", &H1)
        Else

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "MusicOnOff", &H0)
        End If

        If CheckBox2.Checked Then

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "SoundOnOff", &H1)
        Else

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "SoundOnOff", &H0)
        End If

        If wModeBt.Checked Then

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "WindowMode", &H1)
        Else

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "WindowMode", &H0)
        End If

        If languagesLB.SelectedIndex = 0 Then

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "LangSelection", "Por")

        ElseIf languagesLB.SelectedIndex = 1 Then

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "LangSelection", "Eng")

        ElseIf languagesLB.SelectedIndex = 2 Then

            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "LangSelection", "Spn")

        End If

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "ID", MyID.Text)

        'Português
        'English
        'Español



        Me.Close()

    End Sub

    Private Sub gOptions_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ValorTela = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "Resolution", Nothing)
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        If ValorTela = &H0.ToString Then

            RadioButton1.Checked = True

        ElseIf ValorTela = &H1.ToString Then

            RadioButton2.Checked = True

        ElseIf ValorTela = &H2.ToString Then

            RadioButton3.Checked = True

        ElseIf ValorTela = &H3.ToString Then

            RadioButton4.Checked = True

        ElseIf ValorTela = &H4.ToString Then

            RadioButton5.Checked = True

        ElseIf ValorTela = &H5.ToString Then

            RadioButton6.Checked = True


        End If

        Dim ValorMusic = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "MusicOnOff", Nothing)

        If ValorMusic = &H1.ToString Then

            CheckBox1.Checked = True

        Else

            CheckBox1.Checked = False

        End If

        Dim ValorSound = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "SoundOnOff", Nothing)

        If ValorSound = &H1.ToString Then

            CheckBox2.Checked = True

        Else

            CheckBox2.Checked = False

        End If

        Dim ValorWind = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "WindowMode", Nothing)

        If ValorWind = &H1.ToString Then

            wModeBt.Checked = True

        Else

            wModeBt.Checked = False

        End If


        Dim ValorLang = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "LangSelection", Nothing)

        If ValorLang = "Por" Then

            languagesLB.SelectedIndex = 0

        ElseIf ValorLang = "Eng" Then

            languagesLB.SelectedIndex = 1

        ElseIf ValorLang = "Spn" Then

            languagesLB.SelectedIndex = 2

        End If

        Dim ValorID = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Webzen\Mu\Config", "ID", Nothing)

        MyID.Text = ValorID

    End Sub

    Private Sub cancelBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelBt.Click

        Me.Close()

    End Sub
End Class