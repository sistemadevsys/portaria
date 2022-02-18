Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Imports System.Drawing

Public Class frmRegAcesso
    Dim filtroMov, index As Integer
    Dim data_hoje As DateTime = DateAndTime.Now
    Dim sqlm As String
    Dim pop As Integer
    Dim iFUN028 As String
    Dim opc As Integer
    Dim chave As String
    Dim FAS011, EMP002, ARM002, VEI002, FUN035, FUN003, IMG006 As New TextBox

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
        FAS011.Text = ""
        EMP002.Text = ""
        ARM002.Text = ""
        VEI002.Text = ""
        FUN035.Text = ""
        tbPesq01.Clear()
        opc = 1 ' OPCÃO PARA O FILTRO 
        iFUN028 = "FUN"
        filtroMov = 2
        Call carregalist()
        If pop > 0 Then
            Me.lvMovimento.Items(0).Selected = True
            lvMovimento.Select()
        End If
    End Sub
#End Region

#Region "FUNÇÕES"

    Private Sub gravar(arg)
        Select Case arg
            Case 0
                If btnArmario.Text <> Nothing Then
                    ARM002.Text = btnArmario.Text
                Else
                    ARM002.Text = "0"
                End If

                If btnCarro.Text <> Nothing Then
                    VEI002.Text = btnCarro.Text
                Else
                    VEI002.Text = "0"
                End If

                If btnObs.Text <> Nothing Then
                    FUN035.Text = btnObs.Text
                Else
                    FUN035.Text = "Não"
                End If

                If conexao.State = ConnectionState.Open Then conexao.Close()
                Dim cmd As New MySqlCommand("INSERT INTO prt_fass (FUN002,EMP002,VEI002,ARM002,FAS002,FAS003,FAS004,FAS005,FAS011,OBS)values('" & FUN002.Text & "','" & EMP002.Text & "','" & btnCarro.Text & "','" & btnArmario.Text & "','" & Format(data_hoje, "yyyy-MM-dd") & "','" & DateTime.Now.ToLongTimeString().Substring(0, 5) & "','" & DateTime.Now.ToLongTimeString().Substring(0, 5) & "','" & iUsername & "','" & FAS011.Text & "','" & FUN035.Text & "')", conexao)
                conexao.Open()
                cmd.ExecuteNonQuery()
                conexao.Close()
        End Select
    End Sub

    Private Sub limpaCampos()
        EMP003.Text = ""
        FUN004.Text = ""
        FUN009.Text = ""
        FUN029.Text = ""
        FUN030.Text = ""
        FUN031.Text = ""
        FUN032.Text = ""
        FUN033.Text = ""
        FUN034.Text = ""
        btnCarro.Text = Nothing
        btnArmario.Text = Nothing
        btnObs.Text = Nothing
    End Sub
    Private Sub corlist()
        Try
            lvMovimento.FocusedItem.SubItems(0).BackColor = Color.FromArgb(246, 137, 31)
            lvMovimento.FocusedItem.SubItems(1).BackColor = Color.FromArgb(246, 137, 31)
            lvMovimento.FocusedItem.SubItems(0).ForeColor = Color.White
            lvMovimento.FocusedItem.SubItems(1).ForeColor = Color.White
            Return
        Catch ex As Exception

        End Try
    End Sub
    Private Sub carregalist()
        Try
            If conexao.State = 0 Then
                conexao.Open()
            End If

            Call limpaCampos()
            Call filtro() ' FILTRO DE SELEÇÃO SQL
            lvMovimento.Items.Clear()
            lvMovimento.GridLines = True
            lvMovimento.FullRowSelect = True
            lvMovimento.View = View.Details
            lvMovimento.Sorting = SortOrder.None

            Dim cmd As MySqlCommand = New MySqlCommand(sqlm, conexao)
            Dim leitor As MySqlDataReader = cmd.ExecuteReader()
            pop = 0   ' CONTROLA A QUANTIDADE DE REGISTROS NO GRID
            Do While leitor.Read()
                Dim item As New ListViewItem()
                item.Text = leitor(0)

                item = lvMovimento.Items.Add(leitor("FUN002").ToString)  '0 CÓDIGO
                item.SubItems.Add(leitor("FUN003"))                      '1 NOME DO FUNCIONÁRIO
                item.SubItems.Add(leitor("FUN024"))                      '2 REGISTRO DA IMAGEM
                item.SubItems.Add(leitor("FUN028"))                      '3 Tipo de Cadastro FUN028 

                pop += 1 ' faz a contagem dos registros no listview
            Loop
            img.ImageLocation = (My.Application.Info.DirectoryPath & "\file\employee\REGISTRO.dat")
            If pop > 0 Then
                P1.Visible = True
                P2.Visible = True
                P3.Visible = True
                Label2.Visible = True
                P4.Visible = True
                P5.Visible = True
                Button1.Enabled = True
            Else
                P1.Visible = False
                P2.Visible = False
                P3.Visible = False
                Label2.Visible = False
                P4.Visible = False
                P5.Visible = False
                Button1.Enabled = False
            End If

            leitor.Close()
            conexao.Close() ' fecha a conexação com o banco de dados
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub filtro()
        Select Case filtroMov
            Case 0
                sqlm = "SELECT FUN002,FUN003,FUN024,FUN028 FROM prt_cadfun where FUN023 = '0' ORDER BY FUN003,EMP002"
            Case 1
                sqlm = "SELECT FUN002,FUN003,FUN024,FUN028 FROM prt_cadfun where FUN003 like '" & chave & "%' and FUN023 = '0' ORDER BY FUN003"
            Case 2
                sqlm = "SELECT FUN002,FUN003,FUN024,FUN028 FROM prt_cadfun where FUN023 = '0' and FUN028 = '" & iFUN028 & "' ORDER BY FUN003,EMP002"
            Case 3
                If opc = 1 Or opc = 2 Then
                    sqlm = "SELECT FUN002,FUN003,FUN024,FUN028 FROM prt_cadfun where FUN003 like '" & chave & "%' and FUN023 = '0' AND FUN028 = '" & iFUN028 & "' ORDER BY FUN003"
                Else
                    sqlm = "select FUN002,FUN003,FUN024,FUN028 FROM prt_cadfun as a inner join prt_empresa as b on (a.emp002 = b.emp002) where b.emp003 like '" & chave & "%' and a.FUN023 = '0' and a.FUN028 = '" & iFUN028 & "' ORDER BY a.FUN003 "
                End If
        End Select
    End Sub



    Private Sub tbPesq01_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPesq01.KeyPress
        If opc = 0 Then
            filtroMov = 1
        Else
            filtroMov = 3
        End If
    End Sub
    Private Sub tbPesq01_TextChanged(sender As Object, e As EventArgs) Handles tbPesq01.TextChanged
        chave = ""
        chave = "%" & tbPesq01.Text
        Call carregalist()
    End Sub


    Private Sub buscadados()
        If conexao.State = 0 Then
            conexao.Open()
        End If
        Dim comando As New MySqlCommand("select a.EMP002,a.FUN028,a.FUN004,a.FUN009,a.FUN029,a.FUN030,a.FUN031,a.FUN032,a.FUN033,a.FUN034,b.EMP003 FROM prt_cadfun as a left JOIN prt_empresa as b on (a.emp002 = b.emp002) where a.FUN002 = '" & lvMovimento.SelectedItems(0).SubItems(0).Text & "'", conexao)
        Dim leitor As MySqlDataReader = comando.ExecuteReader()
        While leitor.Read()
            iFUN028 = leitor("FUN028")
            If iFUN028 = "FUN" Then
                EMP003.Text = iReg002
            ElseIf iFUN028 = "PRE" Then
                EMP003.Text = "PRESTADORES DE SERVIÇOS AUTONOMOS"
            Else
                EMP003.Text = IIf(Convert.IsDBNull(leitor("EMP003")) = True, "", leitor("EMP003")) ' NOME DA EMPRESA
            End If
            FUN004.Text = IIf(Convert.IsDBNull(leitor("FUN004")) = True, "", leitor("FUN004"))
            FUN009.Text = IIf(Convert.IsDBNull(leitor("FUN009")) = True, "", leitor("FUN009"))
            FUN029.Text = IIf(Convert.IsDBNull(leitor("FUN029")) = True, "", leitor("FUN029"))
            FUN030.Text = IIf(Convert.IsDBNull(leitor("FUN030")) = True, "", leitor("FUN030"))
            FUN031.Text = IIf(Convert.IsDBNull(leitor("FUN031")) = True, "", leitor("FUN031"))
            FUN032.Text = IIf(Convert.IsDBNull(leitor("FUN032")) = True, "", leitor("FUN032"))
            FUN033.Text = IIf(Convert.IsDBNull(leitor("FUN033")) = True, "", leitor("FUN033"))
            FUN034.Text = IIf(Convert.IsDBNull(leitor("FUN034")) = True, "", leitor("FUN034"))
            EMP002.Text = IIf(Convert.IsDBNull(leitor("EMP002")) = True, "", leitor("EMP002"))
        End While
        comando.Cancel()
        leitor.Close()
        conexao.Close()
    End Sub

