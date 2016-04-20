<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebFormLogin.UI2.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group">

        <asp:Label ID="Notification" runat="server" Text="" class="error"></asp:Label>
    </div>
    <div class="form-group">
        <label for="Name">Name</label>
        <asp:TextBox ID="Name" runat="server" class="form-control" data-rule-required="true"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="SurName">Sur Name</label>
        <asp:TextBox ID="SurName" runat="server" class="form-control" data-rule-required="true"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="Email">Email</label>
        <asp:TextBox ID="Email" runat="server" class="form-control" data-rule-email="true"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="Phone">Phone</label>
        <asp:TextBox ID="Phone" runat="server" class="form-control" data-rule-digits="true"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="NickName">Nick Name</label>
        <asp:TextBox ID="NickName" runat="server" class="form-control" data-rule-required="true"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="Password">Password</label>
        <asp:TextBox ID="Password" TextMode="Password"  runat="server" class="form-control" data-rule-required="true"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="ConfirmPassword">Confirm Password</label>
        <asp:TextBox ID="ConfirmPassword" TextMode="Password" runat="server" class="form-control" data-rule-equalto="#Password"></asp:TextBox>
    </div>
    <div class="form-group text-center">
        <asp:Button ID="Button2" runat="server" Text="Reset" class="btn btn-default" />
        <asp:Button ID="btnRegister" OnClick="btnRegister_Click" runat="server" Text="Register" class="btn btn-success" />
    </div>


</asp:Content>
