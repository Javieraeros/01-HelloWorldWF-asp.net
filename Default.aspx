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
        <p>
            <asp:Label ID="label1" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox Id="Nombre" Text="" runat="server"/>
            <asp:Label ID="label1error" runat="server" Text=""
                style="color:red;"></asp:Label>
        </p>
        <p>
            <asp:Label ID="label2" runat="server" Text="Apellidos"></asp:Label>
            <asp:TextBox Id="Apellidos"  Text="" runat="server"/>
            <asp:Label ID="label2error" runat="server" Text=""
                style="color:red;"></asp:Label>
        </p>
        <asp:Button ID="Enviar" runat="server" OnClick="Enviar_Click" Text="Enviar"/>
        </div>
        <p>
        <asp:Label ID="lblresultado" runat="server" Text="" />
        </p>
    </form>
</body>
</html>
