<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Newpage.aspx.cs" Inherits="finalassignment.Newpage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>New Class</h3>
    <asp:SqlDataSource runat="server" id="insert_page"
        ConnectionString="<%$ ConnectionStrings:school_sql_con %>">

    </asp:SqlDataSource>
    <div class="inputrow">
        <label class="control-label col-sm-2">Page Title:</label>
        <asp:TextBox ID="page_name" runat="server" CssClass="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator runat="server"
            ControlToValidate="page_name"
            ErrorMessage="Enter a page title">
        </asp:RequiredFieldValidator>
    </div>
    <div class="inputrow">
        <label class="control-label col-sm-2">Page Content:</label>
        <asp:TextBox ID="page_content" CssClass="form-control" runat="server"></asp:TextBox>
        
    </div>
    <ASP:Button Text="Add a Page" runat="server" OnClick="AddPage" class="btn btn-dark"/>

    <div runat="server" id="debug" class="querybox"></div>
</asp:Content>
