Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmAmplia01
    Dim iVei008 As New TextBox
    Dim tabela As String
    Dim campo As String

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

    Private Sub FrmAmplia01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height - 77) / 2
        Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width + 445) / 2
        VEI003.Clear()
        VEI004.Clear()
        iVei008.Text = ""
        tabela = "prt_veiculos" ' NOME DA TABELA
        campo = "VEI002"      ' CAMPO DA TABELA
        Call pesquisa() ' aciona a pesquisa do veiculos
        imgCar.ImageLocation = (My.Application.Info.DirectoryPath & "\file\car\" & Trim(iVei008.Text) & ".dat")
    End Sub

    Private Sub pesquisa()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter
        Dim sql As String
        sql = "select VEI002,VEI003,VEI004,VEI008 from " & tabela & " where " & campo & " = '" & VEI002.Text & "'"
        If conexao.State = 0 Then
            conexao.Open()
        End If
        da = New MySqlDataAdapter(sql, conexao)
        da.Fill(ds, tabela)
        If ds.Tables(tabela).Rows.Count > 0 Then
            VEI002.Text = ds.Tables(tabela).Rows(0).Item(0)
            VEI003.Text = ds.Tables(tabela).Rows(0).Item(1)
            VEI004.Text = ds.Tables(tabela).Rows(0).Item(2)
            iVei008.Text = ds.Tables(tabela).Rows(0).Item(3)
        Else
            MetroFramework.MetroMessageBox.Show(Me, " Não foi possivel localizar o veiculo inserido no log de acesso. Você ainda pode inserir o veículo utilizando o botão inserir veículo...", "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
        conexao.Close()
    End Sub


End Class
























