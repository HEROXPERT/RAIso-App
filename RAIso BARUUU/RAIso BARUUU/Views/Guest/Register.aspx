<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Guest/Guest.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="RAIso_BARUUU.Views.Guest.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Register Page</h2>
    <div>
        <asp:Label ID="usernameLbl" runat="server" Text="Username : "></asp:Label>
        <asp:TextBox ID="usernameTb" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="passwordLbl" runat="server" Text="Password : "></asp:Label>
        <asp:TextBox ID="passwordTb" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Label ID="dobLbl" runat="server" Text="Day of Birth : "></asp:Label>
        <asp:TextBox ID="dobTb" runat="server" TextMode="Date"></asp:TextBox>
        <br />
        <asp:Label ID="gendelLbl" runat="server" Text="Gender : "></asp:Label>
        <asp:DropDownList ID="genderDDL" runat="server">
            <asp:ListItem Text="Select Gender" Value="" />
            <asp:ListItem Text="Male" Value="Male" />
            <asp:ListItem Text="Female" Value="Female" />
            <asp:ListItem Text="Others" Value="Others" />
        </asp:DropDownList>
        <br />
        <asp:Label ID="addressLbl" runat="server" Text="Address : "></asp:Label>
        <asp:TextBox ID="addressTb" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="phoneLbl" runat="server" Text="Phone Number : "></asp:Label>
        <asp:TextBox ID="phoneTb" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="errorLbl" runat="server" Text="" ForeColor="Red" ></asp:Label>
        <br />
        <asp:Button ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click" />
    </div>
</asp:Content>
