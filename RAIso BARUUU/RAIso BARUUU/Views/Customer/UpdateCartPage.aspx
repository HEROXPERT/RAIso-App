<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="UpdateCartPage.aspx.cs" Inherits="RAIso_BARUUU.Views.Customer.UpdateCartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h2>Update Page
        </h2>
        <asp:Label ID="newquantityLbl" runat="server" Text="New Quantity : "></asp:Label>
        <asp:TextBox ID="newquantitytb" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="errorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
        <br />
        <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" />
    </div>
    <h1><%=Request.QueryString["userid"] %></h1>
    <h1><%=Request.QueryString["statid"] %></h1>
</asp:Content>
