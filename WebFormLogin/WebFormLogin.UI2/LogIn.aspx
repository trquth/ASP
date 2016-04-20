<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="WebFormLogin.UI2.LogIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group">
        <label for="UserName">User Name:</label>
        <asp:TextBox ID="UserName" runat="server" class="form-control" data-rule-required="true"></asp:TextBox>
    </div>
    <div class="form-group">
        <label class="control-label col-sm-3" for="Password">Password:</label>
        <asp:TextBox ID="Password" runat="server" TextMode="Password" class="form-control" data-rule-required="true"></asp:TextBox>
    </div>
    <div class="form-group">
        <div class="col-sm-offset-2 col-sm-10">
            <asp:Button ID="btnLogin" runat="server" Text="Login" class="btn btn-success" />
            <asp:HyperLink ID="likRegister" class="btn btn-primary" runat="server" NavigateUrl="~/Register.aspx">Register</asp:HyperLink>
        </div>
    </div>
</asp:Content>
