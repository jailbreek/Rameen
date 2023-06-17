<%@ Page Language="C#" MasterPageFile="/View/Navbar.Master" AutoEventWireup="true" CodeBehind="AddRamen.aspx.cs" Inherits="Raameenn.View.Ramen.AddRamen" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
    <div>
        <div>
            <asp:Label ID="Label6" runat="server" Text="Meat List" Font-Bold="true" Font-Underline="true" Font-Size="Large"></asp:Label>
            <br />
            <asp:GridView ID="meatListGV" runat="server"></asp:GridView>
            <asp:Label ID="Label1" runat="server" Text="Insert Ramen" Font-Size="Large" Font-Bold="true" Font-Underline="true"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Ramen Name"></asp:Label>
            <br />
            <asp:TextBox ID="RamenName_txt" runat="server"></asp:TextBox>
            <br />
             <asp:Label ID="Label3" runat="server" Text="Meat ID"></asp:Label>
            <br />
            <asp:DropDownList ID="addMeatDD" runat="server" AutoPostBack="True">
                <asp:ListItem Value="1">Beef</asp:ListItem>
                <asp:ListItem Value="2">Chicken</asp:ListItem>
                <asp:ListItem Value="3">Pork</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Broth"></asp:Label>
            <br />
            <asp:TextBox ID="broth_txt" runat="server"></asp:TextBox>
            <br />
             <asp:Label ID="Label5" runat="server" Text="Price"></asp:Label>
            <br />
            <asp:TextBox ID="price_txt" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="addBack_btn" runat="server" Text="Back" OnClick="addBack_btn_Click" />
            <asp:Button ID="btn_add1" runat="server" Text="Insert Ramen" OnClick="btn_add1_Click" />
            <br />
            <asp:Label ID="addStatus_txt" runat="server" Text=""></asp:Label>
        </div>
    </div>
</asp:Content>
