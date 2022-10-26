<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="calculator.aspx.cs" Inherits="Assignment2Gearhartr.calculator.calculator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Enter the Radius of the circle"></asp:Label>
    <br /><br />
    <asp:TextBox ID="txtRadius" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnCalculate" runat="server" Text="Calculate Area & Circumferance" OnClick="btnCalculate_Click" />
    <br /><br />
    <asp:Label ID="Label2" runat="server" Text="Circumferance: "></asp:Label>
    <asp:Label ID="lblCirc" runat="server" Text=""></asp:Label>
    <br /><br />
    <asp:Label ID="Label3" runat="server" Text="Area: "></asp:Label>
    <asp:Label ID="lblArea" runat="server" Text=""></asp:Label>
</asp:Content>
