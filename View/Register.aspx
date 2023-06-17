<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Raameenn.View.Register" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
</head>
<body>
    <form runat="server">
        <h1>Register</h1>
        <div>
            <asp:Label ID="lblUsername" runat="server" Text="Username" ></asp:Label>
            <asp:TextBox runat="server" ID="txtUsername"></asp:TextBox>
            <asp:Label runat="server" ID="errorUsr" ForeColor="Red" Visible="false"></asp:Label>
        </div>

        <div>
            <asp:Label ID="labelEmail" runat="server" Text="Email" ></asp:Label>
            <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>
            <asp:Label runat="server" ID="errorEmail" ForeColor="Red" Visible="false"></asp:Label>
        </div>

        <div>
            <label for="lblGender">Gender:</label>
            <asp:DropDownList runat="server" ID="ddlGender">
                <asp:ListItem Text="Select" Value="Select"></asp:ListItem>
                <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
            </asp:DropDownList>
            <asp:Label runat="server" ID="errorGender" ForeColor="Red" Visible="false"></asp:Label>
        </div>

        <div>
            <asp:Label ID="lblRole" runat="server" Text="Register as" ></asp:Label>
            <asp:DropDownList runat="server" ID="ddlRole">
                <asp:ListItem Text="Select" Value="Select"></asp:ListItem>
                <asp:ListItem Text="Buyer" Value="2"></asp:ListItem>
                <asp:ListItem Text="Seller" Value="3"></asp:ListItem>
            </asp:DropDownList>
            <asp:Label runat="server" ID="errorRole" ForeColor="Red" Visible="false"></asp:Label>
        </div>

        <div>
            <asp:Label ID="lblPass" runat="server" Text="Password" ></asp:Label>
            <asp:TextBox runat="server" ID="txtPass" TextMode="Password"></asp:TextBox>
            <asp:Label runat="server" ID="errorPass" ForeColor="Red" Visible="false"></asp:Label>
        </div>

        <div>
            <asp:Label ID="lblConpass" runat="server" Text="Confirm Password" ></asp:Label>
            <asp:TextBox runat="server" ID="txtConPass" TextMode="Password"></asp:TextBox>
            <asp:Label runat="server" ID="errorConpass" ForeColor="Red" Visible="false"></asp:Label>
        </div>

        <div>
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click"/>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>