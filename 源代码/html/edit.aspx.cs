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
	/// edit 的摘要说明。
	/// </summary>
	public class edit : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.DropDownList DropDownList2;
		protected System.Web.UI.WebControls.DropDownList DropDownList4;
		protected System.Web.UI.WebControls.DropDownList DropDownList5;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.DropDownList DropDownList1;
		protected System.Web.UI.WebControls.DropDownList DropDownList3;
		protected System.Web.UI.WebControls.DropDownList DropDownList6;
        protected System.Data.SqlClient.SqlDataReader dreader;

		Class1 db1;
		Class1 db2;
		private void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			//Response.Write(Request.QueryString["id"]);
			string name=Session["name"].ToString();
			string id=Session["pwd"].ToString();
			//Response.Write(name+id);
			db1=new Class1();
			db2=new Class1();
			string sql="select * from admin where username='";
			sql+=name;
			
			sql+="' and password='";
			sql+=id;
			sql+="'";
			db1.cleardata();
			db1.ExectueSQL("admin",sql);

			if(db1.getdata().Tables["admin"].Rows.Count==0)
			{
				sql="select * from userid where name='"+name+"' and password='"+id+"'";
				db1.cleardata();
				db1.ExectueSQL("userid",sql);
				if(db1.getdata().Tables["userid"].Rows.Count==0)
					Response.Redirect("cuowu1.htm");
			}
			string jb=db1.getdata().Tables["admin"].Rows[0]["jibie"].ToString();
			sql="select * from info where 故障id="+Request.QueryString["id"];
			db1.cleardata();
			db1.ExectueSQL("info",sql);

			if(jb.Trim()!="顶级"&&name!=db1.getdata().Tables["info"].Rows[0]["经手人"].ToString())
				Response.Redirect("cuowu2.htm");
			if(!Page.IsPostBack)
			{
				string sql1="select * from info where 故障id=" + Request.QueryString["id"];
				db1.cleardata();
				db1.ExectueSQL("info",sql1);

				sql1="select * from basicinfo where 设备id=";
				sql1+=db1.getdata().Tables["info"].Rows[0]["设备id"].ToString();
				db1.ExectueSQL("basicinfo",sql1);

				this.Label1.Text=db1.getdata().Tables["basicinfo"].Rows[0]["设备编号"].ToString();

				sql1="select * from sbname where 设备名称id=";
				sql1+=db1.getdata().Tables["basicinfo"].Rows[0]["设备名称id"].ToString();
				db1.ExectueSQL("sbname",sql1);

				this.Label4.Text=db1.getdata().Tables["sbname"].Rows[0]["设备名称"].ToString();

				sql1="select * from labname where 实验室id=";
				sql1+=db1.getdata().Tables["basicinfo"].Rows[0]["实验室id"].ToString();
				db1.ExectueSQL("labname",sql1);

				this.Label2.Text=db1.getdata().Tables["labname"].Rows[0]["实验室名"].ToString();

				for(int i=2000;i<=2007;i++)
				{
					this.DropDownList1.Items.Add(new ListItem(i.ToString()));
				}

				for(int i=1;i<=12;i++)
				{
					this.DropDownList3.Items.Add(new ListItem(i.ToString()));
				}
				for(int i=1;i<=31;i++)
				{
					this.DropDownList6.Items.Add(new ListItem(i.ToString()));
				}
				DateTime dt=DateTime.Parse(db1.getdata().Tables["info"].Rows[0]["登记日期"].ToString());

				this.DropDownList1.SelectedValue=dt.Year.ToString();
				this.DropDownList3.SelectedValue=dt.Month.ToString();
				this.DropDownList6.SelectedValue=dt.Day.ToString();

				sql1="select * from errorinfo";
				db1.ExectueSQL("errorinfo",sql1);

				for(int i=0;i<db1.getdata().Tables["errorinfo"].Rows.Count;i++)
				{
					this.DropDownList5.Items.Add(new ListItem(db1.getdata().Tables["errorinfo"].Rows[i]["故障名称"].ToString()));
				}
				
				sql1="select * from errorinfo where 故障类型号=";
				sql1+=db1.getdata().Tables["info"].Rows[0]["故障类型号"].ToString();
				db2.cleardata();
				db2.ExectueSQL("errorinfo",sql1);

				this.DropDownList5.SelectedValue=db2.getdata().Tables["errorinfo"].Rows[0]["故障名称"].ToString();

				this.TextBox1.Text=db1.getdata().Tables["info"].Rows[0]["经手人"].ToString();

				this.DropDownList2.SelectedValue=db1.getdata().Tables["info"].Rows[0]["具体时间"].ToString();

				this.DropDownList4.SelectedValue=db1.getdata().Tables["info"].Rows[0]["故障部件"].ToString();
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
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button1_Click(object sender, System.EventArgs e)
		{
			string sql1="update info set 经手人='";
			sql1+=this.TextBox1.Text;
			sql1+="',具体时间='";
			sql1+=this.DropDownList2.SelectedValue.ToString();
			sql1+="',故障部件='";
			sql1+=this.DropDownList4.SelectedValue.ToString();
			sql1+="',故障类型号=";

			string sql2="select * from errorinfo where 故障名称='";
			sql2+=this.DropDownList5.SelectedValue.ToString();
			sql2+="'";
			db1.cleardata();
			db1.ExectueSQL("errorinfo",sql2);

			sql1+=db1.getdata().Tables["errorinfo"].Rows[0]["故障类型号"].ToString();
			sql1+=",登记日期='";
			sql1+=this.DropDownList1.SelectedValue.ToString()+"-";
			sql1+=this.DropDownList3.SelectedValue.ToString()+"-";
			sql1+=this.DropDownList6.SelectedValue.ToString();
			sql1+="' where 故障id="+Request.QueryString["id"];

			db1.ExectueSQL("",sql1);
			Response.Redirect("sbgl.aspx");
		}
	}
}
