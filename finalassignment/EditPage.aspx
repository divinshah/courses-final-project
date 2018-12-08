<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditPage.aspx.cs" Inherits="finalassignment.EditPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3 runat="server" id="page_fullname">Edit Page</h3>
    <asp:SqlDataSource runat="server" id="edit_page"
        ConnectionString="<%$ ConnectionStrings:school_sql_con %>">

    </asp:SqlDataSource>

    <div class="inputrow">
        <label class="control-label col-sm-2">Page Title:</label>
        <asp:TextBox ID="page_name" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server"
            ControlToValidate="page_name"
            ErrorMessage="Enter a page name">
        </asp:RequiredFieldValidator>
    </div>
    <div class="inputrow">
        <label class="control-label col-sm-2">Page Content:</label>
        <asp:TextBox ID="page_cont" runat="server" CssClass="form-control"></asp:TextBox>
        
    </div>
    <ASP:Button Text="Update Page" runat="server" OnClick="Edit_Page" class="btn btn-warning"/>

    <div runat="server" id="debug" class="querybox"></div>
</asp:Content>
