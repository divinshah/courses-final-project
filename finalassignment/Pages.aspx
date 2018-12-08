<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pages.aspx.cs" Inherits="finalassignment.Pages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2><%: Title %></h2>
    <a href="Newpage.aspx" class="btn btn-success">Add Page</a>
    <%--
    Microsoft SQL uses + for string concatenation instead
    of Oracle SQL's ||.
    --%>
    
    <asp:SqlDataSource runat="server"
        id="pages_select"
       
        ConnectionString="<%$ ConnectionStrings:school_sql_con %>">
    </asp:SqlDataSource>
    <div id="pages_query" class="querybox" runat="server">
    
    </div>
    <asp:DataGrid id="pages_list"
        runat="server" >
    </asp:DataGrid>
    

    <div id="debug" runat="server"></div>

</asp:Content>
