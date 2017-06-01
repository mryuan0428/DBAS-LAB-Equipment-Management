using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace html
{
	/// <summary>
	/// tijiaodingdan 的摘要说明。
	/// </summary>
	public class tijiaodingdan : System.Web.UI.Page
	{
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter2;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand2;
		protected System.Web.UI.HtmlControls.HtmlForm Form1;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.Label Label6;
		protected System.Web.UI.WebControls.Label Label7;
		protected System.Web.UI.WebControls.Table Table4;
		protected System.Web.UI.WebControls.Label Label8;
		protected System.Data.DataSet dataSet1;
		protected System.Data.DataSet dataSet2;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand3;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand2;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter3;
		protected System.Data.DataSet dataSet3;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter4;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand4;
		protected System.Data.DataSet dataSet4;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand5;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand3;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter5;
		protected System.Web.UI.WebControls.Label Label9;
		protected System.Web.UI.WebControls.Label Label10;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			string name=Session["name"].ToString();
			this.Label1.Text=name;

			string sql1="select * from 用户 where 用户名='";
			sql1+=name;
			
			sql1+="'";
			this.sqlDataAdapter2.SelectCommand.CommandText=sql1;
			this.sqlDataAdapter2.SelectCommand.Connection=this.sqlConnection1;
			this.sqlConnection1.Open();
			this.sqlDataAdapter2.SelectCommand.ExecuteNonQuery();
			this.sqlConnection1.Close();

			this.dataSet2.Clear();
			this.sqlDataAdapter2.Fill(this.dataSet2);
			this.Label2.Text=this.dataSet2.Tables["用户"].Rows[0]["用户类型"].ToString();
			this.Label3.Text=this.dataSet2.Tables["用户"].Rows[0]["性别"].ToString();
			this.Label4.Text=this.dataSet2.Tables["用户"].Rows[0]["生日"].ToString();
			this.Label5.Text=this.dataSet2.Tables["用户"].Rows[0]["手机号"].ToString();
			this.Label6.Text=this.dataSet2.Tables["用户"].Rows[0]["邮箱"].ToString();
			this.Label7.Text=this.dataSet2.Tables["用户"].Rows[0]["住址"].ToString();
			
			string sql="select * from 订单详细 where 用户ID=";
			sql+=this.dataSet2.Tables["用户"].Rows[0]["用户ID"].ToString();
			sql+=" and 订单号=27";

			this.sqlDataAdapter1.SelectCommand.CommandText=sql;
			this.sqlDataAdapter1.SelectCommand.Connection=this.sqlConnection1;
			this.sqlConnection1.Open();
			this.sqlDataAdapter1.SelectCommand.ExecuteNonQuery();
			this.sqlConnection1.Close();

			this.dataSet1.Clear();
			this.sqlDataAdapter1.Fill(this.dataSet1);
			
			for(int i=0;i<this.dataSet1.Tables["订单详细"].Rows.Count;i++)
			{
				TableRow row=new TableRow();
				TableCell cell1=new TableCell();
				string sql2="select 货物名称 from 库存货物 where 货物号="+this.dataSet1.Tables["订单详细"].Rows[i]["货物号"].ToString();
				this.sqlDataAdapter3.SelectCommand.CommandText=sql2;
				this.sqlDataAdapter3.SelectCommand.Connection=this.sqlConnection1;
				this.sqlConnection1.Open();
				this.sqlDataAdapter3.SelectCommand.ExecuteNonQuery();
				this.sqlConnection1.Close();

				this.dataSet3.Clear();
				this.sqlDataAdapter3.Fill(this.dataSet3);
				cell1.Text=this.dataSet3.Tables["库存货物"].Rows[0]["货物名称"].ToString();
				row.Cells.Add(cell1);

				TableCell cell2=new TableCell();
				cell2.Text=this.dataSet1.Tables["订单详细"].Rows[i]["数量"].ToString();
				row.Cells.Add(cell2);

				TableCell cell3=new TableCell();
				cell3.Text=this.dataSet1.Tables["订单详细"].Rows[i]["订购日期"].ToString();
				row.Cells.Add(cell3);

				TableCell cell4=new TableCell();
				cell4.Text=this.dataSet1.Tables["订单详细"].Rows[i]["金额"].ToString();
				row.Cells.Add(cell4);
				this.Table4.Rows.Add(row);

				double num=0;
				for(int j=0;j<this.dataSet1.Tables["订单详细"].Rows.Count;j++)
				{
					num=num+Convert.ToInt32(this.dataSet1.Tables["订单详细"].Rows[j]["金额"]);
				}
				this.Label10.Text=num.ToString();
			}
		}

		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{    
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter2 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
			this.dataSet1 = new System.Data.DataSet();
			this.dataSet2 = new System.Data.DataSet();
			this.sqlSelectCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter3 = new System.Data.SqlClient.SqlDataAdapter();
			this.dataSet3 = new System.Data.DataSet();
			this.sqlDataAdapter4 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand4 = new System.Data.SqlClient.SqlCommand();
			this.dataSet4 = new System.Data.DataSet();
			this.sqlSelectCommand5 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand3 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
			this.sqlDataAdapter5 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "订单详细", new System.Data.Common.DataColumnMapping[] {
																																																			  new System.Data.Common.DataColumnMapping("订单号", "订单号"),
																																																			  new System.Data.Common.DataColumnMapping("货物号", "货物号"),
																																																			  new System.Data.Common.DataColumnMapping("数量", "数量"),
																																																			  new System.Data.Common.DataColumnMapping("订购日期", "订购日期"),
																																																			  new System.Data.Common.DataColumnMapping("金额", "金额"),
																																																			  new System.Data.Common.DataColumnMapping("用户ID", "用户ID")})});
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO 订单详细(订单号, 货物号, 数量, 订购日期, 金额, 用户ID) VALUES (@订单号, @货物号, @数量, @订购日期, @金" +
				"额, @用户ID); SELECT 订单号, 货物号, 数量, 订购日期, 金额, 用户ID FROM 订单详细";
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@订单号", System.Data.SqlDbType.BigInt, 8, "订单号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@货物号", System.Data.SqlDbType.BigInt, 8, "货物号"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@数量", System.Data.SqlDbType.Int, 4, "数量"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@订购日期", System.Data.SqlDbType.DateTime, 8, "订购日期"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@金额", System.Data.SqlDbType.Money, 8, "金额"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@用户ID", System.Data.SqlDbType.BigInt, 8, "用户ID"));
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 订单号, 货物号, 数量, 订购日期, 金额, 用户ID FROM 订单详细";
			// 
			// sqlDataAdapter2
			// 
			this.sqlDataAdapter2.SelectCommand = this.sqlSelectCommand2;
			this.sqlDataAdapter2.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "用户", new System.Data.Common.DataColumnMapping[] {
																																																			new System.Data.Common.DataColumnMapping("用户名", "用户名"),
																																																			new System.Data.Common.DataColumnMapping("用户类型", "用户类型"),
																																																			new System.Data.Common.DataColumnMapping("性别", "性别"),
																																																			new System.Data.Common.DataColumnMapping("真实姓名", "真实姓名"),
																																																			new System.Data.Common.DataColumnMapping("生日", "生日"),
																																																			new System.Data.Common.DataColumnMapping("住址", "住址"),
																																																			new System.Data.Common.DataColumnMapping("手机号", "手机号"),
																																																			new System.Data.Common.DataColumnMapping("邮箱", "邮箱")})});
			// 
			// sqlSelectCommand2
			// 
			this.sqlSelectCommand2.CommandText = "SELECT 用户名, 用户类型, 性别, 真实姓名, 生日, 住址, 手机号, 邮箱 FROM 用户";
			// 
			// dataSet1
			// 
			this.dataSet1.DataSetName = "NewDataSet";
			this.dataSet1.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// dataSet2
			// 
			this.dataSet2.DataSetName = "NewDataSet";
			this.dataSet2.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// sqlSelectCommand3
			// 
			this.sqlSelectCommand3.CommandText = "SELECT 货物类型号1, 货物类型号2, 货物号, 货物名称, 数量, 单价, 点击率, 描述 FROM 库存货物";
			// 
			// sqlInsertCommand2
			// 
			this.sqlInsertCommand2.CommandText = "INSERT INTO 库存货物(货物类型号1, 货物类型号2, 货物名称, 数量, 单价, 点击率, 描述) VALUES (@货物类型号1, @货物类型号2," +
				" @货物名称, @数量, @单价, @点击率, @描述); SELECT 货物类型号1, 货物类型号2, 货物号, 货物名称, 数量, 单价, 点击率, 描述 " +
				"FROM 库存货物 WHERE (货物号 = @@IDENTITY)";
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@货物类型号1", System.Data.SqlDbType.BigInt, 8, "货物类型号1"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@货物类型号2", System.Data.SqlDbType.BigInt, 8, "货物类型号2"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@货物名称", System.Data.SqlDbType.VarChar, 20, "货物名称"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@数量", System.Data.SqlDbType.BigInt, 8, "数量"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@单价", System.Data.SqlDbType.Money, 8, "单价"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@点击率", System.Data.SqlDbType.Int, 4, "点击率"));
			this.sqlInsertCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@描述", System.Data.SqlDbType.VarChar, 1000, "描述"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = @"UPDATE 库存货物 SET 货物类型号1 = @货物类型号1, 货物类型号2 = @货物类型号2, 货物名称 = @货物名称, 数量 = @数量, 单价 = @单价, 点击率 = @点击率, 描述 = @描述 WHERE (货物号 = @Original_货物号) AND (单价 = @Original_单价 OR @Original_单价 IS NULL AND 单价 IS NULL) AND (描述 = @Original_描述 OR @Original_描述 IS NULL AND 描述 IS NULL) AND (数量 = @Original_数量 OR @Original_数量 IS NULL AND 数量 IS NULL) AND (点击率 = @Original_点击率 OR @Original_点击率 IS NULL AND 点击率 IS NULL) AND (货物名称 = @Original_货物名称) AND (货物类型号1 = @Original_货物类型号1) AND (货物类型号2 = @Original_货物类型号2); SELECT 货物类型号1, 货物类型号2, 货物号, 货物名称, 数量, 单价, 点击率, 描述 FROM 库存货物 WHERE (货物号 = @货物号)";
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@货物类型号1", System.Data.SqlDbType.BigInt, 8, "货物类型号1"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@货物类型号2", System.Data.SqlDbType.BigInt, 8, "货物类型号2"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@货物名称", System.Data.SqlDbType.VarChar, 20, "货物名称"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@数量", System.Data.SqlDbType.BigInt, 8, "数量"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@单价", System.Data.SqlDbType.Money, 8, "单价"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@点击率", System.Data.SqlDbType.Int, 4, "点击率"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@描述", System.Data.SqlDbType.VarChar, 1000, "描述"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_货物号", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "货物号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_单价", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "单价", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_描述", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "描述", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_数量", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "数量", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_点击率", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "点击率", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_货物名称", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "货物名称", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_货物类型号1", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "货物类型号1", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_货物类型号2", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "货物类型号2", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@货物号", System.Data.SqlDbType.BigInt, 8, "货物号"));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = @"DELETE FROM 库存货物 WHERE (货物号 = @Original_货物号) AND (单价 = @Original_单价 OR @Original_单价 IS NULL AND 单价 IS NULL) AND (描述 = @Original_描述 OR @Original_描述 IS NULL AND 描述 IS NULL) AND (数量 = @Original_数量 OR @Original_数量 IS NULL AND 数量 IS NULL) AND (点击率 = @Original_点击率 OR @Original_点击率 IS NULL AND 点击率 IS NULL) AND (货物名称 = @Original_货物名称) AND (货物类型号1 = @Original_货物类型号1) AND (货物类型号2 = @Original_货物类型号2)";
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_货物号", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "货物号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_单价", System.Data.SqlDbType.Money, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "单价", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_描述", System.Data.SqlDbType.VarChar, 1000, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "描述", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_数量", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "数量", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_点击率", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "点击率", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_货物名称", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "货物名称", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_货物类型号1", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "货物类型号1", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_货物类型号2", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "货物类型号2", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter3
			// 
			this.sqlDataAdapter3.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter3.InsertCommand = this.sqlInsertCommand2;
			this.sqlDataAdapter3.SelectCommand = this.sqlSelectCommand3;
			this.sqlDataAdapter3.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "库存货物", new System.Data.Common.DataColumnMapping[] {
																																																			  new System.Data.Common.DataColumnMapping("货物类型号1", "货物类型号1"),
																																																			  new System.Data.Common.DataColumnMapping("货物类型号2", "货物类型号2"),
																																																			  new System.Data.Common.DataColumnMapping("货物号", "货物号"),
																																																			  new System.Data.Common.DataColumnMapping("货物名称", "货物名称"),
																																																			  new System.Data.Common.DataColumnMapping("数量", "数量"),
																																																			  new System.Data.Common.DataColumnMapping("单价", "单价"),
																																																			  new System.Data.Common.DataColumnMapping("点击率", "点击率"),
																																																			  new System.Data.Common.DataColumnMapping("描述", "描述")})});
			this.sqlDataAdapter3.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// dataSet3
			// 
			this.dataSet3.DataSetName = "NewDataSet";
			this.dataSet3.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// sqlDataAdapter4
			// 
			this.sqlDataAdapter4.SelectCommand = this.sqlSelectCommand4;
			// 
			// sqlSelectCommand4
			// 
			this.sqlSelectCommand4.CommandText = "INSERT INTO\r\n    订单(\r\n        用户ID, \r\n        日期, \r\n        订单号\r\n    )\r\nVALUES(\r\n" +
				"    , \r\n    \r\n)\r\n";
			// 
			// dataSet4
			// 
			this.dataSet4.DataSetName = "NewDataSet";
			this.dataSet4.Locale = new System.Globalization.CultureInfo("zh-CN");
			// 
			// sqlSelectCommand5
			// 
			this.sqlSelectCommand5.CommandText = "SELECT 用户ID, 日期, 订单号 FROM 订单";
			// 
			// sqlInsertCommand3
			// 
			this.sqlInsertCommand3.CommandText = "INSERT INTO 订单(用户ID, 日期) VALUES (@用户ID, @日期); SELECT 用户ID, 日期, 订单号 FROM 订单 WHERE " +
				"(订单号 = @@IDENTITY)";
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@用户ID", System.Data.SqlDbType.BigInt, 8, "用户ID"));
			this.sqlInsertCommand3.Parameters.Add(new System.Data.SqlClient.SqlParameter("@日期", System.Data.SqlDbType.DateTime, 4, "日期"));
			// 
			// sqlUpdateCommand2
			// 
			this.sqlUpdateCommand2.CommandText = "UPDATE 订单 SET 用户ID = @用户ID, 日期 = @日期 WHERE (订单号 = @Original_订单号) AND (日期 = @Origi" +
				"nal_日期) AND (用户ID = @Original_用户ID); SELECT 用户ID, 日期, 订单号 FROM 订单 WHERE (订单号 = @" +
				"订单号)";
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@用户ID", System.Data.SqlDbType.BigInt, 8, "用户ID"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@日期", System.Data.SqlDbType.DateTime, 4, "日期"));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_订单号", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "订单号", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_日期", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "日期", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_用户ID", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "用户ID", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@订单号", System.Data.SqlDbType.BigInt, 8, "订单号"));
			// 
			// sqlDeleteCommand2
			// 
			this.sqlDeleteCommand2.CommandText = "DELETE FROM 订单 WHERE (订单号 = @Original_订单号) AND (日期 = @Original_日期) AND (用户ID = @O" +
				"riginal_用户ID)";
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_订单号", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "订单号", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_日期", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "日期", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand2.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_用户ID", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "用户ID", System.Data.DataRowVersion.Original, null));
			// 
			// sqlDataAdapter5
			// 
			this.sqlDataAdapter5.DeleteCommand = this.sqlDeleteCommand2;
			this.sqlDataAdapter5.InsertCommand = this.sqlInsertCommand3;
			this.sqlDataAdapter5.SelectCommand = this.sqlSelectCommand5;
			this.sqlDataAdapter5.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "订单", new System.Data.Common.DataColumnMapping[] {
																																																			new System.Data.Common.DataColumnMapping("用户ID", "用户ID"),
																																																			new System.Data.Common.DataColumnMapping("日期", "日期"),
																																																			new System.Data.Common.DataColumnMapping("订单号", "订单号")})});
			this.sqlDataAdapter5.UpdateCommand = this.sqlUpdateCommand2;
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=BDA852BA3F45426;packet size=4096;integrated security=SSPI;data sou" +
				"rce=BDA852BA3F45426;persist security info=True;initial catalog=gouwu";
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			double num=0;
			for(int i=0;i<this.dataSet1.Tables["订单详细"].Rows.Count;i++)
			{
				num=num+Convert.ToInt32(this.dataSet1.Tables["订单详细"].Rows[i]["金额"]);
			}

			string time=DateTime.Now.ToString();
			string sql="insert into 订单(用户ID,日期,总金额,已付款) values("+this.dataSet1.Tables["订单详细"].Rows[0]["用户ID"].ToString()+",'"+
				time+"',"+num+",'未付款')";
			this.sqlDataAdapter4.SelectCommand.CommandText=sql;
			this.sqlDataAdapter4.SelectCommand.Connection=this.sqlConnection1;
			this.sqlConnection1.Open();
			this.sqlDataAdapter4.SelectCommand.ExecuteNonQuery();
			this.sqlConnection1.Close();


			string sql1="select 订单号 from 订单 where 日期='"+time+"' and 用户ID="+this.dataSet1.Tables["订单详细"].Rows[0]["用户ID"].ToString();
			this.sqlDataAdapter5.SelectCommand.CommandText=sql1;
			this.sqlDataAdapter5.SelectCommand.Connection=this.sqlConnection1;
			this.sqlConnection1.Open();
			this.sqlDataAdapter5.SelectCommand.ExecuteNonQuery();
			this.sqlConnection1.Close();

			
			this.sqlDataAdapter5.Fill(this.dataSet4);

			string sql2="update 订单详细 set 订单号="+this.dataSet4.Tables["订单"].Rows[0]["订单号"].ToString()+" where 订单号=27";
			this.sqlDataAdapter1.SelectCommand.CommandText=sql2;
			this.sqlDataAdapter1.SelectCommand.Connection=this.sqlConnection1;
			this.sqlConnection1.Open();
			this.sqlDataAdapter1.SelectCommand.ExecuteNonQuery();
			this.sqlConnection1.Close();
			Response.Write("<script>alert('您已经生成了本次购物的订单');</script>");
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("yonghu.asp?name11="+Request.QueryString["name11"]+"&pwd1="+Request.QueryString["pwd1"]);
		}
	}
}
