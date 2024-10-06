<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Guest/Guest.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="RAIso_BARUUU.Views.Guest.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Home Page</h2>
    <div>
        <h1>Stationery List</h1>
        <asp:GridView ID="StationeryGV" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="StationeryID" HeaderText="No" SortExpression="StationeryID" />
                <asp:BoundField DataField="StationeryName" HeaderText="Name" SortExpression="StationeryName"/>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>