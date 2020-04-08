<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="SubmitGrades.aspx.cs" Inherits="schoolreg.Instructor.Screens.SubmitGrades" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" ID="Label_title" CssClass="title-header">Submit Grades</asp:Label>
    <hr />
       <link href="../Style/StyleSheet1.css" rel="stylesheet" />
    <div class="panel-body">
        <div class="col-lg-12">
            <div class="row">
                <div class="row">
                    <div class="col-md-3">
			            <asp:Label runat="server" CssClass="signup-input-header">Select Course</asp:Label>
                        <!--
                        <asp:DropDownList ID="dept" runat="server" CssClass="signupDropDown" style="margin-top: 10px">
                            <asp:ListItem Enabled="true" Text="Course" Value="-1"></asp:ListItem>
                            <asp:ListItem Text="TestCourse" Value="1"></asp:ListItem>
                            <asp:ListItem Text="CourseTest" Value="12"></asp:ListItem>
                            <asp:ListItem Text="OneMore" Value="12"></asp:ListItem>
                        </asp:DropDownList>
                        -->
                        <asp:DropDownList ID="SelectCourse" runat="server" OnSelectedIndexChanged="SelectCourse_SelectedIndexChanged" AutoPostBack="true" CssClass="signupDropDown" Width="75px" style="margin-top: 10px">
                            <asp:ListItem Text="Course" Enabled="true"/>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="col-md-6" style="margin-top: 20px">
			        <asp:Label runat="server" CssClass="signup-input-header">Students</asp:Label>
                    <div class="row">
                        <asp:ListView ID="ListView1" runat="server">
                            <LayoutTemplate>
                                <table style="border: solid 2px #333333" CellSpacing="0" CellPadding="3" rules="all">
                                    <tr style="background-color: #333333; color: White;">
                                        <th style="width: 150px">Student</th>
                                        <th style="width: 50px">Grade</th>
                                    </tr>
                                    <tbody>
                                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                                    </tbody>
                                </table>
                            </LayoutTemplate>
                               <ItemTemplate>
                                  <tr>
                                    <td><%# Eval("Student")%></td>
                                    <td><asp:TextBox ID="TextBox1" runat="server" style="width: 50px"></asp:TextBox></td>
                                  </tr>
                               </ItemTemplate>
                               <AlternatingItemTemplate>
                                  <tr style="background-color: #dadada;">
                                    <td><%# Eval("Student")%></td>
                                    <td><asp:TextBox ID="TextBox1" runat="server" style="width: 50px"></asp:TextBox></td>
                                  </tr>
                               </AlternatingItemTemplate>
                        </asp:ListView>
                    </div>
                    <div class="row">
                        <div class="col-md-3">
                            <div style="margin-top:20px">
                                <asp:Button ID="submitGrades" OnClick="submitGrades_Click" runat="server" Text="Submit" Height="35px" CssClass="mybutton"  />
                            </div>
                        </div>
                    </div>
                </div>
                </div>
            </div>
        </div>
</asp:Content>

