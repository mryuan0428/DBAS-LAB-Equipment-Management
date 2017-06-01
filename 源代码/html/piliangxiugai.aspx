<%@ Page language="c#" Codebehind="piliangxiugai.aspx.cs" AutoEventWireup="false" Inherits="html.piliangxiugai" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>piliangxiugai</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<style type="text/css">
@import url( css/normal.css ); BODY { BACKGROUND-IMAGE: url(img/JDSJ029.jpg); MARGIN: 0px }
		</style>
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<table width="751" border="0" align="center" cellpadding="0" cellspacing="0" background="img/bgyg1.gif">
			<tr>
				<td height="211">
					<form id="Form1" method="post" runat="server">
						<table width="751" height="224" border="0" cellpadding="0" cellspacing="1" bordercolor="#ccccff"
							bgcolor="#ccccff" style="WIDTH: 751px; HEIGHT: 224px">
							<tr>
								<td height="39" colspan="4" align="center" bgcolor="#ffffff">&nbsp;<FONT face="宋体" class="font1"><FONT face="隶书" size="5">批量设备信息修改</FONT></FONT></td>
							</tr>
							<tr>
								<td width="194" bgcolor="#ffffff">&nbsp;<span class="fontlishu"><FONT face="隶书" size="4">设备</FONT><FONT face="宋体"><FONT face="隶书" size="4">起始编号</FONT>：</FONT></span></td>
								<td width="231" bgcolor="#ffffff">&nbsp;
									<asp:DropDownList id="DropDownList1" runat="server" AutoPostBack="True"></asp:DropDownList></td>
								<td width="221" bgcolor="#ffffff">&nbsp;<FONT face="宋体"><FONT face="隶书" size="4">终止编号:</FONT></FONT></td>
								<td width="204" bgcolor="#ffffff">&nbsp;
									<asp:DropDownList id="DropDownList2" runat="server"></asp:DropDownList></td>
							</tr>
							<tr>
								<td bgcolor="#ffffff">&nbsp;<span class="fontlishu"><FONT face="隶书" size="4">实验室名称</FONT>：</span></td>
								<td colspan="3" bgcolor="#ffffff">&nbsp;
									<asp:DropDownList id="DropDownList3" runat="server" AutoPostBack="True"></asp:DropDownList></td>
							</tr>
							<tr>
								<td bgcolor="#ffffff" style="HEIGHT: 29px">&nbsp;<span class="fontlishu"><FONT face="隶书" size="4">设备名称</FONT>：</span></td>
								<td height="29" colspan="3" bgcolor="#ffffff" style="HEIGHT: 29px">&nbsp;
									<asp:DropDownList id="DropDownList4" runat="server" AutoPostBack="True"></asp:DropDownList></td>
							</tr>
							<tr>
								<td bgcolor="#ffffff">&nbsp;<FONT face="隶书" size="4">厂家信息：</FONT></td>
								<td colspan="3" bgcolor="#ffffff">&nbsp;
									<asp:DropDownList id="DropDownList5" runat="server"></asp:DropDownList></td>
							</tr>
							<tr>
								<td height="30" bgcolor="#ffffff" style="HEIGHT: 30px">&nbsp;<FONT face="隶书" size="4">出厂日期：</FONT></td>
								<td colspan="3" bgcolor="#ffffff" style="HEIGHT: 30px">&nbsp;
									<asp:TextBox id="TextBox1" runat="server"></asp:TextBox></td>
							</tr>
							<tr>
								<td height="34" bgcolor="#ffffff">&nbsp;</td>
								<td colspan="3" bgcolor="#ffffff"><asp:Button ID="Button1" runat="server" Text="确定"></asp:Button></td>
							</tr>
						</table>
					</form>
				</td>
			</tr>
		</table>
	</body>
</HTML>
