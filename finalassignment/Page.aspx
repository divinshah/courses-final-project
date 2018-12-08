<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Page.aspx.cs" Inherits="finalassignment.Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3 id="page_name" runat="server"></h3>
    <a href="EditPage.aspx?Pageid=<%Response.Write(this.pageid);%>" class="btn btn-warning">Edit Page</a>
    <asp:SqlDataSource 
        runat="server"
        id="del_page"
        ConnectionString="<%$ ConnectionStrings:school_sql_con %>">
    </asp:SqlDataSource>
    <asp:Button runat="server" id="del_class_btn"
        OnClick="DelPage"
        OnClientClick="if(!confirm('Are you sure?')) return false;"
        Text="Delete" class="btn btn-danger" />
    <div id="del_debug" class="querybox" runat="server"></div>

    <asp:SqlDataSource runat="server"
        id="page_select"
        ConnectionString="<%$ ConnectionStrings:school_sql_con %>">
    </asp:SqlDataSource>
    <div id="page_contents" runat="server"></div>
    <asp:DataGrid ID="page_list" runat="server">
    </asp:DataGrid>
</asp:Content>
