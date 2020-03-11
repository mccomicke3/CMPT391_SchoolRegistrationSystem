<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Departments.aspx.cs" Inherits="schoolreg.Instructor.Screens.Departments" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" ID="Label_title" CssClass="title-header">Departments</asp:Label>
    <hr />
       <link href="../Style/StyleSheet1.css" rel="stylesheet" />
    <div class="panel-body">
        <div class="col-lg-12">
            <div class="row">
                <div class="col-md-3">
			        <asp:Label runat="server" CssClass="signup-input-header">Select Department</asp:Label>
                    <asp:DropDownList ID="dept" runat="server" CssClass="signupDropDown" style="margin-top: 10px">
                        <asp:ListItem Enabled="true" Text="Department" Value="-1"></asp:ListItem>
                        <asp:ListItem Text="TestDep" Value="1"></asp:ListItem>
                        <asp:ListItem Text="DepTest" Value="12"></asp:ListItem>
                        <asp:ListItem Text="OneMore" Value="12"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-md-5">
			        <asp:Label runat="server" CssClass="signup-input-header">Faculty Instructors</asp:Label>
                    <div style="height: 150px; overflow: scroll; width: 420px">
                        <asp:ListView ID="ListView1" runat="server">
                            <LayoutTemplate>
                                <table style="border: solid 2px #333333; width: 400px" CellSpacing="0" CellPadding="3" rules="all">
                                    <tr style="background-color: #333333; color: White;">
                                        <th>Name</th>
                                        <th>Email</th>
                                        <th>Phone</th>
                                    </tr>
                                    <tbody>
                                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                                    </tbody>
                                </table>
                            </LayoutTemplate>
                               <ItemTemplate>
                                  <tr>
                                     <td><%# Eval("Name")%></td>
                                     <td><%# Eval("Email")%></td>
                                     <td><%# Eval("Phone")%></td>
                                  </tr>
                               </ItemTemplate>
                               <AlternatingItemTemplate>
                                  <tr style="background-color: #dadada;">
                                     <td><%# Eval("Name")%></td>
                                     <td><%# Eval("Email")%></td>
                                     <td><%# Eval("Phone")%></td>
                                  </tr>
                               </AlternatingItemTemplate>
                        </asp:ListView>
                    </div>
                </div>
                <div class="col-md-4">
                    <div class="row">
                        <asp:Label runat="server" CssClass="signup-input-header">Deptarment Head</asp:Label>
                    </div>
                    <div class="row">
                        <asp:Label runat="server" CssClass="label-header">Name Name</asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>