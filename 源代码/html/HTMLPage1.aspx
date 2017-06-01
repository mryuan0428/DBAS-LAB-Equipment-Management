<%@ Register TagPrefix="iewc" Namespace="Microsoft.Web.UI.WebControls" Assembly="Microsoft.Web.UI.WebControls, Version=1.0.2.226, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Register TagPrefix="iewc" Namespace="Microsoft.Web.UI.WebControls" Assembly="Microsoft.Web.UI.WebControls, Version=1.0.2.226, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Page language="c#" Codebehind="HTMLPage1.aspx.cs" AutoEventWireup="false" Inherits="html.HTMLPage1" %>
<%@ Register TagPrefix="iewc" Namespace="Microsoft.Web.UI.WebControls" Assembly="Microsoft.Web.UI.WebControls, Version=1.0.2.226, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>HTMLPage1</title>
		<SCRIPT language="javascript">
	<!-- 
		var lastSelectedIndex = -1;
		function switchstatus(itemName){
			var item = document.getElementById('Item' + itemName);
			//alert('Item' + itemName);
			
			if (item.style.display=='none'){
				item.style.display = '';
			}else{
				item.style.display = 'none';
			}
			if (lastSelectedIndex != -1) 
			{
				var lastSelectedItem = document.getElementById('Item' + lastSelectedIndex);
				if (itemName != lastSelectedIndex) lastSelectedItem.style.display = 'none';
			}
			lastSelectedIndex = itemName;
		}
	-->
		</SCRIPT>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
		<link href="css/normal.css" rel="stylesheet" type="text/css">
		<style type="text/css"> 
		.STYLE1 { FONT-FAMILY: "宋体" } 
		BODY { BACKGROUND-IMAGE: url(img/blank.gif); MARGIN: 0px } 
		</style>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体"></FONT>
			<table width="152" height="562" border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td width="152" valign="top" background="img/01.jpg"><table width="151" height="337" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td width="178" height="14" class="font2">
									<iewc:TreeView id="TreeView2" runat="server" Height="600px" BackColor="#F1F1F1" ShowLines="False"
										SelectExpands="True" ShowPlus="False" BorderStyle="Groove" BorderWidth="2px" CssClass="font2"
										Indent="13" Width="184px">
										<iewc:TreeNode Text="管理员面板" DefaultStyle="font-family:&quot;宋体&quot;;font-size:16px;color:#000066;font-weight:bold;"></iewc:TreeNode>
										<iewc:TreeNode ImageUrl="img/dian_1.gif" Text="基本设备管理" DefaultStyle="font-weight:bold;">
											<iewc:TreeNode NavigateUrl="Basicinfo.aspx" ImageUrl="img/dian_1.gif" Text="基本设备" Target="main">
												<iewc:TreeNode NavigateUrl="add3.aspx" ImageUrl="img/dian_11.gif" Text="单个设备添加 " Target="main"></iewc:TreeNode>
												<iewc:TreeNode NavigateUrl="piliang.aspx" ImageUrl="img/dian_11.gif" Text="批量设备添加" Target="main"></iewc:TreeNode>
												<iewc:TreeNode NavigateUrl="piliangxiugai.aspx" ImageUrl="img/dian_11.gif" Text="批量设备修改" Target="main"></iewc:TreeNode>
												<iewc:TreeNode NavigateUrl="plliangdelete.aspx" ImageUrl="img/dian_11.gif" Text="批量设备删除" Target="main"></iewc:TreeNode>
											</iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="changjia.aspx" ImageUrl="img/dian_1.gif" Text="厂家名称" Target="main">
												<iewc:TreeNode NavigateUrl="add4.aspx" ImageUrl="img/dian_11.gif" Text="厂家名称添加" Target="main"></iewc:TreeNode>
											</iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Labname.aspx" ImageUrl="img/dian_1.gif" Text="实验室名称" Target="main">
												<iewc:TreeNode NavigateUrl="add6.aspx" ImageUrl="img/dian_11.gif" Text="实验室名称添加" Target="main"></iewc:TreeNode>
											</iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="sbname.aspx" ImageUrl="img/dian_1.gif" Text="设备名称" Target="main">
												<iewc:TreeNode NavigateUrl="add7.aspx" ImageUrl="img/dian_11.gif" Text="设备名称添加" Target="main"></iewc:TreeNode>
											</iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="img/dian_1.gif" Text="故障设备管理" DefaultStyle="font-weight:bold;">
											<iewc:TreeNode NavigateUrl="sbgl.aspx" ImageUrl="img/dian_1.gif" Text="故障设备管理" Target="main">
												<iewc:TreeNode NavigateUrl="add.aspx" ImageUrl="img/dian_11.gif" Text="故障设备添加" Target="main"></iewc:TreeNode>
											</iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Errorinfo.aspx" ImageUrl="img/dian_1.gif" Text="故障类型" Target="main">
												<iewc:TreeNode NavigateUrl="add5.aspx" ImageUrl="img/dian_11.gif" Text="故障类型添加" Target="main"></iewc:TreeNode>
											</iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="img/dian_1.gif" Text="数据挖掘" DefaultStyle="font-weight:bold;">
											<iewc:TreeNode ImageUrl="img/dian_1.gif" Text="决策树算法">
												<iewc:TreeNode NavigateUrl="../WebService1/jueceshijian.aspx" ImageUrl="img/dian_11.gif" Text="设备故障率预测"
													Target="main"></iewc:TreeNode>
												<iewc:TreeNode NavigateUrl="../WebService1/shouming.aspx" ImageUrl="img/dian_11.gif" Text="单个未报修设备维修"
													Target="main"></iewc:TreeNode>
												<iewc:TreeNode NavigateUrl="../WebService1/piliangguzhang.aspx" ImageUrl="img/dian_11.gif" Text="批量未报修设备维修"
													Target="main"></iewc:TreeNode>
												<iewc:TreeNode NavigateUrl="../WebService1/yiyuceer.aspx" ImageUrl="img/dian_11.gif" Text="已修复设备维修预测"
													Target="main"></iewc:TreeNode>
											</iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="../WebService1/shijianxulie.aspx" ImageUrl="img/dian_11.gif" Text="时间序列算法"
												Target="main"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="Admin.aspx" ImageUrl="img/dian_1.gif" Text="管理员信息" DefaultStyle="font-weight:bold;"
											Target="main">
											<iewc:TreeNode NavigateUrl="add8.aspx" ImageUrl="img/dian_11.gif" Text="添加管理员" Target="main"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Userid.aspx" ImageUrl="img/dian_11.gif" Text="浏览用户信息" Target="main"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="img/dian_1.gif" Text="打印报表" DefaultStyle="font-weight:bold;">
											<iewc:TreeNode ImageUrl="img/dian_1.gif" Text="打印基本信息表">
												<iewc:TreeNode NavigateUrl="WebForm4.aspx" ImageUrl="img/dian_11.gif" Text="详细基本信息报表" Target="main"></iewc:TreeNode>
												<iewc:TreeNode NavigateUrl="WebForm6.aspx" ImageUrl="img/dian_11.gif" Text="汇总基本信息报表" Target="main"></iewc:TreeNode>
											</iewc:TreeNode>
											<iewc:TreeNode ImageUrl="img/dian_1.gif" Text="打印维护表">
												<iewc:TreeNode NavigateUrl="WebForm7.aspx" ImageUrl="img/dian_11.gif" Text="详细维护信息报表" Target="main"></iewc:TreeNode>
												<iewc:TreeNode NavigateUrl="WebForm5.aspx" ImageUrl="img/dian_11.gif" Text="汇总维护信息报表" Target="main"></iewc:TreeNode>
											</iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="denglu.aspx" ImageUrl="img/dian_1.gif" Text="注销" DefaultStyle="font-weight:bold;"
											Target="_parent"></iewc:TreeNode>
									</iewc:TreeView></td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
			<!-- <DIV style="Z-INDEX: 101; LEFT: 25px; POSITION: absolute; TOP: 31px; width: 100px;" ms_positioning="text2D">-->
			<p><A href="sbgl.aspx" target="main"></A><BR>
				<A href="Basicinfo.aspx" target="main"></A><font face="隶书">
					<BR>
					<A href="Admin.aspx" target="main"></A></font>
				<BR>
				<A href="Changjia.aspx" target="main"></A>
				<BR>
				<A href="Errorinfo.aspx" target="main"></A>
				<BR>
				<A href="Labname.aspx" target="main"></A><font face="隶书"><A href="Admin.aspx" target="main">
					</A></font>
				<BR>
				<A href="Sbname.aspx" target="main"></A>
				<BR>
				<A href="edit3.aspx" target="main"></A>
				<BR>
				<A href="denglu.aspx" target="_parent"></A>
			</p>
			<p><a href="add.aspx" target="main"></a></p>
			<!-- </DIV>-->
		</form>
	</body>
</HTML>
