<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BlogHeader.ascx.cs" Inherits="BlogTest.BlogUserControl.BlogHeader" %>
<script src="/Scripts/jquery-1.9.1.js"></script>
<script src="/Scripts/bootstrap.js"></script>
<link href="/Content/bootstrap.css" rel="stylesheet" />
<link href="/Content/bootstrap-theme.css" rel="stylesheet" />


<div style="min-width:1000px; position:relative">
    <img src="/cropped-blog-header.jpg" alt="Image not found" class="headerImg"/>
    <nav class="nav navbar-default">
        <div class="container-fluid">
            <ul class="nav navbar-nav navbar-right">
                <li id="liLogin" runat="server"><asp:HyperLink runat="server" Text="Login" /></li>
                <li id="liLogout" runat="server"><asp:HyperLink runat="server" Text="Logout" /></li>
            </ul>
        </div>
    </nav>
</div>