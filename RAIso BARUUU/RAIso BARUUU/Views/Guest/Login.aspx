<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Guest/Guest.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RAIso_BARUUU.Views.Guest.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Login Page
    </h2>
    <div>
        <asp:Label ID="usernameLbl" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="usernameTb" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="passwordLbl" runat="server" Text="Password"></asp:Label>
       <asp:TextBox ID="passwordTb" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="remembemeLbl" runat="server" Text="Remember Me"></asp:Label>
        <asp:CheckBox ID="checkRememberme" runat="server" />
        <br />
        <asp:Label ID="errorLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
        <br />
        <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click" />
    </div>
</asp:Content>
