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
		<style type="text/css">BODY { MARGIN-TOP: 0px; BACKGROUND-IMAGE: url(img/JDSJ029.jpg); MARGIN-LEFT: 0px }
		</style>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table height="435" cellSpacing="0" cellPadding="0" width="851" border="0">
				<tr>
					<td width="851" height="30" align="center" vAlign="middle" background="img/dl_bg.gif"
						style="HEIGHT: 30px">&nbsp;<FONT face="隶书" size="5">管理员基本信息</FONT></td>
				</tr>
				<tr>
					<td height="151" vAlign="top" align="center"><table width="84%" border="0" cellspacing="0" cellpadding="0">
							<tr>
								<td align="center"><asp:DataGrid id="DataGrid1" runat="server" Font-Names="隶书" Font-Size="Smaller" AllowPaging="True"
										PageSize="5" Width="309px" AutoGenerateColumns="False" CellPadding="3" BackColor="White" BorderWidth="1px"
										BorderStyle="None" BorderColor="#CCCCFF">
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
								<td align="center"><table width="89%" height="23" border="0" cellpadding="0" cellspacing="0">
										<tr>
											<td width="349" style="WIDTH: 349px"><asp:Button ID="Button1" runat="server" Text="添加"></asp:Button></td>
											<td width="221" style="WIDTH: 214px"><asp:Button id="Button2" runat="server" Text="首页" Height="20px"></asp:Button>
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
					<td height="250" align="center" valign="top">&nbsp;</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
