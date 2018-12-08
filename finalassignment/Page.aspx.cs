using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalassignment
{
    public partial class Page : System.Web.UI.Page
    {
        public string pageid
        {
            get { return Request.QueryString["pageid"]; }
        }
        private string page_basequery = "Select pageid,PAGETITLE,pagecontent FROM Pages";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (pageid == "" || pageid == null) page_name.InnerHtml = "No class found.";
            else
            { 
            page_basequery += " WHERE PAGEID = " + pageid;
            page_select.SelectCommand = page_basequery;

            DataView pageview = (DataView)page_select.Select(DataSourceSelectArguments.Empty);
            string pagename = pageview[0]["Pagetitle"].ToString();
            page_name.InnerHtml = pagename;
                string content1 = pageview[0]["pagecontent"].ToString();
                page_contents.InnerHtml = content1; 


            //page_list.DataSource = Page_Manual_Bind(page_select);
            //page_list.DataBind();
            }

        }
        protected void DelPage(object sennder, EventArgs e)
        {
            string delquery = "DELETE FROM PAGES WHERE pageid=" + pageid;

            del_debug.InnerHtml = delquery;
            del_page.DeleteCommand = delquery;
            del_page.Delete();
        }
        //protected DataView Page_Manual_Bind(SqlDataSource src)
        //{
        //    DataTable mytbl;
        //    DataView myview;
        //    mytbl = ((DataView)src.Select(DataSourceSelectArguments.Empty)).Table;
        //    foreach (DataRow row in mytbl.Rows)
        //    {
        //        row["Teacher"] =
        //            "<a href=\"Teacher.aspx?teacherid="
        //            + row["teacherid"]
        //            + "\">"
        //            + row["Teacher"]
        //            + "</a>";
        //    }
        //
        //}
        //protected void Search_Pages(object sender, EventArgs e)
        //{
        //    /*
        //      This function takes the inputs from the search
        //      and changes the sqldatasource select command
        //      to filter down students.
        //    */
        //    string newsql = page_basequery + " WHERE (1=1) ";
        //    string key = student_key.Text;
        //    List<string> sec = new List<string>();
        //    foreach (ListItem section in student_sec.Items)
        //    {
        //        if (section.Selected)
        //        {
        //            sec.Add(section.Value);
        //        }
        //    }

        //    if (key != "")
        //    {
        //        newsql +=
        //            " AND (CONCAT(STUDENTFNAME, STUDENTLNAME) LIKE '%" + key + "%'" +
        //            " OR STUDENTNUMBER LIKE '%" + key + "%') ";
        //    }
        //    if (sec.Count > 0)
        //    {
        //        //This block only executes when there is at least one section
        //        //selected, meaning the logic won't break if none are.
        //        newsql += " AND ( ";
        //        //Adding a condition where students can be in one,
        //        // 
        //        foreach (string sectionkey in sec)
        //        {
        //            newsql +=
        //                " STUDENTSECTION LIKE '%" + sectionkey + "%' OR";
        //            //This is extendable to more than two sections.
        //            // (
        //            // STUDENTSECTION LIKE '%A%' OR
        //            // STUDENTSECTION LIKE '%B%' OR
        //            // STUDENTSECTION LIKE '%C%' OR
        //            // FALSE
        //            // )
        //        }
        //        newsql += " 1=0)";
        //        //1=0 means FALSE.
        //        //( ... ) OR FALSE will only be true  
        //        //when ( ... ) is true.
        //    }

        //    students_select.SelectCommand = newsql;
        //    student_query.InnerHtml = newsql;

        //    //Intercept the "auto bind" and create our own binding
        //    students_list.DataSource = Students_Manual_Bind(students_select);

        //    students_list.DataBind();

        //}
    }
}