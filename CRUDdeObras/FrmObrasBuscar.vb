Public Class Form1
    Public Property TxtNome As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles AdicionarToolStripButton.Click

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click

        GetObras()

    End Sub

    Private Sub GetObras()
        Using db As New ObrasEntities()
            Dim filtroNome As String = ""

            If TxtNome IsNot Nothing Then
                filtroNome = TxtNome.Text.Trim()
            End If

            Dim listaObras As IQueryable(Of Obras) = db.Obras

            If filtroNome <> "" Then
                listaObras = listaObras.Where(Function(v) v.Nome.Contains(filtroNome))
            End If

            DataGridView1.DataSource = listaObras.ToList()
        End Using
    End Sub

End Class
