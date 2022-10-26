<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="addbook.aspx.cs" Inherits="Assignment3Gearhart.books.addbook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h2>Register a book</h2>
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Title:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtTitle" runat="server" Width="319px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTitle" ErrorMessage="You must enter a title"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Author:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtAuthor" runat="server" Width="320px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAuthor" Display="Dynamic" ErrorMessage="Must Enter an Author"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Price (Don't include $)</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPrice" Display="Dynamic" ErrorMessage="Must Include Price"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Book Type</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtBookType" runat="server" Width="314px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtBookType" ErrorMessage="Must Include Book Type"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td class="auto-style2">ISBN</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtISBN" runat="server" Width="314px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtISBN" ErrorMessage="Must Include ISBN"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtISBN" ErrorMessage="Must be at least 1 no more than 100000" MaximumValue="100000" MinimumValue="1" Display="Dynamic" Type="Integer"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" Width="270px" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
</asp:Content>
