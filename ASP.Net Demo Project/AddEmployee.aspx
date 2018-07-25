<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="ASP.Net_Demo_Project.AddEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Styles.css" />
    <script type="text/javascript">
        function disableID()
        {
            document.getElementById("IDTxt").disabled = document.getElementById("IDGenChk").checked;
        }
    </script>
    <title></title>
</head>
<body>
    <div class="main">
        <h2 class="blockTitle">Add Employee</h2>
        <form id="form1" runat="server">
            <div>
                <asp:CheckBox ID="IDGenChk" runat="server" OnClick="disableID()" Text="Auto-generate ID number" />
                <br />
                <asp:Label ID="IDLbl" runat="server" Text="ID Number"></asp:Label>
                <br />
                <asp:TextBox ID="IDTxt" runat="server" MaxLength="7"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="FirstLbl" runat="server" Text="First Name"></asp:Label>
                <br />
                <asp:TextBox ID="FirstTxt" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="LastLbl" runat="server" Text="Last Name"></asp:Label>
                <br />
                <asp:TextBox ID="LastTxt" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="PhoneLbl" runat="server" Text="Phone Number"></asp:Label>
                <br />
                <asp:TextBox ID="PhoneTxt" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="ZipLbl" runat="server" Text="Zip Code"></asp:Label>
                <br />
                <asp:TextBox ID="ZipTxt" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="HireLbl" runat="server" Text="Hire Date"></asp:Label>
                <br />
                <asp:TextBox ID="HireTxt" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="SubmitBtn" runat="server" OnClick="SubmitBtn_Click" Text="Submit" />
                <br />
                <hr />
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
                <br />
            </div>
        </form>
    </div>
</body>
</html>
