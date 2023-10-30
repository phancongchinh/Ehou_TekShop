<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Categories.aspx.cs" Inherits="Ehou_TekShop.Categories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div>
        <h2>Categories</h2>
    </div>
    
    <asp:GridView 
        runat="server" 
        ID="categoriesGrid" 
        CssClass="table table-striped" 
        BorderColor="White"
        AllowPaging="True" AllowSorting="True"
        ItemType="Ehou_TekShop.Models.Category" 
        DataKeyNames="Id"
        SelectMethod="GetCategories"
        AutoGenerateColumns="false"
    >
        <Columns>
            <asp:DynamicField DataField="Id" />
            <asp:DynamicField DataField="Name" />
        </Columns>

    </asp:GridView>
    
</asp:Content>
