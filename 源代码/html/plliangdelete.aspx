<%@ Page language="c#" Codebehind="plliangdelete.aspx.cs" AutoEventWireup="false" Inherits="html.plliangdelete" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>plliangdelete</title>
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
	<body leftmargin="0" topmargin="0" marginwidth="0" marginheight="0" MS_POSITIONING="GridLayout">
		<table width="753" border="0" cellpadding="0" cellspacing="0" align="center" style="WIDTH: 753px; HEIGHT: 216px">
			<tr>
				<td width="801">
					<form id="Form1" method="post" runat="server">
						<table width="751" border="0" cellpadding="0" cellspacing="0" background="img/bgyg1.gif"
							align="center">
							<tr>
								<td height="211"><table width="751" height="209" border="0" cellpadding="0" cellspacing="1" bordercolor="#ccccff"
										bgcolor="#ccccff">
										<tr>
											<td height="39" colspan="4" align="center" bgcolor="#FFFFFF">&nbsp;<FONT face="宋体" class="font1"><FONT face="隶书" size="5">批量设备信息删除</FONT></FONT></td>
										</tr>
										<tr>
											<td width="194" bgcolor="#FFFFFF" style="HEIGHT: 33px">&nbsp;<span class="fontlishu"><FONT face="隶书" size="4">设备</FONT><FONT face="宋体"><FONT face="隶书" size="4">起始编号</FONT>：</FONT></span></td>
											<td width="231" bgcolor="#FFFFFF" style="HEIGHT: 33px">&nbsp;
												<asp:DropDownList id="DropDownList1" runat="server" AutoPostBack="True"></asp:DropDownList></td>
											<td width="221" bgcolor="#FFFFFF" style="HEIGHT: 33px">&nbsp;<FONT face="宋体"><FONT face="隶书" size="4">终止编号:</FONT></FONT></td>
											<td width="204" bgcolor="#FFFFFF" style="HEIGHT: 33px">&nbsp;
												<asp:DropDownList id="DropDownList2" runat="server" AutoPostBack="True"></asp:DropDownList></td>
										</tr>
										<tr>
											<td bgcolor="#FFFFFF" style="HEIGHT: 31px">&nbsp;<span class="fontlishu"><FONT face="隶书" size="4">实验室名称</FONT>：</span></td>
											<td colspan="3" bgcolor="#FFFFFF" style="HEIGHT: 31px">&nbsp;
												<asp:DropDownList id="DropDownList3" runat="server" AutoPostBack="True"></asp:DropDownList></td>
										</tr>
										<tr>
											<td bgcolor="#FFFFFF" style="HEIGHT: 32px">&nbsp;<span class="fontlishu"><FONT face="隶书" size="4">设备名称</FONT>：</span></td>
											<td colspan="3" bgcolor="#FFFFFF" style="HEIGHT: 32px">&nbsp;
												<asp:DropDownList id="DropDownList4" runat="server" AutoPostBack="True"></asp:DropDownList></td>
										</tr>
										<tr>
											<td bgcolor="#FFFFFF" style="HEIGHT: 31px">&nbsp;<FONT face="隶书" size="4">厂家信息：</FONT></td>
											<td colspan="3" bgcolor="#FFFFFF" style="HEIGHT: 31px">&nbsp;
												<asp:Label id="Label1" runat="server">Label</asp:Label></td>
										</tr>
										<tr>
											<td height="33" bgcolor="#FFFFFF" style="HEIGHT: 33px">
												<FONT face="隶书" size="4">&nbsp;出厂日期：</FONT>
											</td>
											<td colspan="3" bgcolor="#FFFFFF" style="HEIGHT: 33px">&nbsp;
												<asp:Label id="Label2" runat="server">Label</asp:Label></td>
										</tr>
										<tr>
											<td height="34" bgcolor="#FFFFFF">&nbsp;</td>
											<td colspan="3" bgcolor="#FFFFFF"><asp:Button ID="Button1" runat="server" Text="确定"></asp:Button></td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</form>
				</td>
			</tr>
		</table>
	</body>
</HTML>
