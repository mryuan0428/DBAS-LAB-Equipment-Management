<%@ Page language="c#" Codebehind="Errorinfo.aspx.cs" AutoEventWireup="false" Inherits="html.Errorinfo" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Errorinfo</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
	</HEAD>
	<body leftMargin="0" background="img/JDSJ029.jpg" topMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table height="315" cellSpacing="0" cellPadding="0" width="851"
				border="0">
				<tr>
					<td vAlign="middle" align="center" width="851" background="img/dl_bg.gif" height="29">&nbsp;<FONT face="隶书" size="5">故障类型信息</FONT></td>
				</tr>
				<tr>
					<td style="HEIGHT: 177px" vAlign="top" align="center" height="177"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                        <tr>
                          <td align="center"><span style="WIDTH: 402px; HEIGHT: 152px">
                            <asp:DataGrid ID="DataGrid1" runat="server" Width="400px" Font-Names="隶书" Font-Size="Smaller"
								AllowPaging="True" PageSize="5" AutoGenerateColumns="False" CellPadding="3" BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#CCCCFF">
                              <selecteditemstyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></selecteditemstyle>
                              <alternatingitemstyle BackColor="#F7F7F7"></alternatingitemstyle>
                              <itemstyle ForeColor="Black" BackColor="#E7E7FF"></itemstyle>
                              <headerstyle Font-Bold="True" ForeColor="#000066" BackColor="#88A2FF"></headerstyle>
                              <footerstyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></footerstyle>
                              <pagerstyle Visible="False" HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF"
									Mode="NumericPages"></pagerstyle>
                            </asp:DataGrid>
                          </span></td>
                        </tr>
                        <tr>
                          <td align="center"><table height="28" cellSpacing="0" cellPadding="0" width="75%" border="0">
                            <tr>
                              <td style="WIDTH: 399px">&nbsp;&nbsp;
                                  <asp:button id="Button1" runat="server" Text="添加" Height="20px"></asp:button></td>
                              <td>&nbsp;
                                  <asp:button id="Button2" runat="server" Text="首页" ForeColor="Black" Height="20px"></asp:button>
                                <asp:button id="Button3" runat="server" Text="上一页" Height="20px"></asp:button>
                                <asp:button id="Button4" runat="server" Text="下一页" Height="20px"></asp:button>
                                <asp:button id="Button5" runat="server" Text="末页" Height="20px"></asp:button></td>
                            </tr>
                          </table></td>
                        </tr>
                      </table></td>
				</tr>
				<tr>
				  <td height="121" align="center" style="WIDTH: 827px; HEIGHT: 33px">&nbsp;</td>
				</tr>
		  </table>
			&nbsp;
		</form>
</body>
</HTML>
