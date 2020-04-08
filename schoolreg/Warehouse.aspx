<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Warehouse.aspx.cs" Inherits="schoolreg.Warehouse" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" ID="Label_title" CssClass="title-header">Courses Overview</asp:Label>
    <hr />
       <link href="/Instructor/Style/StyleSheet1.css" rel="stylesheet" />
    <div class="panel-body">
        <div class="row">
            <div class="col-lg-12">
                        <div class="col-md-3">
			                <asp:Label runat="server" CssClass="signup-input-header">Course</asp:Label>
                            <asp:DropDownList ID="courseDrop" runat="server" CssClass="signupDropDown" style="margin-top: 10px">
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-3">
			                <asp:Label runat="server" CssClass="signup-input-header">Department</asp:Label>
                            <asp:DropDownList ID="deptDrop" runat="server" CssClass="signupDropDown" style="margin-top: 10px">
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-3">
			                <asp:Label runat="server" CssClass="signup-input-header">Faculty</asp:Label>
                            <asp:DropDownList ID="facDrop" runat="server" CssClass="signupDropDown" style="margin-top: 10px">
                            </asp:DropDownList>
                        </div>
                </div>
            </div>
            <div class="row">
                <div class="col-lg-12">
                        <div class="col-md-3">
			                <asp:Label runat="server" CssClass="signup-input-header">Year</asp:Label>
                            <div class="row">
                                <asp:DropDownList ID="yearDrop" runat="server" CssClass="signupDropDown" style="margin-top: 10px; margin-left: 14px">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="col-md-3">
			                <asp:Label runat="server" CssClass="signup-input-header">Term</asp:Label>
                            <asp:DropDownList ID="termDrop" runat="server" CssClass="signupDropDown" style="margin-top: 10px">
                                <asp:ListItem Enabled="true" Text="Term" Value="-1"></asp:ListItem>
                                <asp:ListItem Text="Winter" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Fall" Value="12"></asp:ListItem>
                                <asp:ListItem Text="Spring" Value="12"></asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-3">
			                <asp:Label runat="server" CssClass="signup-input-header">Instructor</asp:Label>
                            <asp:DropDownList ID="instrDrop" runat="server" CssClass="signupDropDown" style="margin-top: 10px">
                            </asp:DropDownList>
                        </div>
                </div>
            </div>
            <div class="row">
                            <div class="col-md-3">
                                <div style="margin-top:20px">
                                    <asp:Button ID="FirstButton" runat="server" Text="Submit" Height="35px" CssClass="mybutton" OnClick="GetCourses"/>
                                </div>
                            </div>
                        </div>
            <div class="row">
                <div class="col-lg-12">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
                </div>
            </div>
        </div>
</asp:Content>
