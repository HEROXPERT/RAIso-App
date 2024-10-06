<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="CustomerHomePage.aspx.cs" Inherits="RAIso_BARUUU.Views.Customer.CustomerHomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><%= ((RAIso_BARUUU.Model.MsUser)Session["user"]).UserID %></h1>
    <h2>Home Page</h2>
    <div>
        <h1>Stationery List</h1>
        <asp:GridView ID="StationeryGV" runat="server" AutoGenerateColumns="False" OnRowCommand="StationeryGV_RowCommand">
            <Columns>
                <asp:BoundField DataField="StationeryID" HeaderText="No" SortExpression="StationeryID" />
                <asp:TemplateField HeaderText="Stationery Name">
                    <ItemTemplate>
                        <asp:LinkButton ID="detailBtn" runat="server" CommandName="Select" CommandArgument='<%# Eval("StationeryID") %>'>
                            <%# Eval("StationeryName") %>
                        </asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>