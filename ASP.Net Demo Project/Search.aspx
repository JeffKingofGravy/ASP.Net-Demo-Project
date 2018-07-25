<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="AireSpringProject.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Styles.css" />
    <title></title>
</head>
<body>
    <div class="main" id="main">
        <h2 class="blockTitle">Search</h2>
        <form id="form1" runat="server">
            <div>
                <br />
                <span class="searchSpan">
                    <asp:TextBox ID="searchTxt" runat="server" placeholder="Search Term" style="margin-left: 0px"></asp:TextBox>
                </span>
                <span class="searchSpan">
                    <asp:RadioButtonList ID="radioBtn" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                        <asp:ListItem Selected="True">Last Name</asp:ListItem>
                        <asp:ListItem>Phone Number</asp:ListItem>
                    </asp:RadioButtonList>
                </span>
                <br />
                <br />
                <asp:Button ID="searchBtn" runat="server" OnClick="searchBtn_Click" Text="Search" />
                <br />
                <br />
                <asp:GridView ID="EmployeesGV" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" HorizontalAlign="Center">
                    <Columns>
                        <asp:BoundField DataField="EmployeeID" HeaderText="Employee ID" />
                        <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                        <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                        <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" />
                        <asp:BoundField DataField="Zip" HeaderText="Zip Code" />
                        <asp:BoundField DataField="HireDate" DataFormatString="{0:d}" HeaderText="Hire Date" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />
                </asp:GridView>
            </div>
        </form>
    </div>
</body>
</html>
