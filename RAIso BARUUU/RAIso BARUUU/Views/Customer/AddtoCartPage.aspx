<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="AddtoCartPage.aspx.cs" Inherits="RAIso_BARUUU.Views.Customer.AddtoCartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><%=Request.QueryString["id"] %></h1>
    <h2>Fill the quantity to add to cart</h2>
    <asp:Label ID="quantityLbl" runat="server" Text="Quantity :  "></asp:Label>
    <asp:TextBox ID="quantityTb" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="remindquantLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
    <asp:Button ID="submitBtn" runat="server" Text="Submit" OnClick="submitBtn_Click" />
</asp:Content>
