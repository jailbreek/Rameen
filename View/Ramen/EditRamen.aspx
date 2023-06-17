<%@ Page Language="C#" MasterPageFile="/View/Navbar.Master" AutoEventWireup="true" CodeBehind="EditRamen.aspx.cs" Inherits="Raameenn.View.Ramen.EditRamen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
    <div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Update Ramen" Font-Bold="true" Font-Underline="true" Font-Size="Large"></asp:Label>
            <asp:GridView ID="editGV" runat="server" OnRowEditing="GridView1_RowEditing" AutoGenerateEditButton="true"></asp:GridView>
            <br />
            <asp:Button ID="editBackButton" runat="server" Text="Back" OnClick="editBackButton_Click" />

        </div>
    </div>
</asp:Content>
