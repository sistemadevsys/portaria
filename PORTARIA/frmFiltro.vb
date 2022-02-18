Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmFiltro

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
    Private Sub frmAtalhos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            ' BOTÃO INCLUIR NOVO REGISTRO
            Me.Close()
        End If
    End Sub

    Private Sub frmFiltro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height) - 225
        Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width) - 930
        Call carregadados() ' CARREGAS AS INFORMAÇÕES DE LOCALIZAÇÃO DAS GARAGENS
        GAR003.SelectedIndex = 0 ' SELECIONA O PRIMEIRO ITEM DO COMBOBOX
    End Sub
#End Region

#Region "FUNÇÕES"
    Private Sub carregadados()
        Try
            Dim ds, Dset As New DataSet
            Dim dr As DataRow
            Dim dt As New DataTable
            Dim sql = "SELECT LOCG002 FROM PRT_LOCGAR ORDER BY LOCG002 "
            Dim adptr As New MySqlDataAdapter(sql, conexao)
            adptr.Fill(ds, "PRT_LOCGAR")
            dt = ds.Tables(0)
            GAR003.Text = ""
            GAR003.Items.Clear()
            GAR003.Items.Add("Todos")
            For Each dr In dt.Rows
                GAR003.Items.Add(dr.Item("LOCG002"))
            Next
            conexao.Close()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
    End Sub


    Private Sub btnLivre_Click(sender As Object, e As EventArgs) Handles btnLivre.Click
        'LIVRES
        iGAR005 = 0
        alterado = 99
        Me.Close()
    End Sub

    Private Sub brnOcupado_Click(sender As Object, e As EventArgs) Handles brnOcupado.Click
        ' OCUPADO
        iGAR005 = 1
        alterado = 99
        Me.Close()
    End Sub

    Private Sub btnBloqueado_Click(sender As Object, e As EventArgs) Handles btnBloqueado.Click
        ' BLOQUEADO
        iGAR005 = 2
        alterado = 99
        Me.Close()
    End Sub

    Private Sub btnReservado_Click(sender As Object, e As EventArgs) Handles btnReservado.Click
        ' RESERVADO
        iGAR005 = 3
        alterado = 99
        Me.Close()
    End Sub

    Private Sub BtnManutencao_Click(sender As Object, e As EventArgs) Handles BtnManutencao.Click
        ' MANUTENÇÃO
        iGAR005 = 4
        alterado = 99
        Me.Close()
    End Sub


    Private Sub GAR003_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GAR003.SelectedIndexChanged
        iGAR003 = Trim(GAR003.Text)
    End Sub
End Class
























