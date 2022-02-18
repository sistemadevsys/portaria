Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmArmario01
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
        pop = 0
        Call carregalist()
        If pop = 0 Then
            MetroFramework.MetroMessageBox.Show(Me, " Não tem armário disponivel! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
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


        sql = "SELECT ARM002 FROM prt_armarios where ARM004 = '0'"

        If conexao.State = 0 Then
            conexao.Open()
        End If
        Dim cmd As New MySqlCommand(sql, conexao)
        Dim leitor As MySqlDataReader = cmd.ExecuteReader()

        Dim imesa As String
        While leitor.Read()
            imesa = IIf(Convert.IsDBNull(leitor("ARM002")) = True, "", leitor("ARM002"))
            lvdados.Items.Add(imesa, RancomClass.Next(0, 1) Mod 1)

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
    Private Sub lvdados_DoubleClick(sender As Object, e As EventArgs) Handles lvdados.DoubleClick
        Try
            If lvdados.SelectedItems.Count > 0 Then
                frmRegAcesso.btnArmario.Text = lvdados.SelectedItems.Item(0).Text
                Me.Close()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmRegAcesso.btnArmario.Text = ""
        Me.Close()
    End Sub
#End Region

End Class
























