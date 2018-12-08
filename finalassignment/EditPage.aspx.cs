using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace finalassignment
{
    public partial class EditPage : System.Web.UI.Page
    {
        public int pageid
        {
            get { return Convert.ToInt32(Request.QueryString["pageid"]); }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            //Set the values for the student
            DataRowView studentrow = getClassInfo(pageid);
            if (studentrow == null)
            {
                page_fullname.InnerHtml = "No Class Found.";
                return;
            }
            page_name.Text = studentrow["pagetitle"].ToString();
            //debug.InnerHtml = studentrow["classcode"].ToString().Substring(0, 4).ToUpper();
            //class_code.SelectedValue = studentrow["classcode"].ToString().Substring(0, 4).ToUpper();
            //put this into the title so we know who we're editing
            page_cont.Text = studentrow["pagecontent"].ToString().Substring(4);

        }
        protected void Edit_Page(object sender, EventArgs e)
        {
            string name = page_name.Text;
            string contn = page_cont.Text;

            string editquery = "Update pages set pagetitle='" + name + "'," +
                " pagecontent='" + contn + "'" +
                "where pageid=" + pageid;
            debug.InnerHtml = editquery;

            edit_page.UpdateCommand = editquery;
            edit_page.Update();
        }
        protected DataRowView getClassInfo(int id)
        {
            string query = "select * from pages where pageid=" + pageid.ToString();
            edit_page.SelectCommand = query;
            //debug.InnerHtml = query;
            //Another small manual manipulation to present the students name outside of
            //the datagrid.
            DataView pageview = (DataView)edit_page.Select(DataSourceSelectArguments.Empty);

            //If there is no student in the studentview, an invalid id is passed
            if (pageview.ToTable().Rows.Count < 1)
            {
                return null;
            }
            DataRowView pagerowview = pageview[0]; //gets the first result which is always the student
            //string studentinfo = studentview[0][colname].ToString();
            return pagerowview;

        }
        
    }
}