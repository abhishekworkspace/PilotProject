<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Fibonacci.aspx.cs" Inherits="Fibonacci" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      Enter a symbol : <asp:TextBox ID="txtmoreData"  runat="server"></asp:TextBox>
    <asp:Button ID="btnSubmit1" runat="server" Text="Submit" OnClick="btnSubmit_Click" /> 
    </div>
    </form>
</body>
</html>
