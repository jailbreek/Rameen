<%@ Page Language="C#" MasterPageFile="/View/Navbar.Master" AutoEventWireup="true" CodeBehind="EditRamen1.aspx.cs" Inherits="Raameenn.View.Ramen.EditRamen1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
    <div>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Edit Ramen" Font-Bold="true" Font-Underline="true" Font-Size="Large"></asp:Label>
            <asp:GridView ID="editGV1" runat="server"></asp:GridView>
            <asp:Label ID="Label2" runat="server" Text="Ramen Name"></asp:Label>
            <br />
            <asp:TextBox ID="editName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Meat"></asp:Label>
            <br />
            <asp:DropDownList ID="editDD" runat="server">
                <asp:ListItem Value="1">Beef</asp:ListItem>
                <asp:ListItem Value="2">Chicken</asp:ListItem>
                <asp:ListItem Value="3">Pork</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Broth"></asp:Label>
            <br />
            <asp:TextBox ID="editBroth" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Price"></asp:Label>
            <br />
            <asp:TextBox ID="editPrice" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="edit_btn1" runat="server" Text="Edit Ramen" OnClick="edit_btn1_Click" />
            <asp:Button ID="editBack_btn1" runat="server" Text="Back" OnClick="editBack_btn1_Click" />
            <br />
            <asp:Label ID="edit_status" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
