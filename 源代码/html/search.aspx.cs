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
using C1.Web.C1WebChart;
using C1.Web.C1WebChartBase;
using C1.Win.C1Chart;

namespace html
{
	/// <summary>
	/// search 的摘要说明。
	/// </summary>
	public class search : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DropDownList DropDownList1;
		protected System.Web.UI.WebControls.DropDownList DropDownList2;
		protected System.Web.UI.WebControls.DropDownList DropDownList3;
		protected System.Web.UI.WebControls.DropDownList DropDownList4;
		protected System.Web.UI.WebControls.DropDownList DropDownList5;
		protected System.Web.UI.WebControls.DropDownList DropDownList6;
		protected System.Web.UI.WebControls.DropDownList DropDownList7;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
		protected System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		protected html.DataSet1 dataSet11;
		protected C1.Web.C1WebChart.C1WebChart C1WebChart1;
        
		public string s;
		private void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			if(!Page.IsPostBack)
			{
				/*string sql="select * from changjia";
				this.sqlDataAdapter1.SelectCommand.Connection=this.sqlConnection1;
				this.sqlDataAdapter1.SelectCommand.CommandText=sql;
				this.sqlConnection1.Open();
				this.sqlDataAdapter1.SelectCommand.ExecuteNonQuery();
				this.sqlConnection1.Close();

				this.dataSet11.Clear();
				this.sqlDataAdapter1.Fill(this.dataSet11,"changjia");

				for(int i=0;i<this.dataSet11.Tables["changjia"].Rows.Count;i++)
				{
					this.DropDownList1.Items.Add(new ListItem(this.dataSet11.Tables["changjia"].Rows[i]["厂家名称"].ToString()));
				}*/

				string sql="select * from sbname";
				this.sqlDataAdapter1.SelectCommand.Connection=this.sqlConnection1;
				this.sqlDataAdapter1.SelectCommand.CommandText=sql;
				this.sqlConnection1.Open();
				this.sqlDataAdapter1.SelectCommand.ExecuteNonQuery();
				this.sqlConnection1.Close();

				this.dataSet11.Clear();
				this.sqlDataAdapter1.Fill(this.dataSet11,"sbname");

				for(int i=0;i<this.dataSet11.Tables["sbname"].Rows.Count;i++)
				{
					this.DropDownList2.Items.Add(new ListItem(this.dataSet11.Tables["sbname"].Rows[i]["设备名称"].ToString()));
				}
				
				DateTime date=DateTime.Now;
				for(int i=2000;i<=Int32.Parse(date.Year.ToString());i++)
				{
					this.DropDownList1.Items.Add(new ListItem(i.ToString()));
				}
				for(int i=1;i<=12;i++)
				{
					this.DropDownList3.Items.Add(new ListItem(i.ToString()));
				}
				for(int i=1;i<=31;i++)
				{
					this.DropDownList4.Items.Add(new ListItem(i.ToString()));
				}
				for(int i=2000;i<=Int32.Parse(date.Year.ToString());i++)
				{
					this.DropDownList5.Items.Add(new ListItem(i.ToString()));
				}
				for(int i=1;i<=12;i++)
				{
					this.DropDownList6.Items.Add(new ListItem(i.ToString()));
				}
				for(int i=1;i<=31;i++)
				{
					this.DropDownList7.Items.Add(new ListItem(i.ToString()));
				}
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
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.dataSet11 = new html.DataSet1();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.C1WebChart1.DrawDataSeries += new C1.Win.C1Chart.DrawDataSeriesEventHandler(this.C1WebChart1_DrawDataSeries);
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT 厂家id, 厂家名称 FROM changjia";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO changjia(厂家名称) VALUES (@厂家名称); SELECT 厂家id, 厂家名称 FROM changjia WHERE " +
				"(厂家id = @@IDENTITY)";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@厂家名称", System.Data.SqlDbType.VarChar, 10, "厂家名称"));
			// 
			// sqlUpdateCommand1
			// 
			this.sqlUpdateCommand1.CommandText = "UPDATE changjia SET 厂家名称 = @厂家名称 WHERE (厂家id = @Original_厂家id) AND (厂家名称 = @Origi" +
				"nal_厂家名称 OR @Original_厂家名称 IS NULL AND 厂家名称 IS NULL); SELECT 厂家id, 厂家名称 FROM cha" +
				"ngjia WHERE (厂家id = @厂家id)";
			this.sqlUpdateCommand1.Connection = this.sqlConnection1;
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@厂家名称", System.Data.SqlDbType.VarChar, 10, "厂家名称"));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_厂家id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "厂家id", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_厂家名称", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "厂家名称", System.Data.DataRowVersion.Original, null));
			this.sqlUpdateCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@厂家id", System.Data.SqlDbType.Int, 4, "厂家id"));
			// 
			// sqlDeleteCommand1
			// 
			this.sqlDeleteCommand1.CommandText = "DELETE FROM changjia WHERE (厂家id = @Original_厂家id) AND (厂家名称 = @Original_厂家名称 OR " +
				"@Original_厂家名称 IS NULL AND 厂家名称 IS NULL)";
			this.sqlDeleteCommand1.Connection = this.sqlConnection1;
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_厂家id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "厂家id", System.Data.DataRowVersion.Original, null));
			this.sqlDeleteCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@Original_厂家名称", System.Data.SqlDbType.VarChar, 10, System.Data.ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "厂家名称", System.Data.DataRowVersion.Original, null));
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.ConnectionString = "workstation id=\"559-BDAE3A45AA0\";packet size=4096;integrated security=SSPI;data s" +
				"ource=\"559-BDAE3A45AA0\";persist security info=False;initial catalog=jfgl";
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "changjia", new System.Data.Common.DataColumnMapping[] {
																																																				  new System.Data.Common.DataColumnMapping("厂家id", "厂家id"),
																																																				  new System.Data.Common.DataColumnMapping("厂家名称", "厂家名称")})});
			this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();

		}
		#endregion

		private void C1WebChart1_DrawDataSeries(object sender, C1.Win.C1Chart.DrawDataSeriesEventArgs e)
		{
			C1.Win.C1Chart.ChartDataSeries ds = (ChartDataSeries)sender;

			Color clr1 = ds.LineStyle.Color;

			Color clr2 = ds.SymbolStyle.Color;

			if(e.Bounds.Size.Height > 0 && e.Bounds.Size.Width > 0)
			{

				System.Drawing.Drawing2D.LinearGradientBrush lgb =

					new System.Drawing.Drawing2D.LinearGradientBrush(e.Bounds, clr1, clr2, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);

				e.Brush = lgb;

			}
		}

		private void Button1_Click(object sender, System.EventArgs e)
		{
			string start,sb,end;
			//cj=this.DropDownList1.SelectedValue.ToString().Trim();
			sb=this.DropDownList2.SelectedValue.ToString().Trim();

			start=this.DropDownList1.SelectedValue.ToString().Trim()+"-"+this.DropDownList3.SelectedValue.ToString().Trim()+"-"+this.DropDownList4.SelectedValue.ToString().Trim();
			end=this.DropDownList5.SelectedValue.ToString().Trim()+"-"+this.DropDownList6.SelectedValue.ToString().Trim()+"-"+this.DropDownList7.SelectedValue.ToString().Trim();

			localhost.Service1 MyService=new localhost.Service1();
			s=MyService.CreateTree(sb,start,end);
			double unit = 0;
			//C1WebChart1.Header.Text="";
			//C1WebChart1.Footer.Text="Chart 尾";
			//C1WebChart1.BackColor = Color.LightSteelBlue;
			//
			if(s.Length==0)return;
			//C1WebChart1.Reset();
			C1WebChart1.Visible=true;
			C1WebChart1.ImageFormat = System.Drawing.Imaging.ImageFormat.Png;
			C1WebChart1.ImageRenderMethod = ImageRenderMethodEnum.HttpHandler;

			
			//C1WebChart1.ChartGroups.Group0.ChartType = Chart2DTypeEnum.Pie;
			this.GetPieData();
			string sql="select * from changjia";
			this.sqlDataAdapter1.SelectCommand.Connection=this.sqlConnection1;
			this.sqlDataAdapter1.SelectCommand.CommandText=sql;

			this.sqlConnection1.Open();
			this.sqlDataAdapter1.SelectCommand.ExecuteNonQuery();
			this.sqlConnection1.Close();

			this.dataSet11.Clear();
			this.sqlDataAdapter1.Fill(this.dataSet11,"changjia");
		}
		public void AddAxisX()
		{
			
			
			// label x axis with product names
			Axis ax = C1WebChart1.ChartArea.AxisX;
			ax.ValueLabels.Clear();
			
			
			ax.AnnoMethod = AnnotationMethodEnum.ValueLabels;
			for(int i = 0; i < 100; i++)
			{
				//DataRowView drv = dv[i];
				ax.ValueLabels.Add(i, (i+1).ToString());
			}
			try
			{
				ax.Max = 10 - .5;
			}
			catch {}
			
		}
		public void GetPieData()
		{
			// get dataset (from db or cache)
			//DataSet ds = GetDataSet();
    
			// filter the data
			//			DataView dv = new DataView(ds.Tables["Sales"]);
			//			dv.RowFilter = "ProductSales >= 40000";
			//			dv.Sort = "ProductSales";
			//		    
			// create an array of data points
			C1WebChart1.Legend.Visible = true;
			this.AddAxisX();
			//this.AddAxisY();
			string sql="select * from changjia";
			this.sqlDataAdapter1.SelectCommand.Connection=this.sqlConnection1;
			this.sqlDataAdapter1.SelectCommand.CommandText=sql;

			this.sqlConnection1.Open();
			this.sqlDataAdapter1.SelectCommand.ExecuteNonQuery();
			this.sqlConnection1.Close();

			this.dataSet11.Clear();
			this.sqlDataAdapter1.Fill(this.dataSet11,"changjia");

			int count=this.dataSet11.Tables["changjia"].Rows.Count;
			PointF[] data = new PointF[count];
			/*for (int i = 0; i < data.Length; i++)
			{
				float y = float.Parse((3*i+5).ToString());
				data[i] = new PointF(i, y);
			}*/
			for(int i=0;i<this.dataSet11.Tables["changjia"].Rows.Count;i++)
			{
				int j=s.IndexOf(this.dataSet11.Tables["changjia"].Rows[i]["厂家名称"].ToString(),0,s.Length);
				int l=s.IndexOf("%",j,s.Length-j);
				int m=s.IndexOf(":",j,l-j);
				string s1=s.Substring(m+1,l-m-1);
				float y=float.Parse(s1);
				data[i]=new PointF(i,y);
			}

			ChartDataSeriesCollection dscoll = C1WebChart1.ChartGroups[0].ChartData.SeriesList;			

			dscoll.Clear();

			C1WebChart1.ChartLabels.LabelsCollection.Clear();
			for(int i=0; i < data.Length; i++)
			{
				//ChartDataSeries series = C1WebChart1.ChartGroups[0].ChartData.SeriesList[i];
				//series.PointData.CopyDataIn(data);// 这里的data是PointF类型
				ChartDataSeries series = dscoll.AddNewSeries();
				series.PointData.Length = 1;
				series.Y[0] = data[i].Y;
				series.Label=this.dataSet11.Tables["changjia"].Rows[i]["厂家名称"].ToString();



				//加标签
				C1.Win.C1Chart.Label lbl = C1WebChart1.ChartLabels.LabelsCollection.AddNewLabel();
				int j=s.IndexOf(this.dataSet11.Tables["changjia"].Rows[i]["厂家名称"].ToString(),0,s.Length);
				int l=s.IndexOf("%",j,s.Length-j);
				int m=s.IndexOf(":",j,l-j);
				
				//float y=s.Substring(m+1,l-m-1);
				lbl.Text="";
				lbl.Text = s.Substring(m+1,l-m);
				lbl.Compass = LabelCompassEnum.Radial;
				lbl.Offset = 20;
				lbl.Connected = true;
				lbl.Visible = true;
				lbl.AttachMethod = AttachMethodEnum.DataIndex;
				AttachMethodData am = lbl.AttachMethodData;
				am.GroupIndex  = 0;
				am.SeriesIndex = i;
				am.PointIndex  = 0;

				//				C1WebChart1.ChartLabels.LabelsCollection.
				
				

			}

			///////C1WebChart1.ChartGroups[0].ChartData.SeriesList[0].Label="1数量";
			//C1WebChart1.ChartGroups[0].ChartData.SeriesList[1].Label="2质量";
			/*C1WebChart1.ChartGroups[0].ChartData.SeriesList[2].Label="3效益";
			C1WebChart1.ChartGroups[0].ChartData.SeriesList[3].Label="4效率";*/
			
			//C1WebChart1.ChartGroups.Group0.ChartData.SeriesList[0].LineStyle.Thickness = 100;
			///////////C1WebChart1.ChartGroups.Group0.Stacked=false;
			//C1WebChart1.ChartArea.PlotArea.GradientStyle=C1.Win.C1Chart.GradientStyleEnum.VerticalCenter;
			
		}
	}
}
