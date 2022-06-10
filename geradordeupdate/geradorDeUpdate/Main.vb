Imports System
Imports System.IO
Imports System.Text
Imports Microsoft.Win32

Public Class Main

    Private Sub Gerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gerar.Click


        Dim ArquivosUpdate As ArrayList = GetFiles("updates")

        Dim File_UPDATE_TXT As String = ""
        Dim quebra As Integer = 0

        For Each File As String In ArquivosUpdate

            If File.Contains(".") Then

                Dim Crc_Class As New CRC32

                Dim Formated_CRC_String As String

                Dim m_FileStream As New FileStream(File, FileMode.Open, FileAccess.Read, FileShare.Read, 8192I)

                Dim strPath As String = Split(System.IO.Path.GetDirectoryName( _
    System.Reflection.Assembly.GetExecutingAssembly().CodeBase) & "\updates\", "file:\")(1)

                Formated_CRC_String = Crc_Class.GetCrc32String(m_FileStream)
                Dim formatedFile As String() = Split(File, strPath)


                If quebra = 1 Then
                    File_UPDATE_TXT = File_UPDATE_TXT & vbCrLf & formatedFile(1) & ";" & Formated_CRC_String

                Else
                    quebra = 1

                    File_UPDATE_TXT = formatedFile(1) & ";" & Formated_CRC_String

                End If



            End If
        Next


        Dim path As String = "update.txt"

        If System.IO.File.Exists(path) Then
            My.Computer.FileSystem.DeleteFile(path)
        End If


        ' Create or overwrite the file.
        Dim fs As FileStream = File.Create(path)

        ' Add text to the file.
        Dim NEW_TXT As String = Application.StartupPath & "\"

        Dim info As Byte() = New UTF8Encoding(True).GetBytes(File_UPDATE_TXT.Replace(NEW_TXT, ""))
        fs.Write(info, 0, info.Length)
        fs.Close()

        MsgBox("Gerado!", MsgBoxStyle.Information)

        Application.Exit()


    End Sub



    Private Function GetFiles(ByVal pathFolder As String) As ArrayList
        Dim returnFiles As ArrayList = New ArrayList
        Dim dirInfo As DirectoryInfo = New DirectoryInfo(pathFolder)
        If dirInfo.Exists Then
            Dim filesInfo As FileSystemInfo() = dirInfo.GetFileSystemInfos
            For Each fil As FileSystemInfo In filesInfo
                returnFiles.Add(fil.FullName)
                If fil.Attributes = FileAttributes.Directory Then
                    returnFiles.AddRange(GetFiles(fil.FullName))
                End If
            Next
        End If
        Return returnFiles
    End Function


End Class
