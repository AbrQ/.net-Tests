<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style = "font-family: Arial">
                <tr>
                    <td>Username:</td>
                    <td><asp:TextBox ID="txtUsername" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td><asp:TextBox ID="txtPassword" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan = "2">
                        <asp:Button ID="Button1" runat="server" Text="Get Response" OnClick="Button1_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan = "2">
                        <asp:Label ID="lblHelloWorldResponse" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan = "2">
                        <asp:Label ID="lblToken" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
