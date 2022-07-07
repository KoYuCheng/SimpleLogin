<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
    
        會員資料<br />
        <br />
        姓名:<asp:TextBox ID="tname" runat="server" Width="205px"></asp:TextBox>
        <br />
        電話:<asp:TextBox ID="ttel" runat="server" Width="207px"></asp:TextBox>
        <br />
        地址:<asp:TextBox ID="tadd" runat="server" Width="210px" ></asp:TextBox>
        <br />
        Email:<asp:TextBox ID="temail" runat="server" Width="212px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnchan" runat="server" Text="修改資料" OnClick="btnchan_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnlogout" runat="server" Text="登出" OnClick="btnlogout_Click" Width="66px" />
    </div>
    </form>
</body>
</html>
