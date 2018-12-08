using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace finalassignment
{
    public partial class mymenu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            pages_select.SelectCommand = "select * from pages";
            //grab that result set into  something that we can work with
            //I got this code from Christines example
            DataView myview = (DataView)pages_select.Select(DataSourceSelectArguments.Empty);

            string menucontent = "";
            foreach(DataRowView myrow in myview)
            {
                menucontent += "<li><a href=\"Page.aspx?pageid="
                    + myrow["pageid"]
                    + "\">"
                    + myrow["pagetitle"]
                    + "</a></li>";
                //menucontainer.InnerHtml += "< li >< a href = \"Page.aspx?pageid="+ myrow["pageid"]+" > "+myrow["pagetitle"]+" </ a ></ li >";
            //           menucontent += myrow["pageid"]+" "+myrow["pagetitle"];
            }
            

            menucontainer.InnerHtml = menucontent;
        }
    }
}