<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BlogContent.aspx.cs" Inherits="BlogTest.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="CenterControl">
        <asp:FormView ID="BlogContent" runat="server" OnItemUpdating="BlogContent_ItemUpdating" OnItemDeleting="BlogContent_ItemDeleting" OnModeChanging="BlogContent_ModeChanging">
                    <HeaderTemplate>
                        <hr />
                        <hr />
                        <h2>Blogs Info</h2>
                        <hr />
                        <hr />
                    </HeaderTemplate>

                        <ItemTemplate>
                            <div class="blogPanel">
                                <div class="blogHeader">BlogTitle-<asp:Label ID="lblBlogTitle" runat="server" Text='<%#Eval("PostTitle") %>' /></div>
                                <div class="blogContent">
                                    <asp:Label ID="lblblogDescription" runat="server" Text='<%#Eval("PostDescription") %>' />
                                </div>
                                <div class="blogFooter"> 
                                    <span style="float:left;">
                                        <h4>Created By:<asp:Label ID="lblblogCreatedBy" runat="server" Text='<%#Eval("PostAuthor") %>' /></h4>

                                    </span>
                                    &nbsp;&nbsp;
                                    <span style="float:right;">
                                        <h4>Created On: <asp:Label ID="lblCreatedOn" runat="server" Text='<%#Eval("PostCreated") %>' /></h4>
                                    </span>
                                </div>
                            </div>
                            <div>
                                <asp:Button ID="btnEdit" CommandName="edit" runat="server" Text="Edit" />
                                <asp:Button ID="btnDelete" CommandName="Delete" runat="server" Text="Delete" />
                                <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" />
                            </div>
                            
                        </ItemTemplate>

            <EditItemTemplate>
                <div>
                    <label>Post Title</label> &nbsp; &nbsp; <asp:TextBox ID="editPostTitle" runat="server" placeholder='<%#Eval("PostTitle") %>' />
                </div>
                <div>
                    <label>Post Description</label> &nbsp; &nbsp; <asp:TextBox ID="editPostDescription" runat="server" placeholder='<%#Eval("PostDescription") %>' />
                </div>
                <div>
                    <label>Post Content</label> &nbsp; &nbsp; <asp:TextBox ID="editPostContent" runat="server" placeholder='<%#Eval("PostContent") %>' />
                </div>
                <div>
                    <asp:Button ID="btnSummit" runat="server" Text="Summit" OnClick="btnSummit_Click"/>
                    <asp:Button ID="btnCancel" runat="server" Text="Cancel" CommandName="Cancel"/>
                </div>
            </EditItemTemplate>

                    <FooterTemplate>
                        <hr />
                        <hr />
                        <h2>Blogs Info</h2>
                        <hr />
                        <hr />
                    </FooterTemplate>
                </asp:FormView>
    </div>
</asp:Content>
