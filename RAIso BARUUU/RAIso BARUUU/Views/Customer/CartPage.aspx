<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="RAIso_BARUUU.Views.Customer.CartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        Cart Page
    </h2>
    <div>
        <asp:GridView ID="CartGV" runat="server" AutoGenerateColumns="False" OnRowDeleting="CartGV_RowDeleting" OnRowEditing="CartGV_RowEditing" >
            <Columns>               
                <asp:BoundField DataField="MsUser.UserName" HeaderText="Username" SortExpression="MsUser.UserName" />
                <asp:BoundField DataField="MsStationery.StationeryName" HeaderText="Stationery Name" SortExpression="MsStationery.StationeryName" />
                <asp:BoundField DataField="MsStationery.StationeryPrice" HeaderText="Stationery Price" SortExpression="MsStationery.StationeryPrice" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />                
                <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            </Columns>

        </asp:GridView>
        <br />
        <asp:Button ID="checkoutBtn" runat="server" Text="Check Out" OnClick="checkoutBtn_Click" />
    </div>
</asp:Content>
