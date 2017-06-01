<%@ Page language="c#" Codebehind="Sbname.aspx.cs" AutoEventWireup="false" Inherits="html.Sbname" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Sbname</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
	</HEAD>
	<body background="img/JDSJ029.jpg" leftmargin="0" topmargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table width="851" height="403" border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td width="709" height="30" align="center" valign="middle" background="img/dl_bg.gif">&nbsp;<FONT face="隶书" size="5">设备名称信息</FONT></td>
				</tr>
				<tr>
					<td valign="top" align="center"><table width="100%" border="0" cellspacing="0" cellpadding="0">
							<tr>
								<td align="center"><asp:DataGrid ID="DataGrid1" runat="server" BorderColor="#CCCCFF" BorderStyle="None" BorderWidth="1px"
										BackColor="White" CellPadding="3" AutoGenerateColumns="False" PageSize="5" AllowPaging="True" Font-Size="Smaller"
										Font-Names="隶书" Width="360px">
										<SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
										<AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
										<ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
										<HeaderStyle Font-Bold="True" ForeColor="#000066" BackColor="#88A2FF"></HeaderStyle>
										<FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
										<PagerStyle Visible="False" HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF"
											Mode="NumericPages"></PagerStyle>
									</asp:DataGrid></td>
							</tr>
							<tr>
								<td align="center"><table width="69%" height="23" border="0" cellpadding="0" cellspacing="0">
										<tr>
											<td width="353" style="WIDTH: 349px"><span> &nbsp;&nbsp;&nbsp;&nbsp;</span>
												<asp:Button ID="Button1" runat="server" Text="添加"></asp:Button></td>
											<td width="225" style="WIDTH: 214px"><asp:Button id="Button2" runat="server" Text="首页" Height="20px"></asp:Button>
												<asp:Button id="Button3" runat="server" Text="上一页" Height="20px"></asp:Button>
												<asp:Button id="Button4" runat="server" Text="下一页" Height="20px"></asp:Button>
												<asp:Button id="Button5" runat="server" Text="末页" Height="20px"></asp:Button>
											</td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td height="39" align="center" valign="top">&nbsp;</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
