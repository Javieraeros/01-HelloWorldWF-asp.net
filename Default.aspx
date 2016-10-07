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
        <label>Nombre: </label>
        <asp:TextBox Id="Texto" Text="" runat="server"/>
        <asp:Button ID="Enviar" runat="server" OnClick="Enviar_Click" Text="Enviar"/>
        </div>
        <p>
        <asp:Label ID="lblresultado" runat="server" Text="" />
        </p>
    </form>
</body>
</html>
