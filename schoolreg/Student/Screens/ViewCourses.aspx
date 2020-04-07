<%@ Page Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="ViewCourses.aspx.cs" Inherits="schoolreg.Student.Screens.ViewCourses" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<asp:Label runat="server" ID="Label_title" CssClass="title-header">Course History</asp:Label>
    <hr />
       <link href="../Style/StyleSheet1.css" rel="stylesheet" />
    <div class="panel-body">
        <div class="col-lg-12">
            <div class="row">
                <div class="row">
                    <div class="col-md-3">
			            <asp:Label runat="server" CssClass="signup-input-header">Select Semester</asp:Label>
                        <asp:DropDownList ID="dept" runat="server" CssClass="signupDropDown" style="margin-top: 10px">
                            <asp:ListItem Enabled="true" Text="All" Value="-1"></asp:ListItem>
                            <asp:ListItem Text="TestSem" Value="1"></asp:ListItem>
                            <asp:ListItem Text="SemTest" Value="12"></asp:ListItem>
                            <asp:ListItem Text="OneMore" Value="12"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="col-md-6" style="margin-top: 20px">
			        <asp:Label runat="server" CssClass="signup-input-header">Classes</asp:Label>
                    <div class="row">
                        <asp:ListView ID="ListView1" runat="server">
                            <LayoutTemplate>
                                <table style="border: solid 2px #333333; width: 600px" CellSpacing="0" CellPadding="3" rules="all">
                                    <tr style="background-color: #333333; color: White;">
                                        <th>Course</th>
                                        <th>Year</th>
                                        <th>Semester</th>
                                        <th>Grade</th>
                                    </tr>
                                    <tbody>
                                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                                    </tbody>
                                </table>
                            </LayoutTemplate>
                               <ItemTemplate>
                                  <tr>
                                    <td><%# Eval("Course")%></td>
                                    <td><%# Eval("Year")%></td>
                                    <td><%# Eval("Semester")%></td>
                                    <td><%# Eval("Grade")%></td>
                                  </tr>
                               </ItemTemplate>
                               <AlternatingItemTemplate>
                                  <tr style="background-color: #dadada;">
                                    <td><%# Eval("Course")%></td>
                                    <td><%# Eval("Year")%></td>
                                    <td><%# Eval("Semester")%></td>
                                    <td><%# Eval("Grade")%></td>
                                  </tr>
                               </AlternatingItemTemplate>
                        </asp:ListView>
                    </div>
                </div>
                </div>
            </div>
        </div>
</asp:Content>
