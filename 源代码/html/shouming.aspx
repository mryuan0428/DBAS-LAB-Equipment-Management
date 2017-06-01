<%@ Page language="c#" Codebehind="shouming.aspx.cs" AutoEventWireup="false" Inherits="html.shouming" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>shouming</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
		<style type="text/css">
@import url( css/normal.css ); @import url( normal.css ); BODY { BACKGROUND-IMAGE: url(img/blank.gif); MARGIN: 0px }
.STYLE2 { FONT-WEIGHT: normal; COLOR: #333333 }
		</style>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<table width="850" border="0" cellpadding="0" cellspacing="0" bordercolor="#ccccff">
			<tr>
				<td align="center">
					<form id="Form1" method="post" runat="server">
						<table width="714" height="224" border="1" cellpadding="0" cellspacing="0" bordercolor="#ccccff"
							background="img/bgyg1.gif">
							<tr>
								<td colspan="2" class="font2">请选择厂家名称,设备名称和设备编号,则可以预测设备的平均故障时间和设备将要发生故障的时间: </td>
							</tr>
							<tr>
								<td width="233" height="43" align="center" class="font3">厂家名称：</td>
								<td width="475"><table width="100%" border="0" cellspacing="0" cellpadding="0">
										<tr>
											<td height="19" style="WIDTH: 340px">&nbsp;
												<asp:DropDownList id="DropDownList1" runat="server"></asp:DropDownList></td>
											<td>&nbsp;
												<asp:Button id="Button1" runat="server" Text="确定"></asp:Button></td>
										</tr>
									</table>								</td>
							</tr>
							<tr>
								<td height="37" align="center"><span class="font3"> 设备名称：</span></td>
								<td>&nbsp;
									<asp:DropDownList id="DropDownList2" runat="server"></asp:DropDownList></td>
							</tr>
							<tr>
								<td height="36" align="center" class="font3">设备编号：</td>
								<td>&nbsp;
									<asp:DropDownList id="DropDownList3" runat="server"></asp:DropDownList></td>
							</tr>
							<tr>
								<td align="center" class="font3">预测设备的平均故障时间：</td>
								<td>&nbsp;
									<asp:Label id="Label1" runat="server">Label</asp:Label></td>
							</tr>
							<tr>
								<td align="center" class="font3">预测设备间发生故障的时间：								</td>
								<td>&nbsp;
									<asp:Label id="Label2" runat="server">Label</asp:Label></td>
							</tr>
						</table>
					</form>
				</td>
			</tr>
		</table>
	</body>
</HTML>
