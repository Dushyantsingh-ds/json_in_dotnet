using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Net;
using System.Data;
using Newtonsoft.Json;

public partial class CS : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            string json = (new WebClient()).DownloadString("https://raw.githubusercontent.com/aspsnippets/test/master/Customers.json");
            GridView1.DataSource = JsonConvert.DeserializeObject<DataTable>(json);
            GridView1.DataBind();
        }
    }
}