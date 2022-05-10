using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StockList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        clsStockCollection Stocks = new clsStockCollection();
        lstStockList.DataSource = Stocks.StockList;
        lstStockList.DataValueField = "Id";
        lstStockList.DataTextField = "Name";
        lstStockList.DataBind();

    }

    protected void lstStockList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void AddButton_Click(object sender, EventArgs e)
    {
        Session["Id"] = -1;
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void EditButton_Click(object sender, EventArgs e)
    {
        Int32 Id;
        if (lstStockList.SelectedIndex != -1)
        {
            Id = Convert.ToInt32(lstStockList.SelectedValue);
            Session["Id"] = Id;
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void DeleteButton_Click(object sender, EventArgs e)
    {
        Int32 Id;
        if(lstStockList.SelectedIndex != -1)
        {
            Id = Convert.ToInt32(lstStockList.SelectedValue);
            Session["Id"] = Id;
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void ApplyButton_Click(object sender, EventArgs e)
    {
        clsStockCollection AllStocks = new clsStockCollection();
        AllStocks.ReportByType(txtFilter.Text);
        lstStockList.DataSource = AllStocks.StockList;
        lstStockList.DataValueField = "Id";
        lstStockList.DataTextField = "Name";
        lstStockList.DataBind();
    }

    protected void ClearButton_Click(object sender, EventArgs e)
    {
        clsStockCollection AllStocks = new clsStockCollection();

        txtFilter.Text = "";
        AllStocks.ReportByType(txtFilter.Text);
        lstStockList.DataSource = AllStocks.StockList;
        lstStockList.DataValueField = "Id";
        lstStockList.DataTextField = "Name";
        lstStockList.DataBind();
    }

}