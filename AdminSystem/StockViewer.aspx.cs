using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StockViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStock AnStock = (clsStock)Session["AnStock"];
        Response.Write("Stock ID: " + AnStock.Id+ "<br /><br />");
        Response.Write("Stock Name: " + AnStock.Name + "<br /><br />");
        Response.Write("Stock Quantity: " + AnStock.Quantity + "<br /><br />");
        Response.Write("Stock Type: " + AnStock.Type + "<br /><br />");
        Response.Write("Stock Remark: " + AnStock.Remark + "<br /><br />");
        Response.Write("Stock Availablity: " + AnStock.Available + "<br /><br />");
        Response.Write("Modify Time: " + AnStock.Time + "<br /><br />");
    }

    protected void AddStockButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("StockDataEntry.aspx");
    }
}