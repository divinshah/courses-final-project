using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalassignment
{
    public partial class Pages : System.Web.UI.Page
    {
        private string basequery = "Select pageid,Pagetitle,pagecontent,publishdate FROM Pages";

        protected void Page_Load(object sender, EventArgs e)
        {
            pages_select.SelectCommand = basequery;
            //debug.InnerHtml = basequery;
            //classes_list.DataSource = classes_select;
            pages_list.DataSource = Pages_Manual_Bind(pages_select);
            //pages_query.InnerHtml = basequery;
            pages_list.DataBind();

        }

        protected DataView Pages_Manual_Bind(SqlDataSource src)
        {
            //We should have full control over the ability to pick
            //and choose how we represent our serverside data on the client side HTML

            DataView myview;
            DataTable mytbl;
            mytbl = ((DataView)src.Select(DataSourceSelectArguments.Empty)).Table;
            foreach (DataRow row in mytbl.Rows)
            {
                //Intercept a specific column rendering
                //add a link of that column info
                
                   
                row["Pagetitle"] =
                    "<a href=\"Page.aspx?pageid="
                    + row["pageid"]
                    + "\">"
                    + row["pagetitle"]
                     ;



            }
            mytbl.Columns.Remove("pageid");
            //mytbl.Columns.Remove("classid");
            myview = mytbl.DefaultView;

            return myview;

        }
    }
}