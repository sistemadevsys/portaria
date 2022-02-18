Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmVeiculos01
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
    Private Sub frmVeiculos01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call pesquisa()
        Call carregalist(0)
        If pop > 0 Then
            Me.lvFotos.Items(0).Selected = True
            lvFotos.Select()
        End If
    End Sub
#End Region

#Region "FUNÇÕES"
    Private Sub pesquisa()
        If conexao.State = 0 Then
            conexao.Open()
        End If
        Dim comando As New MySqlCommand("select VEI003,VEI004 FROM prt_veiculos where VEI002 = '" & VEI002.Text & "'", conexao)
        Dim leitor As MySqlDataReader = comando.ExecuteReader()
        While leitor.Read()
            VEI003.Text = IIf(Convert.IsDBNull(leitor("VEI003")) = True, "", leitor("VEI003")) '
            VEI004.Text = IIf(Convert.IsDBNull(leitor("VEI004")) = True, "", leitor("VEI004")) '
        End While
        comando.Cancel()
        leitor.Close()
        conexao.Close()
    End Sub
#End Region

#Region "BOTÕES"
    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        alterado = 500
        Me.Close()
    End Sub
#End Region

#Region "FUNÇÕES"
    Private Sub carregalist(arg)
        Select Case arg
            Case 0
                lvFotos.Items.Clear()
                lvFotos.BackColor = Color.White
                lvFotos.GridLines = True
                lvFotos.FullRowSelect = True
                lvFotos.View = View.Details
                lvFotos.Sorting = SortOrder.None
                conexao.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("select IMC001,IMC002,IMC003,IMC005,IMC004 from prt_imgcar where VEI002 = '" & VEI002.Text & "'", conexao)
                Dim leitor As MySqlDataReader = cmd.ExecuteReader()
                pop = 0
                Do While leitor.Read()
                    Dim item As New ListViewItem()
                    item.Text = leitor(0)
                    item = lvFotos.Items.Add(leitor("IMC001").ToString)                ' 0 ID
                    item.SubItems.Add(Format(leitor("IMC002"), "dd/MM/yyyy").ToString) ' 1 DATA DO ARQUIVO
                    item.SubItems.Add(leitor("IMC003").ToString)                       ' 2 HORA DO ARQUIVO
                    item.SubItems.Add(leitor("IMC005").ToString)                       ' 3 PORTEIRO 
                    item.SubItems.Add(leitor("IMC004").ToString)                       ' 4 NOME DO ARQUIVO DA FOTO
                    pop += 1
                Loop
                conexao.Close() ' fecha a conexação com o banco de dados
                leitor.Dispose()
        End Select
    End Sub

    Private Sub lvFotos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvFotos.SelectedIndexChanged
        Try
            If lvFotos.SelectedItems.Count > 0 Then
                'indexFoto = lvFotos.Items.Item(lvFotos.SelectedIndices(0)).Index
                ' FAZ A LEITURA DA IMAGEM COM REFERENCIA DA TABELA BUSCANDOO DIRETORIO ONDE ESTA A IMAGEM
                imgbanco.ImageLocation = (My.Application.Info.DirectoryPath & "\file\car\" & Me.lvFotos.SelectedItems(0).SubItems(4).Text & ".dat")
                registro.Text = Me.lvFotos.SelectedItems(0).SubItems(4).Text
                porteiro.Text = Me.lvFotos.SelectedItems(0).SubItems(3).Text
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region



    
End Class
























