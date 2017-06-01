using System;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace html
{
	public class ActiveReport2 : ActiveReport
	{
		Class1 db1;
		public ActiveReport2()
		{
			db1=new Class1();
			InitializeReport();
		}

		public void SetDb(Class1 db)
		{
			this.db1=db;
		}
		private void ActiveReport2_DataInitialize(object sender, System.EventArgs eArgs)
		{
			this.DataSource=db1.getdata();
		}

		#region ActiveReports Designer generated code
		private PageHeader PageHeader = null;
		private GroupHeader GroupHeader1 = null;
		private Label Label6 = null;
		private Label Label5 = null;
		private Label Label4 = null;
		private Label Label3 = null;
		private Label Label2 = null;
		private GroupHeader GroupHeader2 = null;
		private Detail Detail = null;
		private GroupFooter GroupFooter2 = null;
		private TextBox TextBox1 = null;
		private TextBox TextBox2 = null;
		private TextBox TextBox3 = null;
		private GroupFooter GroupFooter1 = null;
		private PageFooter PageFooter = null;
		public void InitializeReport()
		{
			this.LoadLayout(this.GetType(), "html.ActiveReport2.rpx");
			this.PageHeader = ((DataDynamics.ActiveReports.PageHeader)(this.Sections["PageHeader"]));
			this.GroupHeader1 = ((DataDynamics.ActiveReports.GroupHeader)(this.Sections["GroupHeader1"]));
			this.GroupHeader2 = ((DataDynamics.ActiveReports.GroupHeader)(this.Sections["GroupHeader2"]));
			this.Detail = ((DataDynamics.ActiveReports.Detail)(this.Sections["Detail"]));
			this.GroupFooter2 = ((DataDynamics.ActiveReports.GroupFooter)(this.Sections["GroupFooter2"]));
			this.GroupFooter1 = ((DataDynamics.ActiveReports.GroupFooter)(this.Sections["GroupFooter1"]));
			this.PageFooter = ((DataDynamics.ActiveReports.PageFooter)(this.Sections["PageFooter"]));
			this.Label6 = ((DataDynamics.ActiveReports.Label)(this.GroupHeader1.Controls[0]));
			this.Label5 = ((DataDynamics.ActiveReports.Label)(this.GroupHeader1.Controls[1]));
			this.Label4 = ((DataDynamics.ActiveReports.Label)(this.GroupHeader1.Controls[2]));
			this.Label3 = ((DataDynamics.ActiveReports.Label)(this.GroupHeader1.Controls[3]));
			this.Label2 = ((DataDynamics.ActiveReports.Label)(this.GroupHeader1.Controls[4]));
			this.TextBox1 = ((DataDynamics.ActiveReports.TextBox)(this.GroupFooter2.Controls[0]));
			this.TextBox2 = ((DataDynamics.ActiveReports.TextBox)(this.GroupFooter2.Controls[1]));
			this.TextBox3 = ((DataDynamics.ActiveReports.TextBox)(this.GroupFooter2.Controls[2]));
			// Attach Report Events
			this.DataInitialize += new System.EventHandler(this.ActiveReport2_DataInitialize);
		}

		#endregion
	}
}
