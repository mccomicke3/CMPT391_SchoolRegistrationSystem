<%@ Page Language="C#" MasterPageFile="~/Student1.Master" AutoEventWireup="true" CodeBehind="SelectMajMin.aspx.cs" Inherits="schoolreg.Student.Screens.SelectMajMin" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<asp:Label runat="server" ID="Label_title" CssClass="title-header">Course History</asp:Label>
    <hr />
       <link href="../Style/StyleSheet1.css" rel="stylesheet" />
    <div class="panel-body">
        <div class="col-lg-12">
            <div class="row">
                <div class="row">
                    <div class="col-md-3">
			            <asp:Label runat="server" CssClass="signup-input-header">Select Major</asp:Label>
                        <asp:DropDownList ID="dept" runat="server" CssClass="signupDropDown" style="margin-top: 10px">
                            <asp:ListItem Enabled="true" Text="Major" Value="-1"></asp:ListItem>
                            <asp:ListItem Text="TestMajor" Value="1"></asp:ListItem>
                            <asp:ListItem Text="MajorTest" Value="12"></asp:ListItem>
                            <asp:ListItem Text="OneMore" Value="12"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="row" style="margin-top: 20px">
                    <div class="col-md-3">
			            <asp:Label runat="server" CssClass="signup-input-header">Select Minor</asp:Label>
                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="signupDropDown" style="margin-top: 10px">
                            <asp:ListItem Enabled="true" Text="Minor" Value="-1"></asp:ListItem>
                            <asp:ListItem Text="TestMinor" Value="1"></asp:ListItem>
                            <asp:ListItem Text="MinorTest" Value="12"></asp:ListItem>
                            <asp:ListItem Text="OneMore" Value="12"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="row" style="margin-top: 20px">
                    <div class="col-md-8">
			            <asp:Button ID="Button1" runat="server" Text="Submit" Height="35px" CssClass="mybutton" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
