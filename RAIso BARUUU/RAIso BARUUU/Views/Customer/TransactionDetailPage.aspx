<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="TransactionDetailPage.aspx.cs" Inherits="RAIso_BARUUU.Views.Customer.TransactionDetailPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Transaction Detail</h2>
    <asp:GridView ID="DetailGV" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="MsStationery.StationeryName" HeaderText="Stationery Name" SortExpression="MsStationery.StationeryName" />
            <asp:BoundField DataField="MsStationery.StationeryPrice" HeaderText="Stationery Price" SortExpression="MsStationery.StationeryPrice" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
        </Columns>
    </asp:GridView>

    <h6><%=Request.QueryString["id"] %></h6>
</asp:Content>
