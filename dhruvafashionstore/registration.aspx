<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="dhruvafashionstore.registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 248px;
        }
        .auto-style3 {
            width: 151px;
        }
        .auto-style4 {
            width: 163px;
        }
        .auto-style5 {
            width: 225%;
        }
        .auto-style6 {
            width: 184px;
        }
        .auto-style7 {
            width: 227%;
            height: 44px;
        }
        .auto-style8 {
            height: 42px;
        }
        .auto-style9 {
            width: 163px;
            height: 42px;
        }
        .auto-style11 {
            width: 248px;
            height: 42px;
        }
        .auto-style16 {
            width: 116px;
        }
        .auto-style18 {
            height: 42px;
            width: 116px;
        }
        .auto-style19 {
            height: 47px;
        }
        .auto-style20 {
            width: 163px;
            height: 47px;
        }
        .auto-style21 {
            height: 47px;
            width: 116px;
        }
        .auto-style22 {
            width: 248px;
            height: 47px;
        }
        .auto-style23 {
            height: 91px;
        }
        .auto-style24 {
            width: 163px;
            height: 91px;
        }
        .auto-style25 {
            height: 91px;
            width: 116px;
        }
        .auto-style26 {
            width: 248px;
            height: 91px;
        }
        .auto-style31 {
            height: 70px;
        }
        .auto-style32 {
            width: 163px;
            height: 70px;
        }
        .auto-style33 {
            width: 116px;
            height: 70px;
        }
        .auto-style34 {
            width: 248px;
            height: 70px;
        }
        .auto-style35 {
            height: 26px;
        }
        .auto-style36 {
            width: 163px;
            height: 26px;
        }
        .auto-style37 {
            width: 116px;
            height: 26px;
        }
        .auto-style38 {
            width: 248px;
            height: 26px;
        }
        .auto-style39 {
            height: 66px;
        }
        .auto-style40 {
            width: 163px;
            height: 66px;
        }
        .auto-style41 {
            height: 66px;
            width: 116px;
        }
        .auto-style42 {
            width: 248px;
            height: 66px;
        }
    .auto-style43 {
        width: 179%;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="Label1" runat="server" BackColor="White" Font-Bold="True" Font-Italic="False" Font-Size="X-Large" Font-Strikeout="False" ForeColor="#CC3300" Text="SignUp"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="Label11" runat="server" Font-Size="Small" Text="Already have an Account?"></asp:Label>
                <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="Fuchsia" NavigateUrl="~/login.aspx">Login</asp:HyperLink>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="Label9" runat="server" Text="Name" Font-Size="Small"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server" Height="30px" OnTextChanged="TextBox1_TextChanged" Width="406px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please enter your name"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="Label3" runat="server" Text="Address" Font-Size="Small"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" Height="34px" TextMode="MultiLine" Width="412px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please enter your Address"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="Label4" runat="server" Text="Phone" Font-Size="Small"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox3" runat="server" Height="33px" Width="412px"></asp:TextBox>
            </td>
            <td>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter a valid phone Number"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style39"></td>
            <td class="auto-style40">&nbsp;</td>
            <td class="auto-style41">
                <table class="auto-style5">
                    <tr>
                        <td class="auto-style6">&nbsp;</td>
                        <td class="auto-style3">&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td class="auto-style42">
                <asp:Label ID="Label5" runat="server" Text="Email" Font-Size="Small"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" Height="33px" Width="409px"></asp:TextBox>
            </td>
            <td class="auto-style39">
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="Enter a valid Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
            <td class="auto-style39"></td>
            <td class="auto-style39"></td>
        </tr>
        <tr>
            <td class="auto-style31"></td>
            <td class="auto-style32"></td>
            <td class="auto-style33">
                <table class="auto-style7">
                    <tr>
                        <td>
                            <br />
                        </td>
                        <td>
                            <br />
                        </td>
                    </tr>
                </table>
            </td>
            <td class="auto-style34">
                <asp:Label ID="Label6" runat="server" Text="State" Font-Size="Small"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="33px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="418px">
                </asp:DropDownList>
            </td>
            <td class="auto-style31"></td>
            <td class="auto-style31"></td>
            <td class="auto-style31"></td>
        </tr>
        <tr>
            <td class="auto-style19"></td>
            <td class="auto-style20"></td>
            <td class="auto-style21">
                <br />
                <br />
            </td>
            <td class="auto-style22">
                <asp:Label ID="Label7" runat="server" Text="District" Font-Size="Small"></asp:Label>
                <asp:DropDownList ID="DropDownList2" runat="server" Height="33px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Width="417px">
                    <asp:ListItem Value="1">tvm</asp:ListItem>
                    <asp:ListItem Value="2">kollam</asp:ListItem>
                    <asp:ListItem Value="3">Ekm</asp:ListItem>
                </asp:DropDownList>
                <br />
            </td>
            <td class="auto-style19">&nbsp;</td>
            <td class="auto-style19"></td>
            <td class="auto-style19"></td>
        </tr>
        <tr>
            <td class="auto-style8"></td>
            <td class="auto-style9"></td>
            <td class="auto-style18">
                <br />
            </td>
            <td class="auto-style11">
                <asp:Label ID="Label8" runat="server" Text="Pincode" Font-Size="Small"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server" Height="34px" Width="412px"></asp:TextBox>
            </td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style8"></td>
            <td class="auto-style8"></td>
        </tr>
        <tr>
            <td class="auto-style35"></td>
            <td class="auto-style36"></td>
            <td class="auto-style37"></td>
            <td class="auto-style38">
                <asp:Label ID="Label13" runat="server" Font-Size="Small" Text="Username"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox6" runat="server" Height="33px" Width="412px"></asp:TextBox>
            </td>
            <td class="auto-style35">
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox6" ErrorMessage="Enter Usename"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style35"></td>
            <td class="auto-style35"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style16">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="Label10" runat="server" Text="Password" Font-Size="Small"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox7" runat="server" Height="33px" Width="412px"></asp:TextBox>
            </td>
            <td>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox7" ErrorMessage="Enter a valid password"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style23"></td>
            <td class="auto-style24"></td>
            <td class="auto-style25"></td>
            <td class="auto-style26">
                <asp:Button ID="Button1" runat="server" BackColor="#FF0066" ForeColor="White" OnClick="Button1_Click" Text="Create Account" Width="413px" />
                <table class="auto-style43">
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:HyperLink ID="HyperLink2" runat="server" ForeColor="#FF0066">***Registration Completed start Shopping**** </asp:HyperLink>
                        </td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
            <td class="auto-style23"></td>
            <td class="auto-style23"></td>
            <td class="auto-style23"></td>
        </tr>
    </table>
</asp:Content>
