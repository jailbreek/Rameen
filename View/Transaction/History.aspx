<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="Raameenn.View.Transaction.History" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="histGV" runat="server" AutoGenerateSelectButton="true" OnSelectedIndexChanged="histGV_SelectedIndexChanged"></asp:GridView>
        </div>
    </form>
</body>
</html>
