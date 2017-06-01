<%@ Page language="c#" Codebehind="Labname.aspx.cs" AutoEventWireup="false" Inherits="html.Labname" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Labname</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
		<style type="text/css">
BODY { MARGIN-TOP: 0px; BACKGROUND-IMAGE: url(img/JDSJ029.jpg); MARGIN-LEFT: 0px }
		</style>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE width="849" height="250" border="0" cellPadding="0" cellSpacing="0">
				<TR>
					<TD vAlign="middle" align="center" background="img/dl_bg.gif" height="30">&nbsp;<FONT face="隶书" size="5">实验室信息</FONT></TD>
				</TR>
				<TR>
					<TD style="HEIGHT: 177px" vAlign="top" height="177" align="center"><table width="88%" border="0" cellspacing="0" cellpadding="0">
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
								<td align="center"><table width="550" border="0" cellpadding="0" cellspacing="0">
										<tr>
											<td width="297" style="WIDTH: 253px"><span> &nbsp;&nbsp;&nbsp;&nbsp;</span>
												<asp:Button ID="Button1" runat="server" Text="添加"></asp:Button></td>
											<td width="253" style="WIDTH: 227px"><asp:Button id="Button2" runat="server" Text="首页" Height="20px"></asp:Button>
												<asp:Button id="Button3" runat="server" Text="上一页" Height="20px"></asp:Button>
												<asp:Button id="Button4" runat="server" Text="下一页" Height="20px"></asp:Button>
												<asp:Button id="Button5" runat="server" Text="末页" Height="20px"></asp:Button>
											</td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</TD>
				</TR>
				<TR>
					<TD align="center" style="HEIGHT: 34px">&nbsp;</TD>
				</TR>
		  </TABLE>
		</form>
	</body>
</HTML>
