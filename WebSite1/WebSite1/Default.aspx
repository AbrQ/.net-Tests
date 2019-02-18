<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
    
    <style type = "text/css">
        html{
            background-color: aqua;
        }
        body{
            background-color: azure;
        }
    </style>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <p>
        <asp:Button ID="Button1" runat="server" Text="Llamar" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
