<%@ Page language="c#" Codebehind="Admin.aspx.cs" AutoEventWireup="false" Inherits="html.Admin" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Admin</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
		<style type="text/css">
		@import url("css/normal.css");
BODY { MARGIN-TOP: 0px; BACKGROUND-IMAGE: url(img/blank.gif); MARGIN-LEFT: 0px }
		</style>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table height="376" cellSpacing="0" cellPadding="0" width="850" background="img/bgyg1.gif"
				border="0">
				<tr>
					<td style="HEIGHT: 30px" vAlign="middle" align="center" background="img/dl_bg.gif" height="30">&nbsp;</td>
				</tr>
				<tr>
					<td height="151" vAlign="top" align="center">
						<table width="100%" height="240" border="0" cellpadding="0" cellspacing="0">
                          <tr>
                            <td height="66" class="font1">&nbsp;<font face="隶书" size="5">管理员基本信息</font></td>
                          </tr>
                          <tr>
                            <td><asp:DataGrid ID=DataGrid1 runat="server" Font-Names="隶书" Font-Size="Smaller" AllowPaging="True" PageSize="5" Width="304px" AutoGenerateColumns="False" DataMember="admin" DataKeyField="id" DataSource="<%# dataSet11 %>" CellPadding="3" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#CCCCFF">
                              <selecteditemstyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></selecteditemstyle>
                              <alternatingitemstyle BackColor="#F7F7F7"></alternatingitemstyle>
                              <itemstyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></itemstyle>
                              <headerstyle Font-Bold="True" ForeColor="#000066" BackColor="#88A2FF"></headerstyle>
                              <footerstyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></footerstyle>
                              <columns>
                              <asp:BoundColumn DataField="id" ReadOnly="True" HeaderText="id"></asp:BoundColumn>
                              <asp:BoundColumn DataField="username" HeaderText="姓名"></asp:BoundColumn>
                              <asp:ButtonColumn Text="删除" CommandName="Delete"></asp:ButtonColumn>
                              </columns>
                              <pagerstyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></pagerstyle>
                            </asp:DataGrid></td>
                          </tr>
                          <tr>
                            <td><table width="69%" height="23" border="0" cellpadding="0" cellspacing="0">
                              <tr>
                                <td width="349" style="WIDTH: 349px"><span> &nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button1" runat="server" Text="添加"></asp:Button>
                                </span> </td>
                                <td width="237" style="WIDTH: 214px"><asp:Button id="Button4" runat="server" Text="首页" Height="20px"></asp:Button>
                                    <asp:Button id="Button5" runat="server" Text="上一页" Height="20px"></asp:Button>
                                    <asp:Button id="Button9" runat="server" Text="下一页" Height="20px"></asp:Button>
                                    <asp:Button id="Button10" runat="server" Text="末页" Height="20px"></asp:Button>                                </td>
                              </tr>
                            </table></td>
                          </tr>
                        </table>
						<p>&nbsp;</p>
		          <p>&nbsp; </p></td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
