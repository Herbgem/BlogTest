<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BlogTest.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="CenterControl" style="top:50px;">
        <label>User Name:</label>
        &nbsp;
        &nbsp;
        <asp:TextBox ID="txtUserName" runat="server" placeholder="Enter your Username..." />
        <br /><br />
        <div class="CenterControl">
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Log in"/>
        </div>
        <div class="CenterControl">
            <label id="lblWarning" runat="server" />
        </div>
    </div>
</asp:Content>
