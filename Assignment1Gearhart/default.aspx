<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Assignment1Gearhart.WebForm1" %>
<!-- 
    Zack Gearhart
     
    -->
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Millimeter and Inch Calculator</title>
    <link href="StyleSheet1.css" rel="stylesheet" />
</head>
<body>
        <div id="wrapper">
    <form id="form1" runat="server">
        <header>
            <h1>Convert Inches to Millimeters or Millimeters to Inches</h1>
        </header>
        <nav>
            <a href="default.aspx">Home</a>
        </nav>
        <main>
            <center>
            <asp:Label ID="Label2" runat="server" Text="Enter Inch or Millimenter"></asp:Label>
            <br /><br />
            <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnToInch" runat="server" Text="Millimeter to Inch" OnClick="btnToInch_Click" />
            <br /><br />
            <asp:Button ID="btnToMillimeter" runat="server" Text="Inch to Millimeter" OnClick="btnToMillimeter_Click" />
            <br /> <br />
            <asp:Label ID="lblOutput" runat="server" Text=""></asp:Label>
            </center>
        </main>
        <footer>
            <span>Zack Gearhart</span>
        </footer>
    </form>
    </div>
</body>
</html>
