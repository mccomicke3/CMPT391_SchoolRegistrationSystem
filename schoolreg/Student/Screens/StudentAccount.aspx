<%@ Page Language="C#" MasterPageFile="~/Student1.Master" AutoEventWireup="true" CodeBehind="StudentAccount.aspx.cs" Inherits="schoolreg.Student.Screens.StudentAccount" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<asp:Label runat="server" ID="Label_title" CssClass="title-header">Account</asp:Label>
    <hr />
       <link href="../Style/StyleSheet1.css" rel="stylesheet" />
    <div class="panel-body">
        <div class="col-lg-6">
            <div class="row">
                <div class="col-md-6">
			        <asp:Label runat="server" CssClass="signup-input-header">First Name</asp:Label>
                </div>
            </div>
			<div class="row">
                <div class="col-md-6">
                    <asp:TextBox runat="server" ID="firstName" CssClass="inputfields" Width="200px" Text="first name"/>
                </div>
			</div>
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">
			        <asp:Label runat="server" CssClass="signup-input-header">Last Name</asp:Label>
                </div>
            </div>
			<div class="row">
                <div class="col-md-6">
                    <asp:TextBox runat="server" ID="lastName" CssClass="inputfields" Width="200px" Text="last name" />
                </div>
			</div>
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">
			        <asp:Label runat="server" CssClass="signup-input-header">SIN</asp:Label>
                </div>
            </div>
		    <div class="row">
                <div class="col-md-6">
                    <asp:TextBox runat="server" ID="sin" CssClass="inputfields" Width="200px" Text="123123123" />
                </div>
		    </div>
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">
			        <asp:Button ID="LastButton" runat="server" Text="Apply" Height="35px" CssClass="mybutton" OnClick="UpdatePrimaryAccountInfo"/>
                </div>
            </div>
            <hr />
            <asp:Label runat="server" ID="Label1" CssClass="title-header">Address</asp:Label>
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">
			        <asp:Label runat="server" CssClass="signup-input-header">City</asp:Label>
                </div>
            </div>
		    <div class="row">
                <div class="col-md-6">
                    <asp:TextBox runat="server" ID="city" CssClass="inputfields" Width="200px" Text="Edmonton" />
                </div>
		    </div>
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">
			        <asp:Label runat="server" CssClass="signup-input-header">Number</asp:Label>
                </div>
            </div>
		    <div class="row">
                <div class="col-md-6">
                    <asp:TextBox runat="server" ID="number" CssClass="inputfields" Width="200px" Text="2342" />
                </div>
		    </div>
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">
			        <asp:Label runat="server" CssClass="signup-input-header">Street</asp:Label>
                </div>
            </div>
		    <div class="row">
                <div class="col-md-6">
                    <asp:TextBox runat="server" ID="street" CssClass="inputfields" Width="200px" Text="74St" />
                </div>
		    </div>
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">
			        <asp:Label runat="server" CssClass="signup-input-header">Province</asp:Label>
                </div>
            </div>
		    <div class="row">
                <div class="col-md-6">
                    <asp:TextBox runat="server" ID="province" CssClass="inputfields" Width="200px" Text="Alberta" />
                </div>
		    </div>
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">
			        <asp:Label runat="server" CssClass="signup-input-header">Postal Code</asp:Label>
                </div>
            </div>
		    <div class="row">
                <div class="col-md-6">
                    <asp:TextBox runat="server" ID="postal" CssClass="inputfields" Width="200px" Text="T0B 1K3" />
                </div>
		    </div>
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">
			        <asp:Button ID="Button1" runat="server" Text="Apply" Height="35px" CssClass="mybutton" OnClick="UpdateSecondaryAccountInfo"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
