<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdatePanels.aspx.cs" Inherits="UpdatePanels" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <div>
    <p>On load: <asp:Literal runat="server" ID="onLoadLiteral"></asp:Literal></p>
    
    <p>Updated: <asp:Literal runat="server" ID="outsideUpdatePanelLiteral"></asp:Literal></p>
    <asp:Button ID="outsideUpdatePanelButton" runat="server" Text="Update" onclick="outsideUpdatePanelButton_Click" />

    <asp:UpdatePanel runat="server">
    <ContentTemplate>
        <p><asp:Literal runat="server" ID="inUpdatePanelLiteral"></asp:Literal></p>
        <asp:Button ID="updateButton" runat="server" Text="Update" 
            onclick="updateButton_Click" />
    </ContentTemplate>
    </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
