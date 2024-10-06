<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="TransactionPage.aspx.cs" Inherits="RAIso_BARUUU.Views.Customer.TransactionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Transactions</h2>
    <asp:GridView ID="TransactionGV" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanging="TransactionGV_SelectedIndexChanging">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="Transaction Id" SortExpression="TransactionID" />
            <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" SortExpression="TransactionDate" />
            <asp:BoundField DataField="MsUser.UserName" HeaderText="Customer Name" SortExpression="MsUser.UserName" />
            <asp:CommandField ButtonType="Button" HeaderText="TransactionDetail" ShowHeader="True" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
