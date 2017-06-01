<%@ Page language="c#" Codebehind="HTMLPage111.aspx.cs" AutoEventWireup="false" Inherits="html.HTMLPage111" %>
<%@ Register TagPrefix="iewc" Namespace="Microsoft.Web.UI.WebControls" Assembly="Microsoft.Web.UI.WebControls, Version=1.0.2.226, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>HTMLPage111</title>
		<SCRIPT language="javascript">
	<!-- 
		var lastSelectedIndex = -1;
		function switchstatus(itemName)
		{
			var item = document.getElementById('Item' + itemName);			
			if (item.style.display=='none')
			  {
				item.style.display = '';
			   }
			else
			  {
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
		<style type="text/css"> @import url( normal.css );  </style>
	</HEAD>
	<body background="img/blank.gif" leftmargin="0" topmargin="0" marginwidth="0" marginheight="0"
		MS_POSITIONING="GridLayout">
		<table width="151" border="0" cellspacing="0" cellpadding="0">
			<tr>
				<td>
					<form id="Form1" method="post" runat="server">
						<FONT face="宋体"></FONT>
						<table width="151" height="562" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td width="151" valign="top" background="img/01.jpg">
									<table width="141" height="365" border="0" cellpadding="0" cellspacing="0">
										<tr>
											<td height="15" colspan="2" class="font2">管理员面板</td>
										</tr>
										<tr>
											<td width="13" height="15">
												<img style="CURSOR: hand" onClick="javascript:switchstatus(1)" height="12" src="img/dian_1.gif"
													width="12" align="absMiddle" border="0"></td>
											<td width="128" height="15" class="font2"><A href="sbgl.aspx" target="main" class="font2">故障设备管理</A></td>
										</tr>
										<tr id="Item1" style="DISPLAY: none">
											<td height="15">&nbsp;</td>
											<td nowrap height="15">
												<table width="100%" border="0" cellspacing="0" cellpadding="0">
													<tr>
														<td width="9%"><img src="img/dian_1.gif" height="10" style="CURSOR: hand" onClick="javascript:switchstatus(5)"
																width="10" align="absMiddle" border="0"></td>
														<td width="91%" class="font"><A href="sbgl.aspx" target="main" class="font3">故障设备管理</A></td>
													</tr>
													<tr>
														<td>&nbsp;</td>
														<td class="font"><table width="100%" border="0" cellspacing="0" cellpadding="0">
																<tr id="Item5" style="DISPLAY: none">
																	<td width="10%"><img src="img/dian_11.gif" width="8" height="8"></td>
																	<td width="90%" class="font"><A href="add.aspx" target="main" class="font">故障设备添加 </A>
																	</td>
																</tr>
															</table>
														</td>
													</tr>
													<tr>
														<td><img height="10" src="img/dian_1.gif" width="10" align="absMiddle" border="0"></td>
														<td class="font"><a href="add.aspx" target="main" class="font3">故障类型</a></td>
													</tr>
													<tr>
														<td>&nbsp;</td>
														<td class="font"><table width="100%" border="0" cellspacing="0" cellpadding="0">
																<tr>
																	<td width="10%"><img src="img/dian_11.gif" width="8" height="8"></td>
																	<td width="90%" class="font">故障类型添加</td>
																</tr>
															</table>
														</td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td height="15"><img style="CURSOR: hand" onClick="javascript:switchstatus(2)" src="img/dian_1.gif" width="12"
													height="12" align="absMiddle" border="0">
											</td>
											<td height="15"><a href="Basicinfo.aspx" target="main" class="font2">基本设备管理</a></td>
										</tr>
										<tr id="Item2" style="DISPLAY:none">
											<td height="119"></td>
											<td height="119" valign="top"><table width="100%" border="0" cellspacing="0" cellpadding="0">
													<tr>
														<td width="10%"><img height="10" src="img/dian_1.gif" width="10" align="absMiddle" border="0"></td>
														<td width="90%" class="font"><a href="Errorinfo.aspx" target="main" class="font3">基本设备 </a>
														</td>
													</tr>
													<tr>
														<td>&nbsp;</td>
														<td><table width="100%" border="0" cellspacing="0" cellpadding="0">
																<tr>
																	<td width="11%" height="13"><img src="img/dian_11.gif" width="8" height="8"></td>
																	<td width="89%" class="font"><A href="add3.aspx" target="main" class="font">单个添加</A></td>
																</tr>
																<tr>
																	<td><img src="img/dian_11.gif" width="8" height="8"></td>
																	<td class="font"><a href="piliang.aspx" class="font" target="main">批量添加</a></td>
																</tr>
																<tr>
																	<td><img src="img/dian_11.gif" width="8" height="8"></td>
																	<td class="font"><a href="piliangxiugai.aspx" class="font" target="main">批量修改</a></td>
																</tr>
																<tr>
																	<td><img src="img/dian_11.gif" width="8" height="8"></td>
																	<td class="font"><a href="plliangdelete.aspx" class="font" target="main">批量删除</a></td>
																</tr>
															</table>
														</td>
													</tr>
													<tr>
														<td><img height="10" src="img/dian_1.gif" width="10" align="absMiddle" border="0"></td>
														<td class="font3">厂家名称</td>
													</tr>
													<tr>
														<td>&nbsp;</td>
														<td><table width="100%" border="0" cellspacing="0" cellpadding="0">
																<tr>
																	<td width="10%"><img src="img/dian_11.gif" width="8" height="8"></td>
																	<td width="90%" class="font"><a href="add4.aspx" target="main" class="font"> 厂家名称添加</a></td>
																</tr>
															</table>
														</td>
													</tr>
													<tr>
														<td><img height="10" src="img/dian_1.gif" width="10" align="absMiddle" border="0"></td>
														<td class="font3">实验室名称</td>
													</tr>
													<tr>
														<td>&nbsp;</td>
														<td><table width="100%" border="0" cellspacing="0" cellpadding="0">
																<tr>
																	<td width="10%"><img src="img/dian_11.gif" width="8" height="8"></td>
																	<td width="90%" class="font"><a href="add6.aspx" target="main" class="font"> 实验室名称添加</a></td>
																</tr>
															</table>
														</td>
													</tr>
													<tr>
														<td><img height="10" src="img/dian_1.gif" width="10" align="absMiddle" border="0"></td>
														<td class="font3">设备名称</td>
													</tr>
													<tr>
														<td>&nbsp;</td>
														<td><table width="100%" border="0" cellspacing="0" cellpadding="0">
																<tr>
																	<td width="10%"><img src="img/dian_11.gif" width="8" height="8"></td>
																	<td width="90%" class="font"><a href="add7.aspx" target="main" class="font"> 设备名称添加</a></td>
																</tr>
															</table>
														</td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td height="17"><font class="font2 STYLE1"></font> <img style="CURSOR: hand" onClick="javascript:switchstatus(3)" src="img/dian_1.gif" width="12"
													height="12" align="absMiddle" border="0"></td>
											<td height="17"><span class="font2">数据挖掘</span></td>
										</tr>
										<tr id="Item3" style="DISPLAY:none">
											<td height="15">&nbsp;</td>
											<td height="15" class="font2"><table width="100%" border="0" cellspacing="0" cellpadding="0">
													<tr>
														<td width="9%"><img height="10" src="img/dian_1.gif" width="10" align="absMiddle" border="0"></td>
														<td width="91%"><A href="../WebService1/jueceshijian.aspx" target="main" class="font3">决策树算法</A></td>
													</tr>
													<tr>
														<td>&nbsp;</td>
														<td><table width="100%" border="0" cellspacing="0" cellpadding="0">
																<tr>
																	<td width="9%"><img src="img/dian_11.gif" width="8" height="8"></td>
																	<td width="89%" class="font"><A href="../WebService1/jueceshijian.aspx" target="main" class="font">设备故障率预测</A></td>
																</tr>
																<tr>
																	<td><img src="img/dian_11.gif" width="8" height="8"></td>
																	<td class="font"><a href="../WebService1/shouming.aspx" target="main" class="font">单个故障时间预测</a></td>
																</tr>
																<tr>
																	<td><img src="img/dian_11.gif" width="8" height="8"></td>
																	<td class="font"><A href="../WebService1/shouming.aspx" target="main" class="font">批量故障时间预测</A></td>
																</tr>
															</table>
														</td>
													</tr>
													<tr>
														<td><img src="img/dian_11.gif" width="8" height="8"></td>
														<td><A href="../WebService1/shouming.aspx" target="main" class="font3"><a href="../WebService1/shijianxulie.aspx" target="main" class="font">时间序列算法</a></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td height="14"><img style="CURSOR: hand" onClick="javascript:switchstatus(4)" src="img/dian_1.gif" width="12"
													height="12" align="absMiddle" border="0"><A class="font2" href="Admin.aspx" target="main"></A></td>
											<td height="14"><A class="font2" href="Admin.aspx" target="main">管理员信息</A></td>
										</tr>
										<tr id="item4" style="DISPLAY:none">
											<td height="15">&nbsp;</td>
											<td height="15"><font class="font2 STYLE1"><A class="font2" href="edit3.aspx" target="main"></A></font>
												<table width="100%" border="0" cellspacing="0" cellpadding="0">
													<tr>
														<td><img src="img/dian_11.gif" width="8" height="8"></td>
														<td width="89%" class="font"><A href="add8.aspx" target="main" class="font3">添加管理员</A></td>
													</tr>
													<tr>
														<td><img src="img/dian_11.gif" width="8" height="8"></td>
														<td class="font"><A href="Userid.aspx" target="main" class="font3">浏览用户信息</A></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td height="15">&nbsp;</td>
											<td height="15"><font class="font2 STYLE1"><A class="font2" href="denglu.aspx" target="_parent">注销</A></font></td>
										</tr>
										<tr>
											<td height="15">&nbsp;</td>
											<td height="15"><font class="font2 STYLE1"><A class="font2" href="denglu.aspx" target="_parent"></A><a href="edit3.aspx" target="main" class="font2"></a></font></td>
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
				</td>
			</tr>
		</table>
		<iewc:TreeView id="TreeView1" style="Z-INDEX: 101; LEFT: 224px; POSITION: absolute; TOP: 40px"
			runat="server" Height="216px" Width="120px">
			<iewc:TreeNode Text="故障设备管理">
				<iewc:TreeNode NavigateUrl="sbgl.aspx" Text="故障设备管理" Target="main">
					<iewc:TreeNode NavigateUrl="add.aspx" Text="故障设备添加" Target="main"></iewc:TreeNode>
				</iewc:TreeNode>
			</iewc:TreeNode>
		</iewc:TreeView>
	</body>
</HTML>