#End Region

#Region "ENTER"
    Private Sub tbPesq01_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles tbPesq01.KeyDown
        Dim KeyCode As Short = eventArgs.KeyCode
        If KeyCode = System.Windows.Forms.Keys.Return Then
            If pop > 0 Then
                Me.lvMovimento.Items(0).Selected = True
                lvMovimento.Select()
            End If
        End If
    End Sub
#End Region

#Region "COMPONENTES"
    Private Sub lvMovimento_Click(sender As Object, e As EventArgs) Handles lvMovimento.Click
        For i As Integer = 0 To lvMovimento.Items.Count - 1
            lvMovimento.Items(i).SubItems(0).BackColor = Color.White  ' 
            lvMovimento.Items(i).SubItems(1).BackColor = Color.FromArgb(0, 21, 68)  ' 
            lvMovimento.Items(i).SubItems(0).ForeColor = Color.FromArgb(0, 21, 68) ' 
            lvMovimento.Items(i).SubItems(1).ForeColor = Color.FromArgb(0, 21, 68) ' 
        Next
    End Sub
    Private Sub lvMovimento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvMovimento.SelectedIndexChanged
        Try
            If lvMovimento.SelectedItems.Count > 0 Then
                index = lvMovimento.Items.Item(lvMovimento.SelectedIndices(0)).Index
                Me.FUN002.Text = Convert.ToString(lvMovimento.Items(lvMovimento.SelectedIndices(0)).Text)
                Me.FUN003.Text = Me.lvMovimento.SelectedItems(0).SubItems(1).Text
                Me.IMG006.Text = Me.lvMovimento.SelectedItems(0).SubItems(3).Text
                ' EXIBE IMAGEM CADASTRADA
                img.ImageLocation = (My.Application.Info.DirectoryPath & "\file\employee\" & Me.lvMovimento.SelectedItems(0).SubItems(2).Text & ".dat")

                Call buscadados() ' Busca o Nome da Empresa
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, "" & legenda & "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "BOTÕES"
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnRegistra.Click
        Try
            Call gravar(0) ' GRAVA O REGISTRO NA TABELA PRT_FASS
            MetroFramework.MetroMessageBox.Show(Me, " ACESSO REGISTRADO ")
            alterado = 500
            Me.Close()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message)
        End Try
    End Sub
    Private Sub btnArmario_Click(sender As Object, e As EventArgs) Handles btnArmario.Click
        Call corlist()
        frmArmario01.ShowDialog()
    End Sub
    Private Sub btnCarro_Click(sender As Object, e As EventArgs) Handles btnCarro.Click
        Call corlist()
        frmVeiculos.VEI002.Text = btnCarro.Text
        frmVeiculos.ShowDialog()
    End Sub
    Private Sub btnObs_Click(sender As Object, e As EventArgs) Handles btnObs.Click
        alterado = 0
        Call corlist()
        frmObs01.ShowDialog()
        If alterado = 100 Then
            FAS011.Text = frmObs01.FAS011.Text
        End If
    End Sub
    Private Sub btnhome_Click(sender As Object, e As EventArgs) Handles btnhome.Click
        Me.Close()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Call limpaCampos()
        tbPesq01.Clear()
        opc = 0
        filtroMov = 0
        Call carregalist() ' carrega a relação de funcionários no grid
        If pop > 0 Then
            Me.lvMovimento.Items(0).Selected = True
            lvMovimento.Select()
        End If
        tbPesq01.Focus()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call limpaCampos()
        tbPesq01.Clear()
        opc = 1 ' OPCÃO PARA O FILTRO 
        iFUN028 = "FUN"
        filtroMov = 2
        Call carregalist() ' carrega a relação de funcionários no grid
        If pop > 0 Then
            Me.lvMovimento.Items(0).Selected = True
            lvMovimento.Select()
        End If
        tbPesq01.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Aviso09.IMG006.Text = IMG006.Text
        Aviso09.FUN002.Text = FUN002.Text
        Aviso09.FUN003.Text = FUN003.Text
        alterado = 0
        Aviso09.ShowDialog()
        Call carregalist() ' recarrega os dados no grid dos funcionários
        If pop > 0 Then
            Me.lvMovimento.Items(index).Selected = True
            lvMovimento.Select()
            tbPesq01.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call limpaCampos()
        tbPesq01.Clear()
        opc = 2 ' OPÇÃO PARA O FILTRO
        iFUN028 = "PRE"
        filtroMov = 2
        Call carregalist() ' carrega a relação de funcionários no grid
        If pop > 0 Then
            Me.lvMovimento.Items(0).Selected = True
            lvMovimento.Select()
        End If
        tbPesq01.Focus()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call limpaCampos()
        tbPesq01.Clear()
        opc = 3 ' OPÇÃO PARA O FILTRO
        iFUN028 = "EMP"
        filtroMov = 2
        Call carregalist() ' carrega a relação de funcionários no grid
        If pop > 0 Then
            Me.lvMovimento.Items(0).Selected = True
            lvMovimento.Select()
        End If
        tbPesq01.Focus()
    End Sub
#End Region




End Class
























