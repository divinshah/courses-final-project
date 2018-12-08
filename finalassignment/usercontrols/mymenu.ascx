<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="mymenu.ascx.cs" Inherits="finalassignment.mymenu" %>
<%-- select * from pages --%>
<asp:SqlDataSource runat="server" ID="pages_select" ConnectionString="<%$ ConnectionStrings:school_sql_con %>"></asp:SqlDataSource>
<ul class="nav navbar-nav" id="menucontainer" runat="server">
   
</ul>