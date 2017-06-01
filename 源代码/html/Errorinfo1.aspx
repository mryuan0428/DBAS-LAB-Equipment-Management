<%@ Page language="c#" Codebehind="Errorinfo1.aspx.cs" AutoEventWireup="false" Inherits="html.Errorinfo1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Errorinfo1</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
	</HEAD>
	<body background="img/JDSJ029.jpg" leftmargin="0" topmargin="0" marginwidth="0" marginheight="0"
		MS_POSITIONING="GridLayout">
		<table width="850" border="0" cellspacing="0" cellpadding="0">
			<tr>
				<td>
					<form id="Form1" method="post" runat="server">
						<table width="851" height="384" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td width="851" height="30" align="center" valign="middle" background="img/dl_bg.gif">&nbsp;<FONT face="隶书" size="5">故障类型信息</FONT></td>
							</tr>
							<tr>
								<td height="142" valign="top" style="HEIGHT: 142px" align="center"><span style="HEIGHT: 228px">
										<asp:DataGrid ID="DataGrid1" runat="server" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px"
											BackColor="White" CellPadding="3" GridLines="Horizontal" AutoGenerateColumns="False" PageSize="5"
											AllowPaging="True" Font-Size="Smaller" Font-Names="隶书" Width="400px">
											<SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
											<AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
											<ItemStyle ForeColor="Black" BackColor="#E7E7FF"></ItemStyle>
											<HeaderStyle Font-Bold="True" ForeColor="#000066" BackColor="#88A2FF"></HeaderStyle>
											<FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
											<PagerStyle Visible="False" HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF"
												Mode="NumericPages"></PagerStyle>
										</asp:DataGrid>
									</span>
								</td>
							</tr>
							<tr>
								<td height="177" align="center" valign="top" style="HEIGHT: 177px"><TABLE height="28" cellSpacing="0" cellPadding="0" width="75%" border="0">
										<TBODY>
											<TR>
												<TD width="55%">&nbsp;
												</TD>
												<TD width="45%">
													<asp:Button id="Button1" runat="server" Text="首页" ForeColor="Black" Height="20px"></asp:Button>
													<asp:Button id="Button2" runat="server" Text="上一页" Height="20px"></asp:Button>
													<asp:Button id="Button3" runat="server" Text="下一页" Height="20px"></asp:Button>
													<asp:Button id="Button4" runat="server" Text="末页" Height="20px"></asp:Button></TD>
											</TR>
										</TBODY>
									</TABLE>
								</td>
							</tr>
					  </table>
					</form>
				</td>
			</tr>
		</table>
</body>
</HTML>
