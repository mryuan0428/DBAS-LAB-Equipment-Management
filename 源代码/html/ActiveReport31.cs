using System;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace html
{
	public class ActiveReport3 : ActiveReport
	{
		Class1 db1;
		public ActiveReport3()
		{
			db1=new Class1();
			InitializeReport();
		}

		public void SetDb(Class1 db)
		{
			this.db1=db;
		}
		private void ActiveReport3_DataInitialize(object sender, System.EventArgs eArgs)
		{
			this.DataSource=db1.getdata();
		}

		#region ActiveReports Designer generated code
		private PageHeader PageHeader = null;
		private Label Label1 = null;
		private Label Label2 = null;
		private Label Label3 = null;
		private Label Label4 = null;
		private Label Label5 = null;
		private Label Label6 = null;
		private Label Label7 = null;
		private Label Label8 = null;
		private Detail Detail = null;
		private TextBox TextBox1 = null;
		private TextBox TextBox3 = null;
		private TextBox TextBox4 = null;
		private TextBox TextBox5 = null;
		private TextBox TextBox6 = null;
		private TextBox TextBox7 = null;
		private TextBox TextBox8 = null;
		private TextBox TextBox9 = null;
		private PageFooter PageFooter = null;
		public void InitializeReport()
		{
			this.LoadLayout(this.GetType(), "html.ActiveReport3.rpx");
			this.PageHeader = ((DataDynamics.ActiveReports.PageHeader)(this.Sections["PageHeader"]));
			this.Detail = ((DataDynamics.ActiveReports.Detail)(this.Sections["Detail"]));
			this.PageFooter = ((DataDynamics.ActiveReports.PageFooter)(this.Sections["PageFooter"]));
			this.Label1 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[0]));
			this.Label2 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[1]));
			this.Label3 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[2]));
			this.Label4 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[3]));
			this.Label5 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[4]));
			this.Label6 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[5]));
			this.Label7 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[6]));
			this.Label8 = ((DataDynamics.ActiveReports.Label)(this.PageHeader.Controls[7]));
			this.TextBox1 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[0]));
			this.TextBox3 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[1]));
			this.TextBox4 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[2]));
			this.TextBox5 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[3]));
			this.TextBox6 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[4]));
			this.TextBox7 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[5]));
			this.TextBox8 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[6]));
			this.TextBox9 = ((DataDynamics.ActiveReports.TextBox)(this.Detail.Controls[7]));
			// Attach Report Events
			this.DataInitialize += new System.EventHandler(this.ActiveReport3_DataInitialize);
		}

		#endregion
	}
}
