Imports System.Net
Imports System.Data
Imports Newtonsoft.Json
Partial Class VB
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            Dim json As String = (New WebClient).DownloadString("https://raw.githubusercontent.com/aspsnippets/test/master/Customers.json")
            GridView1.DataSource = JsonConvert.DeserializeObject(Of DataTable)(json)
            GridView1.DataBind()
        End If
    End Sub
End Class
