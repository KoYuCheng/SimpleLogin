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
            <h2>會員登入</h2>
        帳號:<asp:TextBox ID="tetacc" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tetacc" ErrorMessage="no 空" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        密碼:<asp:TextBox ID="tetpass" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tetpass" ErrorMessage="no 空" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="確定" />
            &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnclean" runat="server" Text="清除" OnClick="btnclean_Click"  />
       </div>
        </form>
</body>
</html>
