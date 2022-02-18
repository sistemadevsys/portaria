Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmArmario02
    Dim ARM002 As New TextBox
    Dim comando As New TextBox
    Dim pop As Integer

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
        If iFiltroARM = Nothing Then
            Label2.Text = "Duplo click seleciona o armário"
        Else
            Label2.Text = "Duplo click - DEVOLVE CHAVE DO ARMÁRIO"
        End If
        Call carregalist()
    End Sub
#End Region

#Region "FUNÇÕES"
    Private Sub carregalist()
        lvdados.Items.Clear()
        With lvdados
            .View = View.LargeIcon
            .Cursor = Cursors.Hand
        End With

        Dim Items As New List(Of ListViewItem)
        Dim RancomClass As New Random()
        Dim sql As String

        If iFiltroARM = Nothing Then
            sql = "SELECT ARM002,ARM004 FROM prt_armarios where ARM004 = '0'"
        Else
            sql = "SELECT ARM002,ARM004 FROM prt_armarios where ARM002 = '" & iFiltroARM & "'"
        End If

        If conexao.State = 0 Then
            conexao.Open()
        End If
        Dim cmd As New MySqlCommand(sql, conexao)
        Dim leitor As MySqlDataReader = cmd.ExecuteReader()

        Dim imesa As String
        While leitor.Read()
            Dim teste As String = leitor("ARM004")

            imesa = IIf(Convert.IsDBNull(leitor("ARM002")) = True, "", leitor("ARM002"))

            If teste = 0 Then
                lvdados.Items.Add(imesa, RancomClass.Next(0, 1) Mod 1)
            Else
                lvdados.Items.Add(imesa, RancomClass.Next(1, 1) Mod 2)
            End If

            pop += 1
        End While
        lvdados.Items.AddRange(Items.ToArray)
        cmd.Cancel()
        leitor.Close()
        conexao.Close()
    End Sub
#End Region

#Region "BOTÕES"
    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
    End Sub

    Private Sub gravar(arg)
        Select Case arg
            Case 0
                If conexao.State = ConnectionState.Open Then conexao.Close()
                Dim cmd As New MySqlCommand("update prt_fass set COMANDO = '" & comando.Text & "' WHERE FAS001 = '" & FAS001.Text & "'", conexao)
                conexao.Open()
                cmd.ExecuteNonQuery()
                conexao.Close()
            Case 1
                If conexao.State = ConnectionState.Open Then conexao.Close()
                Dim cmd As New MySqlCommand("update prt_fass set COMANDO = '" & comando.Text & "', ARM002 = '" & lvdados.SelectedItems.Item(0).Text & "' WHERE FAS001 = '" & FAS001.Text & "'", conexao)
                conexao.Open()
                cmd.ExecuteNonQuery()
                conexao.Close()
        End Select
    End Sub
    Private Sub lvdados_DoubleClick(sender As Object, e As EventArgs) Handles lvdados.DoubleClick
        Try
            If lvdados.SelectedItems.Count > 0 Then
                frmRegAcesso.btnArmario.Text = lvdados.SelectedItems.Item(0).Text
                If iFiltroARM = Nothing Then
                    ' NOVO ARMÁRIO
                    comando.Text = "2"
                    Call gravar(1) ' GRAVA STATUS NA TABELA PRT_FASS CAMPO COMANDO = 1
                    alterado = 500
                    MetroFramework.MetroMessageBox.Show(Me, " Evento registrado ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    Try
                        comando.Text = "1"
                        Call gravar(0) ' GRAVA STATUS NA TABELA PRT_FASS CAMPO COMANDO = 1
                        alterado = 500
                        If (MetroFramework.MetroMessageBox.Show(Me, " O ARMÁRIO FOI LIBERADO. Deseja cadastrar outro armário para o funcionário ?", "" & legenda & "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)) = MsgBoxResult.Yes Then
                            iFiltroARM = Nothing
                            Call carregalist()
                        Else
                            Me.Close()
                        End If
                    Catch ex As Exception
                        MetroFramework.MetroMessageBox.Show(Me, ex.Message)
                    End Try
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmRegAcesso.btnArmario.Text = ""
        Me.Close()
    End Sub
#End Region

End Class
























