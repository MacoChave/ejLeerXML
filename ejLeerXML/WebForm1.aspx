<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ejLeerXML.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Leer archivo XML</h1>
            <asp:Button Class="Boton" ID="Button1" runat="server" Text="Leer" OnClick="Button1_Click" />
            <asp:TextBox ID="txtlectura" runat="server" TextMode="MultiLine"></asp:TextBox>
        </div>
    </form>
    
</body>
</html>
