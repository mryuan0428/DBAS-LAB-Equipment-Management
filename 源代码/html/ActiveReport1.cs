using System;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace html
{
	public class ActiveReport1 : ActiveReport
	{
		Class1 db1;
		public ActiveReport1()
		{
			db1=new Class1();
			InitializeReport();
		}

		public void SetDb(Class1 db)
		{
			this.db1=db;
		}
		private void Detail_Format(object sender, System.EventArgs eArgs)
		{
			
		}

		private void ActiveReport1_DataInitialize(object sender, System.EventArgs eArgs)
		{
			
			this.DataSource=db1.getdata();
			//((DataDynamics.ActiveReports.DataSources.SqlDBDataSource)(this.DataSource));
			/*Fields.Add("设备编号");
			Fields.Add("出厂日期");
			Fields.Add("厂家名称");
			Fields.Add("实验室名");
			Fields.Add("设备名称");*/
			//Session["name"]="name";
		}

		private void ActiveReport1_ReportStart(object sender, System.EventArgs eArgs)
		{
			
		}

		#region ActiveReports Designer generated code
		private PageHeader PageHeader = null;
		private Label Label1 = null;
		private Label Label5 = null;
		private Label Label4 = null;
		private Label Label3 = null;
		private Label Label2 = null;
		private Detail Detail = null;
		private TextBox TextBox1 = null;
		private TextBox TextBox2 = null;
		private TextBox TextBox3 = null;
		private TextBox TextBox4 = null;
		private TextBox TextBox5 = null;
		private PageFooter PageFooter = null;
		public void InitializeReport()
		{
			this.LoadLayout(this.GetType(), "html.ActiveReport1.rpx");
			this.PageHeader = ((DataDynamics.ActiveReports.PageHeader)(this.Sections["PageHeader"]));
			this.Detail = ((DataDynamics.ActiveReports.Detail)(this.Sections["Detail"]));
			this.PageFooter = ((DataDynamics.ActiveReports.PageFooter)(this.Sections["PageFooter"]));
			this.Label1 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[0]));
			this.Label5 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[1]));
			this.Label4 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[2]));
			this.Label3 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[3]));
			this.Label2 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[4]));
			this.TextBox1 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[0]));
			this.TextBox2 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[1]));
			this.TextBox3 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[2]));
			this.TextBox4 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[3]));
			this.TextBox5 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[4]));
			// Attach Report Events
			this.Detail.Format += new System.EventHandler(this.Detail_Format);
			this.DataInitialize += new System.EventHandler(this.ActiveReport1_DataInitialize);
			this.ReportStart += new System.EventHandler(this.ActiveReport1_ReportStart);
		}

		#endregion
	}
}
