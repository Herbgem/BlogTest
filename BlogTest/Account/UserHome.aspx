<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UserHome.aspx.cs" Inherits="BlogTest.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="LeftSidebar" class="LeftSidebar">
        <asp:TextBox ID="txtSearch" runat="server"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" CssClass="CenterControl btnSearch" Text="Search" OnClick="btnSearch_Click" />
        <asp:Timer ID="Timer" runat="server" Interval="1000" OnTick="Timer_Tick"/>
        <asp:UpdatePanel ID="pnlUpdateTime" runat="server">
            <ContentTemplate>
                <asp:Label ID="lblTime" CssClass="CenterControl lblTime" runat="server" />
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer" EventName="Tick" />
            </Triggers>
        </asp:UpdatePanel>
    </div>
    <div class="CenterControl">
        <asp:DataList ID="BlogsGrid" runat="server" RepeatColumns="1" RepeatDirection="Vertical" DataKeyField="Id"
            OnItemCommand="BlogsGrid_ItemCommand1">
                    <HeaderTemplate>
                        <hr />
                        <hr />
                        <h2>Blogs Info</h2>
                        <hr />
                        <hr />
                    </HeaderTemplate>

                        <ItemTemplate>
                            <div class="blogPanel">
                                <div>Created Time-<asp:Label ID="lblBlogTitle" runat="server" Text='<%#Eval("PostCreated") %>' />
                                    &nbsp;
                                    &nbsp;
                                    <asp:LinkButton ID="lblblogDescription" runat="server" Text='<%#Eval("PostTitle") %>' CommandName="select" />
                                </div>
                                    

                            </div>
                            
                        </ItemTemplate>

                    <FooterTemplate>
                        <hr />
                        <hr />
                        <h2>Blogs Info</h2>
                        <hr />
                        <hr />
                        
                    </FooterTemplate>
                </asp:DataList>
                <asp:Button ID="btnAddNew" runat="server" Text="Add New" OnClick="btnAddNew_Click"/>
        

    </div>
</asp:Content>
