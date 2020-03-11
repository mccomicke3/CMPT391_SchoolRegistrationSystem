<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="schoolreg._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <h2>Info</h2>
            <asp:DataList ID="DataList1" runat="server" CellSpacing = "3">
                <ItemTemplate>
                    <table class = "table">
                        <tr>
                            <th colspan="2">
                                <b><%# Eval("Name") %></b>
                            </th>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <%# Eval("Department") %>,<br />
                                <%# Eval("Building")%>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Phone
                            </td>
                            <td>
                                <%# Eval("Phone")%>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Date of Birth
                            </td>
                            <td>
                                <%# Eval("DoB")%>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                Salary
                            </td>
                            <td>
                                <%# Eval("Salary")%>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </div>
        <div class="col-md-4">
            <h2>Current Classes</h2>
            <asp:GridView ID="GridView1" autogeneratecolumns="false" runat="server">
                <Columns>
                <asp:BoundField DataField="Class" HeaderText="Class" ReadOnly="True" 
                    SortExpression="Class" />
                <asp:BoundField DataField="Section" HeaderText="Section" 
                    SortExpression="Section" />
                <asp:BoundField DataField="Time" HeaderText="Time" 
                    SortExpression="Time" />
            </Columns>
            </asp:GridView>
        </div>
    </div>

</asp:Content>
