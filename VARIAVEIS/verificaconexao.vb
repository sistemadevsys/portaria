Imports System.Net
Public Class verificaconexao
    Public Shared Function VerificaConexao_TcpSocket() As Boolean
        Try
            Dim cliente As New Sockets.TcpClient("www.google.com", 80)
            cliente.Close()
            Return True
        Catch ex As System.Exception
            Return False
        End Try
    End Function

End Class
