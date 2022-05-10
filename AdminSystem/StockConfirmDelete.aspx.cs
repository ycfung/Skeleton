using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    Int32 Id;
    protected void Page_Load(object sender, EventArgs e)
    {
        Id = Convert.ToInt32(Session["Id"]);
    }

    protected void YesButton_Click(object sender, EventArgs e)
    {
        clsStockCollection AllStock = new clsStockCollection();
        AllStock.ThisStock.Find(Convert.ToString(Id));
        AllStock.Delete();
        Response.Redirect("StockList.aspx");
    }

    protected void NoButton_Click(object sender, EventArgs e)
    {

    }
}