<%@ Page language="c#" Codebehind="Labname1.aspx.cs" AutoEventWireup="false" Inherits="html.Labname1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Labname1</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
	</HEAD>
	<body background="img/JDSJ029.jpg" leftmargin="0" topmargin="0" MS_POSITIONING="GridLayout">
		<table width="850" border="0" cellspacing="0" cellpadding="0">
			<tr>
				<td>
					<form id="Form1" method="post" runat="server">
						<TABLE width="778" height="384" border="0" cellPadding="0" cellSpacing="0">
							<TR>
								<TD vAlign="middle" align="center" background="img/dl_bg.gif" height="30">&nbsp;<FONT face="隶书" size="5">实验室信息</FONT></TD>
							</TR>
							<TR>
								<TD style="HEIGHT: 177px" vAlign="top" height="177"><TABLE id="Table2" cellSpacing="0" cellPadding="0" width="851" border="0">
										<TR>
											<TD width="851" height="228" align="center" valign="top" style="HEIGHT: 228px"><table width="100%" border="0" cellspacing="0" cellpadding="0">
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
														<td align="center"><TABLE cellSpacing="0" cellPadding="0" width="550" border="0">
																<TBODY>
																	<TR>
																		<TD width="297"></TD>
																		<TD width="253"><asp:Button id="Button1" runat="server" Text="首页" Height="20px"></asp:Button>
																			<asp:Button id="Button2" runat="server" Text="上一页" Height="20px"></asp:Button>
																			<asp:Button id="Button3" runat="server" Text="下一页" Height="20px"></asp:Button>
																			<asp:Button id="Button4" runat="server" Text="末页" Height="20px"></asp:Button></TD>
																	</TR>
																</TBODY>
															</TABLE>
														</td>
													</tr>
												</table>
											</TD>
										</TR>
									</TABLE>
								</TD>
							</TR>
							<TR>
								<TD height="177" align="center" vAlign="top" style="HEIGHT: 177px">&nbsp;</TD>
							</TR>
					  </TABLE>
					</form>
				</td>
			</tr>
		</table>
</body>
</HTML>
