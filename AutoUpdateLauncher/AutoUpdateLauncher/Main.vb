Imports System.IO
Imports System.Threading

Public Class Main

    Private nameExeLauncher = "MyLauncher.exe"
    Private nameAttLauncher = "MyLauncher.att"

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown

        Thread.Sleep(1000)

        Me.Label1.Text = "Iniciando checagem..."

        If File.Exists("launcher_version.ang") Then

            My.Computer.FileSystem.DeleteFile("launcher_version.ang")

        End If

        If Not File.Exists("old_launcher_version.ang") Then

            File.Create("old_launcher_version.ang").Close()

        End If

        Try

            My.Computer.Network.DownloadFile("https://mylink.com/launcher_version.txt", "launcher_version.ang")

        Catch ex As Exception
            MsgBox(ex.Message & " Erro Ao tentar obter a versao do launcher! " & ex.Source)

            Application.Exit()
        End Try

        Dim oldL As Array = File.ReadAllLines("old_launcher_version.ang")

        Dim line As Array = File.ReadAllLines("launcher_version.ang")

        If Not line(0) = oldL(0) Then

            My.Computer.FileSystem.DeleteFile("old_launcher_version.ang")

            My.Computer.FileSystem.RenameFile("launcher_version.ang", "old_launcher_version.ang")

            If Not File.Exists(nameAttLauncher) Then

                Try
                    My.Computer.Network.DownloadFile("https://mylink.com/" & nameExeLauncher, nameExeLauncher)
                Catch ex As Exception
                    MsgBox(ex.Message & " Erro Ao tentar baixar a nova versao do launcher! " & ex.Source)

                    Application.Exit()
                End Try



            End If



        End If

        'Substituir novo launcher
        If File.Exists("AngerMu Launcher.att") Then

            My.Computer.FileSystem.DeleteFile(nameAttLauncher)
            My.Computer.FileSystem.DeleteFile("old_launcher_version.ang")
            Me.Label1.Text = "Erro inesperado"
            Main_Load(sender, e)


        End If

        Me.Label1.Text = "Tudo certo..."

        System.Diagnostics.Process.Start(nameExeLauncher)

        Me.Label1.Text = "..."

        Application.Exit()

    End Sub

End Class
