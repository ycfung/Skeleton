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
        AnStock.Id = Convert.ToInt32(TextBoxID.Text);
        AnStock.Name = TextBoxName.Text;
        AnStock.Quantity = Convert.ToInt32(TextBoxQuantity.Text);
        AnStock.Type = TextBoxType.Text;
        AnStock.Remark = TextBoxRemark.Text;
        AnStock.Available = Availablity.Checked;
        if (TextBoxTime.Text.Length == 0)
            AnStock.Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        else
            AnStock.Time = Convert.ToDateTime(TextBoxTime.Text).ToString();
        Session["AnStock"] = AnStock;
        //Response.Write(AnStock.quantity + '\n' + AnStock.name);
        Response.Redirect("StockViewer.aspx");
    }
    protected void GoBack(object sender, EventArgs e)
    {
        Response.Redirect("StockViewer.aspx");
    }



    protected void Find_Click(object sender, EventArgs e)
    {
        clsStock AnStock = new clsStock();
        Int32 Id;
        Boolean Found = false;
        Id = Convert.ToInt32(TextBoxID.Text);
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