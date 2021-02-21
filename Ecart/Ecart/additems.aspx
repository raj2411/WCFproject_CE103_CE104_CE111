<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="additems.aspx.cs" Inherits="Ecart.additems" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1337px;
            height: 424px;
            margin-bottom: 0px;
            margin-top: 23px;
        }
        .auto-style2 {
            width: 1335px;
            height: 76px;
            margin-bottom: 0px;
        }
        .auto-style3 {
            width: 36%;
            margin-top: 28px;
            height: 227px;
            margin-left: 447px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style7 {
            height: 19px;
        }
        .auto-style8 {
            width: 230px;
        }
        .auto-style9 {
            margin-left: 502px;
        }
        .auto-style10 {
            height: 357px;
            width: 1340px;
            margin-top: 17px;
        }
        .auto-style11 {
            margin-left: 445px;
            margin-top: 18px;
        }
        .auto-style12 {
            margin-top: 0px;
        }
        </style>
</head>
<body style="background-color:white">
    <form id="form1" runat="server">
        
        <div class="auto-style2" style="background-color:white">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="Larger" Text="ONLINE BOOK STORE"></asp:Label>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>&nbsp; </b></div>
        <div class="auto-style1" style="background-color:white">
            <table class="auto-style3" border="1">
                <tr>
                    <td class="auto-style4" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="Larger" ForeColor="Black" Text="ADD BOOK DETAILS"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="Medium" Text="ID NUMBER"></asp:Label>
&nbsp;&nbsp; <asp:TextBox ID="TextBox9" runat="server" BackColor="white" Font-Bold="True" Font-Names="Arial Black" Font-Size="Small" ForeColor="Black"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style7" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="Medium" Text="BOOK NAME"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" BackColor="White" Font-Bold="True" Font-Names="Arial Black" Font-Size="Small" ForeColor="Black"></asp:TextBox>
                    </td>
                </tr>
                
                <tr>
                    <td class="auto-style7" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="Medium" Text="DESCRIPTION"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" BackColor="White" Font-Bold="True" Font-Names="Arial Black" Font-Size="Small" ForeColor="Black"></asp:TextBox>
                    </td>
                </tr>
                
                <tr>
                    <td class="auto-style7" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="Medium" Text="PRICE"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox  ID="TextBox6" runat="server" BackColor="White" Font-Bold="True" Font-Names="Arial Black" Font-Size="Small" ForeColor="Black"></asp:TextBox>
                    </td>
                </tr>
                
                <tr>
                    <td class="auto-style7" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="Medium" Text="CATEGORY"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox7" runat="server" BackColor="White" Font-Bold="True" Font-Names="Arial Black" Font-Size="Small" ForeColor="Black"></asp:TextBox>
                    </td>
                </tr>
                
                <tr>
                    <td class="auto-style7" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label7" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="Medium" Text="STATUS"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="TextBox8" runat="server" BackColor="White" Font-Bold="True" Font-Names="Arial Black" Font-Size="Small" ForeColor="Black"></asp:TextBox>
                    </td>
                </tr>s
            </table>
            <br />
            <asp:Button ID="Button1" runat="server" BackColor="White" CssClass="auto-style9" Height="43px" Text="ADD" Width="159px" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" BackColor="White" CssClass="auto-style12" Font-Bold="True" Font-Names="Arial Black" Height="44px" OnClick="Button2_Click" Text="BACK TO ADMIN-HOME" Width="194px" />
        </div>
        <div style="background-color:white" class="auto-style10">
            <br /><br />
            <asp:GridView ID="GridView1" runat="server" CssClass="auto-style11" Height="157px" Width="487px">
                <AlternatingRowStyle BackColor="White" />
            </asp:GridView>

        </div>
    </form>
</body>
</html>
