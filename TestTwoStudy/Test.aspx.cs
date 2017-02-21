using System;
using ServiceReference1;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Test : System.Web.UI.Page
{
    List<STOCK> stock;
    protected void Page_Load(object sender, EventArgs e)
    {
        Service1Client ws = new Service1Client();
        DataList1.DataSource = ws.getAllStocks();
        DataList1.DataBind();
    }

    protected void btnDisplayStock_Click(object sender, EventArgs e)
    {
        Service1Client ws = new Service1Client();
        DataList2.DataSource = ws.getStockByCode(txtStockCode.ToString());
        DataList2.DataBind();
    }
   
}