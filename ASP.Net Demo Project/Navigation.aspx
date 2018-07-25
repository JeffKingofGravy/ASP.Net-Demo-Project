<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Navigation.aspx.cs" Inherits="ASP.Net_Demo_Project.Navigation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Styles.css" />
    <title></title>
</head>
<body>
    <div class="main" id="main">
        <h2 class="blockTitle">Navigation</h2>
        <form id="form1" runat="server">
            <div>
                <br />
                <asp:Button ID="addEmpBtn" runat="server" Text="Add Employee" OnClick="addEmpBtn_Click" Width="125px" />
                <br />
                <br />
                <asp:Button ID="searchBtn" runat="server" Text="Search" OnClick="searchBtn_Click" Width="125px" />
                <br />
                <br />
            </div>
        </form>
    </div>
</body>
</html>
