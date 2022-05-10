using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff staffMember = new clsStaff();
        staffMember = (clsStaff) Session["staffMember"];
        Response.Write("Staff Name: " + staffMember.StaffName + "<br />");
        Response.Write("Staff ID: " + staffMember.StaffId + "<br />");
        Response.Write("Salary: " + staffMember.StaffSalary + "<br />");
        Response.Write("Staff Role: " + staffMember.StaffRole + "<br />");   
        Response.Write("Date Added To System: " + staffMember.StaffDateAdded + "<br />");
    }
}