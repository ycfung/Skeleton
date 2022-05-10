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
        if(IsPostBack == false)
        {
            if(Id != -1)
            {
                DisplayStock();
            }
        }

    }

    protected void Submit(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();
        string Id =TextBoxID.Text;
        string Name = TextBoxName.Text;
        string Quantity = TextBoxQuantity.Text;
        string Type = TextBoxType.Text;
        string Remark = TextBoxRemark.Text;
        Boolean Available = Availablity.Checked;
        string Time = TextBoxTime.Text;

        string Error = "";
        Error = AnStock.Valid(Id, Name, Quantity, Type, Remark, Time);
        if(Error == "")
        {
            AnStock.Id = Id;
            AnStock.Name = Name;
            AnStock.Quantity = Quantity;
            AnStock.Type = Type;
            AnStock.Remark = Remark;
            AnStock.Available = Available;
            AnStock.Time = Time;
            clsStockCollection stockCollection = new clsStockCollection();

            if (Id.Equals("-1")){
                stockCollection.ThisStock = AnStock;
                stockCollection.Add();
            }
            else
            {
                stockCollection.ThisStock.Find(Id);
                stockCollection.ThisStock = AnStock;
                stockCollection.Update();
            }


            Response.Redirect("StockList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }


    }
    protected void GoBack(object sender, EventArgs e)
    {
        Response.Redirect("StockViewer.aspx");
    }



    protected void Find_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();
        string Id;
        Boolean Found = false;
        Id = TextBoxID.Text;
        Found = AnStock.Find(Id);
        if(Found == true)
        {
            TextBoxID.Text = AnStock.Id.ToString();
            TextBoxName.Text = AnStock.Name;
            TextBoxQuantity.Text = AnStock.Quantity.ToString();
            TextBoxType.Text = AnStock.Type;
            TextBoxRemark.Text = AnStock.Remark;
            TextBoxTime.Text = AnStock.Time;
            if (AnStock.Available)
                Availablity.Checked = true;
            else Availablity.Checked = false;

        }

    }

    void DisplayStock()
    {
        clsStockCollection stockCollection = new clsStockCollection();
        stockCollection.ThisStock.Find(Convert.ToString(Id));
        TextBoxID.Text = stockCollection.ThisStock.Id.ToString();
        TextBoxName.Text = stockCollection.ThisStock.Name;
        TextBoxQuantity.Text = stockCollection.ThisStock.Quantity.ToString();
        TextBoxType.Text = stockCollection.ThisStock.Type;
        TextBoxRemark.Text = stockCollection.ThisStock.Remark;
        TextBoxTime.Text = stockCollection.ThisStock.Time;
        if (stockCollection.ThisStock.Available)
            Availablity.Checked = true;
        else Availablity.Checked = false;

    }
}