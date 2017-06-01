<%@ Page language="c#" Codebehind="Weihu1.aspx.cs" AutoEventWireup="false" Inherits="html.Weihu1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Weihu1</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
		<style type="text/css">
		@import url("css/normal.css");

BODY { MARGIN-TOP: 0px; BACKGROUND-IMAGE: url(img/blank.gif); MARGIN-LEFT: 0px }
		</style>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<table width="850" border="0" cellspacing="0" cellpadding="0">
			<tr>
				<td>
					<form id="Form1" method="post" runat="server">
						<table width="700" height="363" border="0" align="center" cellpadding="0" cellspacing="1" bordercolor="#ccccff" bgcolor="#ccccff">
							<tr>
								<td height="30" colspan="4" align="center" valign="middle" bgcolor="#FFFFFF" class="font1"
									style="HEIGHT: 32px">&nbsp;<FONT face="隶书" size="5">维护过程</FONT></td>
							</tr>
							<tr>
							  <td width="182" height="31" align="center" valign="middle" bgcolor="#FFFFFF">&nbsp;<span class="lishu"><FONT face="隶书" size="4">设备编号</FONT>：</span></td>
								<td width="131" valign="top" bgcolor="#FFFFFF">&nbsp;
							  <asp:Label id="Label2" runat="server" Width="80px">Label</asp:Label></td>
								<td width="219" align="center" valign="middle" bgcolor="#FFFFFF">&nbsp;<span class="lishu"><FONT size="4" face="隶书">设备名称</FONT>：</span></td>
								<td width="168" valign="top" bgcolor="#FFFFFF">&nbsp;
							  <asp:Label id="Label4" runat="server" Width="80px">Label</asp:Label></td>
							</tr>
							<tr>
							  <td height="31" align="center" valign="middle" bgcolor="#FFFFFF">&nbsp;<span class="lishu"><FONT face="隶书" size="4">实验室名称</FONT>：</span></td>
								<td valign="top" bgcolor="#FFFFFF">&nbsp;
							  <asp:Label id="Label6" runat="server" Width="88px">Label</asp:Label></td>
								<td align="center" valign="middle" bgcolor="#FFFFFF">&nbsp;<span class="lishu"><FONT face="隶书" size="4">故障名称</FONT>：</span></td>
								<td valign="top" bgcolor="#FFFFFF">&nbsp;
							  <asp:Label id="Label8" runat="server" Width="136px">Label</asp:Label></td>
							</tr>
							<tr>
								<td colspan="4" valign="top" align="center"><table width="100%" border="0" cellspacing="0" cellpadding="0">
										<tr>
											<td align="center" bgcolor="#FFFFFF"><asp:DataGrid ID="DataGrid1" runat="server" Width="663px" BorderColor="#CCCCFF" BorderStyle="None"
													BorderWidth="1px" BackColor="White" CellPadding="3" AutoGenerateColumns="False" AllowPaging="True" Font-Size="Smaller"
													Font-Names="隶书">
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
											<td><table width="100%" height="23" border="0" cellpadding="0" cellspacing="0">
													<tr>
														<td width="353" bgcolor="#FFFFFF" style="WIDTH: 349px"><span> &nbsp;&nbsp;&nbsp;&nbsp;</span>														</td>
														<td width="227" bgcolor="#FFFFFF" style="WIDTH: 214px"><asp:Button id="Button1" runat="server" Text="首页" Height="20px"></asp:Button>
															<asp:Button id="Button2" runat="server" Text="上一页" Height="20px"></asp:Button>
															<asp:Button id="Button3" runat="server" Text="下一页" Height="20px"></asp:Button>
															<asp:Button id="Button4" runat="server" Text="末页" Height="20px"></asp:Button>
													  </td>
													</tr>
												</table>
											</td>
										</tr>
									</table>
								</td>
							</tr>
							<tr>
								<td colspan="4" valign="top" bgcolor="#FFFFFF">&nbsp;</td>
							</tr>
					  </table>
					</form>
				</td>
			</tr>
		</table>
	</body>
</HTML>
