<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebFormLogin.UI2.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="form-group">

        <asp:Label ID="Notification" runat="server" Text="" class="error"></asp:Label>
    </div>
    <div class="form-group">
        <label for="FullName">Full Name</label>
        <asp:TextBox ID="FullName" runat="server" class="form-control" data-rule-required="true"></asp:TextBox>
    </div>  
    <div class="form-group">
        <label for="Email">Email</label>
        <asp:TextBox ID="Email" runat="server" class="form-control" data-rule-email="true"></asp:TextBox>
    </div>
       <div class="form-group">
        <label for="Address">Address</label>
        <asp:TextBox ID="Address" runat="server" class="form-control" data-rule-required="true"></asp:TextBox>
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
        <label for="Opinion">Opinion</label>
        <asp:TextBox ID="Opinion" TextMode="MultiLine"  runat="server" class="form-control" data-rule-required="true" data-rule-maxlength="200"></asp:TextBox>
    </div>
    <div class="form-group text-center">
        <asp:Button ID="Button2" runat="server" Text="Clear" class="btn btn-default" />
        <asp:Button ID="btnSent" OnClick="btnSent_Click" runat="server" Text="Sent" class="btn btn-success" />
    </div>

</asp:Content>
