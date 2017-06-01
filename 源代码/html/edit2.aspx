<%@ Page language="c#" Codebehind="edit2.aspx.cs" AutoEventWireup="false" Inherits="html.edit2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>edit2</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
	    <style type="text/css">
<!--
@import url("css/normal.css");
.STYLE2 {color: #000000; font-weight: normal;}
-->
        </style>
</HEAD>
	<body background="img/JDSJ029.jpg" leftmargin="0" topmargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table width="700" height="246" border="0" align="center" cellpadding="0" cellspacing="1"
				bordercolor="#ccccff" bgcolor="#ccccff">
				<tr>
					<td height="31" colspan="2" align="center" valign="middle" bgcolor="#FFFFFF">&nbsp;<FONT size="5" face="隶书" class="font1">基本设备编辑</FONT></td>
				</tr>
				<tr>
				  <td width="117" bgcolor="#FFFFFF">&nbsp;&nbsp;<span class="fontlishu"><FONT face="隶书" size="4">设备编号</FONT>：</span></td>
					<td width="577" height="35" bgcolor="#FFFFFF">&nbsp;
				  <asp:TextBox id="TextBox1" runat="server" Font-Names="隶书"></asp:TextBox></td>
				</tr>
				<tr>
				  <td bgcolor="#FFFFFF">&nbsp;&nbsp;<span class="fontlishu"><FONT face="隶书" size="4">设备</FONT></span><span class="STYLE2"><FONT face="隶书" size="4">名称</FONT></span><span class="fontlishu">：</span></td>
					<td height="35" bgcolor="#FFFFFF">&nbsp;
				  <asp:DropDownList id="DropDownList1" runat="server" Font-Names="隶书"></asp:DropDownList></td>
				</tr>
				<tr>
				  <td bgcolor="#FFFFFF">&nbsp;&nbsp;<span class="STYLE2"><FONT face="隶书" size="4">实验室名</FONT></span><span class="fontlishu">：</span></td>
					<td height="34" bgcolor="#FFFFFF">&nbsp;
				  <asp:DropDownList id="DropDownList2" runat="server" Font-Names="隶书"></asp:DropDownList></td>
				</tr>
				<tr>
				  <td height="31" bgcolor="#FFFFFF">&nbsp;&nbsp;<span class="STYLE2"><FONT face="隶书" size="4">厂家名称</FONT></span><span class="fontlishu">：</span></td>
					<td height="35" bgcolor="#FFFFFF">&nbsp;
				  <asp:DropDownList id="DropDownList3" runat="server" Font-Names="隶书"></asp:DropDownList></td>
				</tr>
				<tr>
				  <td height="33" bgcolor="#FFFFFF">&nbsp;&nbsp;<span class="STYLE2"><font size="4" face="隶书">出厂日期</font></span><span class="fontlishu">：</span></td>
					<td height="35" bgcolor="#FFFFFF">&nbsp;
				  <asp:TextBox id="TextBox2" runat="server" Font-Names="隶书"></asp:TextBox></td>
				</tr>
				<tr>
					<td bgcolor="#FFFFFF">&nbsp;</td>
					<td height="39" bgcolor="#FFFFFF"><span style="WIDTH: 132px">
							<asp:Button ID="Button1" runat="server" Text="确定"></asp:Button>
						</span>
				  </td>
				</tr>
		  </table>
		</form>
</body>
</HTML>
