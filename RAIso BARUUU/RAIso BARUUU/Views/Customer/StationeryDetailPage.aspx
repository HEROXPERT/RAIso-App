<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="StationeryDetailPage.aspx.cs" Inherits="RAIso_BARUUU.Views.Customer.StationeryDetailPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Stationery Detail Page
    </h2>

    <div>
        <asp:Label ID="statnameLbl" runat="server" Text="Stationery Name : "></asp:Label>
        <asp:Label ID="actualstatnameLbl" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="priceLbl" runat="server" Text="Price :  "></asp:Label>
        <asp:Label ID="actualpriceLbl" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="addcartBtn" runat="server" Text="Add to Cart" OnClick="addcartBtn_Click" />
        <br />

    </div>
    <h1><%=Request.QueryString["userid"] %></h1>
    <h1><%=Request.QueryString["statid"] %></h1>
</asp:Content>
