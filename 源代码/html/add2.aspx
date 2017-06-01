<%@ Page language="c#" Codebehind="add2.aspx.cs" AutoEventWireup="false" Inherits="html.add2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>add2</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
		<style type="text/css">
@import url( css/normal.css ); BODY { BACKGROUND-IMAGE: url(img/JDSJ029.jpg) }
		</style>
	</HEAD>
	<body leftmargin="0" topmargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE width="700" height="320" border="0" align="center" cellPadding="0" cellSpacing="1"
				borderColor="#ccccff" bgcolor="#ccccff" style="WIDTH: 700px; HEIGHT: 312px">
				<tr>
					<td height="30" colspan="4" align="center" valign="middle" bgcolor="#ffffff" class="font1">&nbsp;<FONT face="隶书" size="5">维修过程添加</FONT></td>
				</tr>
				<tr>
					<td width="264" valign="middle" bgcolor="#ffffff" style="WIDTH: 264px; HEIGHT: 31px">&nbsp;
							<span class="lishu"><FONT face="隶书" size="4">设备编号</FONT>：</span></td>
					<td width="160" bgcolor="#ffffff" style="HEIGHT: 31px">&nbsp;
						<asp:Label id="Label2" runat="server" Width="80px">Label</asp:Label></td>
					<td width="190" bgcolor="#ffffff" style="WIDTH: 190px; HEIGHT: 31px">&nbsp; 
							<span class="lishu"><FONT face="隶书" size="4">设备名称</FONT>：</span></td>
					<td width="179" bgcolor="#ffffff" style="HEIGHT: 31px">&nbsp;
						<asp:Label id="Label4" runat="server" Width="80px">Label</asp:Label></td>
				</tr>
				<tr>
					<td bgcolor="#ffffff" style="WIDTH: 264px; HEIGHT: 30px">&nbsp; 
								<span class="lishu"><FONT face="隶书" size="4">实验室名</FONT>：</span></td>
					<td bgcolor="#ffffff" style="HEIGHT: 30px">&nbsp;
						<asp:Label id="Label6" runat="server" Width="88px">Label</asp:Label></td>
					<td bgcolor="#ffffff" style="WIDTH: 190px; HEIGHT: 30px">&nbsp; 
							<span class="lishu"><FONT face="隶书" size="4">故障名称</FONT>：</span></td>
					<td bgcolor="#ffffff" style="HEIGHT: 30px">&nbsp;
						<asp:Label id="Label8" runat="server" Width="136px">Label</asp:Label></td>
				</tr>
				<tr>
					<td colspan="2" bgcolor="#ffffff">&nbsp; <span class="lishu"><FONT face="隶书" size="4">维护过程</FONT>：</span></td>
					<td colspan="2" bgcolor="#ffffff">&nbsp;
						<asp:TextBox id="TextBox1" runat="server" Width="376px" Height="124px"></asp:TextBox></td>
				</tr>
				<tr>
					<td bgcolor="#ffffff" style="WIDTH: 264px; HEIGHT: 32px">&nbsp; 
							<span class="lishu"><FONT face="隶书" size="4">经手人</FONT>：</span></td>
					<td valign="middle" bgcolor="#ffffff" style="HEIGHT: 32px">&nbsp;
						<asp:TextBox id="TextBox2" runat="server"></asp:TextBox></td>
					<td bgcolor="#ffffff" style="WIDTH: 190px; HEIGHT: 32px">&nbsp; 
								<span class="lishu"><FONT face="隶书" size="4">登记日期</FONT>：</span></td>
					<td bgcolor="#ffffff" style="HEIGHT: 32px">&nbsp;
						<asp:Label id="Label12" runat="server" Width="152px">Label</asp:Label></td>
				</tr>
				<tr>
					<td height="33" colspan="2" bgcolor="#ffffff">&nbsp;
						<asp:Button id="Button1" runat="server" Text="确定"></asp:Button></td>
					<td colspan="2" bgcolor="#ffffff">&nbsp;</td>
				</tr>
			</TABLE>
		</form>
	</body>
</HTML>
