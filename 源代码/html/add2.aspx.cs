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
	/// add2 的摘要说明。
	/// </summary>
	public class add2 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Label Label6;
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.TextBox TextBox2;
		protected System.Web.UI.WebControls.Label Label12;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Label Label8;
	
		Class1 db1;
		private void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
			//Response.Write(Session["id"]);
			string name=Session["name"].ToString();
			string id=Session["pwd"].ToString();
			//Response.Write(name+id);
			db1=new Class1();
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
			if(!Page.IsPostBack)
			{
				this.Button1.Attributes.Add("onclick","return confirm('确定添加吗？')");
				string id1=Session["id"].ToString();
				string sql1="select * from weihu where 故障id=" + id1;
				db1.cleardata();
				db1.ExectueSQL("weihu",sql1);
				
				sql1="select * from info where 故障id=" + id1;
				db1.ExectueSQL("info",sql1);
				
				string id2=db1.getdata().Tables["info"].Rows[0]["设备id"].ToString();
				sql1="select * from basicinfo where 设备id=" + id2;
				db1.ExectueSQL("basicinfo",sql1);

				this.Label2.Text=db1.getdata().Tables["basicinfo"].Rows[0]["设备编号"].ToString();

				id2=db1.getdata().Tables["basicinfo"].Rows[0]["设备名称id"].ToString();
				sql1="select * from sbname where 设备名称id=" + id2;
				db1.ExectueSQL("sbname",sql1);
				this.Label4.Text=db1.getdata().Tables["sbname"].Rows[0]["设备名称"].ToString();

				id2=db1.getdata().Tables["basicinfo"].Rows[0]["实验室id"].ToString();
				sql1="select * from labname where 实验室id=" + id2;
				db1.ExectueSQL("labname",sql1);
				this.Label6.Text=db1.getdata().Tables["labname"].Rows[0]["实验室名"].ToString();

				id2=db1.getdata().Tables["info"].Rows[0]["故障类型号"].ToString();
				sql1="select * from errorinfo where 故障类型号=" + id2;
				db1.ExectueSQL("errorinfo",sql1);
				this.Label8.Text=db1.getdata().Tables["errorinfo"].Rows[0]["故障名称"].ToString();
				this.Label12.Text=DateTime.Now.ToString("yyyy-MM-dd");
				Session["id"]=id1;
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
			string sql1="select * from info where 故障id=" + Session["id"].ToString();
			db1.cleardata();
			db1.ExectueSQL("info",sql1);

			sql1="insert into weihu values('" + this.TextBox1.Text.ToString()+"','" + this.TextBox2.Text.ToString();
			sql1+="',"+Session["id"]+",'"+this.Label12.Text.ToString()+"',"+db1.getdata().Tables["info"].Rows[0]["设备id"].ToString()+")";
			//Response.Write(sql1);
			db1.ExectueSQL("",sql1);
			Response.Redirect("Weihu.aspx?id="+Session["id"]);

		}
	}
}
