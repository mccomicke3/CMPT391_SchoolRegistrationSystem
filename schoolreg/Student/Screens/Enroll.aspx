<%@ Page Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="Enroll.aspx.cs" Inherits="schoolreg.Student.Screens.Enroll" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<asp:Label runat="server" ID="Label_title" CssClass="title-header">Enroll</asp:Label>
<hr />
    <link href="../Style/StyleSheet1.css" rel="stylesheet" />
    <div class="panel-body">
        <div class="col-lg-12">
            <div class="col-lg-4">
            <div class="row">
                <div class="col-md-3">
			        <asp:Label runat="server" CssClass="signup-input-header">Filter</asp:Label>
                    <asp:DropDownList ID="dept" runat="server" CssClass="signupDropDown" style="margin-top: 10px">
                        <asp:ListItem Enabled="true" Text="All" Value="-1"></asp:ListItem>
                        <asp:ListItem Text="A" Value="1"></asp:ListItem>
                        <asp:ListItem Text="B" Value="12"></asp:ListItem>
                        <asp:ListItem Text="C" Value="12"></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">
			        <asp:Label runat="server" CssClass="signup-input-header">Courses</asp:Label>
                    <asp:TreeView ID="TreeView1" runat="server">
                        <Nodes>
                            <asp:TreeNode Value="ComputerScience" 
                                Text="Computer Science"
                                Target="Content" 
                                Expanded="False">
             
                                <asp:TreeNode Value="100 - Course Name" 
                                    Text="100 - Course Name"
                                    Target="Content"/>
               
                                <asp:TreeNode Value="200 - Course Name" 
                                    Text="200 - Course Name"
                                    Target="Content"/>
                 
                            </asp:TreeNode>              
            
                            <asp:TreeNode Value="Mathematics" 
                                Text="Mathematics"
                                Target="Content"
                                Expanded="False">
                                
                                <asp:TreeNode Value="100 - Course Name" 
                                    Text="100 - Course Name"
                                    Target="Content"/>
               
                                <asp:TreeNode Value="200 - Course Name" 
                                    Text="200 - Course Name"
                                    Target="Content"/>
                            </asp:TreeNode> 
                        </Nodes>  
                    </asp:TreeView>
                </div>
                </div>
            </div>
            <div class="col-md-8">
                <div class="col-md-4" style="margin-bottom: 20px">
                    <asp:Label runat="server" CssClass="signup-input-header">Semesters</asp:Label>
                </div>
                <div class="col-md-4">
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="signupDropDown">
                        <asp:ListItem Enabled="true" Text="Fall 2020" Value="-1"></asp:ListItem>
                        <asp:ListItem Text="Winter 2021" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Fall 2021" Value="12"></asp:ListItem>
                        <asp:ListItem Text="Winter 2022" Value="12"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                    <div class="row" style="margin-top: 20px">
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
                                        <th>Full</th>
                                        <th>Enroll</th>
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
                                    <td><%# Eval("Full")%></td>
                                    <td><asp:Button ID="LastButton" runat="server" Text="Enroll" Width="60px"/></td>
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
                                    <td><%# Eval("Full")%></td>
                                    <td><asp:Button ID="LastButton" runat="server" Text="Full" Enabled="false" Width="60px" /></td>
                                    </tr>
                                </AlternatingItemTemplate>
                        </asp:ListView>
                    </div>
                </div>
        </div>
    </div>
</asp:Content>
