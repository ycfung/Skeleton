using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
            Session["AnStock"] = AnStock;
            Response.Redirect("StockViewer.aspx");
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
}