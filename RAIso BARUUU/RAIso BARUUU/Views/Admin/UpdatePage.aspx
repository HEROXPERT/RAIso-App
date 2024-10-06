<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="UpdatePage.aspx.cs" Inherits="RAIso_BARUUU.Views.Admin.UpdatePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="nameLbl" runat="server" Text="Stationery Name : "></asp:Label>
    <asp:TextBox ID="nameTb" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="priceLbl" runat="server" Text="Price : "></asp:Label>
    <asp:TextBox ID="priceTb" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="errorLbl" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Button ID="updateBtn" runat="server" Text="Update" OnClick="updateBtn_Click" />
    <h6><%=Request.QueryString["id"] %></h6>
</asp:Content>
