<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddNewPage.aspx.cs" Inherits="BlogTest.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="FormAddNew" runat="server" class="CenterControl" style="position:relative; top:50px;">
            <div><label>Blog Title:</label>&nbsp;&nbsp;<asp:TextBox ID="txbTitle" runat="server" /></div>
            <br />
            <div><label>Blog Description:</label>&nbsp;&nbsp;<asp:TextBox ID="txbDescription" runat="server" /></div>
            <br />
            <div><label>Blog Content:</label><br /><textarea id="txbContent" rows="5" cols="60" runat="server" /></div>
            <div class="CenterControl"><asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="btnSubmit_Click" /></div>
        </div>
</asp:Content>
