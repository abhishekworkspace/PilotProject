<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Switch.aspx.cs" Inherits="Switch" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
 <!--    Enter Data : <asp:TextBox ID="txtData" runat="server"></asp:TextBox>
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" onclick="btnSubmit_Click" /> -->
   
    Enter new Data : <asp:TextBox ID="txtmoreData" runat="server"></asp:TextBox>
    <asp:Button ID="btnSubmit1" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    </div>
    </form>
</body>
</html>
