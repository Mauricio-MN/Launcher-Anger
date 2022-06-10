Option Explicit On
Imports Microsoft.Win32
Imports System.Net
Imports System.IO
Imports System.Security.Cryptography
Imports System.Threading
Imports System.Speech
Imports System.Net.Sockets
Imports System.Net.NetworkInformation
Imports System.Text
Imports System.Drawing

Public Class Main

    Private statusCheckLink = "https://mylink.com/file.txt"
    Private linkUpadates = "https://mylink.com/"

    Dim configmain As String = "1"

    Dim speaker As New Synthesis.SpeechSynthesizer
    'Declarando trd Para ser um Thread
    Dim trd As Object = New Thread(AddressOf ThreadTask)
    'Declara Variavel controladora do RESIZE da janela
    Dim JanelaTick As Integer = 0

    Dim EnableSpeak As Boolean = False
    Dim EnableMUFILE As Boolean = False

    'Funcao chamada speak
    Public Sub Speak(ByVal say As String)

        If EnableSpeak = True Then

            speaker.SpeakAsync(say)

        End If

    End Sub

    Private Sub ThreadTask()

        'variavel que permite app continuar
        Dim AttContinue As Integer = 1
        Dim TenhoUpdate As Integer = 1

        'Removendo Update anterior
        If System.IO.File.Exists("temp.ang") Then
            My.Computer.FileSystem.DeleteFile("temp.ang")
        End If

        'criando uma instância da classe WebClient
        Dim cliente As WebClient = New WebClient

        'Obter lista de atts
        Try
            My.Computer.Network.DownloadFile(linkUpadates & "update.txt", "temp.ang")
            'MsgBox("Arquivo recebido com sucesso.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message & " Erro Ao tentar obter a lista de atualizações! " & ex.Source)

            TenhoUpdate = 0

        End Try

        'limpa a memoria
        cliente.Dispose()


        If TenhoUpdate = 0 Then
            File.Create("temp.ang").Close()
            InfoUpdate.Text = "Failed Update. . ."
            trd.Abort()
            Return
        Else

            InfoUpdate.Text = "Please wait. . ."
            ProgressDown.Value = 0

        End If

        'Lendo linhas, para comparar arquivos do update
        For Each line As String In File.ReadLines("temp.ang")

            'botao de play desabilitado
            Play.Enabled = False

            'Dividindo Arquivo da CRC
            Dim FileAndCRC As String() = Split(line, ";", 2)

            Dim FileATT As String = ""
            Dim FileCRC As String = ""

            'Reservando CRC e Arquivo
            FileCRC = FileAndCRC(1)
            FileATT = FileAndCRC(0)


            'Checagem do arquivo original
            '
            Dim Crc_Class As New CRC32
            'Dim Raw_Crc_Integer As Integer
            Dim Formated_CRC_String As String

            Static Dim CrcFileOri As String
            CrcFileOri = "Junior"

            If System.IO.File.Exists(Application.StartupPath & "\" & FileATT) Then


                Dim m_FileStream As New FileStream(FileATT, FileMode.Open, FileAccess.Read, FileShare.Read, 8192I)


                Formated_CRC_String = Crc_Class.GetCrc32String(m_FileStream)

                m_FileStream.Close()

                CrcFileOri = Formated_CRC_String

            End If

            'Caso a CRC seja diferente
            If (Not CrcFileOri = FileCRC) Then

                Dim redown As Integer = 1
                Dim maxtry As Integer = 0
                Dim updateArchive As Integer = 1
                Dim folder As String = ""

                'Se download falhar tenta 15 vezes
                While redown = 1 And maxtry <= 15

                    Try
                        'Zera o Redownload(para nao tentar novamente)
                        redown = 0

                        updateArchive = 1

                        'Zera a barra de progresso
                        ProgressDown.Value = 0

                        'Mostra arquivo abaixo da barra
                        InfoUpdate.Text = "Update - " & FileATT

                        'Criando Pasta para update(caso haja uma)
                        If FileATT.Contains("\") Then


                            Dim SPasta As String
                            folder = System.IO.Path.GetFileName(FileATT)

                            SPasta = FileATT.Replace(folder, "")

                            If (Not System.IO.Directory.Exists(SPasta)) Then
                                System.IO.Directory.CreateDirectory(SPasta)
                            End If

                        End If

                        'Criando nova instancia, para fazer o download
                        Dim webClient As New WebClient()

                        'Atualiza barra de carregamento, conforme o download ocorre
                        AddHandler webClient.DownloadProgressChanged, AddressOf DownloadProgressChanged

                        If Not File.Exists(Application.StartupPath & "\" & FileATT & ".ang") Then
                            'Inicia download
                            webClient.DownloadFile(New Uri("https://muangenge.net/updatelauncher/" & FileATT.Replace("\", "/")), Application.StartupPath & "\" & FileATT & ".ang")
                        End If

                        'limpa a memoria
                        webClient.Dispose()

                        'Preenche a barra de progresso
                        ProgressDown.Value = 100

                        'Pausa para nao sobrecarregar CPU

                        trd.Sleep(10)

                        'Caso retorne algum erro
                    Catch ex As Exception

                        updateArchive = 0

                        'Update falhou(mostra na barra abaixo da progressbar)
                        Me.InfoUpdate.Text = "Failed Update - " & FileATT

                        'Atualiza tentativas de download
                        maxtry = maxtry + 1

                        'Seta para fezer o redownload
                        redown = 1

                        'Caso ja tenha esgotado as tentativas
                        If maxtry = 16 Then

                            MsgBox("Falha na atualização", MsgBoxStyle.Information)

                            'Impede atualizacao de continuar
                            AttContinue = 0

                        End If


                    End Try

                    'Se pode substituir o velho arquivo
                    If updateArchive = 1 Then

                        'Se o arquivo existe deleta
                        If System.IO.File.Exists(Application.StartupPath & "\" & FileATT) Then
                            My.Computer.FileSystem.DeleteFile(FileATT)
                        End If

                        'Se estiver em uma pasta
                        If FileATT.Contains("\") Then
                            My.Computer.FileSystem.RenameFile(Application.StartupPath & "\" & FileATT & ".ang", folder)

                            'Se for um arquivo do local
                        Else

                            My.Computer.FileSystem.RenameFile(Application.StartupPath & "\" & FileATT & ".ang", FileATT)

                        End If

                    End If

                End While


            End If

            'Mensagem extra de erro
            If AttContinue = 0 Then

                MsgBox("Verifique sua conexão com a internet. . .", MsgBoxStyle.Information)

                Exit For

            End If

        Next

        If Not AttContinue = 0 Then

            ProgressDown.Value = 100

            InfoUpdate.Text = "Update Sucess!"

            Speak("Upideiti Finalizado!")


        End If

        'Finaliza e ativa o play
        Play.Enabled = True

        trd.Abort()


    End Sub


    'PLAY BUTTON
    Private Sub Play_Hover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Play.MouseHover

        With Play


            .UseVisualStyleBackColor = False
            .BackColor = Color.Transparent
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackgroundImageLayout = ImageLayout.Center
            .BackgroundImage = My.Resources.PLAY_HOVER_ 'image name from Resources

        End With

    End Sub
    Private Sub Play_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Play.MouseLeave

        With Play


            .UseVisualStyleBackColor = False
            .BackColor = Color.Transparent
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackgroundImageLayout = ImageLayout.Center
            .BackgroundImage = My.Resources.PLAY_ 'image name from Resources

        End With

    End Sub

    'OTHER BUTTONS
    Private Sub Options_Hover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Options.MouseHover

        With Options


            .UseVisualStyleBackColor = False
            .BackColor = Color.Transparent
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackgroundImageLayout = ImageLayout.Center
            .BackgroundImage = My.Resources.BT_HOVER_ 'My.Resources.BT_HOVER_ 'image name from Resources

        End With

    End Sub
    Private Sub siteBt_Hover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles siteBt.MouseHover

        With siteBt


            .UseVisualStyleBackColor = False
            .BackColor = Color.Transparent
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackgroundImageLayout = ImageLayout.Center
            .BackgroundImage = My.Resources.BT_HOVER_ 'image name from Resources

        End With

    End Sub
    Private Sub registerBt_Hover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registerBt.MouseHover

        With registerBt


            .UseVisualStyleBackColor = False
            .BackColor = Color.Transparent
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackgroundImageLayout = ImageLayout.Center
            .BackgroundImage = My.Resources.BT_HOVER_ 'image name from Resources

        End With

    End Sub
    Private Sub forumBt_Hover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles forumBt.MouseHover

        With forumBt


            .UseVisualStyleBackColor = False
            .BackColor = Color.Transparent
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackgroundImageLayout = ImageLayout.Center
            .BackgroundImage = My.Resources.BT_HOVER_ 'image name from Resources

        End With

    End Sub

    Private Sub guidesBt_Hover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guidesBt.MouseHover

        With guidesBt


            .UseVisualStyleBackColor = False
            .BackColor = Color.Transparent
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackgroundImageLayout = ImageLayout.Center
            .BackgroundImage = My.Resources.BT_HOVER_ 'image name from Resources

        End With

    End Sub

    'BUTTONS NORMAL

    Private Sub Options_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Options.MouseLeave

        With Options


            .UseVisualStyleBackColor = False
            .BackColor = Color.Transparent
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackgroundImageLayout = ImageLayout.Center
            .BackgroundImage = My.Resources.BT_ 'image name from Resources

        End With

    End Sub
    Private Sub siteBt_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles siteBt.MouseLeave

        With siteBt


            .UseVisualStyleBackColor = False
            .BackColor = Color.Transparent
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackgroundImageLayout = ImageLayout.Center
            .BackgroundImage = My.Resources.BT_ 'image name from Resources

        End With

    End Sub
    Private Sub registerBt_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registerBt.MouseLeave

        With registerBt


            .UseVisualStyleBackColor = False
            .BackColor = Color.Transparent
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackgroundImageLayout = ImageLayout.Center
            .BackgroundImage = My.Resources.BT_ 'image name from Resources

        End With

    End Sub
    Private Sub forumBt_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles forumBt.MouseLeave

        With forumBt


            .UseVisualStyleBackColor = False
            .BackColor = Color.Transparent
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackgroundImageLayout = ImageLayout.Center
            .BackgroundImage = My.Resources.BT_ 'image name from Resources

        End With

    End Sub

    Private Sub guidesBt_(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guidesBt.MouseLeave

        With guidesBt


            .UseVisualStyleBackColor = False
            .BackColor = Color.Transparent
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackgroundImageLayout = ImageLayout.Center
            .BackgroundImage = My.Resources.BT_ 'image name from Resources

        End With

    End Sub


    Private Property txtArquivo As Object


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Shown


        Dim BUTTONS As Array = {Options, siteBt, registerBt, forumBt, guidesBt}


        For Each BT_AGR As Object In BUTTONS
            With BT_AGR


                .UseVisualStyleBackColor = False
                .BackColor = Color.Transparent
                .FlatStyle = FlatStyle.Flat
                .FlatAppearance.BorderSize = 0
                .FlatAppearance.MouseOverBackColor = Color.Transparent
                .BackgroundImageLayout = ImageLayout.Center
                .BackgroundImage = My.Resources.BT_ 'image name from Resources

            End With
        Next

        With Play


            .UseVisualStyleBackColor = False
            .BackColor = Color.Transparent
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .BackgroundImageLayout = ImageLayout.Center
            .BackgroundImage = My.Resources.PLAY_ 'image name from Resources


        End With


        Dim caminhovideo1 As String = ("file:///" & Application.StartupPath & "/layout.html").Replace("\", "/")

        GC.Collect()

        'INICIAR TRHEAT UPDATE

        Control.CheckForIllegalCrossThreadCalls = False

        trd.IsBackground = True

        trd.Start()


    End Sub


    Private Sub Play_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Play.Click

        Try
            Dim RunMe As Integer = 0


            Try
                Dim clienteWeb As New WebClient()
                Dim stream As Stream = clienteWeb.OpenRead(statusCheckLink)

                If stream IsNot Nothing Then

                    Speak("Estado - OnLáine")

                    RunMe = 1

                End If

            Catch ex As Exception

                Speak("Estado - Em manutenção")

                MsgBox("Em manutenção . . .")

            End Try


            Me.Enabled = False

            If RunMe = 1 Then

                System.Diagnostics.Process.Start("MuRevenge.lnk")

                Speak(" - Jogo Iniciado")

                Thread.Sleep(8000)

                Application.Exit()

            Else

                Me.Enabled = True

            End If

        Catch ex As Exception
            MsgBox("Houve um problema, erro ANG01!", MsgBoxStyle.Information)
        End Try



    End Sub

    Public Sub DownloadProgressChanged(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)

        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())

        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())

        Dim percentage As Double = bytesIn / totalBytes * 100

        ProgressDown.Value = Integer.Parse(Math.Truncate(percentage).ToString())

    End Sub


    Private Sub Options_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Options.Click

        LauncherOptions.Show()
        Me.Enabled = False

    End Sub

    Private Sub siteBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles siteBt.Click

        Dim webAddress As String = "https://mysite.com/"
        Process.Start(webAddress)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles registerBt.Click

        Dim webAddress As String = "https://mysite.com/"
        Process.Start(webAddress)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles forumBt.Click

        Dim webAddress As String = "https://mysite.com/"
        Process.Start(webAddress)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guidesBt.Click

        Dim webAddress As String = "https://mysite.com/"
        Process.Start(webAddress)

    End Sub


    Private Sub RevengeLauncher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim TitleAttribute = TryCast(Assembly.GetCustomAttributes(GetType(System.Reflection.AssemblyTitleAttribute), False).FirstOrDefault(), System.Reflection.AssemblyTitleAttribute)
        Dim Title = If(TitleAttribute IsNot Nothing, TitleAttribute.Title, String.Empty)
        Dim Version = Assembly.GetName().Version.ToString()
        Console.WriteLine(String.Format("Assembly Title: {0}", Title))
        Console.WriteLine(String.Format("Assembly Version: {0}", Version))
        Console.ReadLine()

        If File.Exists("Data/layout.gif") Then

            PictureBox1.Image = New Bitmap("Data/layout.gif")
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        'Inicio Speak
        If Not File.Exists("angConfig.dat") Then

            Dim File_UPDATE_TXT As String = "1,1"

            Dim fs As FileStream = File.Create("angConfig.dat")

            Dim NEW_TXT As String = Application.StartupPath & "\"

            Dim info As Byte() = New UTF8Encoding(True).GetBytes(File_UPDATE_TXT.Replace(NEW_TXT, ""))
            fs.Write(info, 0, info.Length)
            fs.Close()

        End If

        Dim filename As String = "angConfig.dat"

        Dim result As Byte()

        Using SourceStream As FileStream = File.Open(filename, FileMode.Open)
            result = New Byte(SourceStream.Length - 1) {}
            SourceStream.Read(result, 0, CType(SourceStream.Length, Integer))
        End Using

        If System.Text.Encoding.ASCII.GetString(result) = "1" Then

            EnableSpeak = True

            Me.CheckSpeak.Checked = True

        End If
        'fim Speak


        Speak("Iniciando")

        'Video

        'AxWindowsMediaPlayer1.uiMode = "None"



        Dim AvisoToVoice As New StreamReader("Notice.txt")
        Speak(AvisoToVoice.ReadToEnd)

        Me.Left = (My.Computer.Screen.Bounds.Width - Me.Width) / 2

        Me.Top = (My.Computer.Screen.Bounds.Height - Me.Height) / 2



    End Sub



    Private Sub Abrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.WindowState = 0

    End Sub

    Private Sub Sair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Application.Exit()

    End Sub

    Private Sub forceUpadateBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles forceUpadateBt.Click

        'INICIAR TRHEAT UPDATE

        Control.CheckForIllegalCrossThreadCalls = False

        If trd.IsAlive = True Then
            trd.Abort()
        Else

            trd = New Thread(AddressOf ThreadTask)
            trd.IsBackground = True
            trd.Start()

        End If


    End Sub

    Private Sub CheckSpeak_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckSpeak.CheckedChanged

        Dim File_UPDATE_TXT As String

        If Me.CheckSpeak.Checked = True Then
            File_UPDATE_TXT = "1"
        Else
            File_UPDATE_TXT = "0"
        End If

        Dim fs As FileStream = File.OpenWrite("angConfig.dat")

        Dim NEW_TXT As String = Application.StartupPath & "\"

        Dim info As Byte() = New UTF8Encoding(True).GetBytes(File_UPDATE_TXT.Replace(NEW_TXT, ""))
        fs.Write(info, 0, info.Length)
        fs.Close()

    End Sub

    Private Sub newsBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newsBt.Click

        Dim form As LauncherOptions = New LauncherOptions
        Me.AddOwnedForm(form)
        form.Show()


    End Sub


    Private Sub closeBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closeBt.Click
        Application.Exit()
    End Sub

    Private Sub minimizeBt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimizeBt.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        PictureBox1.Image = Nothing

        PictureBox1.BackgroundImage = My.Resources.DDG

        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch

        Timer1.Dispose()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            If System.IO.File.Exists(Application.StartupPath & "\" & "opengl32.angc") Then
                My.Computer.FileSystem.RenameFile("opengl32.angc", "opengl32.dll")
            End If
        Else
            If System.IO.File.Exists(Application.StartupPath & "\" & "opengl32.dll") Then
                My.Computer.FileSystem.RenameFile("opengl32.dll", "opengl32.angc")
            End If
        End If

    End Sub
End Class