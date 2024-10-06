<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AdminHomePage.aspx.cs" Inherits="RAIso_BARUUU.Views.Admin.AdminHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Home Page</h2>
<div>
    <h1>Stationery List</h1>
    <asp:GridView ID="StationeryGV" runat="server" AutoGenerateColumns="False" OnRowDeleting="StationeryGV_RowDeleting" OnRowEditing="StationeryGV_RowEditing">
        <Columns>
            <asp:BoundField DataField="StationeryID" HeaderText="No" SortExpression="StationeryID" />
            <asp:BoundField DataField="StationeryName" HeaderText="Name" SortExpression="StationeryName"/>
            <asp:CommandField ButtonType="Button" HeaderText="Actions" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
        </Columns>

    </asp:GridView>
    <br />
    <asp:Button ID="insertBtn" runat="server" Text="Insert New" OnClick="insertBtn_Click" />
</div>
    
</asp:Content>
