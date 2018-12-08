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
        private string page_basequery = "Select pageid,PAGETITLE,pagecontent,publishdate FROM Pages";

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
                string date = pageview[0]["publishdate"].ToString();
                publish_date.InnerHtml = "Date of Publish:"+" "+ date;
                


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
        
    }
}