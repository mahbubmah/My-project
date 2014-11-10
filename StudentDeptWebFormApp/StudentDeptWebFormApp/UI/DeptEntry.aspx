<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeptEntry.aspx.cs" Inherits="StudentDeptWebFormApp.UI.DeptEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Code"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Title"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnDeptSave" runat="server" OnClick="btnDeptSave_Click" Text="Save" />
        <br />
        <br />
        <asp:Label ID="msgDeptSave" runat="server"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
