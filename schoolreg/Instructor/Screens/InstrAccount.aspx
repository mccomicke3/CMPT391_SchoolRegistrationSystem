<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="InstrAccount.aspx.cs" Inherits="schoolreg.Instructor.Screens.InstrAccount" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" ID="Label_title" CssClass="title-header">Account</asp:Label>
    <hr />
       <link href="../Style/StyleSheet1.css" rel="stylesheet" />
    <div class="panel-body">
        <div class="col-lg-6">
            <div class="row">
                <div class="col-md-6">
			        <asp:Label runat="server" AssociatedControlID="FacilitatorFirst" CssClass="signup-input-header">First Name</asp:Label>
                </div>
            </div>
			<div class="row">
                <div class="col-md-6">
                    <asp:TextBox runat="server" ID="FacilitatorFirst" CssClass="inputfields" Width="200px"/>
                </div>
			</div>
            <div class="row">
                <div class="col-md-6">
			        <asp:Label runat="server" AssociatedControlID="FacilitatorLast" CssClass="signup-input-header" Text="last name">Last Name</asp:Label>
                </div>
            </div>
			<div class="row">
                <div class="col-md-6">
                    <asp:TextBox runat="server" ID="FacilitatorLast" CssClass="inputfields" Width="200px"/>
                </div>
                <div>
                    <asp:Button ID="LastButton" OnClick="LastButton_Click" runat="server" Text="Rename" Height="35px" CssClass="mybutton"  />
                </div>
			</div>
        </div>
        <div class="col-lg-3">
            <div class="row">
                <div class="col-md-8">
			        <asp:Label runat="server" CssClass="input-header">Date of Birth</asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
			        <asp:Label ID="dobLabel" runat="server" CssClass="label-header"/>
                </div>
            </div>
            <div class="row" style="margin-top: 50px">
                <div class="col-md-6">
			        <asp:Label runat="server" CssClass="input-header">Salary</asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
			        <asp:Label ID="salaryLabel" runat="server" CssClass="label-header"/>
                </div>
            </div>
        </div>
        <div class="col-lg-3">
            <div class="row">
                <div class="col-md-6">
			        <asp:Label runat="server" CssClass="input-header">Department</asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
			        <asp:Label ID="deptLabel" runat="server" CssClass="label-header"/>
                </div>
            </div>
            <div class="row" style="margin-top: 50px">
                <div class="col-md-6">
			        <asp:Label runat="server" CssClass="input-header">Building</asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
			        <asp:Label ID="buildingLabel" runat="server" CssClass="label-header"/>
                </div>
            </div>
        </div>
     </div>

</asp:Content>