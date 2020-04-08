<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Schedule.aspx.cs" Inherits="schoolreg.Instructor.Screens.Schedule" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" ID="Label_title" CssClass="title-header">Schedule</asp:Label>
    <hr />
       <link href="../Style/StyleSheet1.css" rel="stylesheet" />
    <div class="panel-body">
        <div class="col-lg-12">
            <div class="row">
                <div class="row">
                    <div class="col-md-3">
			            <asp:Label runat="server" CssClass="signup-input-header">Select Semester</asp:Label>
                        <asp:DropDownList ID="dept" runat="server" CssClass="signupDropDown" style="margin-top: 10px">
                            <asp:ListItem Enabled="true" Text="Semester" Value="-1"></asp:ListItem>
                            <asp:ListItem Text="TestSem" Value="1"></asp:ListItem>
                            <asp:ListItem Text="SemTest" Value="12"></asp:ListItem>
                            <asp:ListItem Text="OneMore" Value="12"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-md-3">
                        <div>
                            <asp:Button ID="FirstButton" runat="server" Text="Class Page" Height="35px" CssClass="mybutton" PostBackUrl="~/Instructor/Screens/SubmitGrades.aspx" />
                        </div>
                    </div>
                </div>
                <div class="col-md-6" style="margin-top: 20px">
			        <asp:Label runat="server" CssClass="signup-input-header">Classes</asp:Label>
                    <div class="row">
                        <asp:ListView ID="ListView1" runat="server">
                            <LayoutTemplate>
                                <table style="border: solid 2px #333333; width: 600px">
                                    <tr style="background-color: #333333; color: White;">
                                        <th>Course</th>
                                        <th>Credits</th>
                                        <th>Section</th>
                                        <th>Building</th>
                                        <th>Room</th>
                                        <th>Timeslot</th>
                                    </tr>
                                    <tbody>
                                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                                    </tbody>
                                </table>
                            </LayoutTemplate>
                               <ItemTemplate>
                                  <tr>
                                    <td><%# Eval("Course")%></td>
                                    <td><%# Eval("Credits")%></td>
                                    <td><%# Eval("Section")%></td>
                                    <td><%# Eval("Building")%></td>
                                    <td><%# Eval("Room")%></td>
                                    <td><%# Eval("Timeslot")%></td>
                                  </tr>
                               </ItemTemplate>
                               <AlternatingItemTemplate>
                                  <tr style="background-color: #dadada;">
                                    <td><%# Eval("Course")%></td>
                                    <td><%# Eval("Credits")%></td>
                                    <td><%# Eval("Section")%></td>
                                    <td><%# Eval("Building")%></td>
                                    <td><%# Eval("Room")%></td>
                                    <td><%# Eval("Timeslot")%></td>
                                  </tr>
                               </AlternatingItemTemplate>
                        </asp:ListView>
                    </div>
                    <!--
                    <div class="row">
                        <asp:Label runat="server">Add new class</asp:Label>
                    </div>
                    <div class="row">
                        <div class="col">
                            <asp:DropDownList ID="SelectDept" runat="server" OnSelectedIndexChanged="SelectDept_SelectedIndexChanged" AutoPostBack="true" CssClass="signupDropDown" Width="75px" style="margin-top: 10px">
                                <asp:ListItem Text="Dept" Enabled="true"/>
                            </asp:DropDownList>
                            <asp:DropDownList ID="SelectNumber" runat="server" OnSelectedIndexChanged="SelectNumber_SelectedIndexChanged" AutoPostBack="true" CssClass="signupDropDown" Width="65px" style="margin-top: 10px">
                                <asp:ListItem Text="Num" Enabled="true"/>
                            </asp:DropDownList>
                            <asp:DropDownList ID="SelectSection" runat="server" CssClass="signupDropDown" Width="75px" style="margin-top: 10px">
                                <asp:ListItem Enabled="true" Text="Sect" Value="-1"></asp:ListItem>
                            </asp:DropDownList>
                            <asp:Button ID="addClass" runat="server" Text="Add Button" OnClick="addClass_Click" Height="35px" CssClass="mybutton"/>
                        </div>
                    </div>
                    -->
                </div>
                </div>
            </div>
        </div>
</asp:Content>
