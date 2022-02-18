Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmVisitante
    Dim data_hoje As DateTime = DateAndTime.Now
    Dim FUN024 As New TextBox
    Dim IMG001 As New TextBox
    Dim texto, sql As String
    Dim valida As Integer
    Dim opc As Integer
    Dim indexfoto As Integer

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
    Private Sub base_d_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height - 77) / 2
        Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width + 445) / 2
        img.ImageLocation = (My.Application.Info.DirectoryPath & "\file\visitor\" & FUN024.Text & ".dat")
        FUN025.Value = data_hoje
        Call Limpar_textbox(Me)  ' limpa os campos para edição
        Call Limpar_mask(Me)     ' limpa os campos com mascara
        If opcao.Text = "NOVO" Then
            Call geracod() ' GERA UM NOVO CÓDIGO PARA O REGISTRO
            FUN003.Select()
            FUN003.Focus()
            img.Image = Nothing
            btnFoto.Enabled = False
        Else
            btnFoto.Enabled = True
            Call buscadados() ' busca os dados do cadastro
        End If
    End Sub
#End Region

#Region "FUNÇÕES"
    Private Sub geracod()
        Dim sqlmaior As String
        If conexao.State = 0 Then
            conexao.Open()
        End If
        sqlmaior = "Select Max(FUN002) From prt_cadfun"
        Dim cmd As New MySqlCommand(sqlmaior, conexao)
        Dim maior As Integer
        If IsDBNull(cmd.ExecuteScalar) Then
            maior = 1
        Else
            maior = cmd.ExecuteScalar + 1
        End If
        cmd.ExecuteNonQuery()
        FUN002.Text = Format(maior, "000000")
        cmd.Dispose()
        conexao.Close()
    End Sub

    Private Sub buscadados()
        If conexao.State = 0 Then
            conexao.Open()
        End If
        Dim comando As New MySqlCommand("select FUN003,FUN008,FUN009,FUN010,FUN011,FUN012,FUN016,FUN017,FUN018,FUN019,FUN020,FUN021,FUN024,FUN025 from prt_cadfun where FUN002 = '" & FUN002.Text & "'", conexao)
        Dim leitor As MySqlDataReader = comando.ExecuteReader()
        While leitor.Read()
            FUN003.Text = IIf(Convert.IsDBNull(leitor("FUN003")) = True, "", leitor("FUN003")) ' NOME DO VISITANTE 
            FUN008.Text = IIf(Convert.IsDBNull(leitor("FUN008")) = True, "", leitor("FUN008")) ' CPF
            FUN009.Text = IIf(Convert.IsDBNull(leitor("FUN009")) = True, "", leitor("FUN009")) ' RG
            FUN010.Text = IIf(Convert.IsDBNull(leitor("FUN010")) = True, "", leitor("FUN010")) ' EMAIL
            FUN011.Text = IIf(Convert.IsDBNull(leitor("FUN011")) = True, "", leitor("FUN011")) ' FONE 01
            FUN012.Text = IIf(Convert.IsDBNull(leitor("FUN012")) = True, "", leitor("FUN012")) ' FONE 02
            FUN016.Text = IIf(Convert.IsDBNull(leitor("FUN016")) = True, "", leitor("FUN016")) ' ENDEREÇO
            FUN017.Text = IIf(Convert.IsDBNull(leitor("FUN017")) = True, "", leitor("FUN017")) ' BAIRRO
            FUN018.Text = IIf(Convert.IsDBNull(leitor("FUN018")) = True, "", leitor("FUN018")) ' CIDADE
            FUN019.Text = IIf(Convert.IsDBNull(leitor("FUN019")) = True, "", leitor("FUN019")) ' ESTADO
            FUN020.Text = IIf(Convert.IsDBNull(leitor("FUN020")) = True, "", leitor("FUN020")) ' CEP
            FUN021.Text = IIf(Convert.IsDBNull(leitor("FUN021")) = True, "", leitor("FUN021")) ' COMPLEMENTO
            FUN024.Text = IIf(Convert.IsDBNull(leitor("FUN024")) = True, "", leitor("FUN024")) ' REGISTRO DA IMAGEM
            FUN025.Text = IIf(Convert.IsDBNull(leitor("FUN025")) = True, "", leitor("FUN025")) ' DATA DO CADASTRO


            img.ImageLocation = (My.Application.Info.DirectoryPath & "\file\visitor\" & FUN024.Text & ".dat")


        End While
        comando.Cancel()
        leitor.Close()
        conexao.Close()
    End Sub


    Public Sub Limpar_textbox(ByVal controlP As Control)
        Dim ctl As Control
        For Each ctl In controlP.Controls
            If TypeOf ctl Is TextBox Then
                DirectCast(ctl, TextBox).Text = String.Empty
            ElseIf ctl.Controls.Count > 0 Then
                Limpar_textbox(ctl)
            End If
        Next
    End Sub
    Public Sub Limpar_mask(ByVal controlP As Control)
        Dim ctl As Control
        For Each ctl In controlP.Controls
            If TypeOf ctl Is MaskedTextBox Then
                DirectCast(ctl, MaskedTextBox).Text = String.Empty
            ElseIf ctl.Controls.Count > 0 Then
                Limpar_mask(ctl)
            End If
        Next
    End Sub


#End Region

#Region "BOTÕES"
    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
    End Sub
#End Region

#Region "ENTER"
    Private Sub FUN003_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN003.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If FUN003.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o nome do convidado! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FUN003.Focus()
            Else
                FUN008.Focus()
            End If
        End If
    End Sub

    Private Sub FUN008_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN008.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If FUN008.MaskCompleted = False Or FUN008.Text = "   .   .   -" Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o número do CPF! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FUN008.Focus()
            Else
                FUN009.Focus()
            End If
        End If
    End Sub
    Private Sub FUN009_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN009.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If FUN009.MaskCompleted = False Or FUN009.Text = "" Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o número do RG! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FUN009.Focus()
            Else
                FUN016.Focus()
            End If
        End If
    End Sub
    Private Sub FUN016_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN016.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If FUN016.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o endereço! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FUN016.Focus()
            Else
                FUN017.Focus()
            End If
        End If
    End Sub
    Private Sub FUN017_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN017.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If FUN017.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o bairro! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FUN017.Focus()
            Else
                FUN018.Focus()
            End If
        End If
    End Sub
    Private Sub FUN018_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN018.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If FUN018.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe a cidade! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FUN018.Focus()
            Else
                FUN019.Focus()
            End If
        End If
    End Sub
    Private Sub FUN019_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN019.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If FUN019.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o estado (UF)! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FUN019.Focus()
            Else
                FUN020.Focus()
            End If
        End If
    End Sub
    Private Sub FUN020_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN020.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If FUN020.MaskCompleted = False Or FUN020.Text = "     -" Then
                MetroFramework.MetroMessageBox.Show(Me, " Informe o CEP da cidade! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FUN020.Focus()
            Else
                FUN021.Focus()
            End If
        End If
    End Sub
    Private Sub FUN021_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN021.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            FUN011.Focus()
        End If
    End Sub
    Private Sub FUN011_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN011.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            FUN012.Focus()
        End If
    End Sub
    Private Sub FUN012_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles FUN012.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            FUN010.Focus()
        End If
    End Sub
#End Region

#Region "SELEÇÃO DO TEXTBOX"
    Private Sub FUN003_Click(sender As Object, e As EventArgs) Handles FUN003.Click
        FUN003.SelectAll()
    End Sub
    Private Sub FUN008_Click(sender As Object, e As EventArgs) Handles FUN008.Click
        FUN008.SelectAll()
    End Sub
    Private Sub FUN009_Click(sender As Object, e As EventArgs) Handles FUN009.Click
        FUN009.SelectAll()
    End Sub
    Private Sub FUN010_Click(sender As Object, e As EventArgs) Handles FUN010.Click
        FUN010.SelectAll()
    End Sub
    Private Sub FUN011_Click(sender As Object, e As EventArgs) Handles FUN011.Click
        FUN011.SelectAll()
    End Sub
    Private Sub FUN012_Click(sender As Object, e As EventArgs) Handles FUN012.Click
        FUN012.SelectAll()
    End Sub
    Private Sub FUN016_Click(sender As Object, e As EventArgs) Handles FUN016.Click
        FUN016.SelectAll()
    End Sub
    Private Sub FUN017_Click(sender As Object, e As EventArgs) Handles FUN017.Click
        FUN017.SelectAll()
    End Sub
    Private Sub FUN018_Click(sender As Object, e As EventArgs) Handles FUN018.Click
        FUN018.SelectAll()
    End Sub
    Private Sub FUN019_Click(sender As Object, e As EventArgs) Handles FUN019.Click
        FUN019.SelectAll()
    End Sub
    Private Sub FUN020_Click(sender As Object, e As EventArgs) Handles FUN020.Click
        FUN020.SelectAll()
    End Sub
    Private Sub FUN021_Click(sender As Object, e As EventArgs) Handles FUN021.Click
        FUN021.SelectAll()
    End Sub

#End Region

#Region "TESTA PREENCHIMENTO DOS TEXTBOX ANTES DA GRAVAÇÃO"
    Private Sub Testa_Preenchimento()
        valida = 0
        If FUN003.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o nome do convidado! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN003.Focus()
            valida = 0
            Exit Sub
        End If
        If FUN016.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o endereço! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN016.Focus()
            valida = 0
            Exit Sub
        End If
        If FUN017.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o bairro! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN017.Focus()
            valida = 0
            Exit Sub
        End If
        If FUN018.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe a cidade! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN018.Focus()
            valida = 0
            Exit Sub
        End If
        If FUN019.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o estado (UF)! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN019.Focus()
            valida = 0
            Exit Sub
        End If
        If FUN020.MaskCompleted = False Or FUN020.Text = "     -" Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o CEP da cidade! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN020.Focus()
            valida = 0
            Exit Sub
        End If
        If FUN008.MaskCompleted = False Or FUN008.Text = "   .   .   -" Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o número do CPF! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN008.Focus()
            valida = 0
            Exit Sub
        End If
        If FUN009.MaskCompleted = False Or FUN009.Text = "" Then
            MetroFramework.MetroMessageBox.Show(Me, " Informe o número do RG! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FUN009.Focus()
            valida = 0
            Exit Sub
        End If
        valida = 10
    End Sub
#End Region





    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call Testa_Preenchimento() ' TESTA O PREENCHIMENTO DOS CAMPOS OU TEXTBOX

        If valida > 0 Then
            alterado = 500
            If opcao.Text = "NOVO" Then
                texto = "Registro efetuado com sucesso"
                sql = "insert into prt_cadfun(FUN002,FUN003,FUN008,FUN009,FUN016,FUN017,FUN018,FUN019,FUN020,FUN021,FUN011,FUN012,FUN010,FUN025,FUN028,EMP002)values('" & FUN002.Text & "','" & FUN003.Text & "','" & FUN008.Text & "','" & FUN009.Text & "','" & FUN016.Text & "','" & FUN017.Text & "','" & FUN018.Text & "','" & FUN019.Text & "','" & FUN020.Text & "','" & FUN021.Text & "','" & FUN011.Text & "','" & FUN012.Text & "','" & FUN010.Text & "','" & Format(FUN025.Value, "yyyy-MM-dd") & "','VIS','200001')"
            Else
                texto = "Alteração efetuada com sucesso"
                sql = "update prt_cadfun set  FUN003 = '" & FUN003.Text & "',FUN008 = '" & FUN008.Text & "',FUN009 = '" & FUN009.Text & "',FUN016 = '" & FUN016.Text & "',FUN017 = '" & FUN017.Text & "',FUN018 = '" & FUN018.Text & "',FUN019 = '" & FUN019.Text & "',FUN020 = '" & FUN020.Text & "',FUN021 = '" & FUN021.Text & "',FUN011 = '" & FUN011.Text & "',FUN012 = '" & FUN012.Text & "',FUN010 = '" & FUN010.Text & "' WHERE FUN002 = '" & FUN002.Text & "'"
            End If
            Try
                If conexao.State = ConnectionState.Open Then conexao.Close()
                Dim cmd As New MySqlCommand(sql, conexao)
                conexao.Open()
                cmd.ExecuteNonQuery()
                MetroFramework.MetroMessageBox.Show(Me, texto, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                conexao.Close()
                btnFoto.Enabled = True
                opcao.Text = "EDITAR"
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        Aviso09.IMG006.Text = "VIS"
        Aviso09.FUN002.Text = FUN002.Text
        Aviso09.FUN003.Text = FUN003.Text
        alterado = 0
        Aviso09.ShowDialog()
        If alterado > 0 Then
            Call buscadados()  ' RECARREGA OS DADOS
        End If
    End Sub


End Class
























