<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DropDown.aspx.cs" Inherits="DropDown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddlRole" runat="server" class="form-control r-0 light s-12" OnSelectedIndexChanged="ddlRole_SelectedIndexChanged" AutoPostBack="true">
            
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
