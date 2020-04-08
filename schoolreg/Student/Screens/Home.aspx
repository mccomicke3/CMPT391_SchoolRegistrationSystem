<%@ Page Language="C#" MasterPageFile="~/Student1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="schoolreg.Student.Screens.Home" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<asp:Label runat="server" ID="Label_title" CssClass="title-header">Home</asp:Label>
    <hr />
       <link href="../Style/StyleSheet1.css" rel="stylesheet" />
    <div class="panel-body">
        <div class="col-lg-12">
            <div class="row">
                <div class="col-md-3">
			        <asp:Label runat="server" CssClass="input-header" ID="studentName">Name Name</asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6" style="margin-top: 20px;">
			        <asp:Label runat="server" CssClass="input-header">Classes</asp:Label>
                    <div class="row" style="margin-left: 2px">
                        <asp:ListView ID="ListView1" runat="server">
                            <LayoutTemplate>
                                <table style="border: solid 2px #333333; width: 600px">
                                    <tr style="background-color: #333333; color: White;">
                                        <th>Course</th>
                                        <th>Instructor</th>
                                        <th>Section</th>
                                        <th>Classroom</th>
                                        <th>Time</th>
                                    </tr>
                                    <tbody>
                                        <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                                    </tbody>
                                </table>
                            </LayoutTemplate>
                               <ItemTemplate>
                                  <tr>
                                    <td><%# Eval("Course")%></td>
                                    <td><%# Eval("Instructor")%></td>
                                    <td><%# Eval("SectionID")%></td>
                                    <td><%# Eval("Classroom")%></td>
                                    <td><%# Eval("Time")%></td>
                                  </tr>
                               </ItemTemplate>
                               <AlternatingItemTemplate>
                                  <tr style="background-color: #dadada;">
                                    <td><%# Eval("Course")%></td>
                                    <td><%# Eval("Instructor")%></td>
                                    <td><%# Eval("SectionID")%></td>
                                    <td><%# Eval("Classroom")%></td>
                                    <td><%# Eval("Time")%></td>
                                  </tr>
                               </AlternatingItemTemplate>
                        </asp:ListView>
                    </div>
                </div>
            </div>
            <div class="row" style="margin-top: 20px">
                <div class="col-lg-3">
                    <div class="row">
                        <div class="col-md-8">
			                <asp:Label runat="server" CssClass="input-header">Major</asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
			                <asp:Label runat="server" CssClass="label-header" ID="studentMajor">TempMaj</asp:Label>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3">
                    <div class="row">
                        <div class="col-md-8">
			                <asp:Label runat="server" CssClass="input-header">Minor</asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
			                <asp:Label runat="server" CssClass="label-header" ID="studentMinor">TempMinor</asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row" style="margin-top: 20px">
                <div class="col-lg-3">
                    <div class="row">
                        <div class="col-md-8">
			                <asp:Label runat="server" CssClass="input-header">Credits</asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
			                <asp:Label runat="server" CssClass="label-header">0</asp:Label>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3">
                    <div class="row">
                        <div class="col-md-8">
			                <asp:Label runat="server" CssClass="input-header">GPA</asp:Label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6">
			                <asp:Label runat="server" CssClass="label-header" ID="studentGPA">2.0</asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row" style="margin-top: 20px">
                <div class="col-lg-3">
                    <div class="row">
                        <div class="col-md-8">
			                <asp:Button ID="FirstButton" runat="server" Text="Course History" Height="35px" CssClass="mybutton" OnClick="GoToCourseHistory"/>
                        </div>
                    </div>
                </div>
                 <div class="col-lg-3">
                    <div class="row">
                        <div class="col-md-8">
			                <asp:Button ID="Button1" runat="server" Text="Pick Major/Minor" Height="35px" CssClass="mybutton" PostBackUrl="~/Student/Screens/SelectMajMin.aspx" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>