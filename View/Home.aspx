<%@ Page Title="Home" Language="C#" MasterPageFile="/View/Navbar.master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Raameenn.View.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
    <div>
        <h3>Hiii</h3>
    <div>
        </div>
            <asp:GridView ID="GDcustoms" runat="server" AutoGenerateColumns="false" Width="490px">
                <Columns>
                    <asp:BoundField DataField="Username" HeaderText="Username" />
                    <asp:BoundField DataField="Role.Name" HeaderText="Role" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" />
                </Columns>
        </asp:GridView>
    </div>
</asp:Content>
    