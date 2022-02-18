Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class Aviso10
    Private myCam As iCam
    Dim pop As Integer
    Dim data_hoje As DateTime = DateTime.Now
    Dim FileName As String
    Dim img As Bitmap
    Dim acao As String
    Dim FUN024 As New TextBox

#Region "MOVER FORMULÁRIO"
    Dim objDraw As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath
    Dim mover As New MoveForm
    Private Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure
    Private Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        mover.X = Me.Left - MousePosition.X
        mover.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Me.Left = mover.X + MousePosition.X
        Me.Top = mover.y + MousePosition.Y
    End Sub
#End Region

#Region "START DO FORMULÁRIO"
    Private Sub BEEP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
    Private Sub escape_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            ' BOTÃO SALVAR O REGISTRO
            Me.Close()
        End If
    End Sub
    Private Sub Aviso09_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height - 77) / 2
        Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width + 445) / 2
        imgbanco.ImageLocation = (My.Application.Info.DirectoryPath & "\file\companion\" & ACP05.Text & ".dat")
        btnCapIMG.Visible = False
        btnCancel.Visible = False
        btnimporta.Visible = True
        imgCam.Visible = False
        imgbanco.Visible = True

    End Sub
#End Region

#Region "BOTÕES"
    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
    End Sub
    Private Sub btnimporta_Click(sender As Object, e As EventArgs) Handles btnimporta.Click
        acao = "CAPITURA"
        btnCapIMG.Visible = False
        btnCancel.Visible = False
        imgCam.Visible = False
        imgbanco.Visible = True
        op1.Filter = "jpg|*.jpg|gif|*.gif|png|*.png|jpeg|*.jpeg"
        op1.ShowDialog() ' abre a pesquisa de arquivo
    End Sub

    Private Sub btnCaptura_Click(sender As Object, e As EventArgs) Handles btnCaptura.Click
        Try
            btnimporta.Visible = False
            acao = "CAMERA"
            btnCapIMG.Visible = True
            btnCancel.Visible = True
            imgCam.Visible = True
            imgbanco.Visible = False
            Me.imgCam.SizeMode = PictureBoxSizeMode.StretchImage
            myCam = New iCam
            myCam.initCam(Me.imgCam.Handle.ToInt32)  ' CONECTA COM A WEB CAM
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, " Erro ao se conectar com a camera")
        End Try
    End Sub
    Private Sub btnCapIMG_Click(sender As Object, e As EventArgs) Handles btnCapIMG.Click
        img = myCam.copyFrame(Me.imgbanco, New RectangleF(0, 0,
                              Me.imgbanco.Width, Me.imgbanco.Height))
        Call tempValue()
        Call gravar(0) ' grava o caminho das imagens no banco

        myCam.closeCam()
        Application.DoEvents()
        myCam = Nothing

        btnCapIMG.Visible = False
        btnCancel.Visible = False
        btnimporta.Visible = True
        imgCam.Visible = False
        imgbanco.Visible = True

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnCapIMG.Visible = False
        btnCancel.Visible = False
        btnimporta.Visible = True
        imgCam.Visible = False
        imgbanco.Visible = True
        imgbanco.BringToFront()

    End Sub
#End Region

#Region "FUNÇÕES"
    Public Sub tempValue()
        Dim hora As Integer = DateTime.Now.ToLongTimeString().Substring(0, 2)
        Dim minuto As Integer = DateTime.Now.ToLongTimeString().Substring(3, 2)
        Dim segundo As Integer = DateTime.Now.ToLongTimeString().Substring(6, 2)

        FileName = Format(data_hoje, "ddyyyyMM") & segundo & minuto & hora & FUN002.Text
        Dim objImageCodecInfo() As System.Drawing.Imaging.ImageCodecInfo
        objImageCodecInfo = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders
        Dim objEncParams As New System.Drawing.Imaging.EncoderParameters(1)
        Dim objEncParam As New System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100) 'definindo qualidade de 10%
        objEncParams.Param(0) = objEncParam

        img.Save(Application.StartupPath + "\file\companion\" & FileName & ".dat", objImageCodecInfo(1), objEncParams)

    End Sub
    Private Sub gravar(arg)
        Select Case arg
            Case 0
                If conexao.State = ConnectionState.Open Then conexao.Close()
                Dim cmd As New MySqlCommand("update prt_acpt set ACP05 = '" & FileName & "' WHERE ACP01 = '" & FUN002.Text & "'", conexao)
                conexao.Open()
                cmd.ExecuteNonQuery()
                conexao.Close()
                imgbanco.ImageLocation = (My.Application.Info.DirectoryPath & "\file\companion\" & FileName & ".dat")
                alterado = 500
        End Select
    End Sub
#End Region


#Region "COMPONENTES"
    Private Sub op1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles op1.FileOk
        img = Bitmap.FromFile(op1.FileName)
        Call tempValue()
        Call gravar(0) ' grava o caminho das imagens no banco
    End Sub
#End Region


End Class
























