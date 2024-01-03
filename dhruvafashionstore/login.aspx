<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="dhruvafashionstore.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">




    <style type="text/css">
    .auto-style1 {
        width: 416px;
    }
    .auto-style2 {
        height: 26px;
    }
    .auto-style3 {
        width: 416px;
        height: 26px;
    }
    .auto-style6 {
        width: 39px;
    }
    .auto-style7 {
        height: 26px;
        width: 39px;
    }
    .auto-style10 {
        width: 39px;
        height: 50px;
    }
    .auto-style11 {
        width: 416px;
        height: 50px;
    }
    .auto-style12 {
        height: 50px;
    }
    .auto-style13 {
        height: 50px;
        width: 207px;
    }
    .auto-style14 {
        width: 207px;
    }
    .auto-style15 {
        height: 26px;
        width: 207px;
    }
    .auto-style16 {
        width: 39px;
        height: 40px;
    }
    .auto-style17 {
        width: 416px;
        height: 40px;
    }
    .auto-style18 {
        width: 207px;
        height: 40px;
    }
    .auto-style19 {
        height: 40px;
    }
    .auto-style20 {
        width: 100%;
        height: 214px;
    }
    .auto-style21 {
        height: 22px;
        width: 39px;
    }
    .auto-style22 {
        width: 416px;
        height: 22px;
    }
    .auto-style23 {
        height: 22px;
        width: 207px;
    }
    .auto-style24 {
        height: 22px;
    }
    .auto-style25 {
        width: 39px;
        height: 19px;
    }
    .auto-style26 {
        width: 416px;
        height: 19px;
    }
    .auto-style27 {
        width: 207px;
        height: 19px;
    }
    .auto-style28 {
        height: 19px;
    }
</style>




</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style20">
    <tr>
        <td class="auto-style10"></td>
        <td class="auto-style11">
        </td>
        <td class="auto-style13">
            <asp:Label ID="Label1" runat="server" Text="LOGIN" BorderColor="#FF33CC" Font-Size="X-Large" ForeColor="#FF3399" Font-Bold="True"></asp:Label>
        </td>
        <td class="auto-style12">&nbsp;</td>
        <td class="auto-style12"></td>
        <td class="auto-style12"></td>
        <td class="auto-style12"></td>
    </tr>
    <tr>
        <td class="auto-style16"></td>
        <td class="auto-style17"></td>
        <td class="auto-style18">
            <asp:Label ID="Label2" runat="server" Font-Size="X-Small" Text="USERNAME"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" BackColor="White" BorderColor="Black" ForeColor="#FF33CC" Height="32px" Width="267px"></asp:TextBox>
        </td>
        <td class="auto-style19">&nbsp;</td>
        <td class="auto-style19"></td>
        <td class="auto-style19"></td>
        <td class="auto-style19"></td>
    </tr>
    <tr>
        <td class="auto-style21"></td>
        <td class="auto-style22"></td>
        <td class="auto-style23">
            <asp:Label ID="Label3" runat="server" Font-Size="X-Small" Text="PASSWORD"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" BorderColor="Black" ForeColor="#FF33CC" Height="30px" Width="269px"></asp:TextBox>
        </td>
        <td class="auto-style24"></td>
        <td class="auto-style24">
            &nbsp;</td>
        <td class="auto-style24"></td>
        <td class="auto-style24"></td>
    </tr>
    <tr>
        <td class="auto-style25"></td>
        <td class="auto-style26"></td>
        <td class="auto-style27">
            <asp:CheckBox ID="CheckBox1" runat="server" Font-Italic="True" Font-Size="X-Small" Text="Remember password" />
        </td>
        <td class="auto-style28"></td>
        <td class="auto-style28"></td>
        <td class="auto-style28"></td>
        <td class="auto-style28"></td>
    </tr>
    <tr>
        <td class="auto-style7"></td>
        <td class="auto-style3"></td>
        <td class="auto-style15">
            <asp:Button ID="Button1" runat="server" BackColor="#FF33CC" ForeColor="White" Height="40px" Text="LOGIN" Width="275px" OnClick="Button1_Click" />
        </td>
        <td class="auto-style2"></td>
        <td class="auto-style2"></td>
        <td class="auto-style2"></td>
        <td class="auto-style2"></td>
    </tr>
    <tr>
        <td class="auto-style6">&nbsp;</td>
        <td class="auto-style1">&nbsp;</td>
        <td class="auto-style14">
            <asp:Label ID="Label4" runat="server" Font-Size="Small" Text="Not Registered?"></asp:Label>
            <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="Small" ForeColor="#FF33CC" NavigateUrl="~/registration.aspx">SignUp</asp:HyperLink>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
