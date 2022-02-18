Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class Licenca

    Protected Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
    Protected regionHandle As IntPtr

    Dim img As Image
    Dim Data_hoje As DateTime = DateTime.Now
    Dim bt() As Byte
    Dim mt As MemoryStream
#Region "MOVER FORMULÁRIO"
    Dim objDraw As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath
    Dim mover As New MoveForm
    Private Structure MoveForm
        Dim X As Integer
        Dim y As Integer
    End Structure
    Private Sub frmlogin_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        mover.X = Me.Left - MousePosition.X
        mover.y = Me.Top - MousePosition.Y
    End Sub

    Private Sub frmlogin_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button <> Windows.Forms.MouseButtons.Left Then Exit Sub
        Me.Left = mover.X + MousePosition.X
        Me.Top = mover.y + MousePosition.Y
    End Sub
#End Region


#Region "BEEP DO ENTER"
    Private Sub beep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
        End If
    End Sub
#End Region

    Private Sub frmlicuso_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            btnF5.PerformClick()
        End If
        If e.KeyCode = Keys.F7 Then
            btnhome.PerformClick()
        End If
        If e.KeyCode = Keys.F8 Then
            op1.Filter = "jpg|*.jpg|gif|*.gif|png|*.png"
            op1.ShowDialog()
            Call gravafoto()
        End If

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub
    Private Sub frmlicuso_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        redondo(0, 0, Panel1, 20, 20)
        redondo(0, 0, tbcp120, 20, 20)


        Me.Text = ""
        Call BuscaRegistro(1)
        REG011.Select()
        REG011.SelectAll()

        Me.CancelButton = btnhome

    End Sub

    Private Sub redondo(arg1, arg2, componente, arg3, arg4)
        regionHandle = New IntPtr(CreateRoundRectRgn(arg1, arg2, componente.Width, componente.Height, arg3, arg4))
        componente.Region = Region.FromHrgn(regionHandle)
        componente.Region.ReleaseHrgn(regionHandle)
    End Sub

    Public Sub BuscaRegistro(arg)
        Select Case arg
            Case 1
                Try
                    If conexao.State = ConnectionState.Closed Then conexao.Close()
                    conexao.Open()
                    Dim cmd As New MySqlCommand("select * from REGISTRO where REG001 = '" & iReg001 & "'", conexao)
                    Dim drdr As MySqlDataReader
                    drdr = cmd.ExecuteReader
                    drdr.Read()
                    bt = drdr.Item("REG015")      ' logo da empresa
                    mt = New MemoryStream(bt)
                    pb1.Image = Image.FromStream(mt)
                    REG002.Text = drdr("REG002") ' Nome da empresa registrada para uso do sistema
                    REG003.Text = drdr("REG003") ' Endereço
                    REG004.Text = drdr("REG004") ' Bairro
                    REG005.Text = drdr("REG005") ' Cidade
                    REG006.Text = drdr("REG006") ' Estado
                    REG007.Text = drdr("REG007") ' CEP
                    REG008.Text = drdr("REG008") ' Complemento
                    REG009.Text = drdr("REG009") ' CNPJ
                    REG010.Text = drdr("REG010") ' Inscrição Estadual
                    REG011.Text = drdr("REG011") ' Telefone 01
                    REG012.Text = drdr("REG012") ' Telefone 02
                    REG014.Text = drdr("REG014") ' endereço de email
                    cmd.Cancel()
                    conexao.Close()
                Catch ex As Exception
                    conexao.Close()
                End Try
            Case 2
                Try
                    If conexao.State = ConnectionState.Closed Then conexao.Close()
                    conexao.Open()
                    Dim cmd As New MySqlCommand("select * from REGISTRO where REG001 = '" & iReg001 & "'", conexao)
                    Dim drdr As MySqlDataReader
                    drdr = cmd.ExecuteReader
                    drdr.Read()
                    bt = drdr.Item("REG015")      ' logo da empresa
                    mt = New MemoryStream(bt)
                    iReg015 = Image.FromStream(mt)
                    iReg002 = drdr("REG002") ' Nome da empresa registrada para uso do sistema
                    iReg003 = drdr("REG003") ' Endereço
                    iReg004 = drdr("REG004") ' Bairro
                    iReg005 = drdr("REG005") ' Cidade
                    iReg006 = drdr("REG006") ' Estado
                    iReg007 = drdr("REG007") ' CEP
                    iReg008 = drdr("REG008") ' Complemento
                    iReg009 = drdr("REG009") ' CNPJ
                    iReg010 = drdr("REG010") ' Inscrição Estadual
                    iReg011 = drdr("REG011") ' Telefone 01
                    iReg012 = drdr("REG012") ' Telefone 02
                    iReg014 = drdr("REG014") ' endereço de email
                    alterado = 1
                    cmd.Cancel()
                    conexao.Close()
                Catch ex As Exception
                    conexao.Close()
                End Try
        End Select
    End Sub
    Private Sub REG002_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles REG002.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If REG002.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Obrigatório Informar o Nome da Empresa Licenciada")
                REG002.Select()
            Else
                REG009.Select()
            End If
        End If
    End Sub
    Private Sub REG009_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles REG009.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If REG009.MaskCompleted = False Then
                MsgBox(" Informe o CNPJ da Empresa", 64, " Mensagem")
                REG009.Select()
            Else
                REG011.Select()
            End If
        End If
    End Sub
    Private Sub REG011_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles REG011.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            REG012.Select()
        End If
    End Sub
    Private Sub REG012_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles REG012.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            REG010.Select()
        End If
    End Sub
    Private Sub REG010_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles REG010.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            REG003.Select()
        End If
    End Sub
    Private Sub REG003_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles REG003.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If REG003.TextLength = 0 Then
                MsgBox(" Endereço Inválido!", 64, " Mensagem")
                REG003.Select()
            Else
                REG004.Select()
            End If
        End If
    End Sub
    Private Sub REG004_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles REG004.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If REG004.TextLength = 0 Then
                MsgBox(" Bairro Inválido", 64, " Mensagem")
                REG004.Select()
            Else
                REG005.Select()
            End If
        End If
    End Sub
    Private Sub REG005_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles REG005.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If REG005.TextLength = 0 Then
                MsgBox(" Cidade Inválida", 64, " Mensagem")
                REG005.Select()
            Else
                REG006.Select()
            End If
        End If
    End Sub
    Private Sub REG006_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles REG006.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If REG006.TextLength = 0 Then
                MsgBox(" Estado Inválido ", 64, " Mensagem")
                REG006.Select()
            Else
                REG007.Select()
            End If
        End If
    End Sub
    Private Sub REG007_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles REG007.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If REG007.TextLength = 0 Then
                MsgBox(" Obrigatório Informar o Nome da Empresa", 64, " Mensagem")
                REG007.Select()
            Else
                REG008.Select()
            End If
        End If
    End Sub
    Private Sub REG008_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles REG008.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If REG008.TextLength = 0 Then
                MsgBox(" Obrigatório Informar o Complemento! ", 64, " Mensagem")
                REG008.Select()
            Else
                REG014.Select()
            End If
        End If
    End Sub
    Private Sub REG014_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles REG014.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If REG014.TextLength = 0 Then
                MsgBox(" Obrigatório informar email de contato! ", 64, " Mensagem")
                REG014.Select()
            Else
                btnF5.PerformClick()
            End If
        End If
    End Sub


    Public Sub tempValue()
        pb1.Image.Save(Application.StartupPath + "\gshotel.dat")
    End Sub

    Private Sub gravafoto()
        Call tempValue()
        Dim fst As New FileStream(Application.StartupPath + "\gshotel.dat", FileMode.Open)
        Dim arrbyte(fst.Length) As Byte
        fst.Read(arrbyte, 0, arrbyte.Length)
        fst.Close()
        Directory.SetCurrentDirectory(My.Application.Info.DirectoryPath)
        Dim s1 As String = "update registro set REG015 = ? WHERE REG001='" & iReg001 & "'"
        Dim cmnd As New MySqlCommand(s1, conexao)
        Dim par As New MySqlParameter("@Imagem", MySqlDbType.Binary)
        par.Value = arrbyte
        par.Size = arrbyte.Length
        cmnd.Parameters.Add(par)
        conexao.Open()
        cmnd.ExecuteNonQuery()
        conexao.Close()
        alterado = 1
        iReg015 = pb1.Image
    End Sub
    Private Sub pb1_Click(sender As System.Object, e As System.EventArgs) Handles pb1.Click
        op1.Filter = "jpg|*.jpg|gif|*.gif|png|*.png"
        op1.ShowDialog()
        Call gravafoto()
    End Sub
    Private Sub op1_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles op1.FileOk
        img = Image.FromFile(op1.FileName)
        pb1.Image = img
        pb1.SizeMode = PictureBoxSizeMode.StretchImage
        pb1.Image.Save(Application.StartupPath + "\gshotel.dat", Imaging.ImageFormat.Jpeg)
        'str = op1.FileName
    End Sub
    Private Sub GravaCliente()
        If iconexao.State = ConnectionState.Open Then iconexao.Close()
        Dim st As String = "update clientes set CLI002 = '" & REG002.Text & "', CLI004 = '" & REG003.Text & "', CLI005 = '" & REG004.Text & "', CLI006 = '" & REG005.Text & "', CLI007 = '" & REG006.Text & "', CLI008 = '" & REG007.Text & "', CLI009 = '" & REG008.Text & "', CLI014 = '" & REG014.Text & "' WHERE CLI001 = '" & iReg001 & "'"
        Dim cmd As New MySqlCommand(st, iconexao)
        iconexao.Open()
        cmd.ExecuteNonQuery()
        iconexao.Close()
    End Sub

    Private Sub btnhome_Click_1(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
    End Sub

    Private Sub btnF5_Click(sender As Object, e As EventArgs) Handles btnF5.Click
        If conexao.State = ConnectionState.Open Then conexao.Close()
        Dim s1 As String = "UPDATE REGISTRO SET REG003 = '" & REG003.Text & "', REG004 = '" & REG004.Text & "', REG005 = '" & REG005.Text & "', REG006 = '" & REG006.Text & "', REG007 = '" & REG007.Text & "', REG008 = '" & REG008.Text & "', REG010 = '" & REG010.Text & "', REG011 = '" & REG011.Text & "', REG012 = '" & REG012.Text & "'   WHERE REG001 ='" & iReg001 & "'"
        Dim cmnd As New MySqlCommand(s1, conexao)
        conexao.Open()
        cmnd.ExecuteNonQuery()
        conexao.Close()
        Call gravafoto()

        Call GravaCliente() ' grava as alterações na tabela clientes banco sol_controller - nuvem

        MetroFramework.MetroMessageBox.Show(Me, " Registro atualizado com sucesso !", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Call BuscaRegistro(2)
    End Sub
End Class
























