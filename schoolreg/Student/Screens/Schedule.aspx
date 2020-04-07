<%@ Page Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="Schedule.aspx.cs" Inherits="schoolreg.Student.Screens.Schedule" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" ID="Label_title" CssClass="title-header">Schedule</asp:Label>
    <hr />
       <link href="../Style/StyleSheet1.css" rel="stylesheet" />
    <div class="panel-body">
        <div class="col-lg-12">
            <div class="row">
                <div class="col-md-6" style="margin-top: 20px;">
			        <asp:Label runat="server" CssClass="signup-input-header">Classes</asp:Label>
                    <div class="row" style="margin-left: 2px">
                        <asp:ListView ID="ListView1" runat="server">
                            <LayoutTemplate>
                                <table style="border: solid 2px #333333; width: 600px" CellSpacing="0" CellPadding="3" rules="all">
                                    <tr style="background-color: #333333; color: White;">
                                        <th>Course</th>
                                        <th>Instructor</th>
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
                                    <td><%# Eval("Instructor")%></td>
                                    <td><%# Eval("Section")%></td>
                                    <td><%# Eval("Building")%></td>
                                    <td><%# Eval("Room")%></td>
                                    <td><%# Eval("Timeslot")%></td>
                                    </tr>
                                </ItemTemplate>
                                <AlternatingItemTemplate>
                                    <tr style="background-color: #dadada;">
                                    <td><%# Eval("Course")%></td>
                                    <td><%# Eval("Instructor")%></td>
                                    <td><%# Eval("Section")%></td>
                                    <td><%# Eval("Building")%></td>
                                    <td><%# Eval("Room")%></td>
                                    <td><%# Eval("Timeslot")%></td>
                                    </tr>
                                </AlternatingItemTemplate>
                        </asp:ListView>
                    </div>
                </div>
            </div>
            <hr />
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">
			        <asp:Label runat="server" CssClass="signup-input-header">Weekly View</asp:Label>
                </div>
            </div>
			<div class="row" style="margin-top: 20px">
                <div class="col-md-6">
                    <asp:Button ID="LastButton" runat="server" Text="<" Height="35px" CssClass="mybutton"  />
                    <asp:Label runat="server" CssClass="signup-input-header">9/12/2020 - 15/12/2020</asp:Label>
                    <asp:Button ID="Button1" runat="server" Text=">" Height="35px" CssClass="mybutton"  />
                </div>
			</div>
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">>
                    <asp:Label runat="server" CssClass="signup-input-header">WEEKLY VIEW HERE</asp:Label>
                </div>
			</div>
        </div>
    </div>
</asp:Content>
