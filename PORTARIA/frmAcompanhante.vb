Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmAcompanhante
    Dim pop, total, index As Integer
    Dim ACP01, ACP05 As New TextBox
    Dim CADP001 As New TextBox

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
            Call deletar()
            Me.Close()
        End If
    End Sub
    Private Sub frmAcompanhante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CON02.Text = iCON02
        CADP001.Text = Repositorio.CADP001.Text
        total = CDbl(CON07.Text) + CDbl(CON08.Text)
        Soma.Text = total
        ACP01.Text = "NOVO"


        btnFoto.Visible = False
        img.Visible = False

        Call carregalist()
        If pop > 0 Then
            Me.lvdados.Items(0).Selected = True
            lvdados.Select()
        End If

    End Sub
#End Region





#Region "BOTÕES"

    Private Sub deletar()
        Dim cmd As New MySqlCommand("DELETE FROM prt_acpt where CON02 = '" & CON02.Text & "'", conexao)
        conexao.Open()
        cmd.ExecuteNonQuery()
        conexao.Close()

        alterado = 0
        Me.Close()
    End Sub
    Private Sub btnF7_Click(sender As Object, e As EventArgs) Handles btnF7.Click
        Call deletar()
    End Sub

    Private Sub btnF5_Click(sender As Object, e As EventArgs) Handles btnF5.Click
        If total <> pop Then
            MetroFramework.MetroMessageBox.Show(Me, " Quantidade de acompanhantes registros não confere com o total informado ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            alterado = 500
            Me.Close()
        End If
    End Sub
#End Region

#Region "LISTVIEW"
    Private Sub carregalist()
        lvdados.Items.Clear()
        lvdados.BackColor = Color.White
        lvdados.GridLines = True
        lvdados.FullRowSelect = True
        lvdados.View = View.Details
        lvdados.Sorting = SortOrder.None
        conexao.Open()
        Dim cmd As MySqlCommand = New MySqlCommand("select ACP01,ACP02,ACP04,ACP05 FROM prt_acpt where CON02 = '" & CON02.Text & "' ORDER BY ACP02", conexao)
        Dim leitor As MySqlDataReader = cmd.ExecuteReader()
        pop = 0
        Do While leitor.Read()
            Dim item As New ListViewItem()
            item.Text = leitor(0)
            item = lvdados.Items.Add(leitor("ACP02").ToString) ' 0 NOME DO ACOMPANHANTE
            item.SubItems.Add(leitor("ACP04").ToString)        ' 1 CLASSIFICAÇÃO
            item.SubItems.Add(leitor("ACP01"))                 ' 2 ID DA TABELA
            item.SubItems.Add(leitor("ACP05"))                 ' 2 ARQUIVO DA FOTO
            pop += 1 ' faz a contagem dos registros no listview
        Loop


        conexao.Close() ' fecha a conexação com o banco de dados
        leitor.Dispose()

    End Sub
    Private Sub limpaCampos(arg)
        Select Case arg
            Case 0
                ACP01.Text = "NOVO"
                ACP02.ReadOnly = False
                ACP04.ReadOnly = False
                btnFoto.Visible = False
                img.Visible = False
                ACP02.Clear()
                ACP04.Clear()
                ACP05.Text = "REGISTRO"
                ACP02.Focus()
            Case 1
                btnFoto.Visible = True
                img.Visible = True
        End Select

    End Sub
    Private Sub addCargo_Click(sender As Object, e As EventArgs) Handles addCargo.Click
        ACP01.Text = "NOVO"
        If total = pop And ACP01.Text = "NOVO" Then
            MetroFramework.MetroMessageBox.Show(Me, " Processo interrompido! Para acrescentar mais acompanhantes, altere a quantidade no formulário de origem para prosseguir.", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Call limpaCampos(0)
        End If
    End Sub
    Private Sub lvdados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvdados.SelectedIndexChanged
        Try
            If lvdados.SelectedItems.Count > 0 Then
                Index = lvdados.Items.Item(lvdados.SelectedIndices(0)).Index
                Me.ACP02.Text = Me.lvdados.SelectedItems(0).SubItems(0).Text
                Me.ACP04.Text = Me.lvdados.SelectedItems(0).SubItems(1).Text
                Me.ACP01.Text = Me.lvdados.SelectedItems(0).SubItems(2).Text
                Me.ACP05.Text = Me.lvdados.SelectedItems(0).SubItems(3).Text

                img.ImageLocation = (My.Application.Info.DirectoryPath & "\file\companion\" & ACP05.Text & ".dat")

                If pop = 0 Then
                    Call limpaCampos(0)
                Else
                    Call limpaCampos(1)
                End If

            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        Aviso10.FUN002.Text = ACP01.Text
        Aviso10.FUN003.Text = ACP02.Text
        Aviso10.ACP05.Text = ACP05.Text
        alterado = 0
        Aviso10.ShowDialog()
        If alterado > 0 Then
            Call carregalist() ' popula o grid de cadastro das garagens
            If pop > 0 Then
                Me.lvdados.Items(Index).Selected = True
                lvdados.Select()
            End If
        Else
            Me.lvdados.Items(Index).Selected = True
            lvdados.Select()
        End If
    End Sub
#End Region

#Region "ENTER"

    Private Sub ACP02_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles ACP02.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then

            If ACP02.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " É necessário informar o nome do acompanhante! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ACP02.Focus()
            Else
                ACP04.Select()
            End If
        End If
    End Sub

    Private Sub ACP04_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles ACP04.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then

            If ACP04.TextLength = 0 Then
                MetroFramework.MetroMessageBox.Show(Me, " É necessário informar a classificação... ex: (PAI / MÃE / FILHO Etc...)! ", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ACP04.Focus()
            Else
                If total = pop And ACP01.Text = "NOVO" Then
                    MetroFramework.MetroMessageBox.Show(Me, " Processo interrompido! Para acrescentar mais acompanhantes, altere a quantidade no formulário de origem para prosseguir.", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ACP02.Clear()
                    ACP04.Clear()
                    ACP02.Focus()
                Else
                    Try
                        Dim sql As String
                        If ACP01.Text = "NOVO" Then
                            sql = "INSERT INTO prt_acpt (CON02,ACP02,ACP04,ACP05,CADP001)values('" & CON02.Text & "','" & ACP02.Text & "','" & ACP04.Text & "','REGISTRO','" & CADP001.Text & "')"
                        Else
                            sql = "update prt_acpt set ACP02 = '" & ACP02.Text & "', ACP04 = '" & ACP04.Text & "' WHERE ACP01 = '" & ACP01.Text & "'"
                        End If
                        Dim cmd As New MySqlCommand(sql, conexao)
                        conexao.Open()
                        cmd.ExecuteNonQuery()
                        conexao.Close()
                        Call carregalist()
                        If pop > 0 Then
                            Me.lvdados.Items(0).Selected = True
                            lvdados.Select()
                        End If
                    Catch ex As MySqlException
                        MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                End If
            End If
        End If
    End Sub


#End Region







End Class
























