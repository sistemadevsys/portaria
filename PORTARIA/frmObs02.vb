Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmObs02
    Dim linha As New TextBox

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
    Private Sub frmObs02_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        linha.Text = "==================================================="
        FAS011.Clear()
        iFAS011.Clear()
        Call pesquisa()
        iFAS011.Select()
        iFAS011.Focus()
    End Sub
#End Region

#Region "FUNÇÕES"
    Private Sub pesquisa()
        If conexao.State = 0 Then
            conexao.Open()
        End If
        Dim comando As New MySqlCommand("select FAS011 FROM prt_fass where FAS001 = '" & FAS001.Text & "'", conexao)
        Dim leitor As MySqlDataReader = comando.ExecuteReader()
        While leitor.Read()
            FAS011.Text = IIf(Convert.IsDBNull(leitor("FAS011")) = True, "", leitor("FAS011")) ' INFORMAÇÕES ANTERIOR
        End While
        comando.Cancel()
        leitor.Close()
        conexao.Close()
    End Sub
#End Region

#Region "BOTÕES"
    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        alterado = 0
        Me.Close()
    End Sub
#End Region

    Private Sub gLinha()
        Dim cmd As New MySqlCommand("update prt_fass set FAS011 = '" & linha.Text & "' WHERE FAS001 = '" & FAS001.Text & "'", conexao)
        conexao.Open()
        cmd.ExecuteNonQuery()
        conexao.Close()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If iFAS011.TextLength > 0 Then
            If conexao.State = ConnectionState.Open Then conexao.Close()
            linha.Clear()

            linha.Text += vbCrLf
            linha.Text += "Registro de ocorrência:" & vbCrLf
            linha.Text += "Data:   " & Format(Data_hoje, "dd-MM-yyyy") & "   Hora:   " & DateTime.Now.ToLongTimeString().Substring(0, 5) & "   Porteiro:   " & iUsername & vbCrLf
            linha.Text += "----------------------------------------------------------------------------------------" & vbCrLf
            linha.Text += iFAS011.Text & vbCrLf
            linha.Text += "----------------------------------------------------------------------------------------" & vbCrLf
            linha.Text += FAS011.Text
            FAS011.Clear()
            FAS011.Text = linha.Text


            Dim cmd As New MySqlCommand("update prt_fass set FAS011 = '" & FAS011.Text & "', OBS = 'Sim' WHERE FAS001 = '" & FAS001.Text & "'", conexao)
            conexao.Open()
            cmd.ExecuteNonQuery()
            conexao.Close()
            alterado = 500
            MetroFramework.MetroMessageBox.Show(Me, " Evento registrado ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Else
            alterado = 0
            Me.Close()
        End If
    End Sub
End Class
























