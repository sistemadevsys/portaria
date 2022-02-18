Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmLivro01
    Dim Data_hoje As DateTime = DateTime.Now
    Dim junta As New TextBox

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
    Private Sub FrmLivro01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height - 77) / 2
        Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width + 445) / 2
        data.Text = Format(Data_hoje, "dd/MM/yyyy")
        hora.Text = DateTime.Now.ToLongTimeString().Substring(0, 5)
        user.Text = iUsername
        CON14.Clear()
        CON14.Select()
        CON14.Focus()
    End Sub
#End Region

    Private Sub Btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        alterado = 0
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CON14.TextLength = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Digite a ocorrência para salvar no arquivo! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CON14.Focus()
        Else
            junta.Text += vbCrLf
            junta.Text += "Registro de ocorrência:" & vbCrLf
            junta.Text += "Data:   " & data.Text & "   Hora:   " & hora.Text & "   Porteiro:   " & user.Text & vbCrLf
            junta.Text += "----------------------------------------------------------------------------------------------------------------------------" & vbCrLf
            junta.Text += CON14.Text & vbCrLf
            junta.Text += "----------------------------------------------------------------------------------------------------------------------------" & vbCrLf
            junta.Text += iCON14.Text
            CON14.Clear()
            CON14.Text = junta.Text

            Try
                conexao.Open()
                Dim cmd As New MySqlCommand("sp_OCORRENCIA", conexao)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("iCON01", CON01.Text)
                cmd.Parameters.AddWithValue("iCON14", CON14.Text)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MetroFramework.MetroMessageBox.Show(Me, ex.Message)
            Finally
                MetroFramework.MetroMessageBox.Show(Me, " Ocorrência registrada com sucesso! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conexao.Close()
                alterado = 500
                Me.Close()
            End Try

        End If
    End Sub
End Class
























