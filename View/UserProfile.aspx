<%@ Page Title="Profile" Language="C#" MasterPageFile="/View/Navbar.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="Raameenn.View.UserProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
    <div>
        <div>
            <h1 id="ProfileTitleWithName">
                <asp:Label ID="lblUsername" runat="server" Text=""></asp:Label>
            </h1>
            <h2>
                <asp:Label ID="lblRole" runat="server" Text=""></asp:Label>
            </h2>
        </div>
        <div>
            <div>
                
                </div>
            <br />
            <div>
                <asp:Label ID="IdlblUsername" runat="server" Text="Username: " Width="80px"></asp:Label>
                <asp:TextBox ID="txtUsername" runat="server" Enabled="false" AutoCompleteType="Disabled" OnTextChanged="txtUsername_Change" AutoPostBack="true"></asp:TextBox>
            </div>
            <div>
                <asp:Label ID="lblEmail" runat="server" Text="Email:" Width="80px"></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" AutoCompleteType="Disabled" Enabled="false" OnTextChanged="txtEmail_Change" AutoPostBack="true"></asp:TextBox>
            </div>
            <div>
                <label for="lblGender">Gender:</label>
                <asp:DropDownList runat="server" ID="ddlGender">
                    <asp:ListItem Text="Select" Value="Select"></asp:ListItem>
                    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                </asp:DropDownList>
            </div>
                <asp:Label ID="lblInfo" runat="server" Text="   "></asp:Label><br />
            <br />                    
            <div>
                <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" Width="80px"/>
                
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" Enabled="false" Visible="false" Width="80px"/>
            </div>
        </div>
    </div>
</asp:Content>
