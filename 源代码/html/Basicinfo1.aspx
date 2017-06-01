<%@ Page language="c#" Codebehind="Basicinfo1.aspx.cs" AutoEventWireup="false" Inherits="html.Basicinfo1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Basicinfo1</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
		<style type="text/css">
@import url( css/normal.css ); 
		body {
	background-image: url(img/JDSJ029.jpg);
}
</style>
	</HEAD>
	<body leftmargin="0" topmargin="0" MS_POSITIONING="GridLayout">
		<table width="850" border="0" cellspacing="0" cellpadding="0">
			<tr>
				<td>
					<form id="Form1" method="post" runat="server">
						<table width="851" height="332" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td height="30" align="center" valign="middle" background="img/dl_bg.gif">&nbsp;<FONT face="隶书" size="5">设备基本信息管理表</FONT></td>
							</tr>
							<tr>
								<td height="104" align="center" valign="top"><table width="91%" height="72" border="0" cellpadding="0" cellspacing="0">
										<tr>
											<td height="24" colspan="6" align="left" class="font"><img src="img/dian.jpg" width="18" height="18">想查询某个具体设备？请输入查询条件&nbsp;：&nbsp;</td>
										</tr>
										<tr>
											<td width="136" height="25" align="center" class="font">&nbsp;</td>
											<td width="103" class="font2" style="WIDTH: 103px"><span class="font2" style="WIDTH: 103px"><span class="font2" style="WIDTH: 103px">实验室名称：</span></span></td>
											<td width="171" style="WIDTH: 171px">&nbsp;
												<asp:DropDownList id="DropDownList3" runat="server" AutoPostBack="True"></asp:DropDownList></td>
											<td width="83" class="font2" style="WIDTH: 83px"><span class="font2" style="WIDTH: 83px"><span class="font2" style="WIDTH: 83px">设备编号:</span></span></td>
											<td width="120">&nbsp;
												<asp:DropDownList id="DropDownList4" runat="server"></asp:DropDownList></td>
											<td width="162">
												<asp:ImageButton id="ImageButton1" runat="server" ImageUrl="img/search_m.gif"></asp:ImageButton></td>
										</tr>
										<tr>
											<td height="11" colspan="6" align="center" class="font">&nbsp;</td>
										</tr>
									</table>
								</td>
							</tr>
							<tr>
								<td height="105" align="center" valign="top"><table width="92%" height="198" border="0" cellpadding="0" cellspacing="0">
										<tr>
											<td height="159" align="center"><asp:datagrid id="DataGrid1" runat="server" BorderColor="#CCCCFF" BorderStyle="None" BorderWidth="1px"
													BackColor="White" CellPadding="3" AutoGenerateColumns="False" Font-Size="Smaller" Font-Names="隶书" AllowPaging="True" Width="664px"
													PageSize="5">
													<SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
													<AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
													<ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
													<HeaderStyle Font-Bold="True" ForeColor="#000066" BackColor="#88A2FF"></HeaderStyle>
													<FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
													<PagerStyle Visible="False" HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF"
														Mode="NumericPages"></PagerStyle>
												</asp:datagrid></td>
										</tr>
										<tr>
											<td align="center"><table height="28" border="0" cellpadding="0" cellspacing="0">
													<tr>
														<td width="450" style="WIDTH: 450px">&nbsp;</td>
														<td width="249">&nbsp;
															<asp:Button id="Button1" runat="server" Height="20px" Text="首页" ForeColor="Black"></asp:Button>
															<asp:Button id="Button2" runat="server" Height="20px" Text="上一页"></asp:Button>
															<asp:Button id="Button3" runat="server" Height="20px" Text="下一页"></asp:Button>
															<asp:Button id="Button4" runat="server" Height="20px" Text="末页"></asp:Button></td>
													</tr>
												</table>
											</td>
										</tr>
									</table>
								</td>
							</tr>
					  </table>
					</form>
				</td>
			</tr>
		</table>
		<INPUT id="Hidden1" style="Z-INDEX: 101; LEFT: 336px; POSITION: absolute; TOP: 424px" type="hidden"
			name="Hidden1" runat="server">
</body>
</HTML>
