<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="TableList.aspx.cs" Inherits="WebFormLogin.UI2.TableList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:repeater id="ListData" runat="server">      
        <HeaderTemplate>
        <table class="table table-striped">
        <tr>
            <th>Name</th>
            <th></th>
        </tr>
        </HeaderTemplate>
        <ItemTemplate>
        <tr>
            <td><%#Eval("Name")%></td>
            <td><a href="#" class="btn btn-warning">Reserve</a></td>
        </tr>
        </ItemTemplate>
        <FooterTemplate>
        </table>
        </FooterTemplate>                   
      
    </asp:repeater>
</asp:Content>
