<%@ Page Language="C#" MasterPageFile="~/Student1.Master" AutoEventWireup="true" CodeBehind="Drop.aspx.cs" Inherits="schoolreg.Student.Screens.Drop" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" ID="Label_title" CssClass="title-header">Drop</asp:Label>
    <hr />
       <link href="../Style/StyleSheet1.css" rel="stylesheet" />
    <div class="panel-body">
        <div class="col-lg-12">
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
                </div>
                <div class="row" style="margin-top:20px">
                    <div class="col-md-3">
                        <asp:Label runat="server" CssClass="signup-input-header">Classes</asp:Label>
                    </div>
                </div>
                <div class="col-md-6" style="margin-top: 10px">
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
                                        <th>Drop</th>
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
                                    <td style="align-self: center"><asp:CheckBox ID="CheckBox1" runat="server" /></td>
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
                                    <td><asp:CheckBox ID="CheckBox1" runat="server" /></td>
                                  </tr>
                               </AlternatingItemTemplate>
                        </asp:ListView>
                    </div>
                    <div class="row" style="margin-top: 20px">
                        <div class="col-md-3">
			                <asp:Button ID="LastButton" runat="server" Text="Confirm" Height="35px" CssClass="mybutton"  />
                        </div>
                    </div>
                </div>
            </div>
    </div>
</asp:Content>

