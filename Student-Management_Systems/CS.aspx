<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CS.aspx.cs" Inherits="Student_Management_Systems.CS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:Button Text="Upload to FTP" runat="server" OnClick="FTPUpload" />
    <hr />
    <asp:Label ID="lblMessage" runat="server" />
    </form>
</body>
</html>