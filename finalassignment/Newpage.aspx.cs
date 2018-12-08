using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalassignment
{
    public partial class Newpage : System.Web.UI.Page
    {
        private string addquery = "INSERT INTO PAGES" +
            "(pagetitle,pagecontent, publishdate) VALUES";
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void AddPage(object sender, EventArgs e)
        {
            string name = page_name.Text.ToString();
            string contnt = page_content.Text.ToString();

            addquery += "('" +
                name + "','" + contnt + "',getDate())";

            debug.InnerHtml = addquery;

            //Finally when we've done all our trickery to make
            //the sql command work, we can now do it!
            insert_page.InsertCommand = addquery;
            insert_page.Insert();
        }
    }
}