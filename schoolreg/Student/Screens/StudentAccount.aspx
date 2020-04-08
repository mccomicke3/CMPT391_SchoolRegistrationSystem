<%@ Page Language="C#" MasterPageFile="~/Student1.Master" AutoEventWireup="true" CodeBehind="StudentAccount.aspx.cs" Inherits="schoolreg.Student.Screens.StudentAccount" %>

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
                    <asp:TextBox runat="server" ID="FacilitatorFirst" CssClass="inputfields" Width="200px" Text="first name"/>
                </div>
			</div>
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">
			        <asp:Label runat="server" AssociatedControlID="FacilitatorLast" CssClass="signup-input-header">Last Name</asp:Label>
                </div>
            </div>
			<div class="row">
                <div class="col-md-6">
                    <asp:TextBox runat="server" ID="FacilitatorLast" CssClass="inputfields" Width="200px" Text="last name" />
                </div>
			</div>
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">
			        <asp:Label runat="server" AssociatedControlID="FacilitatorLast" CssClass="signup-input-header">SIN</asp:Label>
                </div>
            </div>
		    <div class="row">
                <div class="col-md-6">
                    <asp:TextBox runat="server" ID="TextBox1" CssClass="inputfields" Width="200px" Text="123123123" />
                </div>
		    </div>
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">
			        <asp:Button ID="LastButton" runat="server" Text="Apply" Height="35px" CssClass="mybutton"  />
                </div>
            </div>
            <hr />
            <asp:Label runat="server" ID="Label1" CssClass="title-header">Adress</asp:Label>
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">
			        <asp:Label runat="server" AssociatedControlID="FacilitatorLast" CssClass="signup-input-header">City</asp:Label>
                </div>
            </div>
		    <div class="row">
                <div class="col-md-6">
                    <asp:TextBox runat="server" ID="TextBox2" CssClass="inputfields" Width="200px" Text="Edmonton" />
                </div>
		    </div>
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">
			        <asp:Label runat="server" AssociatedControlID="FacilitatorLast" CssClass="signup-input-header">Street</asp:Label>
                </div>
            </div>
		    <div class="row">
                <div class="col-md-6">
                    <asp:TextBox runat="server" ID="TextBox3" CssClass="inputfields" Width="200px" Text="2342 74St" />
                </div>
		    </div>
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">
			        <asp:Label runat="server" AssociatedControlID="FacilitatorLast" CssClass="signup-input-header">Province</asp:Label>
                </div>
            </div>
		    <div class="row">
                <div class="col-md-6">
                    <asp:TextBox runat="server" ID="TextBox4" CssClass="inputfields" Width="200px" Text="Alberta" />
                </div>
		    </div>
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">
			        <asp:Label runat="server" AssociatedControlID="FacilitatorLast" CssClass="signup-input-header">Country</asp:Label>
                </div>
            </div>
		    <div class="row">
                <div class="col-md-6">
                    <asp:TextBox runat="server" ID="TextBox5" CssClass="inputfields" Width="200px" Text="Canada" />
                </div>
		    </div>
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">
			        <asp:Label runat="server" AssociatedControlID="FacilitatorLast" CssClass="signup-input-header">Postal Code</asp:Label>
                </div>
            </div>
		    <div class="row">
                <div class="col-md-6">
                    <asp:TextBox runat="server" ID="TextBox6" CssClass="inputfields" Width="200px" Text="T0B 1K3" />
                </div>
		    </div>
            <div class="row" style="margin-top: 20px">
                <div class="col-md-6">
			        <asp:Button ID="Button1" runat="server" Text="Apply" Height="35px" CssClass="mybutton"  />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
