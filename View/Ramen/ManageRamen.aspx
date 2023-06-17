<%@ Page Language="C#" MasterPageFile="~/View/Navbar.Master"  CodeBehind="ManageRamen.aspx.cs" Inherits="Raameenn.View.Ramen.ManageRamen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
    <div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Manage Ramen" Font-Size="Large" Font-Bold ="true"></asp:Label>
            <asp:GridView ID="RamenGV" runat="server"></asp:GridView>
            <asp:Button ID="btn_add" runat="server" Text="Add Ramen" OnClick="btn_add_Click" />
            <br />
            <asp:Button ID="btn_edit" runat="server" Text="Edit Ramen" OnClick="btn_edit_Click"  />
        </div>
    </div>
</asp:Content>
